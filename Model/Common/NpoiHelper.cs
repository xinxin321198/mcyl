using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.HSSF.Util;
using NPOI.XSSF.UserModel;
using Model.Common;
using Model.JC;
namespace Model.Common
{
    /// <summary>
    /// 操作excel的帮助类
    /// </summary>
    public class NpoiHelper
    {

        public static bool exportExcelForXlsx(string fileName , string sheetName ,List<string> columnNameList,List<List<string>> dataList)
        {
            HSSFWorkbook workBook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workBook.CreateSheet(sheetName);//创建工作薄
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            dsi.Manager = "lxx";
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            workBook.DocumentSummaryInformation = dsi;
            workBook.SummaryInformation = si;

            IRow rowColumn = sheet.CreateRow(0);
            for (int i = 0; i < columnNameList.Count; i++)
            {
                string columnName = columnNameList[i];
                ICell cell = rowColumn.CreateCell(i);
                cell.SetCellValue(columnName);
            }
            for (int i = 1; i < dataList.Count; i++)
            {
                List<string> stringColumns = dataList[i];
                IRow row = sheet.CreateRow(i);
                for (int j = 0; j < stringColumns.Count; j++)
                {
                    string column = stringColumns[j];
                    ICell cell = row.CreateCell(j);
                    cell.SetCellValue(column);
                }
            }
            FileStream file = new FileStream(@"" + fileName + "", FileMode.Create);
            workBook.Write(file);
            file.Close();
            return true;
        }

        /// <summary>
        /// 从excel中读取数据成一个二维数组,指定列数，多余的会以空字符串填补
        /// </summary>
        /// <param Name="fileName"></param>
        /// <param Name="columnCount"></param>
        /// <returns></returns>
        public static List<List<string>> importExcelFormExcel(string fileName, int columnCount)
        {
            List<List<string>> returnList = new List<List<string>>();
            //HSSFWorkbook wb = new HSSFWorkbook(new FileStream(fileName, FileMode.Open));
            //HSSFSheet sht = (HSSFSheet)wb.GetSheetAt(0);
            //XSSFWorkbook xlsxWb = new XSSFWorkbook(new FileStream(fileName, FileMode.Open));

            IWorkbook workbook = WorkbookFactory.Create(fileName);//使用接口，自动识别excel2003/2007格式
            ISheet sheet = workbook.GetSheetAt(0);//得到里面第一个sheet 
            //取行Excel的最大行数
            int rowsCount = sheet.PhysicalNumberOfRows;
            //为保证Table布局与Excel一样，这里应该取所有行中的最大列数（需要遍历整个Sheet）。
            //为少一交全Excel遍历，提高性能，我们可以人为把第0行的列数调整至所有行中的最大列数。
            int colsCount = sheet.GetRow(0).PhysicalNumberOfCells;
            StringBuilder sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                List<string> rowList = new List<string>();
                for (int collIndex = 0; collIndex < columnCount; collIndex++)
                {
                    rowList.Add(Convert.ToString(sheet.GetRow(rowIndex).GetCell(collIndex)));
                }
                returnList.Add(rowList);
            }
            return returnList;
        }

        /// <summary>
        /// 把excel中读出的stringList二维数组转换为codeTypeList
        /// </summary>
        /// <param name="stringList"></param>
        /// <param name="codeType"></param>
        /// <returns></returns>
        public static List<Jc_code> stringListConvertToJc_codeList(List<List<string>> stringList,Jc_code_type codeType)
        {
            List<Jc_code> codeList = new List<Jc_code>();
            for (int i = 0; i < stringList.Count; i++)
            {
                Jc_code code = new Jc_code();
                code.Fk_code_type = codeType.Id;
                code.Value = stringList[i][0];
                code.Name = stringList[i][1];
                code.Remark = stringList[i][2];
                code.Pym = stringList[i][3];
                code.Wbm = stringList[i][4];
                //code.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                codeList.Add(code);
            }
            return codeList;
        }


        public static List<Jc_icd10_type> stringlistConvertToJc_icd10_typeList(List<List<string>> stringList)
        {
            List<Jc_icd10_type> list = new List<Jc_icd10_type>();
            for (int i = 0; i < stringList.Count; i++)
            {
                Jc_icd10_type icdType = new Jc_icd10_type();
                icdType.Code = stringList[i][0];
                icdType.Name = stringList[i][1];
                icdType.En_name = stringList[i][2];
                icdType.Pym = PinYinConverter.GetFirst(stringList[i][1]);
                icdType.Wbm = WuBiConverter.GetWBCode(stringList[i][1]);
                list.Add(icdType);
            }
            return list;
        }

        public static List<Jc_icd10> stringlistConvertToJc_icd10List(List<List<string>> stringList)
        {
            List<Jc_icd10> list = new List<Jc_icd10>();
            for (int i = 0; i < stringList.Count; i++)
            {
                Jc_icd10 icdType = new Jc_icd10();
                icdType.Icd10_code = stringList[i][0];
                icdType.Name = stringList[i][1];
                icdType.En_name = stringList[i][2];
                icdType.Pym = stringList[i][3];
                icdType.Wbm = WuBiConverter.GetWBCode(stringList[i][1]);
                list.Add(icdType);
            }
            return list;
        }
    }
}

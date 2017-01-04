using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Common;
using client.Common;
using System.Diagnostics;
using Model.JC;

namespace client.JC.代码字典管理
{
    public partial class CodeImportForExcel : Form
    {
        private BLL.JC.基础_代码字典.Jc_codeBLL jc_codeBll = new BLL.JC.基础_代码字典.Jc_codeBLLImp();
        private Model.JC.Jc_code_type codeType = null;
        List<Model.JC.Jc_code> codeList = null;

        //从excel导入code代码的列的数量
        public  const int columnsCount = 5;

        public CodeImportForExcel(Model.JC.Jc_code_type codeType)
        {
            InitializeComponent();
            this.codeType = codeType;
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton__import, skinButton__选择文件);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_code);
            OpenFileDialogHelper.initOpenFileDialog(openFileDialog);

        }

        private void button_选择文件_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    List<List<string>> returnList = NpoiHelper.importExcelFormExcel(fileName, columnsCount);

                    codeList = NpoiHelper.stringListConvertToJc_codeList(returnList, this.codeType);
                    SkinDataGridViewHelper.bindingList(skinDataGridView_code, codeList);
                    SkinDataGridViewHelper.endDataGridView(skinDataGridView_code);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            finally
            {
                openFileDialog.Dispose();

            }
            
        }

    

        private void button_import_Click(object sender, EventArgs e)
        {
            try
            {
                if (codeList==null)
                {
                    throw new Exception("请选择excel文件");
                }
                bool flag = true;
                flag =  jc_codeBll.inertList(codeList);

                if (flag)
                {
                    MyMessageBox.Show("导入成功");
                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("导入失败");
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void checkBox_IsPinyinWuBi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_IsPinyinWuBi.Checked)
                {
                    for (int i = 0; i < codeList.Count; i++)
                    {
                        codeList[i].Pym = PinYinConverter.GetFirst(codeList[i].Name);
                        codeList[i].Wbm = WuBiConverter.GetWBCode(codeList[i].Name);
                    }
                    SkinDataGridViewHelper.bindingList(skinDataGridView_code, this.codeList);
                }
                else
                {
                    for (int i = 0; i < codeList.Count; i++)
                    {
                        codeList[i].Pym = null;
                        codeList[i].Wbm = null;
                    }
                    SkinDataGridViewHelper.bindingList(skinDataGridView_code, this.codeList);
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void CodeImportForExcel_Load(object sender, EventArgs e)
        {

        }


    }
}

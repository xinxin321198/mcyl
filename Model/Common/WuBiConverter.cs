using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Model.Common
{
    /// <summary>
    /// 汉字转五笔码转换类
    /// </summary>
    public class WuBiConverter
    {
        #region 变量
        private const int WB_START = 0;
        private const int OUT_END = 100;

        private static string path = System.Environment.CurrentDirectory + "\\CodeConfig\\";
        #endregion
        #region 构造函数
        /// <summary>
        /// 构造函数，初始化XMLREADER
        /// </summary>
        public WuBiConverter()
        {

        }
        #endregion

        #region 私有方法

        /// <summary>
        /// 读取XML文件中数据
        /// </summary>
        /// <returns>返回String[]</returns>
        private static string[] getXmlData(XmlReader reader,out int wbCodeStation,out int outStation)
        {
            wbCodeStation = WB_START;
            outStation = OUT_END;
            //这里本应该开辟52个空间就够了，防止以后添加XML节点，故开辟多些空间
            StringBuilder[] strValue = new StringBuilder[100];
            string[] result = new string[100];
            int i = 0;
            try
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name != "CodeConfig" && reader.Name != "SpellCode" && reader.Name != "WBCode")
                            {

                                strValue[i] = new StringBuilder();
                                strValue[i].Append(reader.Name);
                            }
                            if (reader.Name == "WBCode")
                            {
                                wbCodeStation = i;
                            }
                            break;
                        case XmlNodeType.Text:
                            strValue[i].Append(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.Name != "CodeConfig" && reader.Name != "SpellCode" && reader.Name != "WBCode")
                            {
                                result[i] = strValue[i].ToString();
                                i++;
                            }
                            if (reader.Name == "CodeConfig")
                            {
                                outStation = i;
                            }
                            break;
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return result;
        }

        /// <summary>
        /// 查找汉字
        /// </summary>
        /// <param name="strName">汉字</param>
        /// <param name="start">搜索的开始位置</param>
        /// <param name="end">搜索的结束位置</param>
        /// <returns>汉语反义成字符串，该字符串只包含大写的英文字母</returns>
        private static string searchWord(string strName, int start, int end, string[] strXmlData)
        {
            strName = strName.Trim().Replace(" ", "");
            if (string.IsNullOrEmpty(strName))
            {
                return strName;
            }
            StringBuilder myStr = new StringBuilder();
            foreach (char vChar in strName)
            {
                // 若是字母或数字则直接输出
                if ((vChar >= 'a' && vChar <= 'z') || (vChar >= 'A' && vChar <= 'Z') || (vChar >= '0' && vChar <= '9'))
                    myStr.Append(char.ToUpper(vChar));
                else
                {
                    // 若字符Unicode编码在编码范围则 查汉字列表进行转换输出
                    string strList = null;
                    int i;
                    for (i = start; i < end; i++)
                    {
                        strList = strXmlData[i];
                        if (strList.IndexOf(vChar) > 0)
                        {
                            myStr.Append(strList[0]);
                            break;
                        }
                    }
                }
            }
            return myStr.ToString();
        }

        #endregion
        #region 公开方法
        /// <summary>
        /// 获得汉语的拼音码
        /// </summary>
        /// <param name="strName">汉字</param>
        /// <returns>汉语拼音码,该字符串只包含大写的英文字母</returns>
        private static string GetSpellCode(string strName)
        {
                    //记录XML中五笔码开始位置！
            int wbCodeStation = WB_START;

        //记录XML中结束位置！
            int outStation = OUT_END;

            /// <summary>
            /// XML文件读取实例
            /// </summary>
            XmlReader reader = null;

            /// <summary>
            /// XML文件中数据
            /// </summary>
            string[] strXmlData = null;

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filePath = path + "CodeConfig.xml";
            if (!File.Exists(filePath))
            {
                throw new Exception("汉字编码对照表文件不存在");
            }
            reader = XmlReader.Create(filePath);
            strXmlData = getXmlData(reader, out wbCodeStation, out outStation);

            //处理空白文件
            //reader.WhitespaceHandling = WhitespaceHandling.None;  
            return searchWord(strName, 0, wbCodeStation,strXmlData);
        }
        /// <summary>
        /// 获得汉语的五笔码
        /// </summary>
        /// <param name="strName">汉字</param>
        /// <returns>汉语五笔码,该字符串只包含大写的英文字母</returns>
        public static string GetWBCode(string strName)
        {
        //记录XML中五笔码开始位置！
        int wbCodeStation = WB_START;

        //记录XML中结束位置！
        int outStation = OUT_END ;
            
        /// <summary>
        /// XML文件读取实例
        /// </summary>
         XmlReader reader = null;

        /// <summary>
        /// XML文件中数据
        /// </summary>
         string[] strXmlData = null;

       

         if (Directory.Exists(path) == false)
         {
             Directory.CreateDirectory(path);
         }
         string filePath = path + "CodeConfig.xml";
         if (!File.Exists(filePath))
         {
             throw new Exception("汉字编码对照表文件不存在,请把文件拷贝到程序根目录下的CodeConfig文件夹中");
         }
         reader = XmlReader.Create(filePath);
         strXmlData = getXmlData(reader, out wbCodeStation, out outStation);

         //处理空白文件
         //reader.WhitespaceHandling = WhitespaceHandling.None;  

         return searchWord(strName, wbCodeStation, outStation, strXmlData).ToUpper() ;
        }
      
        #endregion
    }
}

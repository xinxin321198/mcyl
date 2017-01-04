using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Model.Common
{
    /// <summary>
    /// ����ת�����ת����
    /// </summary>
    public class WuBiConverter
    {
        #region ����
        private const int WB_START = 0;
        private const int OUT_END = 100;

        private static string path = System.Environment.CurrentDirectory + "\\CodeConfig\\";
        #endregion
        #region ���캯��
        /// <summary>
        /// ���캯������ʼ��XMLREADER
        /// </summary>
        public WuBiConverter()
        {

        }
        #endregion

        #region ˽�з���

        /// <summary>
        /// ��ȡXML�ļ�������
        /// </summary>
        /// <returns>����String[]</returns>
        private static string[] getXmlData(XmlReader reader,out int wbCodeStation,out int outStation)
        {
            wbCodeStation = WB_START;
            outStation = OUT_END;
            //���ﱾӦ�ÿ���52���ռ�͹��ˣ���ֹ�Ժ����XML�ڵ㣬�ʿ��ٶ�Щ�ռ�
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
        /// ���Һ���
        /// </summary>
        /// <param name="strName">����</param>
        /// <param name="start">�����Ŀ�ʼλ��</param>
        /// <param name="end">�����Ľ���λ��</param>
        /// <returns>���ﷴ����ַ��������ַ���ֻ������д��Ӣ����ĸ</returns>
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
                // ������ĸ��������ֱ�����
                if ((vChar >= 'a' && vChar <= 'z') || (vChar >= 'A' && vChar <= 'Z') || (vChar >= '0' && vChar <= '9'))
                    myStr.Append(char.ToUpper(vChar));
                else
                {
                    // ���ַ�Unicode�����ڱ��뷶Χ�� �麺���б����ת�����
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
        #region ��������
        /// <summary>
        /// ��ú����ƴ����
        /// </summary>
        /// <param name="strName">����</param>
        /// <returns>����ƴ����,���ַ���ֻ������д��Ӣ����ĸ</returns>
        private static string GetSpellCode(string strName)
        {
                    //��¼XML������뿪ʼλ�ã�
            int wbCodeStation = WB_START;

        //��¼XML�н���λ�ã�
            int outStation = OUT_END;

            /// <summary>
            /// XML�ļ���ȡʵ��
            /// </summary>
            XmlReader reader = null;

            /// <summary>
            /// XML�ļ�������
            /// </summary>
            string[] strXmlData = null;

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filePath = path + "CodeConfig.xml";
            if (!File.Exists(filePath))
            {
                throw new Exception("���ֱ�����ձ��ļ�������");
            }
            reader = XmlReader.Create(filePath);
            strXmlData = getXmlData(reader, out wbCodeStation, out outStation);

            //����հ��ļ�
            //reader.WhitespaceHandling = WhitespaceHandling.None;  
            return searchWord(strName, 0, wbCodeStation,strXmlData);
        }
        /// <summary>
        /// ��ú���������
        /// </summary>
        /// <param name="strName">����</param>
        /// <returns>���������,���ַ���ֻ������д��Ӣ����ĸ</returns>
        public static string GetWBCode(string strName)
        {
        //��¼XML������뿪ʼλ�ã�
        int wbCodeStation = WB_START;

        //��¼XML�н���λ�ã�
        int outStation = OUT_END ;
            
        /// <summary>
        /// XML�ļ���ȡʵ��
        /// </summary>
         XmlReader reader = null;

        /// <summary>
        /// XML�ļ�������
        /// </summary>
         string[] strXmlData = null;

       

         if (Directory.Exists(path) == false)
         {
             Directory.CreateDirectory(path);
         }
         string filePath = path + "CodeConfig.xml";
         if (!File.Exists(filePath))
         {
             throw new Exception("���ֱ�����ձ��ļ�������,����ļ������������Ŀ¼�µ�CodeConfig�ļ�����");
         }
         reader = XmlReader.Create(filePath);
         strXmlData = getXmlData(reader, out wbCodeStation, out outStation);

         //����հ��ļ�
         //reader.WhitespaceHandling = WhitespaceHandling.None;  

         return searchWord(strName, wbCodeStation, outStation, strXmlData).ToUpper() ;
        }
      
        #endregion
    }
}

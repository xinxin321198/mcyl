using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class StringHelper
    {

        public enum 字符类型
        {
            错误 = -1,
            数字 =0,
            字母 =1,
            中文 = 2,
        }

        /// <summary>
        /// 判断字符串首字符如果是数字返回1，如果是字母返回2，如果是中文（暂时判定为其它）返回3
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static 字符类型 judgeStringFirstCharType(string s)
        {
            字符类型 flag = 字符类型.错误;

                string strTemp = s.Substring(0, 1);
                if ("0123456789０１２３４５６７８９".IndexOf(strTemp) > -1)
                {
                    flag =  字符类型.数字;
                }
                else if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ".IndexOf(strTemp) > -1)
                {
                    flag =  字符类型.字母;
                }
                else
                {
                    flag =  字符类型.中文;

                }
            return flag;
        }

        /// <summary>
        /// 检查字符串中是否包含数字，包含返回true，不包含返回false
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool checkStringIsContainDigital(string s)
        {
            bool flag = false;//不包含
            for (int i = 0; i < s.Length; i++)
            {
                string strTemp = s.Substring(i, 1);
                if ("0123456789０１２３４５６７８９".IndexOf(strTemp) > -1)
                {
                    flag = true;
                }
            }
            return flag;
        }


        /// <summary>
        /// 检查字符串中是否包含字母，包含返回true，不包含返回false
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool checkStringIsContainLetter(string s)
        {
            bool flag = false;//不包含
            for (int i = 0; i < s.Length; i++)
            {
                string strTemp = s.Substring(i, 1);
                if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ".IndexOf(strTemp) > -1)
                {
                    flag = true;
                }

            }
            return flag;
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Model.Common
{
    public class MD5Helper
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param Name="sDataIn"></param>
        /// <returns></returns>
        public static string GetMD5(string sDataIn)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToLower();
        }

        //把一些可能会变的值写入app.config
        //读取密码盐
        public static string GetPasswordSalt()
        {
            string salt = AppConfigHelper.GetAppConfig("passwordSalt");
            //string salt = "mcyl";
            return salt;
        }

        /// <summary>
        /// 得到加盐过后的MD5密码
        /// </summary>
        /// <param Name="s"></param>
        /// <returns></returns>
        public static string getEncryption(string s)
        {
            return GetMD5(s + GetPasswordSalt()).ToUpper() ;
        }
    }
}

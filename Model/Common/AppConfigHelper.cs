using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;
namespace Model.Common
{
    public class AppConfigHelper
    {
        ///<summary>   
        ///依据连接串名字connectionName返回数据连接字符串   
        ///</summary>   
        ///<param Name="connectionName"></param>   
        ///<returns></returns>   
        public  static string GetConnectionStringsConfig(string connectionName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            Console.WriteLine(connectionString);
            return connectionString.Trim();
        }

        ///<summary>   
        ///返回＊.exe.config文件中appSettings配置节点的value项   
        ///</summary>   
        ///<param Name="strKey"></param>   
        ///<returns></returns>   
        public static string GetAppConfig(string strKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == strKey)
                {
                    return ConfigurationManager.AppSettings[strKey].Trim();
                }
            }
            return null;
        }

        ///<summary>   
        ///返回显示日期的格式
        ///</summary>   
        ///<param Name="strKey"></param>   
        ///<returns></returns>   
        public static string GetAppConfigFordateFormat()
        {
            return ConfigurationManager.AppSettings["dateFormat"].Trim();
        }
        ///<summary>   
        ///返回显示日期+时间的格式
        ///</summary>   
        ///<param Name="strKey"></param>   
        ///<returns></returns>   
        public static string GetAppConfigFordateTimeFormat()
        {
            return ConfigurationManager.AppSettings["dateTimeFormat"].Trim();
        }
        /// <summary>
        /// 得到最大系统管理员的对象
        /// </summary>
        /// <returns></returns>
        public static RBAC.Rbac_user getAdmin()
        {
            RBAC.Rbac_user admin = new RBAC.Rbac_user();
            admin.Name = ConfigurationManager.AppSettings["adminName"].Trim();
            admin.Pwd = MD5Helper.getEncryption(ConfigurationManager.AppSettings["adminPwd"].Trim());
            return admin;
        }

        /// <summary>
        /// 得到禁用的颜色
        /// </summary>
        /// <returns></returns>
        public static Color getDisableForeColor()
        {
            Color returnColor = ColorTranslator.FromHtml(GetAppConfig("disableForeColor"));
            return returnColor;
        }

        /// <summary>
        /// 得到绿色
        /// </summary>
        /// <returns></returns>
        public static Color getGreenColor()
        {
            Color returnColor = ColorTranslator.FromHtml(GetAppConfig("greenColor"));
            return returnColor;
        }

        /// <summary>
        /// 得到标题的字体大小
        /// </summary>
        /// <returns></returns>
        public static int getTitleFontSize()
        {
            int size =  Convert.ToInt32( GetAppConfig("titleFontSize"));
            return size;
        }

        /// <summary>
        /// 得到标题字体的颜色
        /// </summary>
        /// <returns></returns>
        public static Color getTitleFontColor1()
        {
            Color returnColor = ColorTranslator.FromHtml(GetAppConfig("titleFontColor1"));
            return returnColor;
        }
        /// <summary>
        /// 得到标题字体的颜色
        /// </summary>
        /// <returns></returns>
        public static Color getTitleFontColor2()
        {
            Color returnColor = ColorTranslator.FromHtml(GetAppConfig("titleFontColor2"));
            return returnColor;
        }
    }
}

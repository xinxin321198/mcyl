using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Common;

namespace client.Common
{
    /// <summary>
    /// DateTimePicker控件的帮助类
    /// </summary>
    public class DateTimePickerHelper
    {
        private static CommonBLL commonBll = new CommonBLLImp();

        /// <summary>
        /// 初始化时间控件
        /// </summary>
        /// <param Name="dtp"></param>
        public static void initDateTimePicker(DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;//设置为显示格式为自定义
            dtp.CustomFormat = AppConfigHelper.GetAppConfigFordateFormat(); //设置显示格式
        }

        /// <summary>
        /// 根据出生日期，得到此人的年龄(年份)
        /// </summary>
        /// <param name="csrq"></param>
        /// <returns></returns>
        public static int getAgeForYear(DateTime csrq)
        {
            DateTime currentDate = commonBll.getCurrenDateTime();
            TimeSpan ts = currentDate.Subtract(csrq);//现在的时间与选择的时间间隔
            if (ts.Days < 0)
            {
                throw new Exception("不能选择大于当前时间的日期");
            }
            int year = ts.Days / 365;//岁=相差的天数/365
            int remainderMonthDays = (ts.Days % 365);
            int month = remainderMonthDays / 30;
            int day = remainderMonthDays % 30;
            return year;
        }

        /// <summary>
        /// 根据出生日期，得到此人的年龄（月份）
        /// </summary>
        /// <param name="csrq"></param>
        /// <returns></returns>
        public static int getAgeForMonth(DateTime csrq)
        {
            DateTime currentDate = commonBll.getCurrenDateTime();
            TimeSpan ts = currentDate.Subtract(csrq);//现在的时间与选择的时间间隔
            if (ts.Days < 0)
            {
                throw new Exception("不能选择大于当前时间的日期");
            }
            int year = ts.Days / 365;//岁=相差的天数/365
            int remainderMonthDays = (ts.Days % 365);
            int month = remainderMonthDays / 30;
            int day = remainderMonthDays % 30;
            return month;
        }

        /// <summary>
        /// 根据出生日期，得到此人的年龄（天数）
        /// </summary>
        /// <param name="csrq"></param>
        /// <returns></returns>
        public static int getAgeForDay(DateTime csrq)
        {
            DateTime currentDate = commonBll.getCurrenDateTime();
            TimeSpan ts = currentDate.Subtract(csrq);//现在的时间与选择的时间间隔
            if (ts.Days < 0)
            {
                throw new Exception("不能选择大于当前时间的日期");
            }
            int year = ts.Days / 365;//岁=相差的天数/365
            int remainderMonthDays = (ts.Days % 365);
            int month = remainderMonthDays / 30;
            int day = remainderMonthDays % 30;
            return day;
        }
    }
}

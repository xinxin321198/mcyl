using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Common;
using System.Drawing;

namespace client.Common
{
    public class LabelHelper
    {
        /// <summary>
        /// 初始化label控件为标题样式
        /// </summary>
        /// <param name="labels"></param>
        public static void initTitleLabel(params Label[] labels)
        {
            foreach (Label lb in labels)
            {
                Font f = new Font("宋体", AppConfigHelper.getTitleFontSize(),FontStyle.Bold);
                lb.Font = f;
                lb.ForeColor = AppConfigHelper.getTitleFontColor1();
            }
        }

        public static void initTitleLabel2(params Label[] labels)
        {
            foreach (Label lb in labels)
            {
                Font f = new Font("宋体", AppConfigHelper.getTitleFontSize(), FontStyle.Bold);
                lb.Font = f;
                lb.ForeColor = AppConfigHelper.getTitleFontColor2();
            }
        }
    }
}

using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    public class SkinButtonHelper
    {

        /// <summary>
        /// 初始化普通的按钮样式
        /// </summary>
        /// <param name="buttons"></param>
        public static void initButton(params SkinButton[] buttons )
        {
            foreach (SkinButton button in buttons)
            {
                button.BaseColor = SystemColors.ActiveCaption;//背景色
                button.GlowColor = SystemColors.MenuHighlight;//渐变色
                button.Cursor = Cursors.Hand;//光标移动上去的指针样式
                button.RoundStyle = CCWin.SkinClass.RoundStyle.All;
                button.Radius = 20;//圆角
                button.ForeColorSuit = true;
            }
        }

        /// <summary>
        /// 初始化菜单按钮的杨慧
        /// </summary>
        /// <param name="buttons"></param>
        public static void initMenuButton(params SkinButton[] buttons )
        {
            foreach (SkinButton button in buttons)
            {
                button.BaseColor = SystemColors.ActiveCaption;//背景色
                button.GlowColor = SystemColors.MenuHighlight;//渐变色
                button.Cursor = Cursors.Hand;//光标移动上去的指针样式
            }
        }
    }
}

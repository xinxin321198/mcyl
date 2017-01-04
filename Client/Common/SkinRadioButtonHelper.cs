using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Common
{
    public class SkinRadioButtonHelper
    {
        public static void initSkinRadioButton(params SkinRadioButton[] radios)
        {
            foreach (SkinRadioButton item in radios)
            {
                item.BaseColor = SystemColors.ActiveCaption;//圈圈颜色
            }
        }
    }
}

﻿using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    public class SkinTabControlHelper
    {
        public static void initSkinTabControl(SkinTabControl tab)
        {
            foreach (TabPage item in tab.TabPages)
            {
                item.AutoScroll = true;
            }
            tab.SelectedIndex = 0;
        }
    }
}

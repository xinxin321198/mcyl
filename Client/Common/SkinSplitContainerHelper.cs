using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Common
{
    public class SkinSplitContainerHelper
    {
        public static void initSkinSplitContainer(SkinSplitContainer splitContainer)
        {
            splitContainer.Panel1.AutoScroll = true;
            splitContainer.Panel2.AutoScroll = true;
        }
    }
}

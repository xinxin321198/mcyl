using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    /// <summary>
    /// OpenFileDialog控件的帮助类
    /// </summary>
    class OpenFileDialogHelper
    {
        /// <summary>
        /// 初始化OpenFileDialog
        /// </summary>
        /// <param name="ofd"></param>
        public static void initOpenFileDialog(OpenFileDialog ofd)
        {
            ofd.Filter = "Excel   Files(*.xls;*.xlsx)|*.xls;*.xlsx";
            ofd.InitialDirectory = "C:\\";
        }
    }
}

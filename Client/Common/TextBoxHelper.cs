using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    public class TextBoxHelper
    {
        /// <summary>
        /// 让textbox
        /// 1.获得焦点
        /// 2.光标移动至文本尾
        /// 3.滚动到控件光标处
        /// </summary>
        /// <param name="textBox"></param>
        public static void setTextBoxSelectionEnd(TextBox textBox)
        {
            textBox.Focus();//获得焦点
            //设置光标的位置到文本尾 
            textBox.Select(textBox.TextLength, 0);
            //textBox.SelectionStart = textBox.Text.Length;
            //滚动到控件光标处 
            textBox.ScrollToCaret(); 
        }
    }
}

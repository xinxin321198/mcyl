using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    public partial class MyMessageBox : Form
    {

        /// <summary>
        /// 从透明到显示的频率（数值越大越快，最大为1）
        /// </summary>
        private const double step = 0.1;

        private string msg = null;
        public MyMessageBox()
        {
            InitializeComponent();
            FormHelper.initForm(this);
            this.ControlBox = false;
            SkinButtonHelper.initButton(this.skinButton1);
        }

        public MyMessageBox(string msg)
        {
            InitializeComponent();
            this.msg = msg;
            FormHelper.initForm(this);
            this.ControlBox = false;
            SkinButtonHelper.initButton(this.skinButton1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (timer_start.Enabled == true)
                {
                    return;
                }
                else
                {
                    timer_close.Start();
                }
                    

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);

            }
        }



        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = 0;
                this.richTextBox1.Text = this.msg;
                timer_start.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = this.Opacity + step;
                if (1 == this.Opacity)
                {
                    timer_start.Stop();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            try
            {

                this.Opacity = this.Opacity - step;
                if (0 == this.Opacity)
                {
                    timer_close.Stop();
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }



        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param Name="msg"></param>
        public static void Show(object msg)
        {
            new MyMessageBox(Convert.ToString(msg)).ShowDialog();
        }


    }
}

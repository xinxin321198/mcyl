using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Common;
using BLL.JC.基础_行政区划;
using Model.JC;
using System.Diagnostics;
using Model.Common;
using System.Reflection;
using CCWin;
namespace client
{
    public partial class Sample : CCSkinMain
    {

        public Sample()
        {
            InitializeComponent();
            FormHelper.initForm(this);
        }

        private void button_getDirectory_Click(object sender, EventArgs e)
        {
            //获取模块的完整路径
            MyMessageBox.Show(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            //获取和设置当前目录(该进程从中启动的目录)的完全限定目录
            MyMessageBox.Show(System.Environment.CurrentDirectory);

            //获取应用程序的当前工作目录。这个不一定是程序从中启动的目录啊，有可能程序放在C:\www里,这个函数有可能返回C:\Documents and Settings\ZYB\,或者C:\Program Files\Adobe\,有时不一定返回什么东东，我也搞不懂了
            MyMessageBox.Show(System.IO.Directory.GetCurrentDirectory());

            //获取程序的基目录。
            MyMessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);

            //获取和设置包括该应用程序的目录的名称
            MyMessageBox.Show(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);

            //获取启动了应用程序的可执行文件的路径。效果和2、5一样。只是5返回的字符串后面多了一个"\"而已
            MyMessageBox.Show(System.Windows.Forms.Application.StartupPath);

            //获取启动了应用程序的可执行文件的路径及文件名，效果和1一样
            MyMessageBox.Show(System.Windows.Forms.Application.ExecutablePath);
        }


        private void Sample_Load(object sender, EventArgs e)
        {
        }

        private void button_stopwatch_Click(object sender, EventArgs e)
        {
            int count = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            //List<object> objs =  new BLL.JC.基础_ICD10.Jc_icd10BLLImp().getList(null, null, null);
            //List<Jc_icd10> icd10list = (List<Jc_icd10>)objs[0];
            //count = icd10list.Count;

            count = new BLL.JC.基础_ICD10.Jc_icd10BLLImp().getCount(null,null);
            sw.Stop();
            MyMessageBox.Show(sw.ElapsedMilliseconds + " " + count);
        }

        private void skinButton1_Enter(object sender, EventArgs e)
        {
            skinButton1.BaseColor = Color.PaleGoldenrod;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Jc_kswh ksTmp = new Jc_kswh();
            Type type = ksTmp.GetType();
            foreach (PropertyInfo pi in type.GetProperties())
            {
                object value = pi.GetValue(ksTmp);//获得属性值
                //pi.SetValue(ksTmp,"值");//设置值
                string name = pi.Name;//获得属性名字
            }

            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            object obj = ksTmp.GetType().Assembly.CreateInstance(ksTmp.GetType().FullName);//创建对象
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelHelper.initTitleLabel(label1);
        }

        private void Sample_Activated(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "使文本框获得焦点并且光标在末尾";
            TextBoxHelper.setTextBoxSelectionEnd(textBox1);
        }




        private void skinButton_Metro_Click(object sender, EventArgs e)
        {
           this.XTheme = new CCWin.Skin_Metro();
        
        }

        private void skinButton_DevExpress_Click(object sender, EventArgs e)
        {
            this.XTheme = new CCWin.Skin_DevExpress();
        
        }

        private void skinButton_Mac_Click(object sender, EventArgs e)
        {
            this.XTheme = new CCWin.Skin_Mac();
        
        }

        private void skinButton_VS_Click(object sender, EventArgs e)
        {
            this.XTheme = new CCWin.Skin_VS();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < skinDataGridView1.Rows.Count; i++)
            {
                MyMessageBox.Show(skinDataGridView1.Rows[i].Cells[0].Value);
            }
        }
    }
}

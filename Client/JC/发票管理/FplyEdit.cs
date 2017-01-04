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
using Model.Common;
using BLL.JC.基础_发票领用管理;
using Model.JC;
using BLL.JC.发票领用管理;


namespace client.JC.发票管理
{
    

    public partial class FplyEdit : Form
    {
        Jc_fplyBLL jc_fpBLL = new Jc_fplyBLLImp();
        FplyBLL fplyBll = new FplyBLLImp();

        Jc_renyuan old_renyuan =null;


        public FplyEdit(Jc_renyuan jc_renyuan)
        {
            old_renyuan = jc_renyuan;
            InitializeComponent();
            textBox_xm.Text = old_renyuan.Xm;
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_save, skinButton_cancel);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_fply fpSave = new Jc_fply();


                //界面校验
                
                if ("" == comboBox类型.Text.Trim())
                {              
                    throw new Exception("请选择发票类型！");
                }
                if ("" == textBox起始号.Text.Trim())
                {      
                    throw new Exception("起始号不能为空！");
                }
                if ("" == textBox终止号.Text.Trim())
                {
       
                    throw new Exception("终止号不能为空！");
                }


                long fph1,fph2;
                string lx;          
                string s;
                s = comboBox类型.Text;
                fpSave.Fplx = s.Substring(0,1);
                fpSave.Fph_start = textBox起始号.Text;
                fpSave.Fph_end = textBox终止号.Text;
                fpSave.Lyr_id = old_renyuan.Id; // "11";///client.JC.发票管理.FplyMgr.label_id.text;
                fpSave.Czy_id = "test122";


                //验证发票号码段
                lx= s.Substring(0,1);
                fph1 =Convert.ToInt32(textBox起始号.Text);
                fph2 =Convert.ToInt32(textBox终止号.Text);
                fplyBll.yzfp(lx,fph1,fph2);

                //save
                bool flag = false;
                flag = jc_fpBLL.save(fpSave);
                if (flag)
                {
                    MyMessageBox.Show("保存成功");

                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FplyEdit_Load(object sender, EventArgs e)
        {

        }
    }
}

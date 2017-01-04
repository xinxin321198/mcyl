using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_供应商;
using client.Common;
using Model.Common;
using Model.JC;

namespace client.JC.供应商
{
    public partial class GysEdit : Form
    {
        Jc_gysBLL jc_gysBLL = new Jc_gysBLLImp();
        Jc_gys oldGys = null;
        public GysEdit()
        {
            InitializeComponent();
            this.initUI();
        }
        public GysEdit(Jc_gys jc_gys)
        {
            this.oldGys = jc_gys;
            InitializeComponent();
            this.initUI();

        }

        private void GysEdit_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

     

        private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton保存, skinButton取消);
            ComboBoxHelper.initComboBoxForZfbz(comboBox作废标识);
            ComboBoxHelper.initComboBoxForCode(comboBox_lx,CommonCode.代码类型值.供应商类型,CommonCode.代码值_作废标志代码值.启用);

            if (null != oldGys)
            {
                textBox供应商编号.Text = this.oldGys.Gysbh;
                textBox供应商名称.Text = this.oldGys.Gysmc;
                textBox拼音码.Text = this.oldGys.Pym;
                comboBox_lx.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_lx,this.oldGys.Lx_code,CommonCode.实体类名称.基础_代码字典实体类名);
                textBox地址.Text = this.oldGys.Dz;
                textBox联系人.Text = this.oldGys.Lxr;
                textBox电话.Text = this.oldGys.Dh;
                textBox五笔码.Text = this.oldGys.Wbm;

                comboBox作废标识.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox作废标识, this.oldGys.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
            }
        }

        private void button取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button保存_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_gys gysSave = new Jc_gys();
                gysSave.Gysbh = textBox供应商编号.Text;
                gysSave.Gysmc = textBox供应商名称.Text;
                gysSave.Pym = textBox拼音码.Text;
                gysSave.Lx_code = Jc_code.ConvertToJc_code(comboBox_lx.SelectedItem).Value;
                gysSave.Dz = textBox地址.Text;
                gysSave.Lxr = textBox联系人.Text;
                gysSave.Dh = textBox电话.Text;
                gysSave.Zfbz = Jc_code.ConvertToJc_code(comboBox作废标识.SelectedItem).Value;
                gysSave.Wbm = textBox五笔码.Text;
                this.checkJc_gysIsNull(gysSave);

                bool flag = false;
                if (null == oldGys)
                {
                    flag = jc_gysBLL.save(gysSave);
                }
                else
                {
                    this.checkJc_gysIsEqual(this.oldGys, gysSave);
                    //修改
                    gysSave.Id = oldGys.Id;
                    flag = jc_gysBLL.save(gysSave);
                }


                if (true == flag)
                {
                    MyMessageBox.Show("保存成功!");
                }
                else
                {
                    MyMessageBox.Show("保存失败!");
                }
                this.Close();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
        private void checkJc_gysIsNull(Jc_gys jc_gys)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            if (null == jc_gys.Gysbh || "" == jc_gys.Gysbh)
            {
                flag = true;
                sb.Append("请指定‘供应商编号’的值\n");
            }
            if (null == jc_gys.Gysmc || "" == jc_gys.Gysmc)
            {
                flag = true;
                sb.Append("请指定‘供应商名称’的值\n");
            }
            if (null == jc_gys.Pym || "" == jc_gys.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }
            if (null == jc_gys.Lx_code || "" == jc_gys.Lx_code)
            {
                flag = true;
                sb.Append("请指定‘类型’的值\n");
            }
            if (null == jc_gys.Dz || "" == jc_gys.Dz)
            {
                flag = true;
                sb.Append("请指定‘地址’的值\n");
            }
            if (null == jc_gys.Lxr || "" == jc_gys.Lxr)
            {
                flag = true;
                sb.Append("请指定‘联系人’的值\n");
            }
            if (null == jc_gys.Dh || "" == jc_gys.Dh)
            {
                flag = true;
                sb.Append("请指定‘电话’的值\n");
            }
            if (null == jc_gys.Zfbz || "" == jc_gys.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标识’的值\n");
            }
            if (null == jc_gys.Wbm || "" == jc_gys.Wbm)
            {
                flag = true;
                sb.Append("请指定‘五笔码’的值\n");
            }
            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        /// <summary>
        /// 比较Jc_gys类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_gys"></param>
        /// <param name="newJc_gys"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_gysIsEqual(Jc_gys oldJc_gys, Jc_gys newJc_gys)
        {
            bool flag = false;

            //供应商编号
            if (oldJc_gys.Gysbh != newJc_gys.Gysbh)
            {
                flag = true;
            }

            //供应商名称
            if (oldJc_gys.Gysmc != newJc_gys.Gysmc)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_gys.Pym != newJc_gys.Pym)
            {
                flag = true;
            }

            //类型（关联代码表）
            if (oldJc_gys.Lx_code != newJc_gys.Lx_code)
            {
                flag = true;
            }

            //地址
            if (oldJc_gys.Dz != newJc_gys.Dz)
            {
                flag = true;
            }

            //联系人
            if (oldJc_gys.Lxr != newJc_gys.Lxr)
            {
                flag = true;
            }

            //电话
            if (oldJc_gys.Dh != newJc_gys.Dh)
            {
                flag = true;
            }

            //作废标识
            if (oldJc_gys.Zfbz != newJc_gys.Zfbz)
            {
                flag = true;
            }
            if (oldJc_gys.Wbm != newJc_gys.Wbm)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }
        private void textBox供应商名称_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox拼音码.Text = PinYinConverter.GetFirst(textBox供应商名称.Text);
                textBox五笔码.Text = WuBiConverter.GetWBCode(textBox供应商名称.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


    }
}

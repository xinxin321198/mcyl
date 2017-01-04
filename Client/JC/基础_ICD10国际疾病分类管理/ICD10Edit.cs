using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_ICD10;
using client.Common;
using Model.Common;
using Model.JC;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10Edit : Form
    {
        Jc_icd10BLL jc_icd10BLL = new Jc_icd10BLLImp();
        Jc_icd10 oldicd10 = null;
        public ICD10Edit()
        {
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            this.initUI();
        }



        public ICD10Edit(Jc_icd10 jc_icd10)
        {
            this.oldicd10 = jc_icd10;
            InitializeComponent();
            this.initUI();

        }

        private void ICD10TypeEdit_Load(object sender, EventArgs e)
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

            textBox拼音码.ReadOnly = true;
            textBox五笔码.ReadOnly = true;
            if (null != oldicd10)
            {
                textBox编码.Text = this.oldicd10.Icd10_code ;
                textBox中文名称.Text = this.oldicd10.Name;
                textBox拼音码.Text = this.oldicd10.Pym;
                
                textBox英文名称.Text = this.oldicd10.En_name;
                textBox五笔码.Text = this.oldicd10.Wbm;

                comboBox作废标识.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox作废标识, this.oldicd10.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
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
                Jc_icd10 icd10Save = new Jc_icd10();
                icd10Save.Icd10_code = textBox编码.Text;
                icd10Save.Name = textBox中文名称.Text;
                icd10Save.Pym = textBox拼音码.Text;
                icd10Save.En_name = textBox英文名称.Text;
                icd10Save.Zfbz = Jc_code.ConvertToJc_code(comboBox作废标识.SelectedItem).Value;
                icd10Save.Wbm = textBox五笔码.Text;
                this.checkJc_icd10IsNull(icd10Save);

                bool flag = false;
                if (null == oldicd10)
                {
                    flag = jc_icd10BLL.save(icd10Save);
                }
                else
                {
                    this.checkJc_icd10IsEqual(this.oldicd10, icd10Save);
                    //修改
                    icd10Save.Id = oldicd10.Id;
                    flag = jc_icd10BLL.save(icd10Save);
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

        /// <summary>
        /// 校验Jc_icd10类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_icd10"></param>
        private void checkJc_icd10IsNull(Jc_icd10 jc_icd10)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            if (null == jc_icd10.Id || "" == jc_icd10.Id)
            {
                flag = true;
                sb.Append("请指定‘主键’的值\n");
            }

            //icd-10编码
            if (null == jc_icd10.Icd10_code || "" == jc_icd10.Icd10_code)
            {
                flag = true;
                sb.Append("请指定‘icd-10编码’的值\n");
            }

            //icd-10中文名称
            if (null == jc_icd10.Name || "" == jc_icd10.Name)
            {
                flag = true;
                sb.Append("请指定‘icd-10中文名称’的值\n");
            }

            ////icd-10英文名称
            //if (null == jc_icd10.En_name || "" == jc_icd10.En_name)
            //{
            //    flag = true;
            //    sb.Append("请指定‘icd-10英文名称’的值\n");
            //}

            ////拼音码
            //if (null == jc_icd10.Pym || "" == jc_icd10.Pym)
            //{
            //    flag = true;
            //    sb.Append("请指定‘拼音码’的值\n");
            //}

            ////五笔码
            //if (null == jc_icd10.Wbm || "" == jc_icd10.Wbm)
            //{
            //    flag = true;
            //    sb.Append("请指定‘五笔码’的值\n");
            //}

            //作废标志
            if (null == jc_icd10.Zfbz || "" == jc_icd10.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }



        /// <summary>
        /// 比较Jc_icd10类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_icd10"></param>
        /// <param name="newJc_icd10"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_icd10IsEqual(Jc_icd10 oldJc_icd10, Jc_icd10 newJc_icd10)
        {
            bool flag = false;

            //icd-10编码
            if (oldJc_icd10.Icd10_code != newJc_icd10.Icd10_code)
            {
                flag = true;
            }

            //icd-10中文名称
            if (oldJc_icd10.Name != newJc_icd10.Name)
            {
                flag = true;
            }

            //icd-10英文名称
            if (oldJc_icd10.En_name != newJc_icd10.En_name)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_icd10.Pym != newJc_icd10.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_icd10.Wbm != newJc_icd10.Wbm)
            {
                flag = true;
            }

            //作废标志
            if (oldJc_icd10.Zfbz != newJc_icd10.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }

        private void textBox中文名称_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox拼音码.Text = PinYinConverter.GetFirst(textBox中文名称.Text);
                textBox五笔码.Text = WuBiConverter.GetWBCode(textBox中文名称.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void ICD10Edit_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton保存_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_icd10 icd10Save = new Jc_icd10();
                icd10Save.Name = textBox中文名称.Text;
                icd10Save.Icd10_code = textBox编码.Text;
                icd10Save.Pym = textBox拼音码.Text;
                icd10Save.En_name = textBox英文名称.Text;
                icd10Save.Zfbz = Jc_code.ConvertToJc_code(comboBox作废标识.SelectedItem).Value;
                icd10Save.Wbm = textBox五笔码.Text;
                this.checkJc_icd10IsNull(icd10Save);

                bool flag = false;
                if (null == oldicd10)
                {
                    flag = jc_icd10BLL.save(icd10Save);
                }
                else
                {
                    this.checkJc_icd10IsEqual(this.oldicd10, icd10Save);
                    //修改
                    icd10Save.Id = oldicd10.Id;
                    flag = jc_icd10BLL.save(icd10Save);
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

    }
}

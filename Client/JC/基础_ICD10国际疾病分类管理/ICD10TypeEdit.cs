using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_IDC10疾病种类;
using client.Common;
using Model.Common;
using Model.JC;


namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10TypeEdit : Form
    {
        Jc_icd10_typeBLL jc_icd10typeBLL = new Jc_icd10_typeBLLImp();
        Jc_icd10_type oldicd10type = null;
        public ICD10TypeEdit()
        {
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            this.initUI();
        }



        public ICD10TypeEdit(Jc_icd10_type jc_icd10_type)
        {
            this.oldicd10type = jc_icd10_type;
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
            if (null != oldicd10type)
            {
                textBox疾病种类名称.Text = this.oldicd10type.Name;
                textBox疾病代码.Text = this.oldicd10type.Code;
                textBox拼音码.Text = this.oldicd10type.Pym;
                textBox英文名.Text = this.oldicd10type.En_name;
                textBox五笔码.Text = this.oldicd10type.Wbm;
                comboBox作废标识.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox作废标识, this.oldicd10type.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
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
                Jc_icd10_type icd10_typeSave = new Jc_icd10_type();
                icd10_typeSave.Name = textBox疾病种类名称.Text;
                icd10_typeSave.Code = textBox疾病代码.Text;
                icd10_typeSave.Pym = textBox拼音码.Text;
                icd10_typeSave.En_name = textBox英文名.Text;
                icd10_typeSave.Zfbz = Jc_code.ConvertToJc_code(comboBox作废标识.SelectedItem).Value;
                icd10_typeSave.Wbm = textBox五笔码.Text;
                this.checkJc_icd10_typeIsNull(icd10_typeSave);

                bool flag = false;
                if (null == oldicd10type)
                {
                    flag = jc_icd10typeBLL.save(icd10_typeSave);
                }
                else
                {
                    this.checkJc_icd10_typeIsEqual(this.oldicd10type, icd10_typeSave);
                    //修改
                    icd10_typeSave.Id = oldicd10type.Id;
                    flag = jc_icd10typeBLL.save(icd10_typeSave);
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
        /// 校验Jc_icd10_type类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_icd10_type"></param>
        private void checkJc_icd10_typeIsNull(Jc_icd10_type jc_icd10_type)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            if (null == jc_icd10_type.Id || "" == jc_icd10_type.Id)
            {
                flag = true;
                sb.Append("请指定‘主键’的值\n");
            }

            //疾病代码
            if (null == jc_icd10_type.Code || "" == jc_icd10_type.Code)
            {
                flag = true;
                sb.Append("请指定‘疾病代码’的值\n");
            }

            //疾病种类名称
            if (null == jc_icd10_type.Name || "" == jc_icd10_type.Name)
            {
                flag = true;
                sb.Append("请指定‘疾病种类名称’的值\n");
            }

            //英文名
            if (null == jc_icd10_type.En_name || "" == jc_icd10_type.En_name)
            {
                flag = true;
                sb.Append("请指定‘英文名’的值\n");
            }

            ////拼音码
            //if (null == jc_icd10_type.Pym || "" == jc_icd10_type.Pym)
            //{
            //    flag = true;
            //    sb.Append("请指定‘拼音码’的值\n");
            //}

            ////五笔码
            //if (null == jc_icd10_type.Wbm || "" == jc_icd10_type.Wbm)
            //{
            //    flag = true;
            //    sb.Append("请指定‘五笔码’的值\n");
            //}

            //作废标志
            if (null == jc_icd10_type.Zfbz || "" == jc_icd10_type.Zfbz)
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
        /// 比较Jc_icd10_type类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_icd10_type"></param>
        /// <param name="newJc_icd10_type"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_icd10_typeIsEqual(Jc_icd10_type oldJc_icd10_type, Jc_icd10_type newJc_icd10_type)
        {
            bool flag = false;

            //疾病代码
            if (oldJc_icd10_type.Code != newJc_icd10_type.Code)
            {
                flag = true;
            }

            //疾病种类名称
            if (oldJc_icd10_type.Name != newJc_icd10_type.Name)
            {
                flag = true;
            }

            //英文名
            if (oldJc_icd10_type.En_name != newJc_icd10_type.En_name)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_icd10_type.Pym != newJc_icd10_type.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_icd10_type.Wbm != newJc_icd10_type.Wbm)
            {
                flag = true;
            }

            //作废标志
            if (oldJc_icd10_type.Zfbz != newJc_icd10_type.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }


        private void textBox疾病种类名称_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox拼音码.Text = PinYinConverter.GetFirst(textBox疾病种类名称.Text);
                textBox五笔码.Text = WuBiConverter.GetWBCode(textBox疾病种类名称.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

    }
}

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
using BLL.JC.基础_代码类型字典;
using BLL.JC.基础_代码字典;
using Model.JC;

namespace client.JC.代码字典管理
{
    public partial class CodeEdit : Form
    {
        private Jc_code_type parentCodeType;//所属的代码类别
        private Jc_codeBLL jc_codeBLL = new Jc_codeBLLImp();
        private Jc_code oldCode = null;//正在编辑的code

        public CodeEdit(Jc_code oldCode)
        {
            this.oldCode = oldCode;
            this.parentCodeType = oldCode.Jc_code_type;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_save, skinButton_cancel);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_排序码, NumericUpDownHelper.数值控件模式.整型);
        }

        public CodeEdit(Jc_code_type codeType)
        {
            this.parentCodeType = codeType;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_save, skinButton_cancel);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_排序码, NumericUpDownHelper.数值控件模式.整型);

        }

        private void CodeEdit_Load(object sender, EventArgs e)
        {

            try
            {
                this.initUI();//初始化用户界面
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 初始化用户界面
        /// </summary>
        private void initUI()
        {

            textBox_parentCodeType.Text = parentCodeType.Name;
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);//初始化作废标志

                //判断是新增窗口还是编辑窗口
                if (null == oldCode)//新增
                {
                    clearUI();
                }
                else//修改
                {
                    textBox_name.Text = oldCode.Name;
                    textBox_value.Text = oldCode.Value;
                    textBox_拼音码.Text = oldCode.Pym;
                    textBox_五笔码.Text = oldCode.Wbm;
                    comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, oldCode.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
                    richTextBox_remark.Text = oldCode.Remark;
                    skinNumericUpDown_排序码.Value = (decimal)this.oldCode.Sort;
                }
        }




        /// <summary>
        /// 校验Jc_code类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_code"></param>
        private void checkJc_codeIsNull(Jc_code jc_code)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_code.Id || "" == jc_code.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //代码名称
            if (null == jc_code.Name || "" == jc_code.Name)
            {
                flag = true;
                sb.Append("请指定‘代码名称’的值\n");
            }

            //代码值
            if (null == jc_code.Value || "" == jc_code.Value)
            {
                flag = true;
                sb.Append("请指定‘代码值’的值\n");
            }

            //代码所属类型(关联到代码类型表id)
            if (null == jc_code.Fk_code_type || "" == jc_code.Fk_code_type)
            {
                flag = true;
                sb.Append("请指定‘代码所属类型(关联到代码类型表id)’的值\n");
            }

            //拼音码
            if (null == jc_code.Pym || "" == jc_code.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }

            //五笔码
            if (null == jc_code.Wbm || "" == jc_code.Wbm)
            {
                flag = true;
                sb.Append("请指定‘五笔码’的值\n");
            }

            //备注
            //if (null == jc_code.Remark || "" == jc_code.Remark)
            //{
            //    flag = true;
            //    sb.Append("请指定‘备注’的值\n");
            //}

            //作废废标志（0禁用，1启用）
            if (null == jc_code.Zfbz || "" == jc_code.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废废标志（0禁用，1启用）’的值\n");
            }
            if (null == jc_code.Sort||0==jc_code.Sort)
            {
                flag = true;
                sb.Append("请指定‘排序码’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }




        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {

                Jc_code codeSave = new Jc_code();
                codeSave.Name = textBox_name.Text.Trim();
                codeSave.Value = textBox_value.Text.Trim();
                codeSave.Fk_code_type = parentCodeType.Id;
                codeSave.Pym = textBox_拼音码.Text.Trim();
                codeSave.Wbm = textBox_五笔码.Text.Trim();
                codeSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_zfbz.SelectedItem).Value;
                codeSave.Remark = richTextBox_remark.Text.Trim();
                codeSave.Sort = (decimal)skinNumericUpDown_排序码.Value;

                this.checkJc_codeIsNull(codeSave);

                bool flag = false;
                if (null == oldCode)
                {
                    flag = jc_codeBLL.save(codeSave);
                }
                else
                {
                    this.checkJc_codeIsEqual(oldCode, codeSave);
                    codeSave.Id = oldCode.Id;
                    flag = jc_codeBLL.save(codeSave);//修改，对象中已存在主键，会执行update
                    
                }
                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }
                
                this.Close();
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        /// <summary>
        /// 清空用户界面
        /// </summary>
        private void clearUI()
        {
            textBox_name.Clear();
            textBox_value.Clear();
            richTextBox_remark.Clear();
            oldCode = null;
        }




        /// <summary>
        /// 比较Jc_code类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_code"></param>
        /// <param name="newJc_code"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_codeIsEqual(Jc_code oldJc_code, Jc_code newJc_code)
        {
            bool flag = false;

            //代码名称
            if (oldJc_code.Name != newJc_code.Name)
            {
                flag = true;
            }

            //代码值
            if (oldJc_code.Value != newJc_code.Value)
            {
                flag = true;
            }

            //代码所属类型(关联到代码类型表id)
            if (oldJc_code.Fk_code_type != newJc_code.Fk_code_type)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_code.Pym != newJc_code.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_code.Wbm != newJc_code.Wbm)
            {
                flag = true;
            }

            //备注
            if (oldJc_code.Remark != newJc_code.Remark)
            {
                flag = true;
            }

            //作废废标志（0禁用，1启用）
            if (oldJc_code.Zfbz != newJc_code.Zfbz)
            {
                flag = true;
            }
            if (oldJc_code.Sort != newJc_code.Sort)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_拼音码.Text = PinYinConverter.GetFirst(textBox_name.Text);
                textBox_五笔码.Text = WuBiConverter.GetWBCode(textBox_name.Text);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


    }
}

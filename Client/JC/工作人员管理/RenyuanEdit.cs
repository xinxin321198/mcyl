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
using Model.JC;
using BLL.JC.基础_工作人员;
using BLL.JC.基础_代码字典;
using BLL.JC.基础_科室;


namespace client.JC.工作人员管理
{
    public partial class RenyuanEdit : Form
    {
        Jc_codeBLL jc_codeBLL = new Jc_codeBLLImp();
        Jc_renyuanBLL jc_renyuanBLL = new Jc_renyuanBLLImp();
        Jc_kswhBLL jc_kswhBLL = new Jc_kswhBLLImp();
        Jc_renyuan oldRenyuan = null;

        public RenyuanEdit()
        {
            InitializeComponent();
            this.initUI();
        }

        public RenyuanEdit(Jc_renyuan jc_renyuan)
        {
            this.oldRenyuan = jc_renyuan;
            InitializeComponent();
            this.initUI();
         
        }

        private void RenyuanEdit_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

            
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_cancel, skinButton_save);
            DateTimePickerHelper.initDateTimePicker(dateTimePicker1_出生日期);
            DateTimePickerHelper.initDateTimePicker(dateTimePicker2_参加工作时间);

            ComboBoxHelper.initComboBoxForCode(comboBox_性别, Model.Common.CommonCode.代码类型值.性别类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_民族, Model.Common.CommonCode.代码类型值.民族类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox1_政治面貌, Model.Common.CommonCode.代码类型值.政治面貌类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox1_婚姻状况, Model.Common.CommonCode.代码类型值.婚姻状况类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_学历, Model.Common.CommonCode.代码类型值.学历类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);
            ComboBoxHelper.initComboBoxForCode(comboBox_workerType, CommonCode.代码类型值.工作人员类型, CommonCode.代码值_作废标志代码值.启用);

            textBox拼音码.ReadOnly = true;//只读
            if (null != oldRenyuan)
            {
                //修改
                textBox1_姓名.Text = oldRenyuan.Xm;
                comboBox_性别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_性别, oldRenyuan.Xb_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_民族.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_民族, oldRenyuan.Mz_code, CommonCode.实体类名称.基础_代码字典实体类名);
                dateTimePicker1_出生日期.Value = (DateTime)oldRenyuan.Csrq;
                dateTimePicker2_参加工作时间.Value = (DateTime)oldRenyuan.Cjgzsj;
                comboBox_workerType.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_workerType, oldRenyuan.Rylx_code, CommonCode.实体类名称.基础_代码字典实体类名);
                textBox2_身份证号.Text = oldRenyuan.Sfzh;
                comboBox1_政治面貌.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox1_政治面貌, oldRenyuan.Zzmm_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox1_婚姻状况.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox1_婚姻状况, oldRenyuan.Hyzk_code, CommonCode.实体类名称.基础_代码字典实体类名);
                textBox3_毕业学校.Text = oldRenyuan.Byxx;
                comboBox_学历.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_学历, oldRenyuan.Xl_code, CommonCode.实体类名称.基础_代码字典实体类名);
                textBox_专业.Text = oldRenyuan.Zy;
                textBox4_籍贯.Text = oldRenyuan.Jg;
                richTextBox1_地址.Text = oldRenyuan.Dz;
                textBox5_联系电话.Text = oldRenyuan.Lxdh;
                textBox6_qq.Text = oldRenyuan.Qq;
                textBox_邮箱.Text = oldRenyuan.Yx;
                comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, oldRenyuan.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名); ;
                richTextBox2_备注.Text = oldRenyuan.Bz;
                textBox拼音码.Text = oldRenyuan.Pym;


            }
            else
            {
                //测试数据
                textBox1_姓名.Text = "测试人员";
                comboBox_性别.SelectedIndex = 1;
                comboBox_民族.SelectedIndex = 1;
                textBox2_身份证号.Text = "53042419880722080x";
                comboBox_workerType.SelectedIndex = 1;
                comboBox1_政治面貌.SelectedIndex = 1;
                comboBox1_婚姻状况.SelectedIndex = 1;
                textBox3_毕业学校.Text = "云南大学";
                comboBox_学历.SelectedIndex = 1;
                textBox_专业.Text = "临床医学";
                textBox4_籍贯.Text = "云南玉溪";
                richTextBox1_地址.Text = "玉溪市时代广场";
                textBox5_联系电话.Text = "15087872121";
                textBox6_qq.Text = "123456789";
                textBox_邮箱.Text = "abcdefg@qq.com";
                comboBox_zfbz.SelectedIndex = 1;
                richTextBox2_备注.Text = "这是备注";
            }

        }




        /// <summary>
        /// 初始化所有时间控件
        /// </summary>
        private void initDateTimePicker()
        {

        }



        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /// <summary>
        /// 校验Jc_renyuan类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param Name="Jc_renyuan"></param>
        private void checkJc_renyuanIsNull(Jc_renyuan jc_renyuan)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();


            //姓名
            if (null == jc_renyuan.Xm || "" == jc_renyuan.Xm)
            {
                flag = true;
                sb.Append("请指定‘姓名’的值\n");
            }

            //性别（关联基础字典表）
            if (null == jc_renyuan.Xb_code || "" == jc_renyuan.Xb_code)
            {
                flag = true;
                sb.Append("请指定‘性别（关联基础字典表）’的值\n");
            }

            //民族（关联基础字典表）
            if (null == jc_renyuan.Mz_code || "" == jc_renyuan.Mz_code)
            {
                flag = true;
                sb.Append("请指定‘民族（关联基础字典表）’的值\n");
            }

            //出生日期
            if (null == jc_renyuan.Csrq || DateTime.MinValue == jc_renyuan.Csrq)
            {
                flag = true;
                sb.Append("请指定‘出生日期’的值\n");
            }

            //身份证号
            if (null == jc_renyuan.Sfzh || "" == jc_renyuan.Sfzh)
            {
                flag = true;
                sb.Append("请指定‘身份证号’的值\n");
            }

            //政治面貌（关联基础字典表）
            if (null == jc_renyuan.Zzmm_code || "" == jc_renyuan.Zzmm_code)
            {
                flag = true;
                sb.Append("请指定‘政治面貌（关联基础字典表）’的值\n");
            }

            //婚姻状况（关联基础字典表）
            if (null == jc_renyuan.Hyzk_code || "" == jc_renyuan.Hyzk_code)
            {
                flag = true;
                sb.Append("请指定‘婚姻状况（关联基础字典表）’的值\n");
            }

            //毕业学校
            if (null == jc_renyuan.Byxx || "" == jc_renyuan.Byxx)
            {
                flag = true;
                sb.Append("请指定‘毕业学校’的值\n");
            }

            //学历（关联基础字典表）
            if (null == jc_renyuan.Xl_code || "" == jc_renyuan.Xl_code)
            {
                flag = true;
                sb.Append("请指定‘学历（关联基础字典表）’的值\n");
            }

            //参加工作时间
            if (null == jc_renyuan.Cjgzsj || DateTime.MinValue == jc_renyuan.Cjgzsj)
            {
                flag = true;
                sb.Append("请指定‘参加工作时间’的值\n");
            }

            //专业
            if (null == jc_renyuan.Zy || "" == jc_renyuan.Zy)
            {
                flag = true;
                sb.Append("请指定‘专业’的值\n");
            }

            //籍贯
            if (null == jc_renyuan.Jg || "" == jc_renyuan.Jg)
            {
                flag = true;
                sb.Append("请指定‘籍贯’的值\n");
            }

            //地址
            if (null == jc_renyuan.Dz || "" == jc_renyuan.Dz)
            {
                flag = true;
                sb.Append("请指定‘地址’的值\n");
            }

            //联系电话
            if (null == jc_renyuan.Lxdh || "" == jc_renyuan.Lxdh)
            {
                flag = true;
                sb.Append("请指定‘联系电话’的值\n");
            }

            //qq
            if (null == jc_renyuan.Qq || "" == jc_renyuan.Qq)
            {
                flag = true;
                sb.Append("请指定‘qq’的值\n");
            }

            //邮箱
            if (null == jc_renyuan.Yx || "" == jc_renyuan.Yx)
            {
                flag = true;
                sb.Append("请指定‘邮箱’的值\n");
            }

            //备注
            if (null == jc_renyuan.Bz || "" == jc_renyuan.Bz)
            {
                flag = true;
                sb.Append("请指定‘备注’的值\n");
            }

            //作废标志（0是禁用，1是启用）
            if (null == jc_renyuan.Zfbz || "" == jc_renyuan.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志（0是禁用，1是启用）’的值\n");
            }

            //人员类型（关联基础字典表）
            if (null == jc_renyuan.Rylx_code || "" == jc_renyuan.Rylx_code)
            {
                flag = true;
                sb.Append("请指定‘人员类型（关联基础字典表）’的值\n");
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

                Jc_renyuan renyuanSave = new Jc_renyuan();
                renyuanSave.Xm = textBox1_姓名.Text;
                renyuanSave.Xb_code = Jc_code.ConvertToJc_code(comboBox_性别.SelectedItem).Value;
                renyuanSave.Mz_code = Jc_code.ConvertToJc_code(comboBox_民族.SelectedItem).Value;
                renyuanSave.Csrq = dateTimePicker1_出生日期.Value;
                renyuanSave.Rylx_code = Jc_code.ConvertToJc_code(comboBox_workerType.SelectedItem).Value;
                renyuanSave.Sfzh = textBox2_身份证号.Text;
                renyuanSave.Zzmm_code = Jc_code.ConvertToJc_code(comboBox1_政治面貌.SelectedItem).Value;
                renyuanSave.Hyzk_code = Jc_code.ConvertToJc_code(comboBox1_婚姻状况.SelectedItem).Value;
                renyuanSave.Byxx = textBox3_毕业学校.Text;
                renyuanSave.Xl_code = Jc_code.ConvertToJc_code(comboBox_学历.SelectedItem).Value;
                renyuanSave.Cjgzsj = dateTimePicker2_参加工作时间.Value;
                renyuanSave.Zy = textBox_专业.Text;
                renyuanSave.Jg = textBox4_籍贯.Text;
                renyuanSave.Dz = richTextBox1_地址.Text;
                renyuanSave.Lxdh = textBox5_联系电话.Text;
                renyuanSave.Qq = textBox6_qq.Text;
                renyuanSave.Yx = textBox_邮箱.Text;
                renyuanSave.Bz = richTextBox2_备注.Text;
                renyuanSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_zfbz.SelectedItem).Value;
                renyuanSave.Pym = textBox拼音码.Text;
                this.checkJc_renyuanIsNull(renyuanSave);

                bool flag = false;

                if (null == oldRenyuan)
                {
                    flag = jc_renyuanBLL.save(renyuanSave);
                }
                else
                {
                    this.checkJc_renyuanIsEqual(this.oldRenyuan,renyuanSave);
                    //修改
                    renyuanSave.Id = oldRenyuan.Id;
                    flag = jc_renyuanBLL.save(renyuanSave);
                    //flag = jc_renyuanBLL.saveForUserZh(renyuanSave);


                }

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




        /// <summary>
        /// 比较Jc_renyuan类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_renyuan"></param>
        /// <param name="newJc_renyuan"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_renyuanIsEqual(Jc_renyuan oldJc_renyuan, Jc_renyuan newJc_renyuan)
        {
            bool flag = false;

            //姓名
            if (oldJc_renyuan.Xm != newJc_renyuan.Xm)
            {
                flag = true;
            }

            //性别（关联基础字典表）
            if (oldJc_renyuan.Xb_code != newJc_renyuan.Xb_code)
            {
                flag = true;
            }

            //民族（关联基础字典表）
            if (oldJc_renyuan.Mz_code != newJc_renyuan.Mz_code)
            {
                flag = true;
            }

            //出生日期
            if (oldJc_renyuan.Csrq != newJc_renyuan.Csrq)
            {
                flag = true;
            }

            //身份证号
            if (oldJc_renyuan.Sfzh != newJc_renyuan.Sfzh)
            {
                flag = true;
            }

            //政治面貌（关联基础字典表）
            if (oldJc_renyuan.Zzmm_code != newJc_renyuan.Zzmm_code)
            {
                flag = true;
            }

            //婚姻状况（关联基础字典表）
            if (oldJc_renyuan.Hyzk_code != newJc_renyuan.Hyzk_code)
            {
                flag = true;
            }

            //毕业学校
            if (oldJc_renyuan.Byxx != newJc_renyuan.Byxx)
            {
                flag = true;
            }

            //学历（关联基础字典表）
            if (oldJc_renyuan.Xl_code != newJc_renyuan.Xl_code)
            {
                flag = true;
            }

            //参加工作时间
            if (oldJc_renyuan.Cjgzsj != newJc_renyuan.Cjgzsj)
            {
                flag = true;
            }

            //专业
            if (oldJc_renyuan.Zy != newJc_renyuan.Zy)
            {
                flag = true;
            }

            //籍贯
            if (oldJc_renyuan.Jg != newJc_renyuan.Jg)
            {
                flag = true;
            }

            //地址
            if (oldJc_renyuan.Dz != newJc_renyuan.Dz)
            {
                flag = true;
            }

            //联系电话
            if (oldJc_renyuan.Lxdh != newJc_renyuan.Lxdh)
            {
                flag = true;
            }

            //qq
            if (oldJc_renyuan.Qq != newJc_renyuan.Qq)
            {
                flag = true;
            }

            //邮箱
            if (oldJc_renyuan.Yx != newJc_renyuan.Yx)
            {
                flag = true;
            }

            //备注
            if (oldJc_renyuan.Bz != newJc_renyuan.Bz)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_renyuan.Pym != newJc_renyuan.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_renyuan.Wbm != newJc_renyuan.Wbm)
            {
                flag = true;
            }

            //人员类型（关联基础字典表）
            if (oldJc_renyuan.Rylx_code != newJc_renyuan.Rylx_code)
            {
                flag = true;
            }

            //作废标志（0是禁用，1是启用）
            if (oldJc_renyuan.Zfbz != newJc_renyuan.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }



        /// <summary>
        /// 验证用户界面
        /// </summary>
        private void checkUI()
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            if ("" == textBox1_姓名.Text.Trim())
            {
                flag = false;
                sb.Append("姓名不能为空\n");
            }
            if (-1 == comboBox_性别.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择性别\n");
            }
            if (-1 == comboBox_性别.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择名族\n");
            }
            if (-1 == comboBox_workerType.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择工作人员类型\n");
            }
            if ("" == textBox2_身份证号.Text.Trim())
            {
                flag = false;
                sb.Append("身份证号不能为空\n");
            }

            if (-1 == comboBox1_政治面貌.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择政治面貌\n");
            }
            if (-1 == comboBox1_婚姻状况.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择婚姻状况\n");
            }
            if ("" == textBox3_毕业学校.Text.Trim())
            {
            }
            if (-1 == comboBox_学历.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择学历\n");
            }
            if ("" == textBox_专业.Text.Trim())
            {
            }
            if ("" == textBox4_籍贯.Text.Trim())
            {
            }
            if ("" == richTextBox1_地址.Text.Trim())
            {
            }
            if ("" == textBox5_联系电话.Text.Trim())
            {
            }
            if ("" == textBox6_qq.Text.Trim())
            {
            }
            if ("" == textBox_邮箱.Text.Trim())
            {
            }
            if ("" == richTextBox2_备注.Text.Trim())
            {
            }
            if (-1 == comboBox_zfbz.SelectedIndex)
            {
                flag = false;
                sb.Append("请选择作废标志\n");
            }
            if (!flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void textBox1_姓名_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox拼音码.Text = PinYinConverter.GetFirst(textBox1_姓名.Text);
                //textBox五笔码.Text = WuBiConverter.GetWBCode(textBox1_姓名.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}

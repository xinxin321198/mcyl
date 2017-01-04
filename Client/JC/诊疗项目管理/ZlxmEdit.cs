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
using Model.JC;
using BLL.JC.基础_诊疗项目管理;
using Model.Common;

namespace client.JC.诊疗项目管理
{
    public partial class ZlxmEdit : Form
    {
        Jc_zlxmBLL jc_zlxmBLL = new Jc_zlxmBLLImp();
        Jc_zlxm oldZlxm = null;

        public ZlxmEdit()
        {
            InitializeComponent();
            this.initUI();
        }

        public ZlxmEdit(Jc_zlxm jc_zlxm)
        {
            this.oldZlxm = jc_zlxm;
            InitializeComponent();
            this.initUI();

        }

        private void ZlxmEdit_Load(object sender, EventArgs e)
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
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);
            ComboBoxHelper.initComboBoxForCode(comboBox诊疗分类, CommonCode.代码类型值.诊疗项目分类, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox费用归类, CommonCode.代码类型值.费用归类, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox农合收费类别, CommonCode.代码类型值.诊疗项目_农合收费类别, CommonCode.代码值_作废标志代码值.启用);
            //如果是修改，则需初始化
            if (null != oldZlxm)
            {
                textBox项目编码.Text = this.oldZlxm.Xmbh;
                textBox项目名称.Text = this.oldZlxm.Xmmc;
                textBox单位.Text = this.oldZlxm.Dw;
                numericUpDown单价.Value = Convert.ToDecimal(this.oldZlxm.Dj);
                numericUpDown最高限价.Value = Convert.ToDecimal(this.oldZlxm.Zgxj);              
                comboBox诊疗分类.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox诊疗分类, this.oldZlxm.Fl_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox费用归类.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox费用归类, this.oldZlxm.Fygl_code, CommonCode.实体类名称.基础_代码字典实体类名);                
                textBox拼音码.Text = this.oldZlxm.Pym;
                textBox数字码.Text = this.oldZlxm.Szm;
                textBox项目内容.Text = this.oldZlxm.Xmnr;
                textBox除外内容.Text = this.oldZlxm.Cwnr;
                textBox说明.Text = this.oldZlxm.Note;
                textBox检查方法.Text = this.oldZlxm.Jcff;
                textBox标准.Text = this.oldZlxm.Biaozhuan;
                textBox禁检.Text = this.oldZlxm.Jinjian;
                textBox应急.Text = this.oldZlxm.Yinji;
                dateTimePicker公布时间.Value = Convert.ToDateTime(this.oldZlxm.Gbsj);
                textBox公布机构.Text = this.oldZlxm.Gbjg;
                textBox医保编码.Text = this.oldZlxm.Ybbm;
                textBox农合编码.Text = this.oldZlxm.Nhbm;                
                comboBox农合收费类别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox农合收费类别, this.oldZlxm.Nhsflb_code, CommonCode.实体类名称.基础_代码字典实体类名);
                textBox五笔码.Text = this.oldZlxm.Wbm;                
                comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, this.oldZlxm.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
                
            }
            //else//新增
            //{                     //方便测试，使窗体打开时有值，不用手动输入值调试。
            //    textBox项目编码.Text = "0002";
            //    textBox项目名称.Text ="医疗项目"; 
            //    textBox单位.Text ="医院" ;
            //    comboBox诊疗分类.SelectedIndex =0;
            //    comboBox费用归类.SelectedIndex =0;                
            //    textBox数字码.Text = "123";
            //    textBox项目内容.Text ="治疗" ;
            //    textBox除外内容.Text ="检查" ;
            //    textBox说明.Text = "保守医疗";
            //    textBox检查方法.Text = "化疗";
            //    textBox标准.Text ="无" ;
            //    textBox禁检.Text = "头部";
            //    textBox应急.Text = "无";
            //    textBox公布机构.Text = "卫生局";
            //    textBox医保编码.Text = "A53";
            //    textBox农合编码.Text = "YX003";
            //    comboBox农合收费类别.SelectedIndex =0;               
            //    comboBox_zfbz.SelectedIndex =0;
            //}

        }
       

        private void checkJc_zlxmIsNull(Jc_zlxm jc_zlxm)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();


            //项目名称
            if (null == jc_zlxm.Xmmc || "" == jc_zlxm.Xmmc)
            {
                flag = true;
                sb.Append("请指定‘项目名称’的值\n");
            }
            //单位
            if (null == jc_zlxm.Dw || "" == jc_zlxm.Dw )
            {
                flag = true;
                sb.Append("请指定‘单位’的值\n");
            }
            if (null == jc_zlxm.Dj  || 0 ==jc_zlxm.Dj)
            {
                flag = true;
                sb.Append("请指定‘单价’的值\n");
            }
            if (null == jc_zlxm.Zgxj  || 0 == jc_zlxm.Zgxj )
            {
                flag = true;
                sb.Append("请指定‘最高限价’的值\n");
            }
            if (null == jc_zlxm.Fl_code ||"" == jc_zlxm.Fl_code )
            {
                flag = true;
                sb.Append("请指定‘诊疗分类’的值\n");
            }
            if (null == jc_zlxm.Fygl_code  || "" == jc_zlxm.Fygl_code )
            {
                flag = true;
                sb.Append("请指定‘费用归类’的值\n");
            }
            if (null == jc_zlxm.Pym  || "" == jc_zlxm.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }
            if (null == jc_zlxm.Szm  || "" == jc_zlxm.Szm )
            {
                flag = true;
                sb.Append("请指定‘数字码’的值\n");
            }
            if (null == jc_zlxm.Xmnr  || "" == jc_zlxm.Xmnr )
            {
                flag = true;
                sb.Append("请指定‘项目内容’的值\n");
            }
            if (null == jc_zlxm.Cwnr || "" == jc_zlxm.Cwnr )
            {
                flag = true;
                sb.Append("请指定‘除外内容’的值\n");
            }
            if (null == jc_zlxm.Cwnr || "" == jc_zlxm.Cwnr)
            {
                flag = true;
                sb.Append("请指定‘除外内容’的值\n");
            }
            if (null == jc_zlxm.Cwnr || "" == jc_zlxm.Cwnr)
            {
                flag = true;
                sb.Append("请指定‘除外内容’的值\n");
            }
            if (null == jc_zlxm.Cwnr || "" == jc_zlxm.Cwnr)
            {
                flag = true;
                sb.Append("请指定‘除外内容’的值\n");
            }
            if (null == jc_zlxm.Note || "" == jc_zlxm.Note )
            {
                flag = true;
                sb.Append("请指定‘说明’的值\n");
            }
            if (null == jc_zlxm.Jcff  || "" == jc_zlxm.Jcff )
            {
                flag = true;
                sb.Append("请指定‘检查方法’的值\n");
            }
            if (null == jc_zlxm.Biaozhuan  || "" == jc_zlxm.Biaozhuan )
            {
                flag = true;
                sb.Append("请指定‘标准’的值\n");
            }
            if (null == jc_zlxm.Jinjian  || "" == jc_zlxm.Jinjian )
            {
                flag = true;
                sb.Append("请指定‘禁检’的值\n");
            }
            if (null == jc_zlxm.Yinji || "" == jc_zlxm.Yinji )
            {
                flag = true;
                sb.Append("请指定‘应急’的值\n");
            }
            //if (null == jc_zlxm.Gbsj || "" == jc_zlxm.Gbsj )
            //{
            //    flag = true;
            //    sb.Append("请指定‘公布时间’的值\n");
            //}
            if (null == jc_zlxm.Gbjg  || "" == jc_zlxm.Gbjg )
            {
                flag = true;
                sb.Append("请指定‘公布机构’的值\n");
            }
            if (null == jc_zlxm.Ybbm || "" == jc_zlxm.Ybbm)
            {
                flag = true;
                sb.Append("请指定‘医保编码’的值\n");
            }
            if (null == jc_zlxm.Nhbm || "" == jc_zlxm.Nhbm)
            {
                flag = true;
                sb.Append("请指定‘农合编码’的值\n");
            }
            if (null == jc_zlxm.Nhsflb_code || "" == jc_zlxm.Nhsflb_code)
            {
                flag = true;
                sb.Append("请指定‘病人类型’的值\n");
            }
            if (null == jc_zlxm.Wbm || "" == jc_zlxm.Wbm)
            {
                flag = true;
                sb.Append("请指定‘五笔码’的值\n");
            }
            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }
        private void button保存_Click(object sender, EventArgs e)
        {
            try
            {

                Jc_zlxm zlxmSave = new Jc_zlxm();
                zlxmSave.Xmbh = textBox项目编码.Text;
                zlxmSave.Xmmc = textBox项目名称.Text;
                zlxmSave.Dw = textBox单位.Text;
                zlxmSave.Dj = numericUpDown单价.Value;
                zlxmSave.Zgxj = numericUpDown最高限价.Value;
                zlxmSave.Fl_code = Jc_code.ConvertToJc_code(comboBox诊疗分类.SelectedItem).Value; 
                zlxmSave.Fygl_code = Jc_code.ConvertToJc_code( comboBox费用归类.SelectedItem).Value; 
                zlxmSave.Pym = textBox拼音码.Text;
                zlxmSave.Szm = textBox数字码.Text;
                zlxmSave.Xmnr = textBox项目内容.Text;
                zlxmSave.Cwnr = textBox除外内容.Text;
                zlxmSave.Note = textBox说明.Text;
                zlxmSave.Jcff = textBox检查方法.Text;
                zlxmSave.Biaozhuan = textBox标准.Text;
                zlxmSave.Jinjian = textBox禁检.Text;
                zlxmSave.Yinji = textBox应急.Text;
                zlxmSave.Gbsj = Convert.ToDateTime(dateTimePicker公布时间.Text);
                zlxmSave.Gbjg = textBox公布机构.Text;
                zlxmSave.Ybbm = textBox医保编码.Text;
                zlxmSave.Nhbm = textBox农合编码.Text;
                zlxmSave.Nhsflb_code = Jc_code.ConvertToJc_code(comboBox农合收费类别.SelectedItem).Value;
                zlxmSave.Zfbz = Jc_code.ConvertToJc_code( comboBox_zfbz.SelectedItem).Value;
                zlxmSave.Wbm = textBox五笔码.Text;
                this.checkJc_zlxmIsNull(zlxmSave);

                bool flag = false;
                if (null == oldZlxm)
                {
                    flag = jc_zlxmBLL.save(zlxmSave);
                }
                else
                {
                    this.checkJc_zlxmIsEqual(this.oldZlxm, zlxmSave);
                    zlxmSave.Id = oldZlxm.Id;
                    flag = jc_zlxmBLL.save(zlxmSave);


                }


                    if (true ==flag )
                    {
                        MessageBox.Show("保存成功!");
                    }
                    else
                    {
                        MessageBox.Show("保存失败!");
                    }
                    this.Close();
                    
               
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 比较Jc_zlxm类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_zlxm"></param>
        /// <param name="newJc_zlxm"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_zlxmIsEqual(Jc_zlxm oldJc_zlxm, Jc_zlxm newJc_zlxm)
        {
            bool flag = false;

            //项目编码
            if (oldJc_zlxm.Xmbh != newJc_zlxm.Xmbh)
            {
                flag = true;
            }

            //项目名称
            if (oldJc_zlxm.Xmmc != newJc_zlxm.Xmmc)
            {
                flag = true;
            }

            //单位
            if (oldJc_zlxm.Dw != newJc_zlxm.Dw)
            {
                flag = true;
            }

            //单价
            if (oldJc_zlxm.Dj != newJc_zlxm.Dj)
            {
                flag = true;
            }

            //最高限价
            if (oldJc_zlxm.Zgxj != newJc_zlxm.Zgxj)
            {
                flag = true;
            }

            //分类(关联代码表)
            if (oldJc_zlxm.Fl_code != newJc_zlxm.Fl_code)
            {
                flag = true;
            }

            //费用归类(关联代码表)
            if (oldJc_zlxm.Fygl_code != newJc_zlxm.Fygl_code)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_zlxm.Pym != newJc_zlxm.Pym)
            {
                flag = true;
            }

            //数字码
            if (oldJc_zlxm.Szm != newJc_zlxm.Szm)
            {
                flag = true;
            }

            //项目内容
            if (oldJc_zlxm.Xmnr != newJc_zlxm.Xmnr)
            {
                flag = true;
            }

            //除外内容
            if (oldJc_zlxm.Cwnr != newJc_zlxm.Cwnr)
            {
                flag = true;
            }

            //说明
            if (oldJc_zlxm.Note != newJc_zlxm.Note)
            {
                flag = true;
            }

            //检查方法
            if (oldJc_zlxm.Jcff != newJc_zlxm.Jcff)
            {
                flag = true;
            }

            //标准
            if (oldJc_zlxm.Biaozhuan != newJc_zlxm.Biaozhuan)
            {
                flag = true;
            }

            //禁检
            if (oldJc_zlxm.Jinjian != newJc_zlxm.Jinjian)
            {
                flag = true;
            }

            //应急
            if (oldJc_zlxm.Yinji != newJc_zlxm.Yinji)
            {
                flag = true;
            }

            //公布时间
            if (oldJc_zlxm.Gbsj != newJc_zlxm.Gbsj)
            {
                flag = true;
            }

            //公布机构
            if (oldJc_zlxm.Gbjg != newJc_zlxm.Gbjg)
            {
                flag = true;
            }

            //医保编码
            if (oldJc_zlxm.Ybbm != newJc_zlxm.Ybbm)
            {
                flag = true;
            }

            //农合编码
            if (oldJc_zlxm.Nhbm != newJc_zlxm.Nhbm)
            {
                flag = true;
            }

            //农合收费类别(关联代码表)
            if (oldJc_zlxm.Nhsflb_code != newJc_zlxm.Nhsflb_code)
            {
                flag = true;
            }

            //作废
            if (oldJc_zlxm.Zfbz != newJc_zlxm.Zfbz)
            {
                flag = true;
            }
            //五笔码
            if (oldJc_zlxm.Wbm != newJc_zlxm.Wbm)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }


        private void button取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox项目名称_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox拼音码.Text = PinYinConverter.GetFirst(textBox项目名称.Text);
                textBox五笔码.Text = WuBiConverter.GetWBCode(textBox项目名称.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //private void skinButton1_Click(object sender, EventArgs e)//测试用的代码
        //{
        //    List<Jc_zlxm> zlxmList = new List<Jc_zlxm>();
        //    for (int j = 0; j < 100000; j++)
        //    {
        //        Jc_zlxm zlxmSave1 = new Jc_zlxm();
        //        zlxmList.Add(zlxmSave1);
        //    }
        //    jc_zlxmBLL.inertList(zlxmList);
        //}
    }
}

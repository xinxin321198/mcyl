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
using BLL.JC.基础_药品字典;
using Model.JC;
using client.JC.代码字典管理;

namespace client.JC.药品管理
{
    public partial class YpEdit : Form
    {

        private Jc_ypBLL ypBLL = new Jc_ypBLLImp();

        private Jc_yp oldYp = null;

        public YpEdit()
        {
            InitializeComponent();
            this.initUI();
        }

        public YpEdit(Jc_yp yp)
        {
            this.oldYp = yp;
            InitializeComponent();
            this.initUI();
        }

        private void YpEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (null == oldYp)
                {
                    //新增打开
                    //测试
                    MyMessageBox.Show("初始化一些测试数据，正式部署请删除相关代码");
                    textBox_药品编码.Text = "测试药品编码";
                    textBox_药品名称.Text = "测试药品名称";
                    textBox_药品成分.Text = "测试药品成分";
                    textBox_二维码.Text = "二维码";
                    textBox_药品通用名.Text = "药品通用名";
                    textBox_药品批准文号.Text = "药品批准文号";
                    textBox_药品注册证号.Text = "药品注册证号";
                    comboBox_药品剂型.SelectedIndex = 0;
                    textBox_药品规格.Text = "药品规格";
                    numericUpDown_单次用量.Value = (decimal)0;
                    comboBox_单次用量单位.SelectedIndex = 1;
                    comboBox_用药途径.SelectedIndex = 1;
                    skinComboBox_大单位.SelectedIndex = 1;
                    skinComboBox_小单位.SelectedIndex = 1;

                    checkBox_处方药.Checked = true;
                    checkBox_处方权限基药.Checked = true;
                    checkBox_处方权限医保.Checked = true;
                    checkBox_处方权限毒麻.Checked = true;
                    checkBox_精神.Checked = true;
                    checkBox_处方权限贵重.Checked = true;
                    checkBox_处方权限进口.Checked = true;
                    checkBox_处方权限自制.Checked = true;
                    checkBox_处方权限自费.Checked = true;
                    checkBox_处方权限特殊.Checked = true;
                    checkBox_皮试.Checked = true;

                    comboBox_药物类型.SelectedIndex = 1;
                    textBox_药品描述适应症.Text = "_药品描述适应症";
                    textBox_药品描述禁忌症.Text = "_药品描述禁忌症";
                    checkBox_药品描述孕妇或哺乳期禁用.Checked = true;
                    textBox_药品描述不良反应.Text = "_药品描述不良反应";
                    comboBox_药品分类.SelectedIndex = 1;
                    textBox_条形码.Text = "_条形码";
                    numericUpDown_换算系数.Value = (decimal)0;
                    checkBox_抗生素.Checked = true;


                    comboBox_药价级别.SelectedIndex = 1;
                    checkBox_是否拆零用.Checked = true;
                    checkBox_是否拆零卖.Checked = true;

                    numericUpDown_包装批发价.Value = (decimal)0;
                    numericUpDown_包装零售价.Value = (decimal)0;
                    numericUpDown_包装门诊价.Value = (decimal)0;
                    numericUpDown_包装住院价.Value = (decimal)0;
                    numericUpDown_换算比例.Value = (decimal)0;
                    comboBox_有效转态.SelectedIndex = 1;
                    comboBox_作废标志.SelectedIndex = 1;
                    numericUpDown_单次上限用量.Value = (decimal)0;
                    numericUpDown_单次下限用量.Value = (decimal)0;
                    numericUpDown_连续用量天数.Value = (decimal)0;
                    numericUpDown_连续用量次数.Value = (decimal)0;
                    textBox_生产企业.Text = "生产企业";
                }
                else
                {
                    textBox_药品编码.Text = this.oldYp.Ypbm;
                    textBox_药品名称.Text = this.oldYp.Ypmc;
                    textBox_药品成分.Text = this.oldYp.Ypcf;
                    textBox_二维码.Text = this.oldYp.Ewm;
                    textBox_药品通用名.Text = this.oldYp.Yptymc;
                    textBox_药品批准文号.Text = this.oldYp.Yppzwh;
                    textBox_药品注册证号.Text = this.oldYp.Ypzczh;
                    comboBox_药品剂型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药品剂型, this.oldYp.Ypjx_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    textBox_药品规格.Text = this.oldYp.Ypgg;
                    numericUpDown_单次用量.Value = (decimal)this.oldYp.Ypdcyl;
                    comboBox_单次用量单位.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_单次用量单位, this.oldYp.Ypdcyldw_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinNumericUpDown_单次用量换算比例.Value = (decimal)this.oldYp.Dcyldwbl;
                    comboBox_用药途径.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_用药途径, this.oldYp.Ypyytj_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinComboBox_大单位.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_大单位, this.oldYp.Ddw_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinComboBox_小单位.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_小单位, this.oldYp.Xdw_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    textBox_gyzz.Text = this.oldYp.Gyzz;

                    checkBox_处方药.Checked = this.oldYp.Cfybz_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限基药.Checked = this.oldYp.Cfqxjy_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限医保.Checked = this.oldYp.Cfqxyb_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限毒麻.Checked = this.oldYp.Cfqxdm_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_精神.Checked = this.oldYp.Cfqxjs_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限贵重.Checked = this.oldYp.Cfqxgz_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限进口.Checked = this.oldYp.Cfqxjk_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限自制.Checked = this.oldYp.Cfqxzz_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限自费.Checked = this.oldYp.Cfqxzf_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_处方权限特殊.Checked = this.oldYp.Cfqxts_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    checkBox_皮试.Checked = this.oldYp.Ps_code == CommonCode.代码值_勾叉.勾 ? true : false;

                    comboBox_药物类型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药物类型, this.oldYp.Yplx_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    textBox_药品描述适应症.Text = this.oldYp.Ypmssyz;
                    textBox_药品描述禁忌症.Text = this.oldYp.Ypmsjjz;
                    checkBox_药品描述孕妇或哺乳期禁用.Checked = this.oldYp.Ypmsyfhbrqjy_code == CommonCode.代码值_勾叉.勾 ? true : false;
                    textBox_药品描述不良反应.Text = this.oldYp.Ypmsblfy;
                    comboBox_药品分类.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药品分类, this.oldYp.Ypfl_code, CommonCode.实体类名称.基础_代码字典实体类名); ;
                    textBox_条形码.Text = this.oldYp.Txm;
                    textBox_拼音码.Text = this.oldYp.Pym;
                    numericUpDown_换算系数.Value = (decimal)this.oldYp.Hsxs;
                    checkBox_抗生素.Checked = this.oldYp.Sfkss_code == CommonCode.代码值_勾叉.勾 ? true : false; ;


                    comboBox_药价级别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药价级别, this.oldYp.Yjjb_code, CommonCode.实体类名称.基础_代码字典实体类名); ;
                    checkBox_是否拆零用.Checked = this.oldYp.Sfcly_code == CommonCode.代码值_勾叉.勾 ? true : false; ;
                    checkBox_是否拆零卖.Checked = this.oldYp.Sfclm_code == CommonCode.代码值_勾叉.勾 ? true : false; ;

                    numericUpDown_包装批发价.Value = (decimal)this.oldYp.Bzpfj;
                    numericUpDown_包装零售价.Value = (decimal)this.oldYp.Bzlsj;
                    numericUpDown_包装门诊价.Value = (decimal)this.oldYp.Bzmzj;
                    numericUpDown_包装住院价.Value = (decimal)this.oldYp.Bzzyj;
                    numericUpDown_换算比例.Value = (decimal)this.oldYp.Hsbl;
                    comboBox_有效转态.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_有效转态, this.oldYp.Yxzt_code, CommonCode.实体类名称.基础_代码字典实体类名); ; ;
                    comboBox_作废标志.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_作废标志, this.oldYp.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名); ; ;
                    numericUpDown_单次上限用量.Value = (decimal)this.oldYp.Dcsxyl;
                    numericUpDown_单次下限用量.Value = (decimal)this.oldYp.Dcxxyl;
                    numericUpDown_连续用量天数.Value = (decimal)this.oldYp.Lxylts;
                    numericUpDown_连续用量次数.Value = (decimal)this.oldYp.Lxylcs;
                    textBox_生产企业.Text = this.oldYp.Scqy;
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }


        private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_cancel, skinButton_save, skinButton_药品剂型查询, skinButton_药物类型查询, skinButton_用药途径查询);

            ComboBoxHelper.initComboBoxForCode(comboBox_药品剂型, CommonCode.代码类型值.CV5301_01药物剂型代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_用药途径, CommonCode.代码类型值.CV5201_22用药途径代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_药物类型, CommonCode.代码类型值.CV5301_06药物类型代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_药价级别, CommonCode.代码类型值.药品_药价级别,CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_药品分类, CommonCode.代码类型值.药品_分类, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_单次用量单位, CommonCode.代码类型值.药品_单次用量单位, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_有效转态, CommonCode.代码类型值.基础_有效状态, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForZfbz(comboBox_作废标志);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_大单位, CommonCode.代码类型值.药品_大单位, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_小单位, CommonCode.代码类型值.药品_小单位, CommonCode.代码值_作废标志代码值.启用);


            NumericUpDownHelper.initNumericUpDown(numericUpDown_包装零售价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_包装门诊价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_包装批发价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_包装住院价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_单次上限用量, NumericUpDownHelper.数值控件模式.二位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_单次下限用量, NumericUpDownHelper.数值控件模式.二位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_单次用量, NumericUpDownHelper.数值控件模式.二位小数);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_连续用量次数, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_连续用量天数, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(numericUpDown_换算系数, NumericUpDownHelper.数值控件模式.一位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_单次用量换算比例, NumericUpDownHelper.数值控件模式.一位小数);

            DateTimePickerHelper.initDateTimePicker(dateTimePicker_批准日期);

            

            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {

                Jc_yp ypSave = new Jc_yp();
                ypSave.Ypbm = textBox_药品编码.Text;
                ypSave.Ypmc = textBox_药品名称.Text;
                ypSave.Ypcf = textBox_药品成分.Text;
                ypSave.Yptymc = textBox_药品通用名.Text;
                ypSave.Yppzwh = textBox_药品批准文号.Text;
                ypSave.Ypzczh = textBox_药品注册证号.Text;
                ypSave.Gyzz = textBox_gyzz.Text;
                ypSave.Ypjx_code = Jc_code.ConvertToJc_code(comboBox_药品剂型.SelectedItem).Value;
                ypSave.Ypgg = textBox_药品规格.Text;
                ypSave.Ypdcyl = numericUpDown_单次用量.Value;
                ypSave.Ypdcyldw_code = Jc_code.ConvertToJc_code(comboBox_单次用量单位.SelectedItem).Value;
                ypSave.Ypyytj_code = Jc_code.ConvertToJc_code(comboBox_用药途径.SelectedItem).Value;
                ypSave.Ddw_code =Jc_code.ConvertToJc_code( skinComboBox_大单位.SelectedItem).Value;
                ypSave.Xdw_code = Jc_code.ConvertToJc_code( skinComboBox_小单位.SelectedItem).Value;

                ypSave.Cfybz_code = checkBox_处方药.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxjy_code = checkBox_处方权限基药.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxyb_code = checkBox_处方权限医保.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxdm_code = checkBox_处方权限毒麻.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxjs_code = checkBox_精神.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxgz_code = checkBox_处方权限贵重.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxjk_code = checkBox_处方权限进口.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxzz_code = checkBox_处方权限自制.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxzf_code = checkBox_处方权限自费.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Cfqxts_code = checkBox_处方权限特殊.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Ps_code = checkBox_皮试.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;

                ypSave.Yplx_code = Jc_code.ConvertToJc_code(comboBox_药物类型.SelectedItem).Value;
                ypSave.Ypmssyz = textBox_药品描述适应症.Text;
                ypSave.Ypmsjjz = textBox_药品描述禁忌症.Text;
                ypSave.Ypmsyfhbrqjy_code = checkBox_药品描述孕妇或哺乳期禁用.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Ypmsblfy = textBox_药品描述不良反应.Text;
                ypSave.Ypfl_code = Jc_code.ConvertToJc_code(comboBox_药品分类.SelectedItem).Value;
                ypSave.Txm = textBox_条形码.Text;
                ypSave.Pym = textBox_拼音码.Text;
                ypSave.Ewm = textBox_二维码.Text;
                ypSave.Hsxs = numericUpDown_换算系数.Value;
                ypSave.Sfkss_code = checkBox_抗生素.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;


                ypSave.Yjjb_code = Jc_code.ConvertToJc_code(comboBox_药价级别.SelectedItem).Value;
                ypSave.Sfcly_code = checkBox_是否拆零用.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                ypSave.Sfclm_code = checkBox_是否拆零卖.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;

                ypSave.Bzpfj = numericUpDown_包装批发价.Value;
                ypSave.Bzlsj = numericUpDown_包装零售价.Value;
                ypSave.Bzmzj = numericUpDown_包装门诊价.Value;
                ypSave.Bzzyj = numericUpDown_包装住院价.Value;
                ypSave.Hsbl = numericUpDown_换算比例.Value;
                ypSave.Yxzt_code = Jc_code.ConvertToJc_code(comboBox_有效转态.SelectedItem).Value;
                ypSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_作废标志.SelectedItem).Value;
                ypSave.Dcsxyl = numericUpDown_单次上限用量.Value;
                ypSave.Dcxxyl = numericUpDown_单次下限用量.Value;
                ypSave.Lxylts = numericUpDown_连续用量天数.Value;
                ypSave.Lxylcs = numericUpDown_连续用量次数.Value;
                ypSave.Scqy = textBox_生产企业.Text;
                ypSave.Pzrq = dateTimePicker_批准日期.Value;

                this.checkJc_ypIsNull(ypSave);

                bool flag = false;
                if (null == this.oldYp)
                {
                    //新增
                    flag = ypBLL.save(ypSave);
                }
                else
                {
                    this.checkJc_ypIsEqual(this.oldYp, ypSave);
                    ypSave.Id = this.oldYp.Id;
                    flag = ypBLL.save(ypSave);

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
        /// 校验Jc_yp类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param Name="Jc_yp"></param>
        private void checkJc_ypIsNull(Jc_yp jc_yp)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_yp.Id || "" == jc_yp.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //药品编码（药品类型cv5301.06）
            if (null == jc_yp.Ypbm || "" == jc_yp.Ypbm)
            {
                flag = true;
                sb.Append("请指定‘药品编码（药品类型cv5301.06）’的值\n");
            }

            //药品名称(商品名)
            if (null == jc_yp.Ypmc || "" == jc_yp.Ypmc)
            {
                flag = true;
                sb.Append("请指定‘药品名称(商品名)’的值\n");
            }

            //药品通用名
            if (null == jc_yp.Yptymc || "" == jc_yp.Yptymc)
            {
                flag = true;
                sb.Append("请指定‘药品通用名’的值\n");
            }

            //药品成分
            if (null == jc_yp.Ypcf || "" == jc_yp.Ypcf)
            {
                flag = true;
                sb.Append("请指定‘药品成分’的值\n");
            }

            //药品批准文号
            if (null == jc_yp.Yppzwh || "" == jc_yp.Yppzwh)
            {
                flag = true;
                sb.Append("请指定‘药品批准文号’的值\n");
            }

            //药品注册证号
            if (null == jc_yp.Ypzczh || "" == jc_yp.Ypzczh)
            {
                flag = true;
                sb.Append("请指定‘药品注册证号’的值\n");
            }
            //药品注册证号
            if (null == jc_yp.Gyzz || "" == jc_yp.Gyzz)
            {
                flag = true;
                sb.Append("请指定‘国药准字’的值\n");
            }

            //剂型,cv5301.01药物剂型代码(关联代码表)
            if (null == jc_yp.Ypjx_code || "" == jc_yp.Ypjx_code)
            {
                flag = true;
                sb.Append("请指定‘剂型,cv5301.01药物剂型代码(关联代码表)’的值\n");
            }

            //规格
            if (null == jc_yp.Ypgg || "" == jc_yp.Ypgg)
            {
                flag = true;
                sb.Append("请指定‘规格’的值\n");
            }

            //药品单次用量
            if (null == jc_yp.Ypdcyl || 0 == jc_yp.Ypdcyl)
            {
                flag = true;
                sb.Append("请指定‘药品单次用量’的值\n");
            }

            //药品单次用量单位(关联代码表)
            if (null == jc_yp.Ypdcyldw_code || "" == jc_yp.Ypdcyldw_code)
            {
                flag = true;
                sb.Append("请指定‘药品单次用量单位(关联代码表)’的值\n");
            }

            //用量用法,cv5201.22用药途径代码(关联代码表)
            if (null == jc_yp.Ypyytj_code || "" == jc_yp.Ypyytj_code)
            {
                flag = true;
                sb.Append("请指定‘用量用法,cv5201.22用药途径代码(关联代码表)’的值\n");
            }

            //包装单位
            if (null == jc_yp.Ddw_code || "" == jc_yp.Ddw_code)
            {
                flag = true;
                sb.Append("请指定‘大单位’的值\n");
            }

            //发药单位
            if (null == jc_yp.Xdw_code || "" == jc_yp.Xdw_code)
            {
                flag = true;
                sb.Append("请指定‘小单位’的值\n");
            }

            //处方药标志（rx  otc）(是否，关联代码表)
            if (null == jc_yp.Cfybz_code || "" == jc_yp.Cfybz_code)
            {
                flag = true;
                sb.Append("请指定‘处方药标志（rx  otc）(是否，关联代码表)’的值\n");
            }

            //处方权限基药(是否，关联代码表)
            if (null == jc_yp.Cfqxjy_code || "" == jc_yp.Cfqxjy_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限基药(是否，关联代码表)’的值\n");
            }

            //处方权限医保(是否，关联代码表)
            if (null == jc_yp.Cfqxyb_code || "" == jc_yp.Cfqxyb_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限医保(是否，关联代码表)’的值\n");
            }

            //处方权限毒麻(是否，关联代码表)
            if (null == jc_yp.Cfqxdm_code || "" == jc_yp.Cfqxdm_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限毒麻(是否，关联代码表)’的值\n");
            }

            //处方权限精神(是否，关联代码表)
            if (null == jc_yp.Cfqxjs_code || "" == jc_yp.Cfqxjs_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限精神(是否，关联代码表)’的值\n");
            }

            //处方权限贵重(是否，关联代码表)
            if (null == jc_yp.Cfqxgz_code || "" == jc_yp.Cfqxgz_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限贵重(是否，关联代码表)’的值\n");
            }

            //处方权限进口(是否，关联代码表)
            if (null == jc_yp.Cfqxjk_code || "" == jc_yp.Cfqxjk_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限进口(是否，关联代码表)’的值\n");
            }

            //处方权限自制(是否，关联代码表)
            if (null == jc_yp.Cfqxzz_code || "" == jc_yp.Cfqxzz_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限自制(是否，关联代码表)’的值\n");
            }

            //处方权限自费(是否，关联代码表)
            if (null == jc_yp.Cfqxzf_code || "" == jc_yp.Cfqxzf_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限自费(是否，关联代码表)’的值\n");
            }

            //处方权限特殊(是否，关联代码表)
            if (null == jc_yp.Cfqxts_code || "" == jc_yp.Cfqxts_code)
            {
                flag = true;
                sb.Append("请指定‘处方权限特殊(是否，关联代码表)’的值\n");
            }

            //皮试(是否，关联代码表)
            if (null == jc_yp.Ps_code || "" == jc_yp.Ps_code)
            {
                flag = true;
                sb.Append("请指定‘皮试(是否，关联代码表)’的值\n");
            }

            //cv5301.06药物类型代码(关联代码表)
            if (null == jc_yp.Yplx_code || "" == jc_yp.Yplx_code)
            {
                flag = true;
                sb.Append("请指定‘cv5301.06药物类型代码(关联代码表)’的值\n");
            }

            //药品描述适应症
            if (null == jc_yp.Ypmssyz || "" == jc_yp.Ypmssyz)
            {
                flag = true;
                sb.Append("请指定‘药品描述适应症’的值\n");
            }

            //药品描述禁忌症（疾病）
            if (null == jc_yp.Ypmsjjz || "" == jc_yp.Ypmsjjz)
            {
                flag = true;
                sb.Append("请指定‘药品描述禁忌症（疾病）’的值\n");
            }

            //药品描述孕妇或哺乳期禁用(是否，关联代码表)
            if (null == jc_yp.Ypmsyfhbrqjy_code || "" == jc_yp.Ypmsyfhbrqjy_code)
            {
                flag = true;
                sb.Append("请指定‘药品描述孕妇或哺乳期禁用(是否，关联代码表)’的值\n");
            }

            //药品描述不良反应
            if (null == jc_yp.Ypmsblfy || "" == jc_yp.Ypmsblfy)
            {
                flag = true;
                sb.Append("请指定‘药品描述不良反应’的值\n");
            }

            //药品分类(关联代码表)
            if (null == jc_yp.Ypfl_code || "" == jc_yp.Ypfl_code)
            {
                flag = true;
                sb.Append("请指定‘药品分类(关联代码表)’的值\n");
            }

            //药价级别(关联代码表)
            if (null == jc_yp.Yjjb_code || "" == jc_yp.Yjjb_code)
            {
                flag = true;
                sb.Append("请指定‘药价级别(关联代码表)’的值\n");
            }

            //条形码
            if (null == jc_yp.Txm || "" == jc_yp.Txm)
            {
                flag = true;
                sb.Append("请指定‘条形码’的值\n");
            }

            //二维码
            if (null == jc_yp.Ewm || "" == jc_yp.Ewm)
            {
                flag = true;
                sb.Append("请指定‘二维码’的值\n");
            }

            //拼音码
            if (null == jc_yp.Pym || "" == jc_yp.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }

            //换算系数
            if (null == jc_yp.Hsxs || 0 == jc_yp.Hsxs)
            {
                flag = true;
                sb.Append("请指定‘换算系数’的值\n");
            }

            //是否拆零用(是否，关联代码表)
            if (null == jc_yp.Sfcly_code || "" == jc_yp.Sfcly_code)
            {
                flag = true;
                sb.Append("请指定‘是否拆零用(是否，关联代码表)’的值\n");
            }

            //包装批发价
            if (null == jc_yp.Bzpfj || 0 == jc_yp.Bzpfj)
            {
                flag = true;
                sb.Append("请指定‘包装批发价’的值\n");
            }

            //包装零售价
            if (null == jc_yp.Bzlsj || 0 == jc_yp.Bzlsj)
            {
                flag = true;
                sb.Append("请指定‘包装零售价’的值\n");
            }

            //包装门诊价
            if (null == jc_yp.Bzmzj || 0 == jc_yp.Bzmzj)
            {
                flag = true;
                sb.Append("请指定‘包装门诊价’的值\n");
            }

            //包装住院价
            if (null == jc_yp.Bzzyj || 0 == jc_yp.Bzzyj)
            {
                flag = true;
                sb.Append("请指定‘包装住院价’的值\n");
            }

            //换算比例
            if (null == jc_yp.Hsbl || 0 == jc_yp.Hsbl)
            {
                flag = true;
                sb.Append("请指定‘换算比例’的值\n");
            }

            //是否拆零卖(是否，关联代码表)
            if (null == jc_yp.Sfclm_code || "" == jc_yp.Sfclm_code)
            {
                flag = true;
                sb.Append("请指定‘是否拆零卖(是否，关联代码表)’的值\n");
            }

            //有效状态（0无效，1有效, 关联代码表）
            if (null == jc_yp.Yxzt_code || "" == jc_yp.Yxzt_code)
            {
                flag = true;
                sb.Append("请指定‘有效状态（0无效，1有效, 关联代码表）’的值\n");
            }

            //作废标志（0作废，1有效）
            if (null == jc_yp.Zfbz || "" == jc_yp.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志（0作废，1有效）’的值\n");
            }

            //单次上限用量
            if (null == jc_yp.Dcsxyl || 0 == jc_yp.Dcsxyl)
            {
                flag = true;
                sb.Append("请指定‘单次上限用量’的值\n");
            }

            //单次上限用量
            if (null == jc_yp.Dcxxyl || 0 == jc_yp.Dcxxyl)
            {
                flag = true;
                sb.Append("请指定‘单次上限用量’的值\n");
            }

            //连续用量天数
            if (null == jc_yp.Lxylts || 0 == jc_yp.Lxylts)
            {
                flag = true;
                sb.Append("请指定‘连续用量天数’的值\n");
            }

            //连续用量次数
            if (null == jc_yp.Lxylcs || 0 == jc_yp.Lxylcs)
            {
                flag = true;
                sb.Append("请指定‘连续用量次数’的值\n");
            }

            //生产企业
            if (null == jc_yp.Scqy || "" == jc_yp.Scqy)
            {
                flag = true;
                sb.Append("请指定‘生产企业’的值\n");
            }

            //批准日期
            if (null == jc_yp.Pzrq || DateTime.MinValue == jc_yp.Pzrq)
            {
                flag = true;
                sb.Append("请指定‘批准日期’的值\n");
            }

            //是否是抗生素（1是，0否，关联代码表）
            if (null == jc_yp.Sfkss_code || "" == jc_yp.Sfkss_code)
            {
                flag = true;
                sb.Append("请指定‘是否是抗生素（1是，0否，关联代码表）’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }



        /// <summary>
        /// 比较Jc_yp类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_yp"></param>
        /// <param name="newJc_yp"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_ypIsEqual(Jc_yp oldJc_yp, Jc_yp newJc_yp)
        {
            bool flag = false;

            //药品编码（药品类型cv5301.06）
            if (oldJc_yp.Ypbm != newJc_yp.Ypbm)
            {
                flag = true;
            }

            //药品名称(商品名)
            if (oldJc_yp.Ypmc != newJc_yp.Ypmc)
            {
                flag = true;
            }

            //药品通用名
            if (oldJc_yp.Yptymc != newJc_yp.Yptymc)
            {
                flag = true;
            }

            //药品成分
            if (oldJc_yp.Ypcf != newJc_yp.Ypcf)
            {
                flag = true;
            }

            //药品批准文号
            if (oldJc_yp.Yppzwh != newJc_yp.Yppzwh)
            {
                flag = true;
            }

            //药品注册证号
            if (oldJc_yp.Ypzczh != newJc_yp.Ypzczh)
            {
                flag = true;
            }
            //国药准字
            if (oldJc_yp.Gyzz != newJc_yp.Gyzz)
            {
                flag = true;
            }

            //剂型,cv5301.01药物剂型代码(关联代码表)
            if (oldJc_yp.Ypjx_code != newJc_yp.Ypjx_code)
            {
                flag = true;
            }

            //规格
            if (oldJc_yp.Ypgg != newJc_yp.Ypgg)
            {
                flag = true;
            }

            //药品单次用量
            if (oldJc_yp.Ypdcyl != newJc_yp.Ypdcyl)
            {
                flag = true;
            }

            //药品单次用量单位(关联代码表)
            if (oldJc_yp.Ypdcyldw_code != newJc_yp.Ypdcyldw_code)
            {
                flag = true;
            }

            //用量用法,cv5201.22用药途径代码(关联代码表)
            if (oldJc_yp.Ypyytj_code != newJc_yp.Ypyytj_code)
            {
                flag = true;
            }

            //包装单位
            if (oldJc_yp.Ddw_code != newJc_yp.Ddw_code)
            {
                flag = true;
            }

            //发药单位
            if (oldJc_yp.Xdw_code != newJc_yp.Xdw_code)
            {
                flag = true;
            }

            //处方药标志（rx  otc）(是否，关联代码表)
            if (oldJc_yp.Cfybz_code != newJc_yp.Cfybz_code)
            {
                flag = true;
            }

            //处方权限基药(是否，关联代码表)
            if (oldJc_yp.Cfqxjy_code != newJc_yp.Cfqxjy_code)
            {
                flag = true;
            }

            //处方权限医保(是否，关联代码表)
            if (oldJc_yp.Cfqxyb_code != newJc_yp.Cfqxyb_code)
            {
                flag = true;
            }

            //处方权限毒麻(是否，关联代码表)
            if (oldJc_yp.Cfqxdm_code != newJc_yp.Cfqxdm_code)
            {
                flag = true;
            }

            //处方权限精神(是否，关联代码表)
            if (oldJc_yp.Cfqxjs_code != newJc_yp.Cfqxjs_code)
            {
                flag = true;
            }

            //处方权限贵重(是否，关联代码表)
            if (oldJc_yp.Cfqxgz_code != newJc_yp.Cfqxgz_code)
            {
                flag = true;
            }

            //处方权限进口(是否，关联代码表)
            if (oldJc_yp.Cfqxjk_code != newJc_yp.Cfqxjk_code)
            {
                flag = true;
            }

            //处方权限自制(是否，关联代码表)
            if (oldJc_yp.Cfqxzz_code != newJc_yp.Cfqxzz_code)
            {
                flag = true;
            }

            //处方权限自费(是否，关联代码表)
            if (oldJc_yp.Cfqxzf_code != newJc_yp.Cfqxzf_code)
            {
                flag = true;
            }

            //处方权限特殊(是否，关联代码表)
            if (oldJc_yp.Cfqxts_code != newJc_yp.Cfqxts_code)
            {
                flag = true;
            }

            //皮试(是否，关联代码表)
            if (oldJc_yp.Ps_code != newJc_yp.Ps_code)
            {
                flag = true;
            }

            //cv5301.06药物类型代码(关联代码表)
            if (oldJc_yp.Yplx_code != newJc_yp.Yplx_code)
            {
                flag = true;
            }

            //药品描述适应症
            if (oldJc_yp.Ypmssyz != newJc_yp.Ypmssyz)
            {
                flag = true;
            }

            //药品描述禁忌症（疾病）
            if (oldJc_yp.Ypmsjjz != newJc_yp.Ypmsjjz)
            {
                flag = true;
            }

            //药品描述孕妇或哺乳期禁用(是否，关联代码表)
            if (oldJc_yp.Ypmsyfhbrqjy_code != newJc_yp.Ypmsyfhbrqjy_code)
            {
                flag = true;
            }

            //药品描述不良反应
            if (oldJc_yp.Ypmsblfy != newJc_yp.Ypmsblfy)
            {
                flag = true;
            }

            //药品分类(关联代码表)
            if (oldJc_yp.Ypfl_code != newJc_yp.Ypfl_code)
            {
                flag = true;
            }

            //药价级别(关联代码表)
            if (oldJc_yp.Yjjb_code != newJc_yp.Yjjb_code)
            {
                flag = true;
            }

            //条形码
            if (oldJc_yp.Txm != newJc_yp.Txm)
            {
                flag = true;
            }

            //二维码
            if (oldJc_yp.Ewm != newJc_yp.Ewm)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_yp.Pym != newJc_yp.Pym)
            {
                flag = true;
            }

            //换算系数
            if (oldJc_yp.Hsxs != newJc_yp.Hsxs)
            {
                flag = true;
            }

            //是否拆零用(是否，关联代码表)
            if (oldJc_yp.Sfcly_code != newJc_yp.Sfcly_code)
            {
                flag = true;
            }

            //包装批发价
            if (oldJc_yp.Bzpfj != newJc_yp.Bzpfj)
            {
                flag = true;
            }

            //包装零售价
            if (oldJc_yp.Bzlsj != newJc_yp.Bzlsj)
            {
                flag = true;
            }

            //包装门诊价
            if (oldJc_yp.Bzmzj != newJc_yp.Bzmzj)
            {
                flag = true;
            }

            //包装住院价
            if (oldJc_yp.Bzzyj != newJc_yp.Bzzyj)
            {
                flag = true;
            }

            //换算比例
            if (oldJc_yp.Hsbl != newJc_yp.Hsbl)
            {
                flag = true;
            }

            //是否拆零卖(是否，关联代码表)
            if (oldJc_yp.Sfclm_code != newJc_yp.Sfclm_code)
            {
                flag = true;
            }

            //有效状态（0无效，1有效, 关联代码表）
            if (oldJc_yp.Yxzt_code != newJc_yp.Yxzt_code)
            {
                flag = true;
            }

            //单次上限用量
            if (oldJc_yp.Dcsxyl != newJc_yp.Dcsxyl)
            {
                flag = true;
            }

            //单次上限用量
            if (oldJc_yp.Dcxxyl != newJc_yp.Dcxxyl)
            {
                flag = true;
            }

            //连续用量天数
            if (oldJc_yp.Lxylts != newJc_yp.Lxylts)
            {
                flag = true;
            }

            //连续用量次数
            if (oldJc_yp.Lxylcs != newJc_yp.Lxylcs)
            {
                flag = true;
            }

            //生产企业
            if (oldJc_yp.Scqy != newJc_yp.Scqy)
            {
                flag = true;
            }

            //批准日期
            if (oldJc_yp.Pzrq != newJc_yp.Pzrq)
            {
                flag = true;
            }

            //是否是抗生素（1是，0否，关联代码表）
            if (oldJc_yp.Sfkss_code != newJc_yp.Sfkss_code)
            {
                flag = true;
            }

            //作废标志（0作废，1有效）
            if (oldJc_yp.Zfbz != newJc_yp.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_code_type codeType = new Jc_code_type();
                codeType.Value = CommonCode.代码类型值.CV5301_01药物剂型代码;
                CodeSearch codeSearch = new CodeSearch(codeType);
                codeSearch.ShowDialog();
                Jc_code code = codeSearch.SelectedCode;
                if (code!=null)
                {
                    comboBox_药品剂型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药品剂型, code.Value, CommonCode.实体类名称.基础_代码字典实体类名);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_用药途径查询_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_code_type codeType = new Jc_code_type();
                codeType.Value = CommonCode.代码类型值.CV5201_22用药途径代码;
                CodeSearch codeSearch = new CodeSearch(codeType);
                codeSearch.ShowDialog();
                Jc_code code = codeSearch.SelectedCode;
                if (code != null)
                {
                    comboBox_用药途径.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_用药途径, code.Value, CommonCode.实体类名称.基础_代码字典实体类名);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Jc_code_type codeType = new Jc_code_type();
                codeType.Value = CommonCode.代码类型值.CV5301_06药物类型代码;
                CodeSearch codeSearch = new CodeSearch(codeType);
                codeSearch.ShowDialog();
                Jc_code code = codeSearch.SelectedCode;
                if (code != null)
                {
                    comboBox_药物类型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_药物类型, code.Value, CommonCode.实体类名称.基础_代码字典实体类名);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_药品名称_TextChanged(object sender, EventArgs e)
        {
            textBox_拼音码.Text = PinYinConverter.GetFirst(textBox_药品名称.Text).Trim().ToUpper();
        }


    }
}

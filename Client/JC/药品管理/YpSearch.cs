using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Common;
using client.Common;
using BLL.JC.基础_药品字典;
using Model.JC;

namespace client.JC.药品管理
{
    public partial class YpSearch : Form
    {
        private Jc_ypBLL ypBll = new Jc_ypBLLImp();


        /// <summary>
        /// 分页对象，初始化列表数据之前置为null可查出所有的数据，否则就根据page当前的所有数据量、当前页计算出数据的范围去查询，并且返回这一个page
        /// </summary>
        private PageInfo page = null;

        /// <summary>
        /// 检索字符串
        /// </summary>
        private string queryString;

        public string QueryString
        {
            get { return queryString; }
            set { queryString = value; }
        }

        /// <summary>
        /// 药品分类的code对象
        /// </summary>
        private Jc_code ypflCode;
        /// <summary>
        /// 药品分类的code对象
        /// </summary>
        public Jc_code YpflCode
        {
            get { return ypflCode; }
            set { ypflCode = value; }
        }

        /// <summary>
        /// 双击选中的药品对象
        /// </summary>
        private Jc_yp selectedYp;

        public Jc_yp SelectedYp
        {
            get { return selectedYp; }
            set { selectedYp = value; }
        }

        public YpSearch()
        {
            InitializeComponent();
            FormHelper.initFormForToolWindow(this);
            LabelHelper.initTitleLabel(label_msg,label_药品分类);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);


        }


        private void skinDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.selectedYp = (Jc_yp)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView1);
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void initDataGridView(string queryString)
        {
            if (null==queryString||""==queryString)
            {
		        return ;
            }
            StringHelper.字符类型 flag = StringHelper.judgeStringFirstCharType(queryString); ;
            Jc_yp ypParamLike = new Jc_yp();
            if (flag== StringHelper.字符类型.数字)
	        {
                ypParamLike.Ypbm = queryString;
	        }
            else if (flag== StringHelper.字符类型.字母)
	        {
                ypParamLike.Pym = queryString.ToUpper() ;
		 
	        }
            else if (flag== StringHelper.字符类型.中文)
	        {
                ypParamLike.Ypmc = queryString;//药品名称
                ypParamLike.Yptymc = queryString;//药品通用名称
            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }

            Jc_yp ypParam = new Jc_yp();
            ypParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            ypParam.Ypfl_code = this.YpflCode.Value;
            List<object> objs = ypBll.getListContactObjectByPageForFast(ypParam, this.page, ypParamLike, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView1, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl();


            if (skinDataGridView1.DataSource == null)
            {
                return;
            }

            //*******************************UI,datagridview隐藏字段，start
            //隱藏列start
            //skinDataGridView1.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView1.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView1.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView1.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            #region

            skinDataGridView1.Columns[Jc_yp.ID].Visible = false;//主键
            skinDataGridView1.Columns[Jc_yp.ID].HeaderText = "主键";

            //skinDataGridView1.Columns[Jc_yp.YPBM].Visible = false;//药品编码（药品类型cv5301.06）
            skinDataGridView1.Columns[Jc_yp.YPBM].HeaderText = "药品编码";

            //skinDataGridView1.Columns[Jc_yp.YPMC].Visible = false;//药品名称(商品名)
            skinDataGridView1.Columns[Jc_yp.YPMC].HeaderText = "药品名称";

            //skinDataGridView1.Columns[Jc_yp.YPTYMC].Visible = false;//药品通用名
            skinDataGridView1.Columns[Jc_yp.YPTYMC].HeaderText = "药品通用名";

            skinDataGridView1.Columns[Jc_yp.YPCF].Visible = false;//药品成分
            skinDataGridView1.Columns[Jc_yp.YPCF].HeaderText = "药品成分";

            skinDataGridView1.Columns[Jc_yp.YPPZWH].Visible = false;//药品批准文号
            skinDataGridView1.Columns[Jc_yp.YPPZWH].HeaderText = "药品批准文号";

            skinDataGridView1.Columns[Jc_yp.YPZCZH].Visible = false;//药品注册证号
            skinDataGridView1.Columns[Jc_yp.YPZCZH].HeaderText = "药品注册证号";

            skinDataGridView1.Columns[Jc_yp.GYZZ].Visible = false;//国药准字
            skinDataGridView1.Columns[Jc_yp.GYZZ].HeaderText = "国药准字";

            skinDataGridView1.Columns[Jc_yp.YPJX_CODE].Visible = false;//剂型,cv5301.01药物剂型代码(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPJX_CODE].HeaderText = "剂型,cv5301.01药物剂型代码(关联代码表)";

            //skinDataGridView1.Columns[Jc_yp.YPGG].Visible = false;//规格
            skinDataGridView1.Columns[Jc_yp.YPGG].HeaderText = "规格";

            skinDataGridView1.Columns[Jc_yp.YPDCYL].Visible = false;//药品单次用量
            skinDataGridView1.Columns[Jc_yp.YPDCYL].HeaderText = "药品单次用量";

            skinDataGridView1.Columns[Jc_yp.YPDCYLDW_CODE].Visible = false;//药品单次用量单位(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPDCYLDW_CODE].HeaderText = "药品单次用量单位(关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YPYYTJ_CODE].Visible = false;//用量用法,cv5201.22用药途径代码(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPYYTJ_CODE].HeaderText = "用量用法,cv5201.22用药途径代码(关联代码表)";

            skinDataGridView1.Columns[Jc_yp.DDW_CODE].Visible = false;//大单位(药品大单位，关联代码表)
            skinDataGridView1.Columns[Jc_yp.DDW_CODE].HeaderText = "大单位(药品大单位，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.XDW_CODE].Visible = false;//小单位(药品小单位，关联代码表)
            skinDataGridView1.Columns[Jc_yp.XDW_CODE].HeaderText = "小单位(药品小单位，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFYBZ_CODE].Visible = false;//处方药标志（rx  otc）(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFYBZ_CODE].HeaderText = "处方药标志（rx  otc）(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXJY_CODE].Visible = false;//处方权限基药(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXJY_CODE].HeaderText = "处方权限基药(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXYB_CODE].Visible = false;//处方权限医保(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXYB_CODE].HeaderText = "处方权限医保(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXDM_CODE].Visible = false;//处方权限毒麻(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXDM_CODE].HeaderText = "处方权限毒麻(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXJS_CODE].Visible = false;//处方权限精神(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXJS_CODE].HeaderText = "处方权限精神(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXGZ_CODE].Visible = false;//处方权限贵重(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXGZ_CODE].HeaderText = "处方权限贵重(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXJK_CODE].Visible = false;//处方权限进口(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXJK_CODE].HeaderText = "处方权限进口(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXZZ_CODE].Visible = false;//处方权限自制(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXZZ_CODE].HeaderText = "处方权限自制(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXZF_CODE].Visible = false;//处方权限自费(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXZF_CODE].HeaderText = "处方权限自费(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.CFQXTS_CODE].Visible = false;//处方权限特殊(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.CFQXTS_CODE].HeaderText = "处方权限特殊(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.PS_CODE].Visible = false;//皮试(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.PS_CODE].HeaderText = "皮试(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YPLX_CODE].Visible = false;//cv5301.06药物类型代码(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPLX_CODE].HeaderText = "cv5301.06药物类型代码(关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YPMSSYZ].Visible = false;//药品描述适应症
            skinDataGridView1.Columns[Jc_yp.YPMSSYZ].HeaderText = "药品描述适应症";

            skinDataGridView1.Columns[Jc_yp.YPMSJJZ].Visible = false;//药品描述禁忌症（疾病）
            skinDataGridView1.Columns[Jc_yp.YPMSJJZ].HeaderText = "药品描述禁忌症（疾病）";

            skinDataGridView1.Columns[Jc_yp.YPMSYFHBRQJY_CODE].Visible = false;//药品描述孕妇或哺乳期禁用(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPMSYFHBRQJY_CODE].HeaderText = "药品描述孕妇或哺乳期禁用(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YPMSBLFY].Visible = false;//药品描述不良反应
            skinDataGridView1.Columns[Jc_yp.YPMSBLFY].HeaderText = "药品描述不良反应";

            skinDataGridView1.Columns[Jc_yp.YPFL_CODE].Visible = false;//药品分类(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YPFL_CODE].HeaderText = "药品分类(关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YJJB_CODE].Visible = false;//药价级别(关联代码表)
            skinDataGridView1.Columns[Jc_yp.YJJB_CODE].HeaderText = "药价级别(关联代码表)";

            skinDataGridView1.Columns[Jc_yp.TXM].Visible = false;//条形码
            skinDataGridView1.Columns[Jc_yp.TXM].HeaderText = "条形码";

            skinDataGridView1.Columns[Jc_yp.EWM].Visible = false;//二维码
            skinDataGridView1.Columns[Jc_yp.EWM].HeaderText = "二维码";

            skinDataGridView1.Columns[Jc_yp.PYM].Visible = false;//拼音码
            skinDataGridView1.Columns[Jc_yp.PYM].HeaderText = "拼音码";

            skinDataGridView1.Columns[Jc_yp.HSXS].Visible = false;//换算系数
            skinDataGridView1.Columns[Jc_yp.HSXS].HeaderText = "换算系数";

            skinDataGridView1.Columns[Jc_yp.SFCLY_CODE].Visible = false;//是否拆零用(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.SFCLY_CODE].HeaderText = "是否拆零用(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.BZPFJ].Visible = false;//包装批发价
            skinDataGridView1.Columns[Jc_yp.BZPFJ].HeaderText = "包装批发价";

            skinDataGridView1.Columns[Jc_yp.BZLSJ].Visible = false;//包装零售价
            skinDataGridView1.Columns[Jc_yp.BZLSJ].HeaderText = "包装零售价";

            skinDataGridView1.Columns[Jc_yp.BZMZJ].Visible = false;//包装门诊价
            skinDataGridView1.Columns[Jc_yp.BZMZJ].HeaderText = "包装门诊价";

            skinDataGridView1.Columns[Jc_yp.BZZYJ].Visible = false;//包装住院价
            skinDataGridView1.Columns[Jc_yp.BZZYJ].HeaderText = "包装住院价";

            skinDataGridView1.Columns[Jc_yp.HSBL].Visible = false;//换算比例
            skinDataGridView1.Columns[Jc_yp.HSBL].HeaderText = "换算比例";

            skinDataGridView1.Columns[Jc_yp.SFCLM_CODE].Visible = false;//是否拆零卖(是否，关联代码表)
            skinDataGridView1.Columns[Jc_yp.SFCLM_CODE].HeaderText = "是否拆零卖(是否，关联代码表)";

            skinDataGridView1.Columns[Jc_yp.YXZT_CODE].Visible = false;//有效状态（0无效，1有效, 关联代码表）
            skinDataGridView1.Columns[Jc_yp.YXZT_CODE].HeaderText = "有效状态（0无效，1有效, 关联代码表）";

            skinDataGridView1.Columns[Jc_yp.ZFBZ].Visible = false;//作废标志（0作废，1有效）
            skinDataGridView1.Columns[Jc_yp.ZFBZ].HeaderText = "作废标志（0作废，1有效）";

            skinDataGridView1.Columns[Jc_yp.DCSXYL].Visible = false;//单次上限用量
            skinDataGridView1.Columns[Jc_yp.DCSXYL].HeaderText = "单次上限用量";

            skinDataGridView1.Columns[Jc_yp.DCXXYL].Visible = false;//单次上限用量
            skinDataGridView1.Columns[Jc_yp.DCXXYL].HeaderText = "单次上限用量";

            skinDataGridView1.Columns[Jc_yp.LXYLTS].Visible = false;//连续用量天数
            skinDataGridView1.Columns[Jc_yp.LXYLTS].HeaderText = "连续用量天数";

            skinDataGridView1.Columns[Jc_yp.LXYLCS].Visible = false;//连续用量次数
            skinDataGridView1.Columns[Jc_yp.LXYLCS].HeaderText = "连续用量次数";

            skinDataGridView1.Columns[Jc_yp.SCQY].Visible = false;//生产企业
            skinDataGridView1.Columns[Jc_yp.SCQY].HeaderText = "生产企业";

            skinDataGridView1.Columns[Jc_yp.PZRQ].Visible = false;//批准日期
            skinDataGridView1.Columns[Jc_yp.PZRQ].HeaderText = "批准日期";
            skinDataGridView1.Columns[Jc_yp.PZRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView1.Columns[Jc_yp.SFKSS_CODE].Visible = false;//是否是抗生素（1是，0否，关联代码表）
            skinDataGridView1.Columns[Jc_yp.SFKSS_CODE].HeaderText = "是否是抗生素（1是，0否，关联代码表）";
            skinDataGridView1.Columns[Jc_yp.DCYLDWBL].Visible = false;//单次用量单位比例
            skinDataGridView1.Columns[Jc_yp.DCYLDWBL].HeaderText = "单次用量单位比例";
            #endregion
            //*******************************UI,datagridview隐藏字段，start

            //*******************************UI,实体类字段转换，start
            #region
             SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "ypjxCode", "ypjxCodeName", "剂型", CommonCode.实体类名称.基础_代码字典实体类名);
             SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "ddwCode", "ddwCodeName", "大单位(药品大单位，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

             SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "xdwCode", "xdwCodeName", "小单位(药品小单位，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "ypdcyldwCode", "ypdcyldwCodeName", "药品单次用量单位", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "ypyytjCode", "ypyytjCodeName", "用量用法", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfybzCode", "cfybzCodeName", "处方药标志（rx  otc）(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxjyCode", "cfqxjyCodeName", "处方权限基药(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxybCode", "cfqxybCodeName", "处方权限医保(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxdmCode", "cfqxdmCodeName", "处方权限毒麻(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxjsCode", "cfqxjsCodeName", "处方权限精神(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxgzCode", "cfqxgzCodeName", "处方权限贵重(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxjkCode", "cfqxjkCodeName", "处方权限进口(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxzzCode", "cfqxzzCodeName", "处方权限自制(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxzfCode", "cfqxzfCodeName", "处方权限自费(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "cfqxtsCode", "cfqxtsCodeName", "处方权限特殊(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "psCode", "psCodeName", "皮试(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
           // DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "yplxCode", "yplxCodeName", "药物类型", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "ypmsyfhbrqjyCode", "ypmsyfhbrqjyCodeName", "药品描述孕妇或哺乳期禁用(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "YpflCode", "ypflCodeName", "药品分类", CommonCode.实体类名称.基础_代码字典实体类名);
           // DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "yjjbCode", "yjjbCodeName", "药价级别", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "sfclyCode", "sfclyCodeName", "是否拆零用(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "sfclmCode", "sfclmCodeName", "是否拆零卖(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "yxztCode", "yxztCodeName", "有效状态（0无效，1有效, 关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "sfkssCode", "sfkssCodeName", "是否是抗生素", CommonCode.实体类名称.基础_代码字典实体类名);
            #endregion
            //*******************************UI,实体类字段转换，end

            skinDataGridView1.Columns["ypdcyldwCode"].Visible = false;
            skinDataGridView1.Columns["ypyytjCode"].Visible = false;

            skinDataGridView1.Columns["yplxCode"].Visible = false;
            skinDataGridView1.Columns["ypflCode"].Visible = false;
            skinDataGridView1.Columns["yjjbCode"].Visible = false;



            skinDataGridView1.Columns["cfybzCode"].Visible = false;
            skinDataGridView1.Columns["cfqxjyCode"].Visible = false;
            skinDataGridView1.Columns["cfqxybCode"].Visible = false;
            skinDataGridView1.Columns["cfqxdmCode"].Visible = false;
            skinDataGridView1.Columns["cfqxjsCode"].Visible = false;
            skinDataGridView1.Columns["cfqxgzCode"].Visible = false;
            skinDataGridView1.Columns["cfqxjkCode"].Visible = false;
            skinDataGridView1.Columns["cfqxzzCode"].Visible = false;
            skinDataGridView1.Columns["cfqxzfCode"].Visible = false;
            skinDataGridView1.Columns["cfqxtsCode"].Visible = false;
            skinDataGridView1.Columns["psCode"].Visible = false;
            skinDataGridView1.Columns["ypmsyfhbrqjyCode"].Visible = false;
            skinDataGridView1.Columns["sfclyCode"].Visible = false;
            skinDataGridView1.Columns["sfclmCode"].Visible = false;
            skinDataGridView1.Columns["ypjxCode"].Visible = false;
            skinDataGridView1.Columns["yxztCode"].Visible = false;

            SkinDataGridViewHelper.endDataGridView(skinDataGridView1);
        }




        private void YpSearch_Activated(object sender, EventArgs e)
        {
            try
            {
   
                TextBoxHelper.setTextBoxSelectionEnd(textBox_query);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void YpSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }



        private void textBox_query_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.YpflCode==null)
                {
                    return;
                }
                if ( this.textBox_query.Text.Trim()==null|| this.textBox_query.Text.Trim()=="")
                {
                    return;
                }
                this.queryString = this.textBox_query.Text.Trim().ToUpper();
                this.page = null;
                this.initDataGridView(this.queryString);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }




        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl()
        {
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前页码
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();//总页数
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();//每页显示多少条
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();//数据总数
        }

        //首页按钮的点击事件
        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;//当前页设为第一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //上一页按钮的点击事件
        private void toolStripButton_prevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.PrevPage;//当前页设为上一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //下一页按钮的点击事件
        private void toolStripButton_nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.NextPage;//当前页设为下一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //末尾页按钮的点击事件
        private void toolStripButton_endPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = this.page.PageCount;//当前页设为末尾页页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void skinDataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }

                if (key == Keys.Enter)
                {
                    this.selectedYp = (Jc_yp)SkinDataGridViewHelper.getKeyPreesEnterCurrentDataGridViewItem(skinDataGridView1);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
            
        }


        private void YpSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView1.Focus();
                }
                if (key == Keys.Left || key == Keys.Right)
                {
                    textBox_query.Focus();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void YpSearch_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_query.Clear();
                textBox_query.Text = this.queryString;
                label_药品分类.Text = this.YpflCode.Name;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
     
        }




    }
}

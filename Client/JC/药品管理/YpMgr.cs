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
using BLL.JC.基础_药品字典;
using Model.RBAC;

namespace client.JC.药品管理
{
    public partial class YpMgr : Form
    {
        private Jc_ypBLL ypBLL = new Jc_ypBLLImp();

        private PageInfo page = null;
        private Main main = null;//主窗体引用

        public YpMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_yp);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            YpEdit ypEdit = new YpEdit();
            ypEdit.ShowDialog();
            this.page = null;

            this.initDataGridView_yp();
        }

        private void YpMgr_Load(object sender, EventArgs e)
        {
            try
            {
                this.initUI();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void initUI()
        {

            this.initDataGridView_yp();

        }

        private void initPageControl()
        {
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();
            toolStrip_yp.Dock = DockStyle.Bottom;
        }

        private void initDataGridView_yp()
        {
            List<SortInfo> pageList = new List<SortInfo>();
            pageList.Add(new SortInfo(Jc_yp.YPBM));
            List<object> objs = ypBLL.getListContactObjectByPage(null, this.page, null, pageList);
            List<Jc_yp> ypList = (List<Jc_yp>)objs[0];
            this.page = (PageInfo)objs[1];

            SkinDataGridViewHelper.bindingList(skinDataGridView_yp, ypList);


            this.initPageControl();


            if (skinDataGridView_yp.DataSource == null)
            {
                return;
            }

            //*******************************UI,datagridview隐藏字段，start
            //隱藏列start
            //dataGridView_yp.Columns["ID"].Visible = false;//隐藏此列
            //dataGridView_yp.Columns["ID"].HeaderText = "主键";//设置列名
            //dataGridView_yp.Columns["ID"].DisplayIndex = 0;//列的顺序
            //dataGridView_yp.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            #region

            skinDataGridView_yp.Columns[Jc_yp.ID].Visible = false;//主键
            skinDataGridView_yp.Columns[Jc_yp.ID].HeaderText = "主键";

            //dataGridView_yp.Columns[Jc_yp.YPBM].Visible = false;//药品编码（药品类型cv5301.06）
            skinDataGridView_yp.Columns[Jc_yp.YPBM].HeaderText = "药品编码";

            //dataGridView_yp.Columns[Jc_yp.YPMC].Visible = false;//药品名称(商品名)
            skinDataGridView_yp.Columns[Jc_yp.YPMC].HeaderText = "药品名称";

            skinDataGridView_yp.Columns[Jc_yp.YPTYMC].Visible = false;//药品通用名
            skinDataGridView_yp.Columns[Jc_yp.YPTYMC].HeaderText = "药品通用名";

            //dataGridView_yp.Columns[Jc_yp.YPCF].Visible = false;//药品成分
            skinDataGridView_yp.Columns[Jc_yp.YPCF].HeaderText = "药品成分";

            skinDataGridView_yp.Columns[Jc_yp.YPPZWH].Visible = false;//药品批准文号
            skinDataGridView_yp.Columns[Jc_yp.YPPZWH].HeaderText = "药品批准文号";

            //dataGridView_yp.Columns[Jc_yp.YPZCZH].Visible = false;//药品注册证号
            skinDataGridView_yp.Columns[Jc_yp.YPZCZH].HeaderText = "药品注册证号";

            skinDataGridView_yp.Columns[Jc_yp.GYZZ].Visible = false;//国药准字
            skinDataGridView_yp.Columns[Jc_yp.GYZZ].HeaderText = "国药准字";

            skinDataGridView_yp.Columns[Jc_yp.YPJX_CODE].Visible = false;//剂型,cv5301.01药物剂型代码(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPJX_CODE].HeaderText = "剂型,cv5301.01药物剂型代码(关联代码表)";

            //dataGridView_yp.Columns[Jc_yp.YPGG].Visible = false;//规格
            skinDataGridView_yp.Columns[Jc_yp.YPGG].HeaderText = "规格";

            skinDataGridView_yp.Columns[Jc_yp.YPDCYL].Visible = false;//药品单次用量
            skinDataGridView_yp.Columns[Jc_yp.YPDCYL].HeaderText = "药品单次用量";

            skinDataGridView_yp.Columns[Jc_yp.YPDCYLDW_CODE].Visible = false;//药品单次用量单位(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPDCYLDW_CODE].HeaderText = "药品单次用量单位(关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YPYYTJ_CODE].Visible = false;//用量用法,cv5201.22用药途径代码(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPYYTJ_CODE].HeaderText = "用量用法,cv5201.22用药途径代码(关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.DDW_CODE].Visible = false;//大单位(药品大单位，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.DDW_CODE].HeaderText = "大单位(药品大单位，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.XDW_CODE].Visible = false;//小单位(药品小单位，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.XDW_CODE].HeaderText = "小单位(药品小单位，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFYBZ_CODE].Visible = false;//处方药标志（rx  otc）(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFYBZ_CODE].HeaderText = "处方药标志（rx  otc）(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXJY_CODE].Visible = false;//处方权限基药(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXJY_CODE].HeaderText = "处方权限基药(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXYB_CODE].Visible = false;//处方权限医保(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXYB_CODE].HeaderText = "处方权限医保(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXDM_CODE].Visible = false;//处方权限毒麻(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXDM_CODE].HeaderText = "处方权限毒麻(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXJS_CODE].Visible = false;//处方权限精神(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXJS_CODE].HeaderText = "处方权限精神(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXGZ_CODE].Visible = false;//处方权限贵重(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXGZ_CODE].HeaderText = "处方权限贵重(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXJK_CODE].Visible = false;//处方权限进口(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXJK_CODE].HeaderText = "处方权限进口(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXZZ_CODE].Visible = false;//处方权限自制(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXZZ_CODE].HeaderText = "处方权限自制(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXZF_CODE].Visible = false;//处方权限自费(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXZF_CODE].HeaderText = "处方权限自费(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.CFQXTS_CODE].Visible = false;//处方权限特殊(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.CFQXTS_CODE].HeaderText = "处方权限特殊(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.PS_CODE].Visible = false;//皮试(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.PS_CODE].HeaderText = "皮试(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YPLX_CODE].Visible = false;//cv5301.06药物类型代码(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPLX_CODE].HeaderText = "cv5301.06药物类型代码(关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YPMSSYZ].Visible = false;//药品描述适应症
            skinDataGridView_yp.Columns[Jc_yp.YPMSSYZ].HeaderText = "药品描述适应症";

            skinDataGridView_yp.Columns[Jc_yp.YPMSJJZ].Visible = false;//药品描述禁忌症（疾病）
            skinDataGridView_yp.Columns[Jc_yp.YPMSJJZ].HeaderText = "药品描述禁忌症（疾病）";

            skinDataGridView_yp.Columns[Jc_yp.YPMSYFHBRQJY_CODE].Visible = false;//药品描述孕妇或哺乳期禁用(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPMSYFHBRQJY_CODE].HeaderText = "药品描述孕妇或哺乳期禁用(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YPMSBLFY].Visible = false;//药品描述不良反应
            skinDataGridView_yp.Columns[Jc_yp.YPMSBLFY].HeaderText = "药品描述不良反应";

            skinDataGridView_yp.Columns[Jc_yp.YPFL_CODE].Visible = false;//药品分类(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YPFL_CODE].HeaderText = "药品分类(关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YJJB_CODE].Visible = false;//药价级别(关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.YJJB_CODE].HeaderText = "药价级别(关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.TXM].Visible = false;//条形码
            skinDataGridView_yp.Columns[Jc_yp.TXM].HeaderText = "条形码";

            skinDataGridView_yp.Columns[Jc_yp.EWM].Visible = false;//二维码
            skinDataGridView_yp.Columns[Jc_yp.EWM].HeaderText = "二维码";

            skinDataGridView_yp.Columns[Jc_yp.PYM].Visible = false;//拼音码
            skinDataGridView_yp.Columns[Jc_yp.PYM].HeaderText = "拼音码";

            skinDataGridView_yp.Columns[Jc_yp.HSXS].Visible = false;//换算系数
            skinDataGridView_yp.Columns[Jc_yp.HSXS].HeaderText = "换算系数";

            skinDataGridView_yp.Columns[Jc_yp.SFCLY_CODE].Visible = false;//是否拆零用(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.SFCLY_CODE].HeaderText = "是否拆零用(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.BZPFJ].Visible = false;//包装批发价
            skinDataGridView_yp.Columns[Jc_yp.BZPFJ].HeaderText = "包装批发价";

            skinDataGridView_yp.Columns[Jc_yp.BZLSJ].Visible = false;//包装零售价
            skinDataGridView_yp.Columns[Jc_yp.BZLSJ].HeaderText = "包装零售价";

            skinDataGridView_yp.Columns[Jc_yp.BZMZJ].Visible = false;//包装门诊价
            skinDataGridView_yp.Columns[Jc_yp.BZMZJ].HeaderText = "包装门诊价";

            skinDataGridView_yp.Columns[Jc_yp.BZZYJ].Visible = false;//包装住院价
            skinDataGridView_yp.Columns[Jc_yp.BZZYJ].HeaderText = "包装住院价";

            skinDataGridView_yp.Columns[Jc_yp.HSBL].Visible = false;//换算比例
            skinDataGridView_yp.Columns[Jc_yp.HSBL].HeaderText = "换算比例";

            skinDataGridView_yp.Columns[Jc_yp.SFCLM_CODE].Visible = false;//是否拆零卖(是否，关联代码表)
            skinDataGridView_yp.Columns[Jc_yp.SFCLM_CODE].HeaderText = "是否拆零卖(是否，关联代码表)";

            skinDataGridView_yp.Columns[Jc_yp.YXZT_CODE].Visible = false;//有效状态（0无效，1有效, 关联代码表）
            skinDataGridView_yp.Columns[Jc_yp.YXZT_CODE].HeaderText = "有效状态（0无效，1有效, 关联代码表）";

            skinDataGridView_yp.Columns[Jc_yp.ZFBZ].Visible = false;//作废标志（0作废，1有效）
            skinDataGridView_yp.Columns[Jc_yp.ZFBZ].HeaderText = "作废标志（0作废，1有效）";

            skinDataGridView_yp.Columns[Jc_yp.DCSXYL].Visible = false;//单次上限用量
            skinDataGridView_yp.Columns[Jc_yp.DCSXYL].HeaderText = "单次上限用量";

            skinDataGridView_yp.Columns[Jc_yp.DCXXYL].Visible = false;//单次上限用量
            skinDataGridView_yp.Columns[Jc_yp.DCXXYL].HeaderText = "单次上限用量";

            skinDataGridView_yp.Columns[Jc_yp.LXYLTS].Visible = false;//连续用量天数
            skinDataGridView_yp.Columns[Jc_yp.LXYLTS].HeaderText = "连续用量天数";

            skinDataGridView_yp.Columns[Jc_yp.LXYLCS].Visible = false;//连续用量次数
            skinDataGridView_yp.Columns[Jc_yp.LXYLCS].HeaderText = "连续用量次数";

            skinDataGridView_yp.Columns[Jc_yp.SCQY].Visible = false;//生产企业
            skinDataGridView_yp.Columns[Jc_yp.SCQY].HeaderText = "生产企业";

            skinDataGridView_yp.Columns[Jc_yp.PZRQ].Visible = false;//批准日期
            skinDataGridView_yp.Columns[Jc_yp.PZRQ].HeaderText = "批准日期";
            skinDataGridView_yp.Columns[Jc_yp.PZRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_yp.Columns[Jc_yp.SFKSS_CODE].Visible = false;//是否是抗生素（1是，0否，关联代码表）
            skinDataGridView_yp.Columns[Jc_yp.SFKSS_CODE].HeaderText = "是否是抗生素（1是，0否，关联代码表）";

            skinDataGridView_yp.Columns[Jc_yp.DCYLDWBL].Visible = false;//单次用量单位比例
            skinDataGridView_yp.Columns[Jc_yp.DCYLDWBL].HeaderText = "单次用量单位比例";
            #endregion
            //*******************************UI,datagridview隐藏字段，start

            //*******************************UI,实体类字段转换，start
            #region
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ypjxCode", "ypjxCodeName", "剂型", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ypdcyldwCode", "ypdcyldwCodeName", "药品单次用量单位", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ypyytjCode", "ypyytjCodeName", "用量用法,cv5201.22用药途径代码", CommonCode.实体类名称.基础_代码字典实体类名);
             SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ddwCode", "ddwCodeName", "大单位(药品大单位，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

             SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "xdwCode", "xdwCodeName", "小单位(药品小单位，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfybzCode", "cfybzCodeName", "处方药标志（rx  otc）(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxjyCode", "cfqxjyCodeName", "处方权限基药(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxybCode", "cfqxybCodeName", "处方权限医保(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxdmCode", "cfqxdmCodeName", "处方权限毒麻(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxjsCode", "cfqxjsCodeName", "处方权限精神(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxgzCode", "cfqxgzCodeName", "处方权限贵重(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxjkCode", "cfqxjkCodeName", "处方权限进口(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxzzCode", "cfqxzzCodeName", "处方权限自制(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxzfCode", "cfqxzfCodeName", "处方权限自费(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "cfqxtsCode", "cfqxtsCodeName", "处方权限特殊(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "psCode", "psCodeName", "皮试(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "yplxCode", "yplxCodeName", "药物类型", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ypmsyfhbrqjyCode", "ypmsyfhbrqjyCodeName", "药品描述孕妇或哺乳期禁用(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "ypflCode", "ypflCodeName", "药品分类", CommonCode.实体类名称.基础_代码字典实体类名);
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "yjjbCode", "yjjbCodeName", "药价级别", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "sfclyCode", "sfclyCodeName", "是否拆零用(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "sfclmCode", "sfclmCodeName", "是否拆零卖(是否，关联代码表)", CommonCode.实体类名称.基础_代码字典实体类名);
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "yxztCode", "yxztCodeName", "有效状态（0无效，1有效, 关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_yp, "sfkssCode", "sfkssCodeName", "是否是抗生素", CommonCode.实体类名称.基础_代码字典实体类名);
            #endregion
            //*******************************UI,实体类字段转换，end

            skinDataGridView_yp.Columns["cfybzCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxjyCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxybCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxdmCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxjsCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxgzCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxjkCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxzzCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxzfCode"].Visible = false;
            skinDataGridView_yp.Columns["cfqxtsCode"].Visible = false;
            skinDataGridView_yp.Columns["psCode"].Visible = false;
            skinDataGridView_yp.Columns["ypmsyfhbrqjyCode"].Visible = false;
            skinDataGridView_yp.Columns["sfclyCode"].Visible = false;
            skinDataGridView_yp.Columns["sfclmCode"].Visible = false;
            skinDataGridView_yp.Columns["ypjxCode"].Visible = false;
            skinDataGridView_yp.Columns["yxztCode"].Visible = false;


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_yp);
        }

        private void toolStripButton_nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.NextPage;
                this.initDataGridView_yp();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_prevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.PrevPage;

                this.initDataGridView_yp();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;
                this.initDataGridView_yp();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_endPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = this.page.PageCount;
                this.initDataGridView_yp();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_importForExcel_Click(object sender, EventArgs e)
        {
            MyMessageBox.Show("未实现");
        }

        private void dataGridView_yp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Jc_yp yp = (Jc_yp)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_yp);
                YpEdit ypedit = new YpEdit(yp);
                ypedit.ShowDialog();
                this.page = null;

                this.initDataGridView_yp();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

     

    }
}

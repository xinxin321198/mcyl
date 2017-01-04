using Model.RBAC;
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
using BLL.YPKC.药品库存_单据主表;
using Model.Common;
using Model.YPKC;
using Model.JC;
using client.YPKC.药品入库;
using BLL.JC.基础_工作人员账户关系表;
using client.YPKC.Common;
using BLL.JC.基础_代码类型字典;
using BLL.JC.基础_代码字典;
using BLL.JC.代码;
using BLL.YPKC.药品入库;

namespace client.YPKC.药品入库
{
    public partial class YpRuKuMgr : Form
    {
        private Ypkc_djBLL djBll = new Ypkc_djBLLImp();
        private Ypkc_RuKuBLL rukuBll = new Ypkc_RuKuBLLImp();

        private PageInfo page = null;

        private Main main = null;//主窗体引用


        private Jc_renyuan_userBLL renyuanUserBll = new Jc_renyuan_userBLLImp();

        private Jc_codeBLL jc_codeBll = new Jc_codeBLLImp();
        private CodeBLL codeBll = new CodeBLLImp();


        public YpRuKuMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton( this.skinButton_入库);

            SkinDataGridViewHelper.initDataGridView(skinDataGridView_ypin);


        }

        private void YpkcMgr_Load(object sender, EventArgs e)
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
            this.initDataGridView();


        }

        private void initDataGridView()
        {
            Ypkc_dj djParam = new Ypkc_dj();
            djParam.Djlx_code = CommonCode.药品库存_单据类型.入库;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Ypkc_dj.DJH));
            List<object> objs = djBll.getListContactObjectByPage(djParam, this.page, null, sortList);
            List<Ypkc_dj> ypList = (List<Ypkc_dj>)objs[0];
            this.page = (PageInfo)objs[1];
            SkinDataGridViewHelper.bindingList(skinDataGridView_ypin, ypList);
            this.initPageControl();


            if (skinDataGridView_ypin.DataSource == null)
            {
                return;
            }
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_ypin.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_ypin.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_ypin.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_ypin.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）
            if (null == skinDataGridView_ypin.DataSource)
            {
                return;
            }

            skinDataGridView_ypin.Columns[Ypkc_dj.ID].Visible = false;//主键
            skinDataGridView_ypin.Columns[Ypkc_dj.ID].HeaderText = "主键";

            //skinDataGridView_ypin.Columns[Ypkc_dj.DJH].Visible = false;//单据流水号
            skinDataGridView_ypin.Columns[Ypkc_dj.DJH].HeaderText = "单据流水号";

            skinDataGridView_ypin.Columns[Ypkc_dj.DJLX_CODE].Visible = false;//单据类型（关联代码表，入库、退货）
            skinDataGridView_ypin.Columns[Ypkc_dj.DJLX_CODE].HeaderText = "单据类型（关联代码表，入库、退货）";

            skinDataGridView_ypin.Columns[Ypkc_dj.YPFL_CODE].Visible = false;//库存药品类型（关联代码表，西药、成药、中药、卫材）
            skinDataGridView_ypin.Columns[Ypkc_dj.YPFL_CODE].HeaderText = "库存药品类型（关联代码表，西药、成药、中药、卫材）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_LYGYS].Visible = false;//来源供应商外键（关联供应商表）
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_LYGYS].HeaderText = "来源供应商外键（关联供应商表）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_LYKS].Visible = false;//来源科室外键（关联科室表）
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_LYKS].HeaderText = "来源科室外键（关联科室表）";

            skinDataGridView_ypin.Columns[Ypkc_dj.LYBH].Visible = false;//来源编号（冗余）
            skinDataGridView_ypin.Columns[Ypkc_dj.LYBH].HeaderText = "来源编号（冗余）";

            skinDataGridView_ypin.Columns[Ypkc_dj.LYMC].Visible = false;//来源名称（冗余）
            skinDataGridView_ypin.Columns[Ypkc_dj.LYMC].HeaderText = "来源名称（冗余）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_MDKS].Visible = false;//目的科室外键（关联科室表，药库/药房）
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_MDKS].HeaderText = "目的科室外键（关联科室表，药库/药房）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_MDGYS].Visible = false;//目的供应商外键（关联供应商表）
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_MDGYS].HeaderText = "目的供应商外键（关联供应商表）";

            skinDataGridView_ypin.Columns[Ypkc_dj.MDBH].Visible = false;//目的编号（冗余）
            skinDataGridView_ypin.Columns[Ypkc_dj.MDBH].HeaderText = "目的编号（冗余）";

            skinDataGridView_ypin.Columns[Ypkc_dj.MDMC].Visible = false;//目的名称（冗余）
            skinDataGridView_ypin.Columns[Ypkc_dj.MDMC].HeaderText = "目的名称（冗余）";

            skinDataGridView_ypin.Columns[Ypkc_dj.ZDR].Visible = false;//制单人姓名(冗余)
            skinDataGridView_ypin.Columns[Ypkc_dj.ZDR].HeaderText = "制单人姓名(冗余)";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_RENYUAN_ZDR].Visible = false;//制单人外键
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_RENYUAN_ZDR].HeaderText = "制单人外键";

            skinDataGridView_ypin.Columns[Ypkc_dj.JZR].Visible = false;//记帐人姓名（冗余）
            skinDataGridView_ypin.Columns[Ypkc_dj.JZR].HeaderText = "记帐人姓名（冗余）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_RENYUAN_JZR].Visible = false;//记账人外键
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_RENYUAN_JZR].HeaderText = "记账人外键";

            skinDataGridView_ypin.Columns[Ypkc_dj.ZDSJ].Visible = false;//制单时间
            skinDataGridView_ypin.Columns[Ypkc_dj.ZDSJ].HeaderText = "制单时间";
            skinDataGridView_ypin.Columns[Ypkc_dj.ZDSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_ypin.Columns[Ypkc_dj.JZSJ].Visible = false;//记帐时间
            skinDataGridView_ypin.Columns[Ypkc_dj.JZSJ].HeaderText = "记帐时间";
            skinDataGridView_ypin.Columns[Ypkc_dj.JZSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_ypin.Columns[Ypkc_dj.JZZT_CODE].Visible = false;//是否记帐（关联代码表，是否）
            skinDataGridView_ypin.Columns[Ypkc_dj.JZZT_CODE].HeaderText = "是否记帐（关联代码表，是否）";

            skinDataGridView_ypin.Columns[Ypkc_dj.REMARK].Visible = false;//备注
            skinDataGridView_ypin.Columns[Ypkc_dj.REMARK].HeaderText = "备注";

            skinDataGridView_ypin.Columns[Ypkc_dj.CAIGOUFS_CODE].Visible = false;//采购方式（关联代码表）
            skinDataGridView_ypin.Columns[Ypkc_dj.CAIGOUFS_CODE].HeaderText = "采购方式（关联代码表）";

            skinDataGridView_ypin.Columns[Ypkc_dj.PEISONGFS_CODE].Visible = false;//配送方式（关联代码表）
            skinDataGridView_ypin.Columns[Ypkc_dj.PEISONGFS_CODE].HeaderText = "配送方式（关联代码表）";

            skinDataGridView_ypin.Columns[Ypkc_dj.GOUJINSJ].Visible = false;//购进时间
            skinDataGridView_ypin.Columns[Ypkc_dj.GOUJINSJ].HeaderText = "购进时间";
            skinDataGridView_ypin.Columns[Ypkc_dj.GOUJINSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_ypin.Columns[Ypkc_dj.YANSHOU_CODE].Visible = false;//验收（合格，不合格）
            skinDataGridView_ypin.Columns[Ypkc_dj.YANSHOU_CODE].HeaderText = "验收（合格，不合格）";

            skinDataGridView_ypin.Columns[Ypkc_dj.CHULIYJ].Visible = false;//处理意见
            skinDataGridView_ypin.Columns[Ypkc_dj.CHULIYJ].HeaderText = "处理意见";

            skinDataGridView_ypin.Columns[Ypkc_dj.CHULIJG].Visible = false;//处理结果
            skinDataGridView_ypin.Columns[Ypkc_dj.CHULIJG].HeaderText = "处理结果";

            skinDataGridView_ypin.Columns[Ypkc_dj.TUIHUOZT_CODE].Visible = false;//退货状态（药品采购，退货状态）
            skinDataGridView_ypin.Columns[Ypkc_dj.TUIHUOZT_CODE].HeaderText = "退货状态（药品采购，退货状态）";

            skinDataGridView_ypin.Columns[Ypkc_dj.FK_SHR].Visible = false;//审核人编号
            skinDataGridView_ypin.Columns[Ypkc_dj.FK_SHR].HeaderText = "审核人编号";

            skinDataGridView_ypin.Columns[Ypkc_dj.SHRXM].Visible = false;//审核人姓名
            skinDataGridView_ypin.Columns[Ypkc_dj.SHRXM].HeaderText = "审核人姓名";

            skinDataGridView_ypin.Columns[Ypkc_dj.SHSJ].Visible = false;//审核时间
            skinDataGridView_ypin.Columns[Ypkc_dj.SHSJ].HeaderText = "审核时间";
            skinDataGridView_ypin.Columns[Ypkc_dj.SHSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_ypin.Columns[Ypkc_dj.ZFBZ].Visible = false;//作废标志
            skinDataGridView_ypin.Columns[Ypkc_dj.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "djlxCode", "djlxCodeName", "单据类型", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "ypflCode", "ypflCodeName", "库存药品类型", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "jzztCode", "jzztCodeName", "是否记帐", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "caigoufsCode", "caigoufsCodeName", "采购方式", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "peisongfsCode", "peisongfsCodeName", "配送方式", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "yanshouCode", "yanshouCodeName", "验收", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_ypin, "tuihuoztCode", "tuihuoztCodeName", "退货状态", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            //skinDataGridView_ypin.Columns["djlxCode"].Visible = false;//单据类型（关联代码表，入库、退货）

            //skinDataGridView_ypin.Columns["YpflCode"].Visible = false;//库存药品类型（关联代码表，西药、成药、中药、卫材）

            //skinDataGridView_ypin.Columns["jzztCode"].Visible = false;//是否记帐（关联代码表，是否）

            //skinDataGridView_ypin.Columns["caigoufsCode"].Visible = false;//采购方式（关联代码表）

            //skinDataGridView_ypin.Columns["peisongfsCode"].Visible = false;//配送方式（关联代码表）

            //skinDataGridView_ypin.Columns["yanshouCode"].Visible = false;//验收（合格，不合格）

            skinDataGridView_ypin.Columns["tuihuoztCode"].Visible = false;//退货状态（药品采购，退货状态）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_ypin);

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



        private void skinButton_查询_Click(object sender, EventArgs e)
        {
            try
            {
                this.page = null;
                this.initDataGridView();
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
                this.initDataGridView();
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

                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
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
                this.initDataGridView();
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
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_入库_Click(object sender, EventArgs e)
        {
            try
            {
                YpKuCunLxSelect yplxSelect = new YpKuCunLxSelect();
                yplxSelect.ShowDialog();
                Jc_code ypLxCode =  yplxSelect.SelectedYpKuCunLx;
                if (ypLxCode == null)
                {
                    return;
                }
                Jc_code djLxCode = codeBll.getCodeByValue(CommonCode.药品库存_单据类型.入库, CommonCode.代码类型值.库存_单据类型);
                YpRuKuEdit edit = new YpRuKuEdit(this.main.LoginModel.LoginRenyuan, djLxCode, ypLxCode);
                edit.ShowDialog();
                this.page = null;
                this.initDataGridView();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_ypin_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Ypkc_dj dj = (Ypkc_dj)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_ypin);
                YpRuKuEdit edit = new YpRuKuEdit(this.main.LoginModel.LoginRenyuan, dj);
                edit.ShowDialog();
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ypkc_dj dj = (Ypkc_dj)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_ypin);
                DialogResult dr = MessageBox.Show(@"是否删除单据流水号为""" + dj.Djh + @"""的单据", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
                {
                    return;
                }


                bool flag = rukuBll.deleteRuKuDjById(dj.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.page = null;
                this.initDataGridView();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }




    }
}

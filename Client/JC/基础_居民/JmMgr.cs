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
using Model.JC;
using BLL.JC.基础_居民;
using client.Common;
using Model.RBAC;

namespace client.JC.基础_居民
{
    public partial class JmMgr : Form
    {

        private PageInfo page = null;
        private Jc_jmBLL jc_jmBll = new Jc_jmBLLImp();
        private Main main = null;//主窗体引用



        public JmMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_add);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_jm);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            JmEdit jmedit = new JmEdit();
            jmedit.ShowDialog();
            this.page = null;
            this.initDataGridView();
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




        private void initUI()
        {
            this.initDataGridView();
        }
        
        private void initDataGridView()
        {
            Jc_jm jmParam = new Jc_jm();
            List<object> objs = jc_jmBll.getListContactObjectByPage(jmParam, this.page,null,null);
            List<Jc_jm> jmList = (List<Jc_jm>)objs[0];
            this.page = (PageInfo)objs[1];
            SkinDataGridViewHelper.bindingList(skinDataGridView_jm, jmList);

            this.initPageControl();

            if (skinDataGridView_jm.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_jm.Columns[Jc_jm.ID].Visible = false;//主键
            skinDataGridView_jm.Columns[Jc_jm.ID].HeaderText = "主键";

            skinDataGridView_jm.Columns[Jc_jm.SFZH].Visible = false;//身份证号
            skinDataGridView_jm.Columns[Jc_jm.SFZH].HeaderText = "身份证号";

            //skinDataGridView_jm.Columns[Jc_jm.XM].Visible = false;//姓名
            skinDataGridView_jm.Columns[Jc_jm.XM].HeaderText = "姓名";

            skinDataGridView_jm.Columns[Jc_jm.XB_CODE].Visible = false;//性别（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.XB_CODE].HeaderText = "性别（关联代码表）";

            skinDataGridView_jm.Columns[Jc_jm.CSRQ].Visible = false;//出生日期
            skinDataGridView_jm.Columns[Jc_jm.CSRQ].HeaderText = "出生日期";
            skinDataGridView_jm.Columns[Jc_jm.CSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_jm.Columns[Jc_jm.MZ_CODE].Visible = false;//民族（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.MZ_CODE].HeaderText = "民族（关联代码表）";

            skinDataGridView_jm.Columns[Jc_jm.XX_CODE].Visible = false;//血型（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.XX_CODE].HeaderText = "血型（关联代码表）";

            skinDataGridView_jm.Columns[Jc_jm.RH_CODE].Visible = false;//rh代码（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.RH_CODE].HeaderText = "rh代码（关联代码表）";

            skinDataGridView_jm.Columns[Jc_jm.CSDZ].Visible = false;//出生地址
            skinDataGridView_jm.Columns[Jc_jm.CSDZ].HeaderText = "出生地址";

            skinDataGridView_jm.Columns[Jc_jm.HJDZ].Visible = false;//户籍地址
            skinDataGridView_jm.Columns[Jc_jm.HJDZ].HeaderText = "户籍地址";

            skinDataGridView_jm.Columns[Jc_jm.XZZ_XZQH].Visible = false;//现住址所属行政区划（行政区区划代码）
            skinDataGridView_jm.Columns[Jc_jm.XZZ_XZQH].HeaderText = "现住址所属行政区划（行政区区划代码）";

            skinDataGridView_jm.Columns[Jc_jm.XZZ_XIANG_XI_DI_ZHI].Visible = false;//现住址，详细地址（乡/镇，村，组，门牌号）
            skinDataGridView_jm.Columns[Jc_jm.XZZ_XIANG_XI_DI_ZHI].HeaderText = "现住址，详细地址（乡/镇，村，组，门牌号）";

            skinDataGridView_jm.Columns[Jc_jm.GZDW_XX].Visible = false;//工作单位或学校
            skinDataGridView_jm.Columns[Jc_jm.GZDW_XX].HeaderText = "工作单位或学校";
            skinDataGridView_jm.Columns[Jc_jm.ZY_CODE].Visible = false;//职业代码（暂做保留）
            skinDataGridView_jm.Columns[Jc_jm.ZY_CODE].HeaderText = "职业代码（暂做保留）";
            skinDataGridView_jm.Columns[Jc_jm.ZY].Visible = false;//职业
            skinDataGridView_jm.Columns[Jc_jm.ZY].HeaderText = "职业";
            skinDataGridView_jm.Columns[Jc_jm.WH_CODE].Visible = false;//文化代码（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.WH_CODE].HeaderText = "文化代码（关联代码表）";
            skinDataGridView_jm.Columns[Jc_jm.HYZK_CODE].Visible = false;//婚姻状况（关联代码表）
            skinDataGridView_jm.Columns[Jc_jm.HYZK_CODE].HeaderText = "婚姻状况（关联代码表）";
            skinDataGridView_jm.Columns[Jc_jm.LXDH].Visible = false;//联系电话
            skinDataGridView_jm.Columns[Jc_jm.LXDH].HeaderText = "联系电话";
            skinDataGridView_jm.Columns[Jc_jm.JHR_XM].Visible = false;//监护人姓名
            skinDataGridView_jm.Columns[Jc_jm.JHR_XM].HeaderText = "监护人姓名";
            skinDataGridView_jm.Columns[Jc_jm.JHR_DH].Visible = false;//监护人电话
            skinDataGridView_jm.Columns[Jc_jm.JHR_DH].HeaderText = "监护人电话";
            skinDataGridView_jm.Columns[Jc_jm.NHBM].Visible = false;//农合编码
            skinDataGridView_jm.Columns[Jc_jm.NHBM].HeaderText = "农合编码";
            skinDataGridView_jm.Columns[Jc_jm.YBKH].Visible = false;//医保卡号
            skinDataGridView_jm.Columns[Jc_jm.YBKH].HeaderText = "医保卡号";
            skinDataGridView_jm.Columns[Jc_jm.CJKH].Visible = false;//城居卡号
            skinDataGridView_jm.Columns[Jc_jm.CJKH].HeaderText = "城居卡号";
            skinDataGridView_jm.Columns[Jc_jm.ZFZH].Visible = false;//支付账号
            skinDataGridView_jm.Columns[Jc_jm.ZFZH].HeaderText = "支付账号";
            skinDataGridView_jm.Columns[Jc_jm.JKDABH].Visible = false;//健康档案编号
            skinDataGridView_jm.Columns[Jc_jm.JKDABH].HeaderText = "健康档案编号";
            skinDataGridView_jm.Columns[Jc_jm.PYM].Visible = false;//拼音码
            skinDataGridView_jm.Columns[Jc_jm.PYM].HeaderText = "拼音码";
            skinDataGridView_jm.Columns[Jc_jm.WBM].Visible = false;//五笔码
            skinDataGridView_jm.Columns[Jc_jm.WBM].HeaderText = "五笔码";
            skinDataGridView_jm.Columns[Jc_jm.ZFBZ].Visible = false;//作废标志
            skinDataGridView_jm.Columns[Jc_jm.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "xbCode", "xbCodeName", "性别（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "mzCode", "mzCodeName", "民族（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "xxCode", "xxCodeName", "血型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "rhCode", "rhCodeName", "rh代码（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "zyCode", "zyCodeName", "职业代码（暂做保留）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "whCode", "whCodeName", "文化代码（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_jm, "hyzkCode", "hyzkCodeName", "婚姻状况（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            //.Columns["xbCode"].Visible = false;//性别（关联代码表）

            //.Columns["mzCode"].Visible = false;//民族（关联代码表）

            //.Columns["xxCode"].Visible = false;//血型（关联代码表）

            //.Columns["rhCode"].Visible = false;//rh代码（关联代码表）

            //.Columns["zyCode"].Visible = false;//职业代码（暂做保留）

            //.Columns["whCode"].Visible = false;//文化代码（关联代码表）

            //.Columns["hyzkCode"].Visible = false;//婚姻状况（关联代码表）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换                      

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_jm);

        }

        private void JmMgr_Load(object sender, EventArgs e)
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

        private void dataGridView_jm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_jm jm = (Jc_jm)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_jm);
                JmEdit jmEdit = new JmEdit(jm);
                jmEdit.ShowDialog();
                this.initUI();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }


    }
}

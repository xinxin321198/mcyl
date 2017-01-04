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
using System.Reflection;
using Model.JC;
using BLL.JC.基础_工作人员;
using Model.Common;
using Model.RBAC;
using BLL.JC.工作人员;

namespace client.JC.工作人员管理
{
    public partial class RenYuanMgr : Form
    {
        Jc_renyuanBLL jc_renyuanBLL = new Jc_renyuanBLLImp();

        RenyuanBLL renyuanBll = new RenyuanBLLImp();

        PageInfo page = null;
        private Main main = null;//主窗体引用

        public RenYuanMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_add, skinButton_keshi, skinButton_zhanghu);

            SkinDataGridViewHelper.initDataGridView(skinDataGridView_renyuan);
        }


        private void RenYuanMgr_Load(object sender, EventArgs e)
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

        /// <summary>
        /// 初始化用户界面
        /// </summary>
        private void initUI()
        {
            this.initDataGridViewRenyuan();//初始化datagridview
        }

        /// <summary>
        /// 初始化datagridview
        /// </summary>
        private void initDataGridViewRenyuan()
        {
            List<object> objs = jc_renyuanBLL.getListContactObjectByPage(null, this.page,null,null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_renyuan, objs[0]);
            this.page = (PageInfo)objs[1];
            this.initPageControl();


            if (skinDataGridView_renyuan.DataSource == null)
            {
                return;
            }
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_renyuan.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_renyuan.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_renyuan.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_renyuan.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].Visible = false;//主键
            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].HeaderText = "主键";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.XM].Visible = false;//姓名
            skinDataGridView_renyuan.Columns[Jc_renyuan.XM].HeaderText = "姓名";

            skinDataGridView_renyuan.Columns[Jc_renyuan.XB_CODE].Visible = false;//性别（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.XB_CODE].HeaderText = "性别（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.MZ_CODE].Visible = false;//民族（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.MZ_CODE].HeaderText = "民族（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].Visible = false;//出生日期
            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].HeaderText = "出生日期";
            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.SFZH].Visible = false;//身份证号
            skinDataGridView_renyuan.Columns[Jc_renyuan.SFZH].HeaderText = "身份证号";

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZZMM_CODE].Visible = false;//政治面貌（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZZMM_CODE].HeaderText = "政治面貌（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.HYZK_CODE].Visible = false;//婚姻状况（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.HYZK_CODE].HeaderText = "婚姻状况（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.BYXX].Visible = false;//毕业学校
            skinDataGridView_renyuan.Columns[Jc_renyuan.BYXX].HeaderText = "毕业学校";

            skinDataGridView_renyuan.Columns[Jc_renyuan.XL_CODE].Visible = false;//学历（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.XL_CODE].HeaderText = "学历（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].Visible = false;//参加工作时间
            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].HeaderText = "参加工作时间";
            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZY].Visible = false;//专业
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZY].HeaderText = "专业";

            skinDataGridView_renyuan.Columns[Jc_renyuan.JG].Visible = false;//籍贯
            skinDataGridView_renyuan.Columns[Jc_renyuan.JG].HeaderText = "籍贯";

            skinDataGridView_renyuan.Columns[Jc_renyuan.DZ].Visible = false;//地址
            skinDataGridView_renyuan.Columns[Jc_renyuan.DZ].HeaderText = "地址";

            skinDataGridView_renyuan.Columns[Jc_renyuan.LXDH].Visible = false;//联系电话
            skinDataGridView_renyuan.Columns[Jc_renyuan.LXDH].HeaderText = "联系电话";

            skinDataGridView_renyuan.Columns[Jc_renyuan.QQ].Visible = false;//qq
            skinDataGridView_renyuan.Columns[Jc_renyuan.QQ].HeaderText = "qq";

            skinDataGridView_renyuan.Columns[Jc_renyuan.YX].Visible = false;//邮箱
            skinDataGridView_renyuan.Columns[Jc_renyuan.YX].HeaderText = "邮箱";

            skinDataGridView_renyuan.Columns[Jc_renyuan.BZ].Visible = false;//备注
            skinDataGridView_renyuan.Columns[Jc_renyuan.BZ].HeaderText = "备注";

            skinDataGridView_renyuan.Columns[Jc_renyuan.PYM].Visible = false;//拼音码
            skinDataGridView_renyuan.Columns[Jc_renyuan.PYM].HeaderText = "拼音码";

            skinDataGridView_renyuan.Columns[Jc_renyuan.WBM].Visible = false;//五笔码
            skinDataGridView_renyuan.Columns[Jc_renyuan.WBM].HeaderText = "五笔码";

            skinDataGridView_renyuan.Columns[Jc_renyuan.RYLX_CODE].Visible = false;//人员类型（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.RYLX_CODE].HeaderText = "人员类型（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZFBZ].Visible = false;//作废标志（0是禁用，1是启用）
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZFBZ].HeaderText = "作废标志（0是禁用，1是启用）";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "xbCode", "xbCodeName", "性别（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "mzCode", "mzCodeName", "民族（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "zzmmCode", "zzmmCodeName", "政治面貌（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "hyzkCode", "hyzkCodeName", "婚姻状况（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "xlCode", "xlCodeName", "学历（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "rylxCode", "rylxCodeName", "人员类型（关联基础字典表）", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            //skinDataGridView_renyuan.Columns["xbCode"].Visible = false;//性别（关联基础字典表）

            //skinDataGridView_renyuan.Columns["mzCode"].Visible = false;//民族（关联基础字典表）

            //skinDataGridView_renyuan.Columns["zzmmCode"].Visible = false;//政治面貌（关联基础字典表）

            //skinDataGridView_renyuan.Columns["hyzkCode"].Visible = false;//婚姻状况（关联基础字典表）

            //skinDataGridView_renyuan.Columns["xlCode"].Visible = false;//学历（关联基础字典表）

            //skinDataGridView_renyuan.Columns["rylxCode"].Visible = false;//人员类型（关联基础字典表）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_renyuan);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MyMessageBox.Show("工作人员不允许删除，请设为禁用");
            try
            {
                Jc_renyuan renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
               DialogResult dr = MessageBox.Show(@"是否删除""" + renyuan.Xm + @"""", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
                {
                    return;
                }
                bool flag = renyuanBll.deleteRenyuanContactRecordById(renyuan.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.page = null;

                this.initDataGridViewRenyuan();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_renyuan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_renyuan renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
                RenyuanEdit renyuanEdit = new RenyuanEdit(renyuan);
                renyuanEdit.ShowDialog();
                this.initDataGridViewRenyuan();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
           
        }



        private void dataGridView_renyuan_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_renyuan.ClearSelection();
        }



        private void 指定所属科室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_renyuan renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
                if (renyuan.Rylx_code!=CommonCode.代码值_工作人员类型.医生)
                {
                    throw new Exception("只有医生可以指定科室");
                }
                RenYuanKeShiRelation renyuanRelation = new RenYuanKeShiRelation(renyuan);
                renyuanRelation.ShowDialog();
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
                this.initDataGridViewRenyuan();
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

                this.initDataGridViewRenyuan();
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
                this.initDataGridViewRenyuan();
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
                this.initDataGridViewRenyuan();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initPageControl()
        {
            //分页控件
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();
            toolStrip_page.Dock = DockStyle.Bottom;
        }

        private void button_指定账户_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_renyuan renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
                RenyuanUserRelation renyuanuser = new RenyuanUserRelation(renyuan);
                renyuanuser.ShowDialog();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            RenyuanSearch renyuanSearch = new RenyuanSearch();
            renyuanSearch.ShowDialog();
        }

        private void skinButton_add_Click(object sender, EventArgs e)
        {
            RenyuanEdit renyuanedit = new RenyuanEdit();
            renyuanedit.ShowDialog();
            this.page = null;
            initDataGridViewRenyuan();
        }


    }
}

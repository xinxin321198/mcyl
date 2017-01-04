using client.Common;
using Model.Common;
using Model.JC;
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
using BLL.MZ.门诊;
using Model.MZ;
using BLL.MZ.门诊_挂号;

namespace client.MZ.门诊挂号
{
    public partial class Chaxun_tuihao : Form
    {

        private PageInfo ghPage = null;

        private Main main = null;


        private Mz_ghBLL mz_ghBLL = new Mz_ghBLLImp();
        private MzBLL mzBll = new MzBLLImp();


        public Chaxun_tuihao(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_查询);
            ComboBoxHelper.initComboBoxForCode(comboBox_state, CommonCode.代码类型值.挂号_状态, CommonCode.代码值_作废标志代码值.启用);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_gh);

        }

        private void Chaxun_tuihao_Load(object sender, EventArgs e)
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

            //退号界面
            comboBox_state.SelectedIndex = 1;
            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
            this.initDataGridView_gh(ghParam);
        }

        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.ghPage.CurrentPage = 1;
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void toolStripButton_prevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ghPage.PrevPage == 0)
                {
                    return;
                }
                this.ghPage.CurrentPage = ghPage.PrevPage;
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void toolStripButton_nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ghPage.NextPage == 0)
                {
                    return;
                }
                this.ghPage.CurrentPage = ghPage.NextPage;
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void toolStripButton_endPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.ghPage.CurrentPage = ghPage.PageCount;
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        private void button_query_Click(object sender, EventArgs e)
        {
            try
            {
                this.ghPage = null;
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = Jc_code.ConvertToJc_code(comboBox_state.SelectedItem).Value;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void 退号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mz_gh yw_gh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_gh));
                DialogResult dr = MessageBox.Show(@"是否退号""" + yw_gh.Jc_jm.Xm + @"?""", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不退
                {
                    return;
                }
                bool flag = mzBll.ghTuiHaoById(yw_gh.Id);
                if (flag)
                {
                    MyMessageBox.Show("退号成功");
                }
                else
                {
                    MyMessageBox.Show("退号失败");
                }
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = CommonCode.门诊_挂号状态.已挂号;
                this.ghPage = null;
                this.initDataGridView_gh(ghParam);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initPageControl()
        {
            toolStripLabel_currentPage.Text = this.ghPage.CurrentPage.ToString();
            toolStripLabel_pageCount.Text = this.ghPage.PageCount.ToString();
            toolStripLabel_pageSize.Text = this.ghPage.PageSize.ToString();
            toolStripLabel_allCount.Text = this.ghPage.AllCount.ToString();
            toolStrip_gh.Dock = DockStyle.Bottom;
        }

        private void initDataGridView_gh(Mz_gh ghParam)
        {
            ghParam.Fk_jc_kswh = this.main.LoginModel.LoginKeShi.Id;
            List<object> objList = mz_ghBLL.getListContactObjectByPage(ghParam, this.ghPage, null, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_gh, objList[0]);


            if (skinDataGridView_gh.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_gh.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_gh.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_gh.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_gh.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_gh.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_gh.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_gh.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_gh.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_gh.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_gh.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            skinDataGridView_gh.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_gh.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_gh.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_gh.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_gh.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_gh.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_gh.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_gh.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_gh.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_gh.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_gh.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_gh.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_gh.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_gh.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_gh.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_gh.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_gh.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_gh.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_gh.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            //skinDataGridView_gh.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_gh.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_gh.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_gh.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_gh.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_gh.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_gh.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "jc_jm", "jm_xm", "病人姓名", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_gh.Columns["jc_jm"].Visible = false;
            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "jc_kswh", "jc_kswhName", "挂号科室", CommonCode.实体类名称.基础_科室实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "jc_renyuan", "jc_renyuanName", "挂号的医生", CommonCode.实体类名称.基础_工作人员实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "ghlxCode", "ghlxCodeName", "挂号类型", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gh, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_gh);
            //分页信息
            this.ghPage = (PageInfo)objList[1];
            this.initPageControl();
        }
    }
}

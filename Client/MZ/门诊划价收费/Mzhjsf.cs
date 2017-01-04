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
using Model.RBAC;
using BLL.MZ.门诊_挂号;
using Model.MZ;
using Model.Common;
using BLL.JC.代码;

namespace client.MZ.门诊划价收费
{
    public partial class Mzhjsf : Form
    {
        private Main main = null;

        private Mz_ghBLL mz_ghBll = new Mz_ghBLLImp();
        private CodeBLL codeBll = new CodeBLLImp();

        private Mz_gh huajiaGh = null;

        public Mzhjsf(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_快速挂号,this.skinButton_刷新,this.skinButton_记账,this.skinButton_开始划价,this.skinButton_添加医嘱);
            SkinDataGridViewHelper.initDataGridView(this.skinDataGridView_挂号);
            LabelHelper.initTitleLabel( label_brlx, label_lsh, label_nl, label_xb, label_xm);

        }
        private void Mzsf_Load(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView_gh();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }

        private void skinButton_快速挂号_Click(object sender, EventArgs e)
        {
            try
            {
                MzHjFast_gh hjsf_gh = new MzHjFast_gh(this.main.LoginModel);
                hjsf_gh.ShowDialog();
                this.initDataGridView_gh();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void initDataGridView_gh()
        {
            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = CommonCode.门诊_挂号状态.划价收费挂号;
            List<Mz_gh> ghList = (List<Mz_gh>)mz_ghBll.getList(ghParam, null, null)[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_挂号, ghList);

            if (skinDataGridView_挂号.DataSource == null)
            {
                return;
            }


            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_挂号.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_挂号.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_挂号.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_挂号.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_gh.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_挂号.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_挂号.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_gh.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_挂号.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_gh.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_挂号.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_挂号.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_挂号.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_挂号.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_挂号.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_挂号.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_挂号.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_挂号.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            skinDataGridView_挂号.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_挂号.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_挂号.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_挂号.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_挂号.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_挂号.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_挂号.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "jc_jm", "jm_xm", "姓名", CommonCode.实体类名称.基础_居民实体类名);
            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "jc_jm", "jm_xb", "性别", CommonCode.实体类名称.基础_居民实体类名);
            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "jc_jm", "jm_age", "年龄", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_挂号.Columns["jc_jm"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_挂号.Columns["brlxCode"].Visible = false;

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "jc_kswh", "jc_kswhName", "挂号科室外键", CommonCode.实体类名称.基础_科室实体类名);
            skinDataGridView_挂号.Columns["jc_kswh"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "jc_renyuan", "jc_renyuanName", "挂号的医生外键", CommonCode.实体类名称.基础_工作人员实体类名);
            skinDataGridView_挂号.Columns["jc_renyuan"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "ghlxCode", "ghlxCodeName", "挂号类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_挂号.Columns["ghlxCode"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_挂号, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_挂号.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_挂号);

        }

        private void skinButton_刷新_Click(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView_gh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_开始划价_Click(object sender, EventArgs e)
        {
            try
            {
                this.kaiShiHuaJia();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 开始划价
        /// </summary>
        private void kaiShiHuaJia()
        {
            this.huajiaGh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_挂号));
            label_xm.Text = huajiaGh.Brxm;
            label_xb.Text = huajiaGh.Brxb;
            label_nl.Text = DateTimePickerHelper.getAgeForDay((DateTime)huajiaGh.Brcsrq).ToString() + "岁";
            label_lsh.Text = "NO." + huajiaGh.Lsh.ToString();
            label_brlx.Text = codeBll.getCodeByValue(huajiaGh.Brlx_code, CommonCode.代码类型值.病人类型).Name;

        }

        private void skinDataGridView_挂号_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.kaiShiHuaJia();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

    }
}

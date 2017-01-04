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
using Model.MZ;
using BLL.MZ.门诊_医嘱;
using BLL.MZ.门诊_挂号;
using BLL.JC.代码;
using BLL.JC.基础_科室;
using BLL.JC.基础_工作人员;
using BLL.MZ.门诊;

namespace client.MZ.门诊药房
{
    public partial class Mzyf : Form
    {
        private Main main = null;

        private Mz_yzBLL mz_yzBll = new Mz_yzBLLImp();
        private Mz_ghBLL mz_ghBll = new Mz_ghBLLImp();
        private CodeBLL codeBll = new CodeBLLImp();
        private Jc_kswhBLL jc_kswhBll = new Jc_kswhBLLImp();
        private Jc_renyuanBLL jc_renyuanBll = new Jc_renyuanBLLImp();
        private MzBLL mzBll = new MzBLLImp();


        private Mz_gh mz_fayaoGh = null;
        public Mzyf(Main main)
        {
            this.main = main;
            InitializeComponent();
            SkinDataGridViewHelper.initDataGridView(this.skinDataGridView_fy);
            SkinButtonHelper.initButton(this.skinButton_刷新,this.skinButton_发药完成,this.skinButton_开始发药);
            LabelHelper.initTitleLabel(label_病人类型, label_流水号, label_年龄, label_性别, label_姓名, label_就诊科室, label_诊断医生);
            LabelHelper.initTitleLabel2(label_病人类型title, label_流水号title, label_年龄title, label_性别title, label_姓名title, label_就诊科室title, label_诊断医生title);

            SkinDataGridViewHelper.initDataGridView(this.skinDataGridView_医嘱);
        }

        private void Mzyf_Load(object sender, EventArgs e)
        {
            try
            {
                this.skinButton_发药完成.Enabled = false;
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
            ghParam.State_code = CommonCode.门诊_挂号状态.已收费;
            List<Mz_gh> ghList = (List<Mz_gh>)mz_ghBll.getList(ghParam, null, null)[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_fy, ghList);

            if (skinDataGridView_fy.DataSource == null)
            {
                return;
            }


            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_fy.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_fy.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_fy.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_fy.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_fy.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_fy.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_gh.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_fy.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_fy.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_gh.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_fy.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_gh.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_fy.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_fy.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_fy.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_fy.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_fy.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_fy.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_fy.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_fy.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_fy.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_fy.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_fy.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            skinDataGridView_fy.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_fy.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_fy.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_fy.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_fy.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_fy.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_fy.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            skinDataGridView_fy.Columns["jc_jm"].Visible = false;
            skinDataGridView_fy.Columns["brlxCode"].Visible = false;
            skinDataGridView_fy.Columns["jc_kswh"].Visible = false;
            skinDataGridView_fy.Columns["jc_renyuan"].Visible = false;
            skinDataGridView_fy.Columns["ghlxCode"].Visible = false;
            skinDataGridView_fy.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_fy);
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

        private void skinButton_开始发药_Click(object sender, EventArgs e)
        {
            try
            {
                this.faYaoStart();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }


        private void faYaoStart()
        {
            this.mz_fayaoGh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_fy));
            label_姓名.Text = mz_fayaoGh.Brxm;
            label_性别.Text = mz_fayaoGh.Brxb;
            label_年龄.Text = DateTimePickerHelper.getAgeForDay((DateTime)mz_fayaoGh.Brcsrq).ToString() + "岁";
            label_流水号.Text = "NO." + mz_fayaoGh.Lsh.ToString();
            label_病人类型.Text = codeBll.getCodeByValue(mz_fayaoGh.Brlx_code, CommonCode.代码类型值.病人类型).Name;
            label_就诊科室.Text = jc_kswhBll.getById(mz_fayaoGh.Fk_jc_kswh).Ksmc;
            label_诊断医生.Text = jc_renyuanBll.getById(mz_fayaoGh.Fk_jc_renyuan).Xm;

            this.initDataGridView_医嘱(this.mz_fayaoGh);

        }


        private void initDataGridView_医嘱(Mz_gh gh)
        {
            Mz_yz yzParam = new Mz_yz();
            yzParam.Fk_gh_id = gh.Id;//此挂号下的医嘱
            yzParam.Fk_keshi_id = this.main.LoginModel.LoginKeShi.Id;
            List<Mz_yz> yzList = (List<Mz_yz>)mz_yzBll.getList(yzParam, null, null)[0];

            SkinDataGridViewHelper.bindingList(skinDataGridView_医嘱, yzList);
            SkinDataGridViewHelper.addCheckBox(skinDataGridView_医嘱);
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_医嘱.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_医嘱.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_医嘱.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_医嘱.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）
            if (null == skinDataGridView_医嘱.DataSource)
            {
                skinButton_发药完成.Enabled = false;
                return;
            }

            skinDataGridView_医嘱.Columns[Mz_yz.ID].Visible = false;//主键
            skinDataGridView_医嘱.Columns[Mz_yz.ID].HeaderText = "主键";

            skinDataGridView_医嘱.Columns[Mz_yz.ZFBZ].Visible = false;//作废标志
            skinDataGridView_医嘱.Columns[Mz_yz.ZFBZ].HeaderText = "作废标志";

            //skinDataGridView_医嘱.Columns[Mz_yz.YZNR].Visible = false;//医嘱内容
            skinDataGridView_医嘱.Columns[Mz_yz.YZNR].HeaderText = "医嘱内容";
            skinDataGridView_医嘱.Columns[Mz_yz.YZNR].DisplayIndex = skinDataGridView_医嘱.ColumnCount - 1;

            skinDataGridView_医嘱.Columns[Mz_yz.YZLX_CODE].Visible = false;//医嘱类型（关联代码表）
            skinDataGridView_医嘱.Columns[Mz_yz.YZLX_CODE].HeaderText = "医嘱类型";

            skinDataGridView_医嘱.Columns[Mz_yz.FK_YP].Visible = false;//药品外键（关联药品表）
            skinDataGridView_医嘱.Columns[Mz_yz.FK_YP].HeaderText = "药品外键";

            skinDataGridView_医嘱.Columns[Mz_yz.FK_ZLXM].Visible = false;//诊疗项目外键（关联诊疗项目表）
            skinDataGridView_医嘱.Columns[Mz_yz.FK_ZLXM].HeaderText = "诊疗项目外键";

            //skinDataGridView_医嘱.Columns[Mz_yz.XMBH].Visible = false;//项目编号（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.XMBH].HeaderText = "项目编号";

            //skinDataGridView_医嘱.Columns[Mz_yz.XMMC].Visible = false;//项目名称（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.XMMC].HeaderText = "项目名称";

            //skinDataGridView_医嘱.Columns[Mz_yz.XDW].Visible = false;//小单位（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.XDW].HeaderText = "小单位";

            //skinDataGridView_医嘱.Columns[Mz_yz.GG].Visible = false;//规格（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.GG].HeaderText = "规格";

            //skinDataGridView_医嘱.Columns[Mz_yz.JX].Visible = false;//剂型（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.JX].HeaderText = "剂型";

            //skinDataGridView_医嘱.Columns[Mz_yz.SL].Visible = false;//数量
            skinDataGridView_医嘱.Columns[Mz_yz.SL].HeaderText = "数量";

            //skinDataGridView_医嘱.Columns[Mz_yz.YYTJ].Visible = false;//用药途径（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.YYTJ].HeaderText = "用药途径";

            skinDataGridView_医嘱.Columns[Mz_yz.YYPL_CODE].Visible = false;//用药频率（关联代码表）
            skinDataGridView_医嘱.Columns[Mz_yz.YYPL_CODE].HeaderText = "用药频率（关联代码表）";

            //skinDataGridView_医嘱.Columns[Mz_yz.DCYL].Visible = false;//单次用量（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.DCYL].HeaderText = "单次用量";

            //skinDataGridView_医嘱.Columns[Mz_yz.DCYLDW].Visible = false;//单次用量单位（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.DCYLDW].HeaderText = "单次用量单位";

            //skinDataGridView_医嘱.Columns[Mz_yz.TS].Visible = false;//天数
            skinDataGridView_医嘱.Columns[Mz_yz.TS].HeaderText = "天数";

            //skinDataGridView_医嘱.Columns[Mz_yz.YYPL].Visible = false;//用药频率（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.YYPL].HeaderText = "用药频率";

            skinDataGridView_医嘱.Columns[Mz_yz.FK_GH_ID].Visible = false;//挂号表外键（关联挂号表）
            skinDataGridView_医嘱.Columns[Mz_yz.FK_GH_ID].HeaderText = "挂号表外键（关联挂号表）";

            skinDataGridView_医嘱.Columns[Mz_yz.GH_LSH].Visible = false;//挂号表的流水号（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.GH_LSH].HeaderText = "挂号表的流水号（冗余）";

            //skinDataGridView_医嘱.Columns[Mz_yz.DS].Visible = false;//滴速
            skinDataGridView_医嘱.Columns[Mz_yz.DS].HeaderText = "滴速";

            //skinDataGridView_医嘱.Columns[Mz_yz.PH].Visible = false;//批号
            skinDataGridView_医嘱.Columns[Mz_yz.PH].HeaderText = "批号";

            //skinDataGridView_医嘱.Columns[Mz_yz.JJ].Visible = false;//进价
            skinDataGridView_医嘱.Columns[Mz_yz.JJ].HeaderText = "进价";

            //skinDataGridView_医嘱.Columns[Mz_yz.LSJ].Visible = false;//零售价
            skinDataGridView_医嘱.Columns[Mz_yz.LSJ].HeaderText = "零售价";

            skinDataGridView_医嘱.Columns[Mz_yz.DCYLDWBL].Visible = false;//单次用量单位比例
            skinDataGridView_医嘱.Columns[Mz_yz.DCYLDWBL].HeaderText = "单次用量单位比例";

            skinDataGridView_医嘱.Columns[Mz_yz.FK_KESHI_ID].Visible = false;//科室外键（关联科室表）
            skinDataGridView_医嘱.Columns[Mz_yz.FK_KESHI_ID].HeaderText = "科室外键（关联科室表）";

            skinDataGridView_医嘱.Columns[Mz_yz.SFWC_CODE].Visible = false;//是否完成（关联代码表，是否）
            skinDataGridView_医嘱.Columns[Mz_yz.SFWC_CODE].HeaderText = "是否完成（关联代码表，是否）";

            //skinDataGridView_医嘱.Columns[Mz_yz.SFWC].Visible = false;//是否完成（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.SFWC].HeaderText = "是否完成";

            //skinDataGridView_医嘱.Columns[Mz_yz.KESHI].Visible = false;//科室（冗余）
            skinDataGridView_医嘱.Columns[Mz_yz.KESHI].HeaderText = "科室";

            #endregion UI,datagridview隐藏基本字段，end

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_医嘱);

            this.skinButton_发药完成.Enabled = true;

            bool flag = false;//默认可以发药
            for (int i = 0; i < skinDataGridView_医嘱.Rows.Count; i++)
            {
                Mz_yz yzTemp = (Mz_yz)skinDataGridView_医嘱.Rows[i].DataBoundItem;
                if (yzTemp.Sfwc_code == CommonCode.代码值_勾叉.勾)
                {
                    skinDataGridView_医嘱.Rows[i].Cells[SkinDataGridViewHelper.checkBox列名称].Value = true;
                    skinDataGridView_医嘱.Rows[i].ReadOnly = true;
                    flag = true;
                }
                else
                {
                    skinDataGridView_医嘱.Rows[i].ReadOnly = false;
                    flag = false;
                }
            }

            if (flag)//如果全部都是选中，禁用按钮
            {
                this.skinButton_发药完成.Enabled = false;
            }
        }

        private void skinDataGridView_fy_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.faYaoStart();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_医嘱_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skinButton_发药完成_Click(object sender, EventArgs e)
        {
            try
            {
                List<Mz_yz> yzList = new List<Mz_yz>();
                if (skinDataGridView_医嘱.DataSource==null)
                {
                    return;
                }
                for (int i = 0; i < skinDataGridView_医嘱.Rows.Count; i++)
                {
                    bool check = (bool)skinDataGridView_医嘱.Rows[i].Cells[SkinDataGridViewHelper.checkBox列名称].Value;
                    if (check == true)
                    {
                        yzList.Add((Mz_yz)skinDataGridView_医嘱.Rows[i].DataBoundItem);
                    }
                }
                bool flag = mzBll.faYao(yzList);
                if (flag)
                {
                    MyMessageBox.Show("还未实现扣减库存");
                    MyMessageBox.Show("发药完成");
                }
                else
                {
                    MyMessageBox.Show("发药失败");
                }

                this.initDataGridView_医嘱(this.mz_fayaoGh);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}

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
using Model.Common;
using Model.JC;
using Model.MZ;
using BLL.MZ.门诊_挂号;
using BLL.JC.基础_代码字典;
using BLL.JC.代码;
using BLL.MZ.门诊;
using client.JC.基础_ICD10国际疾病分类管理;
using BLL.MZ.门诊_病历诊断;
using BLL.MZ.门诊_病历;
using client.YPKC.药品库存;
using Model.YPKC;
using client.JC.诊疗项目管理;
using BLL.JC.基础_药品字典;
using BLL.MZ.门诊_医嘱;
using BLL.YPKC.药品库存_库存表;
using BLL.YPKC.药品库存;
using BLL.JC.基础_工作人员;
using BLL.JC.基础_科室;

namespace client.MZ.门诊医生站
{
    public partial class MzYs : Form
    {
        /// <summary>
        /// 主窗体的引用
        /// </summary>
        private Main main = null;


        private Mz_ghBLL mz_ghBll = new Mz_ghBLLImp();
        private MzBLL mzBll = new MzBLLImp();
        private Jc_codeBLL jc_codeBll = new Jc_codeBLLImp();
        private CodeBLL codeBll = new CodeBLLImp();
        private Mz_blBLL mz_blBll = new Mz_blBLLImp();
        private Mz_blzdBLL mz_blzdBll = new Mz_blzdBLLImp();
        private Jc_ypBLL ypBll = new Jc_ypBLLImp();
        private Mz_yzBLL mz_yzBll = new Mz_yzBLLImp();
        private YpkcBLL ypkcBll = new YpkcBLLImp();
        private Jc_kswhBLL jc_kswhBll = new Jc_kswhBLLImp();
        private Jc_renyuanBLL jc_renyuanBll = new Jc_renyuanBLLImp();

        private ICD10Search icd10Search = new ICD10Search();//icd10查询窗体
        private List<Mz_blzd> blzdList =null;//保存的病历诊断
        private Mz_gh zhenduan_gh = null;//要诊断的号
        private Mz_bl oldBl = null;//此号的病历




        //药品库存查询窗体
        private YpKuCunSearchForYz kucunSearchForYz = new YpKuCunSearchForYz();
        //诊疗项目
        private ZlxmSearch zlxmSearch = new ZlxmSearch();
        //开医嘱选中的药品
        private Ypkc_kc selectedYpkc = null;
        private Jc_yp selectedKcYP = null;
        //开医嘱选中的诊疗项目
        private Jc_zlxm selectedZlxm = null;

        private Mz_yz oldYz = null;

        public MzYs(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(this.skinButton_刷新, this.skinButton_快速挂号,
                this.skinButton_save,
                this.skinButton_接诊,
                this.skinButton_开始诊断,
                this.skinButton_诊断完成,
                this.skinButton_添加医嘱);
            SkinSplitContainerHelper.initSkinSplitContainer(skinSplitContainer_总的左右);
            SkinTabControlHelper.initSkinTabControl(skinTabControl_病历医嘱);
            SkinTabControlHelper.initSkinTabControl(skinTabControl_病人列表);
            LabelHelper.initTitleLabel(label_2天内挂号病人,label_keshi, label_病人类型, label_流水号, label_年龄, label_性别, label_姓名, label_就诊科室, label_诊断医生);
            LabelHelper.initTitleLabel2( label_病人类型title, label_流水号title, label_年龄title, label_性别title, label_姓名title, label_就诊科室title, label_诊断医生title);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_未收费);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_待诊病人);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_接诊中的病人);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_blzd);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_医嘱);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_已收费);
            Jc_kswh yfKs = new Jc_kswh();
            yfKs.Yfbz_code = CommonCode.代码值_勾叉.勾;
            ComboBoxHelper.initComboBoxForKswh(skinComboBox_药房, yfKs, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForYpflCodeAndZlxmCode(this.skinComboBox_医嘱分类);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_用药频率, CommonCode.代码类型值.药品_用药频率, CommonCode.代码值_作废标志代码值.启用);

            //number
            //病历
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_体温, NumericUpDownHelper.数值控件模式.一位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_呼吸, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_脉搏, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_BP1, NumericUpDownHelper.数值控件模式.一位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_BP2, NumericUpDownHelper.数值控件模式.一位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_心率, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_空腹血糖值, NumericUpDownHelper.数值控件模式.二位小数);


            //医嘱
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_药品单次用量, NumericUpDownHelper.数值控件模式.二位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_用药天数, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_单次用量换算比例, NumericUpDownHelper.数值控件模式.一位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_医嘱数量, NumericUpDownHelper.数值控件模式.整型);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_库存量, NumericUpDownHelper.数值控件模式.整型);

        }


        private void MzYs_Load(object sender, EventArgs e)
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
            label_keshi.Text = this.main.LoginModel.LoginKeShi.Ksmc;

            this.enabledUI_bl(false);


            this.initDataGridView_待诊病人();
            this.initDataGridView_接诊中的病人();
            this.initDataGridView_未收费();
            this.initDataGridView_已收费();

            this.enabledUI_yz(false);
            //禁用医嘱的一些控件(必须禁用的)
            this.textBox_项目编号.Enabled = false;
            this.textBox_项目名称.Enabled = false;
            this.textBox_小单位.Enabled = false;
            this.textBox_规格.Enabled = false;
            this.textBox_剂型.Enabled = false;
            this.textBox_用药途径.Enabled = false;
            this.textBox_药品单次用量单位.Enabled = false;
            this.skinNumericUpDown_库存量.Enabled = false;
            this.skinNumericUpDown_医嘱数量.Enabled = false;
            this.skinNumericUpDown_单次用量换算比例.Enabled = false;
        }


        private void initDataGridView_未收费()
        {

            List < Mz_gh > ghList = mzBll.getWeiShouFeiGhListContactObject();
            SkinDataGridViewHelper.bindingList(skinDataGridView_未收费, ghList);

            if (skinDataGridView_未收费.DataSource == null)
            {
                return;
            }
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_未收费.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_未收费.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_未收费.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_未收费.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_未收费.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_未收费.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_未收费.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_未收费.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_未收费.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_未收费.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_未收费.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_未收费.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_未收费.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_未收费.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_未收费.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_未收费.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_未收费.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_未收费.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            skinDataGridView_未收费.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_未收费.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_未收费.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_未收费.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_未收费.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_未收费.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_未收费.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "jc_jm", "jm_xm", "病人姓名", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_未收费.Columns["jc_jm"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_未收费.Columns["brlxCode"].Visible = false;

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "jc_kswh", "jc_kswhName", "挂号科室外键", CommonCode.实体类名称.基础_科室实体类名);
            skinDataGridView_未收费.Columns["jc_kswh"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "jc_renyuan", "jc_renyuanName", "挂号的医生外键", CommonCode.实体类名称.基础_工作人员实体类名);
            skinDataGridView_未收费.Columns["jc_renyuan"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "ghlxCode", "ghlxCodeName", "挂号类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_未收费.Columns["ghlxCode"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_未收费, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_未收费.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_未收费);
        }

        private void initDataGridView_待诊病人()
        {
            Mz_gh gh = new Mz_gh();
            gh.State_code = CommonCode.门诊_挂号状态.已挂号;
            gh.Fk_jc_kswh = this.main.LoginModel.LoginKeShi.Id;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Mz_gh.GHRQ));
            List<object> objs = mz_ghBll.getList(gh, null, sortList);
            List<Mz_gh> ghList = (List<Mz_gh>)objs[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_待诊病人, ghList);

            if (skinDataGridView_待诊病人.DataSource == null)
            {
                return;
            }


            #region UI,datagridview隐藏基本字段，start
        //隱藏列start
        //.Columns["ID"].Visible = false;//隐藏此列
        //.Columns["ID"].HeaderText = "主键";//设置列名
        //.Columns["ID"].DisplayIndex = 0;//列的顺序
        //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        skinDataGridView_待诊病人.Columns[Mz_gh.ID].Visible = false;//主键
        skinDataGridView_待诊病人.Columns[Mz_gh.ID].HeaderText = "主键";

        //skinDataGridView_待诊病人.Columns[Mz_gh.LSH].Visible = false;//流水号
        skinDataGridView_待诊病人.Columns[Mz_gh.LSH].HeaderText = "流水号";

        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

        //skinDataGridView_gh.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

        skinDataGridView_待诊病人.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
        skinDataGridView_待诊病人.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        //skinDataGridView_gh.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

        skinDataGridView_待诊病人.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

        //skinDataGridView_gh.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

        skinDataGridView_待诊病人.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

        skinDataGridView_待诊病人.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
        skinDataGridView_待诊病人.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

        skinDataGridView_待诊病人.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
        skinDataGridView_待诊病人.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
        skinDataGridView_待诊病人.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

        skinDataGridView_待诊病人.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
        skinDataGridView_待诊病人.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

        skinDataGridView_待诊病人.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
        skinDataGridView_待诊病人.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
        skinDataGridView_待诊病人.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        skinDataGridView_待诊病人.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
        skinDataGridView_待诊病人.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

        skinDataGridView_待诊病人.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
        skinDataGridView_待诊病人.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

        #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

        //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "jc_jm", "jm_xm", "姓名", CommonCode.实体类名称.基础_居民实体类名);
        //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "jc_jm", "jm_xb", "性别", CommonCode.实体类名称.基础_居民实体类名);
        //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "jc_jm", "jm_age", "年龄", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_待诊病人.Columns["jc_jm"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);
           skinDataGridView_待诊病人.Columns["brlxCode"].Visible = false;

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "jc_kswh", "jc_kswhName", "挂号科室外键", CommonCode.实体类名称.基础_科室实体类名);
            skinDataGridView_待诊病人.Columns["jc_kswh"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "jc_renyuan", "jc_renyuanName", "挂号的医生外键", CommonCode.实体类名称.基础_工作人员实体类名);
            skinDataGridView_待诊病人.Columns["jc_renyuan"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "ghlxCode", "ghlxCodeName", "挂号类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_待诊病人.Columns["ghlxCode"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_待诊病人, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_待诊病人.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_待诊病人);

        }

        private void initDataGridView_接诊中的病人()
        {
            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = CommonCode.门诊_挂号状态.接诊中;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Mz_gh.GHRQ));
            List<object> objs = mz_ghBll.getListContactObject(ghParam, null, sortList);
            SkinDataGridViewHelper.bindingList(skinDataGridView_接诊中的病人, objs[0]);

            if (skinDataGridView_接诊中的病人.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_接诊中的病人.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_接诊中的病人.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_接诊中的病人.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_接诊中的病人.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_接诊中的病人.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_接诊中的病人.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_接诊中的病人.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_接诊中的病人.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_接诊中的病人.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_接诊中的病人.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_接诊中的病人.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_接诊中的病人.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_接诊中的病人.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_接诊中的病人.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "jc_jm", "jm_xm", "病人姓名", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_接诊中的病人.Columns["jc_jm"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_接诊中的病人.Columns["brlxCode"].Visible = false;

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "jc_kswh", "jc_kswhName", "挂号科室外键", CommonCode.实体类名称.基础_科室实体类名);
            skinDataGridView_接诊中的病人.Columns["jc_kswh"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "jc_renyuan", "jc_renyuanName", "挂号的医生外键", CommonCode.实体类名称.基础_工作人员实体类名);
            skinDataGridView_接诊中的病人.Columns["jc_renyuan"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "ghlxCode", "ghlxCodeName", "挂号类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_接诊中的病人.Columns["ghlxCode"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_接诊中的病人, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_接诊中的病人.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_接诊中的病人);
        }

        private void initDataGridView_已收费()
        {
            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = CommonCode.门诊_挂号状态.已收费;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Mz_gh.GHRQ));
            List<object> objs = mz_ghBll.getListContactObject(ghParam, null, sortList);
            SkinDataGridViewHelper.bindingList(skinDataGridView_已收费, objs[0]);

            if (skinDataGridView_已收费.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_已收费.Columns[Mz_gh.ID].Visible = false;//主键
            skinDataGridView_已收费.Columns[Mz_gh.ID].HeaderText = "主键";

            //skinDataGridView_已收费.Columns[Mz_gh.LSH].Visible = false;//流水号
            skinDataGridView_已收费.Columns[Mz_gh.LSH].HeaderText = "流水号";

            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_JM].Visible = false;//挂号病人的外键
            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_JM].HeaderText = "挂号病人的外键";

            //skinDataGridView_已收费.Columns[Mz_gh.BRXM].Visible = false;//病人姓名（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRXM].HeaderText = "病人姓名";

            skinDataGridView_已收费.Columns[Mz_gh.BRCSRQ].Visible = false;//病人出生日期（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRCSRQ].HeaderText = "病人出生日期（冗余）";
            skinDataGridView_已收费.Columns[Mz_gh.BRCSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_已收费.Columns[Mz_gh.BRXB].Visible = false;//病人性别（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRXB].HeaderText = "病人性别";

            skinDataGridView_已收费.Columns[Mz_gh.BRSFZH].Visible = false;//病人身份证号（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRSFZH].HeaderText = "病人身份证号（冗余）";

            //skinDataGridView_已收费.Columns[Mz_gh.BRLXDH].Visible = false;//病人联系电话（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRLXDH].HeaderText = "病人联系电话";

            skinDataGridView_已收费.Columns[Mz_gh.BRXZZ_XZQH].Visible = false;//现住址所属行政区划（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRXZZ_XZQH].HeaderText = "现住址所属行政区划（冗余）";

            skinDataGridView_已收费.Columns[Mz_gh.BRXZZ_DETAIL].Visible = false;//现住址，详细地址（冗余）
            skinDataGridView_已收费.Columns[Mz_gh.BRXZZ_DETAIL].HeaderText = "现住址，详细地址（冗余）";

            skinDataGridView_已收费.Columns[Mz_gh.BRLX_CODE].Visible = false;//病人类型
            skinDataGridView_已收费.Columns[Mz_gh.BRLX_CODE].HeaderText = "病人类型";

            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_KSWH].Visible = false;//挂号科室外键
            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_KSWH].HeaderText = "挂号科室外键";

            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_RENYUAN].Visible = false;//挂号的医生外键
            skinDataGridView_已收费.Columns[Mz_gh.FK_JC_RENYUAN].HeaderText = "挂号的医生外键";

            skinDataGridView_已收费.Columns[Mz_gh.GHLX_CODE].Visible = false;//挂号类型（关联代码表）
            skinDataGridView_已收费.Columns[Mz_gh.GHLX_CODE].HeaderText = "挂号类型（关联代码表）";

            skinDataGridView_已收费.Columns[Mz_gh.GHRQ].Visible = false;//挂号日期
            skinDataGridView_已收费.Columns[Mz_gh.GHRQ].HeaderText = "挂号日期";
            skinDataGridView_已收费.Columns[Mz_gh.GHRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_已收费.Columns[Mz_gh.STATE_CODE].Visible = false;//挂号状态
            skinDataGridView_已收费.Columns[Mz_gh.STATE_CODE].HeaderText = "挂号状态";

            skinDataGridView_已收费.Columns[Mz_gh.ZFBZ].Visible = false;//作废标志
            skinDataGridView_已收费.Columns[Mz_gh.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "jc_jm", "jm_xm", "病人姓名", CommonCode.实体类名称.基础_居民实体类名);
            skinDataGridView_已收费.Columns["jc_jm"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "brlxCode", "brlxCodeName", "病人类型", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_已收费.Columns["brlxCode"].Visible = false;

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "jc_kswh", "jc_kswhName", "挂号科室外键", CommonCode.实体类名称.基础_科室实体类名);
            skinDataGridView_已收费.Columns["jc_kswh"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "jc_renyuan", "jc_renyuanName", "挂号的医生外键", CommonCode.实体类名称.基础_工作人员实体类名);
            skinDataGridView_已收费.Columns["jc_renyuan"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "ghlxCode", "ghlxCodeName", "挂号类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_已收费.Columns["ghlxCode"].Visible = false;
            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_已收费, "stateCode", "stateCodeName", "挂号状态", CommonCode.实体类名称.基础_代码字典实体类名);
            skinDataGridView_已收费.Columns["stateCode"].Visible = false;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_已收费);
        }



        private void 接诊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.jiezhenStar();//接诊病人，其它医生不能再接诊

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_刷新待接诊病人_Click(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView_待诊病人();
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
                MzFast_gh fast_gh = new MzFast_gh(this.main.LoginModel);
                fast_gh.ShowDialog();
                this.initDataGridView_待诊病人();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItem_接诊完成_Click(object sender, EventArgs e)
        {
            try
            {
                this.zhenduanEnd();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 接诊病人
        /// </summary>
        private void jiezhenStar()
        {
            Mz_gh gh = (Mz_gh)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_待诊病人);
            DialogResult dr = MessageBox.Show(@"是否要接诊?", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool flag = mzBll.ghJieZhenStart(gh.Id); ;
                if (flag)
                {
                    this.initDataGridView_待诊病人();
                    this.initDataGridView_接诊中的病人();
                }
                else
                {
                    throw new Exception("接诊失败！请检查网络或联系管理员");
                }
            }
        }

        /// <summary>
        /// 开始诊断病人()得到病人病历信息
        /// </summary>
        private void zhendaunStart()
        {
            this.enabledUI_bl(true);
            this.enabledUI_yz(true);
            this.zhenduan_gh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_接诊中的病人));
            label_姓名.Text = zhenduan_gh.Brxm;
            label_性别.Text = zhenduan_gh.Brxb;
            label_年龄.Text = DateTimePickerHelper.getAgeForDay((DateTime)zhenduan_gh.Brcsrq).ToString() + "岁";
            label_流水号.Text = "NO." + zhenduan_gh.Lsh.ToString();
            label_病人类型.Text = codeBll.getCodeByValue(zhenduan_gh.Brlx_code,CommonCode.代码类型值.病人类型).Name;
            label_就诊科室.Text = jc_kswhBll.getById( zhenduan_gh.Fk_jc_kswh).Ksmc;
            label_诊断医生.Text = jc_renyuanBll.getById( zhenduan_gh.Fk_jc_renyuan).Xm
;

            this.oldBl = mzBll.getMzblByGhId(this.zhenduan_gh.Id);

            if (this.oldBl != null)
            {
                this.rtfRichTextBox_主诉.Text = this.oldBl.Zs;
                this.rtfRichTextBox_现病史.Text = this.oldBl.Xbs;
                this.rtfRichTextBox_既往史.Text = this.oldBl.Jws;
                this.rtfRichTextBox_过敏史.Text = this.oldBl.Gms;
                this.skinNumericUpDown_体温.Value = (decimal)this.oldBl.Tw;
                this.skinNumericUpDown_呼吸.Value = (decimal)this.oldBl.Hx;
                this.skinNumericUpDown_脉搏.Value = (decimal)this.oldBl.Mb;
                this.skinNumericUpDown_BP1.Value = (decimal)this.oldBl.Mb;
                this.skinNumericUpDown_心率.Value = (decimal)this.oldBl.Xl;
                this.skinNumericUpDown_空腹血糖值.Value = (decimal)this.oldBl.Kfxtz;
                this.rtfRichTextBox_查体.Text = this.oldBl.Cha_ti;
                this.rtfRichTextBox_处理意见.Text = this.oldBl.Clyj;

                Mz_blzd blzdParam = new Mz_blzd();
                blzdParam.Fk_bl_id = this.oldBl.Id;
                this.blzdList = (List<Mz_blzd>)mz_blzdBll.getList(blzdParam, null, null)[0];

                this.initDataGridViewForBlzd(this.blzdList);

            }
            else
            {
                this.rtfRichTextBox_主诉.Clear();
                this.rtfRichTextBox_现病史.Clear();
                this.rtfRichTextBox_既往史.Clear();
                this.rtfRichTextBox_过敏史.Clear();
                this.skinNumericUpDown_体温.Value = 0;
                this.skinNumericUpDown_呼吸.Value =0;
                this.skinNumericUpDown_脉搏.Value =0;
                this.skinNumericUpDown_BP1.Value =0;
                this.skinNumericUpDown_心率.Value =0;
                this.skinNumericUpDown_空腹血糖值.Value=0;
                this.rtfRichTextBox_查体.Clear();
                this.rtfRichTextBox_处理意见.Clear();
                this.oldBl = null;
                this.blzdList = null;
                this.skinDataGridView_blzd.DataSource = null;
            }

            //医嘱
            this.initDataGridView_医嘱();


        }

        /// <summary>
        /// 诊断完成
        /// </summary>
        private void zhenduanEnd()
        {
            Mz_gh gh = (Mz_gh)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_接诊中的病人);
            DialogResult dr = MessageBox.Show(@"是否已诊断完""" + gh.Jc_jm.Xm + @"""?", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                bool flag = mzBll.ghJieZhenEnd(gh.Id);
                if (flag)
                {
                    this.initDataGridView_接诊中的病人();
                    this.initDataGridView_未收费();
                }
                else
                {
                    throw new Exception("完成接诊失败！请检查网络或联系管理员");
                }
            }
            this.zhenduan_gh = null;//诊断中的病人置为空
            this.enabledUI_bl(false);
            this.enabledUI_yz(false);
        }


        private void skinDataGridView_接诊中的病人_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.zhendaunStart();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void 开始诊断ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.zhendaunStart();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 校验Mz_bl类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Mz_bl"></param>
        private void checkMz_blIsNull(Mz_bl mz_bl)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == mz_bl.Id || "" == mz_bl.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //作废标志
            if (null == mz_bl.Zfbz || "" == mz_bl.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            //主诉
            if (null == mz_bl.Zs || "" == mz_bl.Zs)
            {
                flag = true;
                sb.Append("请指定‘主诉’的值\n");
            }

            //现病史
            if (null == mz_bl.Xbs || "" == mz_bl.Xbs)
            {
                flag = true;
                sb.Append("请指定‘现病史’的值\n");
            }

            //既往史
            if (null == mz_bl.Jws || "" == mz_bl.Jws)
            {
                flag = true;
                sb.Append("请指定‘既往史’的值\n");
            }

            //过敏史
            if (null == mz_bl.Gms || "" == mz_bl.Gms)
            {
                flag = true;
                sb.Append("请指定‘过敏史’的值\n");
            }

            //体温（摄氏度）
            if (null == mz_bl.Tw || 0 == mz_bl.Tw)
            {
                flag = true;
                sb.Append("请指定‘体温（摄氏度）’的值\n");
            }

            //呼吸（次/分）
            if (null == mz_bl.Hx || 0 == mz_bl.Hx)
            {
                flag = true;
                sb.Append("请指定‘呼吸（次/分）’的值\n");
            }

            //脉搏（次/分）
            if (null == mz_bl.Mb || 0 == mz_bl.Mb)
            {
                flag = true;
                sb.Append("请指定‘脉搏（次/分）’的值\n");
            }

            //收缩血压（mmhg）
            if (null == mz_bl.Ssxy || 0 == mz_bl.Ssxy)
            {
                flag = true;
                sb.Append("请指定‘收缩血压（mmhg）’的值\n");
            }

            //舒张血压（mmhg）
            if (null == mz_bl.Szxy || 0 == mz_bl.Szxy)
            {
                flag = true;
                sb.Append("请指定‘舒张血压（mmhg）’的值\n");
            }

            //心率（次/分）
            if (null == mz_bl.Xl || 0 == mz_bl.Xl)
            {
                flag = true;
                sb.Append("请指定‘心率（次/分）’的值\n");
            }

            //空腹血糖值（mmol/l）
            if (null == mz_bl.Kfxtz || 0 == mz_bl.Kfxtz)
            {
                flag = true;
                sb.Append("请指定‘空腹血糖值（mmol/l）’的值\n");
            }

            //查体
            if (null == mz_bl.Cha_ti || "" == mz_bl.Cha_ti)
            {
                flag = true;
                sb.Append("请指定‘查体’的值\n");
            }

            //挂号表外键（关联挂号表）
            if (null == mz_bl.Fk_gh_id || "" == mz_bl.Fk_gh_id)
            {
                flag = true;
                sb.Append("请指定‘挂号表外键（关联挂号表）’的值\n");
            }

            //挂号表的流水号（冗余）
            if (null == mz_bl.Gh_lsh || 0 == mz_bl.Gh_lsh)
            {
                flag = true;
                sb.Append("请指定‘挂号表的流水号（冗余）’的值\n");
            }

            //处理意见
            if (null == mz_bl.Clyj || "" == mz_bl.Clyj)
            {
                flag = true;
                sb.Append("请指定‘处理意见’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                Mz_bl bl = new Mz_bl();
                bl.Zs = rtfRichTextBox_主诉.Text.Trim();
                bl.Xbs = rtfRichTextBox_现病史.Text.Trim();
                bl.Jws = rtfRichTextBox_既往史.Text.Trim();
                bl.Gms = rtfRichTextBox_过敏史.Text.Trim();
                bl.Tw = skinNumericUpDown_体温.Value;
                bl.Hx = skinNumericUpDown_呼吸.Value;
                bl.Mb = skinNumericUpDown_脉搏.Value;
                bl.Ssxy = skinNumericUpDown_BP1.Value;
                bl.Szxy = skinNumericUpDown_BP2.Value;
                bl.Xl = skinNumericUpDown_心率.Value;
                bl.Kfxtz = skinNumericUpDown_空腹血糖值.Value;
                bl.Cha_ti = rtfRichTextBox_查体.Text.Trim();
                bl.Clyj = rtfRichTextBox_处理意见.Text.Trim();

                bl.Fk_gh_id = this.zhenduan_gh.Id;
                bl.Gh_lsh = this.zhenduan_gh.Lsh;
                bl.Zfbz = CommonCode.代码值_作废标志代码值.启用;




                this.checkMz_blIsNull(bl);
                bool flag = false;
                if (this.oldBl == null)
                {
                    flag = mzBll.SaveMzbl(bl, blzdList);
                    //this.oldBl = mzBll.getMzblByGhId(this.zhenduan_gh.Id);
                }
                else
                {
                    bl.Id = this.oldBl.Id;
                    flag = mzBll.modifyMzbl(bl, blzdList);
                }
                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                    this.enabledUI_bl(false);
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

        private void enabledUI_bl(bool isEnabled)
        {
            this.rtfRichTextBox_主诉.Enabled = isEnabled;
            this.rtfRichTextBox_现病史.Enabled = isEnabled;
            this.rtfRichTextBox_既往史.Enabled = isEnabled;
            this.rtfRichTextBox_过敏史.Enabled = isEnabled;
            this.skinNumericUpDown_体温.Enabled = isEnabled;
            this.skinNumericUpDown_呼吸.Enabled = isEnabled;
            this.skinNumericUpDown_脉搏.Enabled = isEnabled;
            this.skinNumericUpDown_BP1.Enabled = isEnabled;
            this.skinNumericUpDown_BP2.Enabled = isEnabled;
            this.skinNumericUpDown_心率.Enabled = isEnabled;
            this.skinNumericUpDown_空腹血糖值.Enabled = isEnabled;
            this.rtfRichTextBox_查体.Enabled = isEnabled;
            this.textBox_query诊断.Enabled = isEnabled;
            this.rtfRichTextBox_处理意见.Enabled = isEnabled;

            this.skinButton_save.Enabled = isEnabled;
            this.skinContextMenuStrip_诊断.Enabled = isEnabled;
        }

        private void enabledUI_yz(bool isEnabled)
        {
            this.skinComboBox_药房.Enabled = isEnabled;
            this.skinComboBox_医嘱分类.Enabled = isEnabled;
            this.textBox_query医嘱.Enabled = isEnabled;
            this.skinComboBox_用药频率.Enabled = isEnabled;
            this.skinNumericUpDown_药品单次用量.Enabled = isEnabled;
            this.skinNumericUpDown_用药天数.Enabled = isEnabled;
            this.textBox_滴速.Enabled = isEnabled;
            this.rtfRichTextBox_医嘱内容.Enabled = isEnabled;
            this.skinButton_添加医嘱.Enabled = isEnabled;

            this.skinContextMenuStrip_医嘱.Enabled = isEnabled;
        }

        private void initDataGridViewForBlzd(List<Mz_blzd> blzdList)
        {
            SkinDataGridViewHelper.bindingList(skinDataGridView_blzd, blzdList,true);
            if (skinDataGridView_blzd.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_blzd.Columns[Mz_blzd.ID].Visible = false;//主键
            skinDataGridView_blzd.Columns[Mz_blzd.ID].HeaderText = "主键";

            skinDataGridView_blzd.Columns[Mz_blzd.ZFBZ].Visible = false;//作废标志
            skinDataGridView_blzd.Columns[Mz_blzd.ZFBZ].HeaderText = "作废标志";

            skinDataGridView_blzd.Columns[Mz_blzd.FK_GH_ID].Visible = false;//挂号表外键（关联挂号表）
            skinDataGridView_blzd.Columns[Mz_blzd.FK_GH_ID].HeaderText = "挂号表外键（关联挂号表）";

            skinDataGridView_blzd.Columns[Mz_blzd.GH_LSH].Visible = false;//挂号表的流水号（冗余）
            skinDataGridView_blzd.Columns[Mz_blzd.GH_LSH].HeaderText = "挂号表的流水号（冗余）";

            skinDataGridView_blzd.Columns[Mz_blzd.FK_ICD10_ID].Visible = false;//icd10疾病表外键（关联icd10疾病表）
            skinDataGridView_blzd.Columns[Mz_blzd.FK_ICD10_ID].HeaderText = "icd10疾病表外键（关联icd10疾病表）";

            //skinDataGridView_blzd.Columns[Mz_blzd.ICD10_CODE].Visible = false;//icd10疾病编码（冗余）
            skinDataGridView_blzd.Columns[Mz_blzd.ICD10_CODE].HeaderText = "icd10疾病编码";

            //skinDataGridView_blzd.Columns[Mz_blzd.ICD10_NAME].Visible = false;//icd10疾病中文名称
            skinDataGridView_blzd.Columns[Mz_blzd.ICD10_NAME].HeaderText = "icd10疾病中文名称";

            skinDataGridView_blzd.Columns[Mz_blzd.FK_BL_ID].Visible = false;//门诊病历外键（关联门诊病历表）
            skinDataGridView_blzd.Columns[Mz_blzd.FK_BL_ID].HeaderText = "门诊病历外键（关联门诊病历表）";

            #endregion UI,datagridview隐藏基本字段，end


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_blzd);

        }

        private void textBox_诊断_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_query诊断.Text==""||textBox_query诊断==null)
                {
                    return;
                }
                icd10Search.QueryString = this.textBox_query诊断.Text.Trim();
                icd10Search.ShowDialog();
                textBox_query诊断.Clear();
                if (icd10Search.SelectedICD10==null)
                {
                    return;
                }

                Mz_blzd blzd = new Mz_blzd();
                blzd.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                blzd.Fk_gh_id = this.zhenduan_gh.Id;
                blzd.Gh_lsh = this.zhenduan_gh.Lsh;
                blzd.Fk_icd10_id = icd10Search.SelectedICD10.Id;
                blzd.Icd10_code = icd10Search.SelectedICD10.Icd10_code;
                blzd.Icd10_name = icd10Search.SelectedICD10.Name;
                if (this.blzdList==null)
                {
                    this.blzdList = new List<Mz_blzd>();
                }
                blzdList.Add(blzd);

                this.initDataGridViewForBlzd(this.blzdList);
                

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void skinButton_开始诊断_Click(object sender, EventArgs e)
        {
            try
            {
                this.zhendaunStart();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_诊断完成_Click(object sender, EventArgs e)
        {
            try
            {
                this.zhenduanEnd();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_接诊_Click(object sender, EventArgs e)
        {
            try
            {
                this.jiezhenStar();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_诊断完的病人_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.chakanWeiShouFei();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 查看未收费的病人信息
        /// </summary>
        private void chakanWeiShouFei()
        {
            this.enabledUI_bl(false);
            this.enabledUI_yz(false);
            this.zhenduan_gh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_未收费));
            label_姓名.Text = zhenduan_gh.Brxm;
            label_性别.Text = zhenduan_gh.Brxb;
            label_年龄.Text = DateTimePickerHelper.getAgeForDay((DateTime)zhenduan_gh.Brcsrq).ToString() + "岁";
            label_流水号.Text = "NO." + zhenduan_gh.Lsh.ToString();
            label_病人类型.Text = zhenduan_gh.BrlxCode.Name;
            label_就诊科室.Text = jc_kswhBll.getById( zhenduan_gh.Fk_jc_kswh).Ksmc;
            label_诊断医生.Text = jc_renyuanBll.getById(zhenduan_gh.Fk_jc_renyuan).Xm;
            //查此挂号的病历
            Mz_bl blTemp = mzBll.getMzblByGhId(this.zhenduan_gh.Id);
            if (blTemp != null)
            {
                this.rtfRichTextBox_主诉.Text = blTemp.Zs;
                this.rtfRichTextBox_现病史.Text = blTemp.Xbs;
                this.rtfRichTextBox_既往史.Text = blTemp.Jws;
                this.rtfRichTextBox_过敏史.Text = blTemp.Gms;
                this.skinNumericUpDown_体温.Value = (decimal)blTemp.Tw;
                this.skinNumericUpDown_呼吸.Value = (decimal)blTemp.Hx;
                this.skinNumericUpDown_脉搏.Value = (decimal)blTemp.Mb;
                this.skinNumericUpDown_BP1.Value = (decimal)blTemp.Mb;
                this.skinNumericUpDown_心率.Value = (decimal)blTemp.Xl;
                this.skinNumericUpDown_空腹血糖值.Value = (decimal)blTemp.Kfxtz;
                this.rtfRichTextBox_查体.Text = blTemp.Cha_ti;
                this.rtfRichTextBox_处理意见.Text = blTemp.Clyj;

                Mz_blzd blzdParam = new Mz_blzd();
                blzdParam.Fk_bl_id = blTemp.Id;
                this.blzdList = (List<Mz_blzd>)mz_blzdBll.getList(blzdParam, null, null)[0];

                this.initDataGridViewForBlzd(this.blzdList);

            }
            else
            {
                this.rtfRichTextBox_主诉.Clear();
                this.rtfRichTextBox_现病史.Clear();
                this.rtfRichTextBox_既往史.Clear();
                this.rtfRichTextBox_过敏史.Clear();
                this.skinNumericUpDown_体温.Value = 0;
                this.skinNumericUpDown_呼吸.Value = 0;
                this.skinNumericUpDown_脉搏.Value = 0;
                this.skinNumericUpDown_BP1.Value = 0;
                this.skinNumericUpDown_心率.Value = 0;
                this.skinNumericUpDown_空腹血糖值.Value = 0;
                this.rtfRichTextBox_查体.Clear();
                this.rtfRichTextBox_处理意见.Clear();
                this.oldBl = null;
                this.blzdList = null;
                this.skinDataGridView_blzd.DataSource = null;
            }

            //查此挂号的医嘱
            initDataGridView_医嘱();

        }


        /// <summary>
        /// 根据医嘱类型，查询药品或者查询诊疗项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_query_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_query医嘱.Text.Trim() == "")
                {
                    return;
                }
                this.kucunSearchForYz.QueryString = textBox_query医嘱.Text.Trim();
                this.kucunSearchForYz.Ks = (Jc_kswh)skinComboBox_药房.SelectedItem;
                Jc_code codeTemp = Jc_code.ConvertToJc_code(skinComboBox_医嘱分类.SelectedItem);
                if (codeTemp.Jc_code_type.Value==CommonCode.代码类型值.药品_分类)
                {
                    this.kucunSearchForYz.YpflCode = codeTemp;
                    if (!this.kucunSearchForYz.Visible)//如果没有显示，就显示出来
                    {
                        this.kucunSearchForYz.ShowDialog();
                    }
                    if (this.kucunSearchForYz.SelectedYpkc_kc != null)
                    {
                        this.selectedYpkc = this.kucunSearchForYz.SelectedYpkc_kc;
                        textBox_项目编号.Text = selectedYpkc.Ypbh;
                        textBox_项目名称.Text = selectedYpkc.Ypmc;
                        textBox_小单位.Text = selectedYpkc.Xdw;//小单位
                        textBox_规格.Text = selectedYpkc.Ypgg;
                        textBox_剂型.Text = selectedYpkc.Jx;
                        this.skinNumericUpDown_库存量.Value = (decimal)selectedYpkc.Sl;
                        
                        //查药品表，得到药品相关信息
                        selectedKcYP = ypBll.getContactObjectById(selectedYpkc.Fk_yp_id);
                        textBox_用药途径.Text = selectedKcYP.YpyytjCode.Name;
                        skinNumericUpDown_单次用量换算比例.Value = (decimal)selectedKcYP.Dcyldwbl;
                        skinNumericUpDown_药品单次用量.Value = (decimal)selectedKcYP.Ypdcyl;
                        textBox_药品单次用量单位.Text = selectedKcYP.YpdcyldwCode.Name;
                    }
                }
                else if (codeTemp.Jc_code_type.Value==CommonCode.代码类型值.诊疗项目分类)
                {
                    if (!zlxmSearch.Visible)
                    {
                        this.zlxmSearch.ShowDialog();
                    }
                    if (zlxmSearch.SelectedZlxm!=null)
                    {
                        this.selectedZlxm = this.zlxmSearch.SelectedZlxm;
                        textBox_项目编号.Text = selectedZlxm.Xmbh;
                        textBox_项目名称.Text = selectedZlxm.Xmmc;
                        rtfRichTextBox_医嘱内容.Text = selectedZlxm.Xmnr;
                    }
                }
                textBox_query医嘱.Clear();
               
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void clearUI_yz()
        {
            this.selectedYpkc = null;
            this.selectedKcYP = null;
            this.selectedZlxm = null;
            textBox_项目编号.Clear();
            textBox_小单位.Clear();
            textBox_规格.Clear();
            textBox_剂型.Clear();
            textBox_项目名称.Clear();
            this.skinNumericUpDown_库存量.Value = 0;
            skinNumericUpDown_医嘱数量.Value = 0;

            textBox_用药途径.Clear();
            skinNumericUpDown_药品单次用量.Value = 0;
            textBox_药品单次用量单位.Clear();
            skinNumericUpDown_用药天数.Value = 0;

        }

        private void initDataGridView_医嘱()
        {
            if (this.zhenduan_gh==null)
            {
                return;
            }
            Mz_yz yzParam = new Mz_yz();
            yzParam.Fk_gh_id = this.zhenduan_gh.Id;
            List<Mz_yz> yzList = (List<Mz_yz>)mz_yzBll.getList(yzParam,null,null)[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_医嘱, yzList, true);

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_医嘱.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_医嘱.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_医嘱.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_医嘱.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）
            if (null == skinDataGridView_医嘱.DataSource)
            {
                return;
            }

            skinDataGridView_医嘱.Columns[Mz_yz.ID].Visible = false;//主键
            skinDataGridView_医嘱.Columns[Mz_yz.ID].HeaderText = "主键";

            skinDataGridView_医嘱.Columns[Mz_yz.ZFBZ].Visible = false;//作废标志
            skinDataGridView_医嘱.Columns[Mz_yz.ZFBZ].HeaderText = "作废标志";

            //skinDataGridView_医嘱.Columns[Mz_yz.YZNR].Visible = false;//医嘱内容
            skinDataGridView_医嘱.Columns[Mz_yz.YZNR].HeaderText = "医嘱内容";
            skinDataGridView_医嘱.Columns[Mz_yz.YZNR].DisplayIndex = skinDataGridView_医嘱.ColumnCount-1;

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
            skinDataGridView_医嘱 .Columns[Mz_yz.PH].HeaderText = "批号";

            skinDataGridView_医嘱.Columns[Mz_yz.JJ].Visible = false;//进价
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

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            //控件结束时候处理的一些事件
            SkinDataGridViewHelper.endDataGridView(skinDataGridView_医嘱);

        }



        /// <summary>
        /// 校验Mz_yz类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Mz_yz"></param>
        private void checkMz_yzIsNull(Mz_yz mz_yz)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();


            //作废标志
            if (null == mz_yz.Zfbz || "" == mz_yz.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            //医嘱内容
            //if (null == mz_yz.Yznr || "" == mz_yz.Yznr)
            //{
            //    flag = true;
            //    sb.Append("请指定‘医嘱内容’的值\n");
            //}

            //医嘱类型（关联代码表）
            if (null == mz_yz.Yzlx_code || "" == mz_yz.Yzlx_code)
            {
                flag = true;
                sb.Append("请指定‘医嘱类型（关联代码表）’的值\n");
            }

            ////药品外键（关联药品表）
            //if (null == mz_yz.Fk_yp || "" == mz_yz.Fk_yp)
            //{
            //    flag = true;
            //    sb.Append("请指定‘药品外键（关联药品表）’的值\n");
            //}

            ////诊疗项目外键（关联诊疗项目表）
            //if (null == mz_yz.Fk_zlxm || "" == mz_yz.Fk_zlxm)
            //{
            //    flag = true;
            //    sb.Append("请指定‘诊疗项目外键（关联诊疗项目表）’的值\n");
            //}

            //项目编号（冗余）
            if (null == mz_yz.Xmbh || "" == mz_yz.Xmbh)
            {
                flag = true;
                sb.Append("请指定‘项目编号（冗余）’的值\n");
            }

            //项目名称（冗余）
            if (null == mz_yz.Xmmc || "" == mz_yz.Xmmc)
            {
                flag = true;
                sb.Append("请指定‘项目名称（冗余）’的值\n");
            }

            //小单位（冗余）
            if (null == mz_yz.Xdw || "" == mz_yz.Xdw)
            {
                flag = true;
                sb.Append("请指定‘小单位（冗余）’的值\n");
            }

            //规格（冗余）
            if (null == mz_yz.Gg || "" == mz_yz.Gg)
            {
                flag = true;
                sb.Append("请指定‘规格（冗余）’的值\n");
            }

            //剂型（冗余）
            if (null == mz_yz.Jx || "" == mz_yz.Jx)
            {
                flag = true;
                sb.Append("请指定‘剂型（冗余）’的值\n");
            }

            //数量
            if (null == mz_yz.Sl || 0 == mz_yz.Sl)
            {
                flag = true;
                sb.Append("请指定‘数量’的值\n");
            }

            //用药途径（冗余）
            if (null == mz_yz.Yytj || "" == mz_yz.Yytj)
            {
                flag = true;
                sb.Append("请指定‘用药途径（冗余）’的值\n");
            }

            //用药频率（关联代码表）
            if (null == mz_yz.Yypl_code || "" == mz_yz.Yypl_code)
            {
                flag = true;
                sb.Append("请指定‘用药频率（关联代码表）’的值\n");
            }

            //单次用量（冗余）
            if (null == mz_yz.Dcyl || 0 == mz_yz.Dcyl)
            {
                flag = true;
                sb.Append("请指定‘单次用量（冗余）’的值\n");
            }

            //单次用量单位（冗余）
            if (null == mz_yz.Dcyldw || "" == mz_yz.Dcyldw)
            {
                flag = true;
                sb.Append("请指定‘单次用量单位（冗余）’的值\n");
            }

            //天数
            if (null == mz_yz.Ts || 0 == mz_yz.Ts)
            {
                flag = true;
                sb.Append("请指定‘天数’的值\n");
            }

            //用药频率（冗余）
            if (null == mz_yz.Yypl || "" == mz_yz.Yypl)
            {
                flag = true;
                sb.Append("请指定‘用药频率（冗余）’的值\n");
            }

            //挂号表外键（关联挂号表）
            if (null == mz_yz.Fk_gh_id || "" == mz_yz.Fk_gh_id)
            {
                flag = true;
                sb.Append("请指定‘挂号表外键（关联挂号表）’的值\n");
            }

            //挂号表的流水号（冗余）
            if (null == mz_yz.Gh_lsh || 0 == mz_yz.Gh_lsh)
            {
                flag = true;
                sb.Append("请指定‘挂号表的流水号（冗余）’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        /// <summary>
        /// 检查当前挂号下的医嘱单中的某种药品编号的药品，如果批号和进价都相同的话，就不允许重新添加
        /// </summary>
        /// <param name="yzSave"></param>
        private void checkYpRepeat(Mz_yz yzSave)
        {
            Mz_yz yzParam = new Mz_yz();
            yzParam.Yzlx_code = CommonCode.门诊_医嘱类型.药品;
            yzParam.Fk_gh_id = this.zhenduan_gh.Id;
            yzParam.Fk_yp = yzSave.Fk_yp;
            yzParam.Fk_keshi_id = yzSave.Fk_keshi_id;
            List<Mz_yz> yzList =(List<Mz_yz>) mz_yzBll.getList(yzParam, null, null)[0];
            for (int i = 0; i < yzList.Count; i++)
            {
                Mz_yz yzTemp = yzList[i];
                if (yzSave.Fk_yp==yzTemp.Fk_yp&& yzSave.Ph==yzTemp.Ph&&yzSave.Jj==yzTemp.Jj&&yzSave.Fk_keshi_id==yzTemp.Fk_keshi_id)
                {
                    throw new Exception("药品已存在于医嘱中，相同编号、批号、进价、科室的药不允许重复添加，请在列表上选择此药品进行数量的修改，名称为:"+yzTemp.Xmmc+",批号为:"+yzTemp.Ph+",进价为:"+yzTemp.Jj+"。");
                }
            }
        }

        private void skinButton_添加医嘱_Click(object sender, EventArgs e)
        {
            try
            {
                Mz_yz yztemp = new Mz_yz();
                yztemp.Sl = skinNumericUpDown_医嘱数量.Value;
                yztemp.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                Jc_code cha = codeBll.getCodeByValue(CommonCode.代码值_勾叉.叉,CommonCode.代码类型值.基础_勾叉);
                yztemp.Sfwc_code = cha.Value;
                yztemp.Sfwc = cha.Name;
                if (this.zhenduan_gh == null)
                {
                    throw new Exception("请从左边“接诊中病人”列表选择而一个病人进行诊断，才可以添加医嘱");
                }
                else
                {
                    yztemp.Fk_gh_id = this.zhenduan_gh.Id;
                    yztemp.Gh_lsh = this.zhenduan_gh.Lsh;
                }
                if (null!=this.selectedYpkc&&null==this.selectedZlxm)
                {
                    //如果选中的是库存
                    yztemp.Fk_yp = this.selectedYpkc.Fk_yp_id;
                    yztemp.Fk_keshi_id = Jc_kswh.ConvertToJc_kswh(this.skinComboBox_药房.SelectedItem).Id;
                    yztemp.Yzlx_code = CommonCode.门诊_医嘱类型.药品;
                    yztemp.Xmbh = textBox_项目编号.Text;
                    yztemp.Xmmc = textBox_项目名称.Text;
                    yztemp.Xdw = textBox_小单位.Text;
                    yztemp.Gg = textBox_规格.Text;
                    yztemp.Jx = textBox_剂型.Text;
                    yztemp.Yznr = rtfRichTextBox_医嘱内容.Text;
                    yztemp.Yytj = textBox_用药途径.Text;
                    yztemp.Yypl = Jc_code.ConvertToJc_code(skinComboBox_用药频率.SelectedItem).Name;
                    yztemp.Yypl_code = Jc_code.ConvertToJc_code(skinComboBox_用药频率.SelectedItem).Value;
                    yztemp.Dcyl = skinNumericUpDown_药品单次用量.Value;
                    yztemp.Dcyldw = textBox_药品单次用量单位.Text;
                    yztemp.Ts = skinNumericUpDown_用药天数.Value;
                    yztemp.Ds = textBox_滴速.Text.Trim() ;
                    yztemp.Ph = this.selectedYpkc.Ph;
                    yztemp.Jj = this.selectedYpkc.Jj;
                    yztemp.Lsj = this.selectedYpkc.Lsj;
                    yztemp.Dcyldwbl = Convert.ToDecimal(this.skinNumericUpDown_单次用量换算比例.Value);
                    yztemp.Keshi = Jc_kswh.ConvertToJc_kswh(this.skinComboBox_药房.SelectedItem).Ksmc;
                    this.checkYpRepeat(yztemp);//校验医嘱中的相同药品不能重复
                }
                else if (null != this.selectedZlxm && null == this.selectedYpkc)
                {
                    //如果选中的诊疗项目
                    yztemp.Fk_zlxm = this.selectedZlxm.Id;
                    yztemp.Yzlx_code = CommonCode.门诊_医嘱类型.诊疗项目;
                    yztemp.Xmbh = textBox_项目编号.Text;
                    yztemp.Xmmc = textBox_项目名称.Text;
                    yztemp.Yznr = rtfRichTextBox_医嘱内容.Text;
                }
                else if (null != this.oldYz)
                {
                    yztemp.Id = this.oldYz.Id;//修改医嘱
                    yztemp.Fk_keshi_id = this.oldYz.Fk_keshi_id;
                    yztemp.Fk_yp = this.oldYz.Fk_yp;
                    yztemp.Fk_zlxm=this.oldYz.Fk_zlxm;
                    yztemp.Yzlx_code = this.oldYz.Yzlx_code;
                    yztemp.Xmbh = textBox_项目编号.Text;
                    yztemp.Xmmc = textBox_项目名称.Text;
                    yztemp.Xdw = textBox_小单位.Text;
                    yztemp.Gg = textBox_规格.Text;
                    yztemp.Jx = textBox_剂型.Text;
                    yztemp.Yznr = rtfRichTextBox_医嘱内容.Text;
                    yztemp.Yytj = textBox_用药途径.Text;
                    yztemp.Yypl = Jc_code.ConvertToJc_code(skinComboBox_用药频率.SelectedItem).Name;
                    yztemp.Yypl_code = Jc_code.ConvertToJc_code(skinComboBox_用药频率.SelectedItem).Value;
                    yztemp.Dcyl = skinNumericUpDown_药品单次用量.Value;
                    yztemp.Dcyldw = textBox_药品单次用量单位.Text;
                    yztemp.Ts = skinNumericUpDown_用药天数.Value;
                    yztemp.Ds = textBox_滴速.Text.Trim();
                    yztemp.Ph = this.oldYz.Ph;
                    yztemp.Jj = this.oldYz.Jj;
                    yztemp.Lsj = this.oldYz.Lsj;
                    yztemp.Dcyldwbl = Convert.ToDecimal(this.skinNumericUpDown_单次用量换算比例.Value);
                    this.skinButton_添加医嘱.Text = "新增";
                }
                else
                {
                    throw new Exception("非药品新增、非诊疗项目新增，非医嘱修改，没有此种分支，请联系管理员");
                }
                this.checkMz_yzIsNull(yztemp);
                bool flag = mz_yzBll.save(yztemp);
                if (!flag)
                {
                    MyMessageBox.Show("添加医嘱失败");
                }
                this.clearUI_yz();
                this.initDataGridView_医嘱();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void 删除医嘱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mz_yz deleteYz = Mz_yz.ConvertToMz_yz(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_医嘱));
                bool flag = mz_yzBll.deleteById(deleteYz.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.clearUI_yz();
                this.initDataGridView_医嘱();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 得到用药频率的值
        /// </summary>
        /// <returns></returns>
        private int getYyplCount(Jc_code yypl)
        {
            int count = 0;
            if (yypl.Value == CommonCode.药品_用药频率.一天一次)
            {
                count = 1;
            }
            else if (yypl.Value == CommonCode.药品_用药频率.一天二次)
            {
                count = 2;
            }
            else if (yypl.Value == CommonCode.药品_用药频率.一天三次)
            {
                count = 3;
            }
            else if (yypl.Value == CommonCode.药品_用药频率.立即)
            {
                count = 1;
            }
            else
            {
                throw new Exception("错误:未知的用药频率");
            }
            return count;
        }

        /// <summary>
        /// 得到开药医嘱的数量
        /// </summary>
        private decimal getYzCount(Jc_code yypl, decimal dcyl, decimal dcylhsbl, decimal ts)
        {
            int count = getYyplCount(yypl);
            if (ts == 0)
            {
                return 0;
            }
            decimal xdwsl = (count * dcyl) / Convert.ToDecimal(dcylhsbl);//（用药频率X单次用量）/单次用量比例=小单位数量
            decimal ypkcsl = xdwsl * ts;//小单位数量X天数
            textBox1.Text = ypkcsl.ToString();
            textBox2.Text = ((int)ypkcsl).ToString();
            if ((int)ypkcsl < ypkcsl)
            {
                ypkcsl = (int)ypkcsl + 1;
            }
            return (int)ypkcsl;
            //3.12
        }

        /// <summary>
        /// 校验用药的数量不能大于库存量
        /// </summary>
        private void checkYzCount(decimal yzsl)
        {
            if (yzsl > this.skinNumericUpDown_库存量.Value)
            {
                skinNumericUpDown_用药天数.Value = 0;
                throw new Exception("开药的数量不能大于药品库存量");
            }
        }

        private void skinComboBox_用药频率_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Jc_code yyplCode = (Jc_code)skinComboBox_用药频率.SelectedItem;
                decimal dcyl = skinNumericUpDown_药品单次用量.Value;
                decimal dcylhsbl = Convert.ToDecimal(this.skinNumericUpDown_单次用量换算比例.Value);
                decimal ts = skinNumericUpDown_用药天数.Value;
                decimal yzsl =  getYzCount(yyplCode, dcyl, dcylhsbl, ts);
                skinNumericUpDown_医嘱数量.Value = yzsl;
                checkYzCount(yzsl);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinNumericUpDown_药品单次用量_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Jc_code yyplCode = (Jc_code)skinComboBox_用药频率.SelectedItem;
                decimal dcyl = skinNumericUpDown_药品单次用量.Value;
                decimal dcylhsbl = Convert.ToDecimal(this.skinNumericUpDown_单次用量换算比例.Value);
                decimal ts = skinNumericUpDown_用药天数.Value;
                decimal yzsl = getYzCount(yyplCode, dcyl, dcylhsbl, ts);
                skinNumericUpDown_医嘱数量.Value = yzsl;
                checkYzCount(yzsl);

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinNumericUpDown_用药天数_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Jc_code yyplCode = (Jc_code)skinComboBox_用药频率.SelectedItem;
                decimal dcyl = skinNumericUpDown_药品单次用量.Value;
                decimal dcylhsbl = Convert.ToDecimal(this.skinNumericUpDown_单次用量换算比例.Value);
                decimal ts = skinNumericUpDown_用药天数.Value;
                decimal yzsl = getYzCount(yyplCode, dcyl, dcylhsbl, ts);
                skinNumericUpDown_医嘱数量.Value = yzsl;
                checkYzCount(yzsl);

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.blzdList.RemoveAt(SkinDataGridViewHelper.getCurrentDataGridViewItemIndex(skinDataGridView_blzd));
                this.initDataGridViewForBlzd(this.blzdList);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_医嘱_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Mz_yz yz = (Mz_yz)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_医嘱);
                this.oldYz = yz;
                if (yz.Yzlx_code == CommonCode.门诊_医嘱类型.药品)
                {
                    Ypkc_kc ypkc = ypkcBll.getByYpIdForYz(yz);
                    this.skinNumericUpDown_库存量.Value = (decimal)ypkc.Sl;
                }
                this.textBox_项目编号.Text = yz.Xmbh;
                this.textBox_项目名称.Text = yz.Xmmc;
                this.textBox_小单位.Text = yz.Xdw;
                this.textBox_规格.Text = yz.Gg;
                this.textBox_剂型.Text = yz.Jx;
                this.textBox_用药途径.Text = yz.Yytj;

                this.skinNumericUpDown_单次用量换算比例.Value = (decimal)yz.Dcyldwbl;
                this.skinComboBox_用药频率.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_用药频率,yz.Yypl_code,CommonCode.实体类名称.基础_代码字典实体类名);
                this.skinNumericUpDown_药品单次用量.Value = (decimal)yz.Dcyl;
                this.textBox_药品单次用量单位.Text = yz.Dcyldw;
                this.skinNumericUpDown_用药天数.Value = (decimal)yz.Ts;
                this.skinNumericUpDown_医嘱数量.Value =(decimal) yz.Sl;
                this.textBox_滴速.Text = yz.Ds;
                this.textBox_query医嘱.Text = yz.Yznr;

                this.skinButton_添加医嘱.Text = "保存";
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_已收费_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.chakanShouFei();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 查看已收费病人信息
        /// </summary>
        private void chakanShouFei()
        {
            this.enabledUI_bl(false);
            this.enabledUI_yz(false);
            this.zhenduan_gh = Mz_gh.ConvertToMz_gh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_已收费));
            label_姓名.Text = zhenduan_gh.Brxm;
            label_性别.Text = zhenduan_gh.Brxb;
            label_年龄.Text = DateTimePickerHelper.getAgeForDay((DateTime)zhenduan_gh.Brcsrq).ToString() + "岁";
            label_流水号.Text = "NO." + zhenduan_gh.Lsh.ToString();
            label_病人类型.Text = zhenduan_gh.BrlxCode.Name;
            label_就诊科室.Text = jc_kswhBll.getById(zhenduan_gh.Fk_jc_kswh).Ksmc;
            label_诊断医生.Text = jc_renyuanBll.getById(zhenduan_gh.Fk_jc_renyuan).Xm;
            //查此挂号的病历
            Mz_bl blTemp = mzBll.getMzblByGhId(this.zhenduan_gh.Id);
            if (blTemp != null)
            {
                this.rtfRichTextBox_主诉.Text = blTemp.Zs;
                this.rtfRichTextBox_现病史.Text = blTemp.Xbs;
                this.rtfRichTextBox_既往史.Text = blTemp.Jws;
                this.rtfRichTextBox_过敏史.Text = blTemp.Gms;
                this.skinNumericUpDown_体温.Value = (decimal)blTemp.Tw;
                this.skinNumericUpDown_呼吸.Value = (decimal)blTemp.Hx;
                this.skinNumericUpDown_脉搏.Value = (decimal)blTemp.Mb;
                this.skinNumericUpDown_BP1.Value = (decimal)blTemp.Mb;
                this.skinNumericUpDown_心率.Value = (decimal)blTemp.Xl;
                this.skinNumericUpDown_空腹血糖值.Value = (decimal)blTemp.Kfxtz;
                this.rtfRichTextBox_查体.Text = blTemp.Cha_ti;
                this.rtfRichTextBox_处理意见.Text = blTemp.Clyj;

                Mz_blzd blzdParam = new Mz_blzd();
                blzdParam.Fk_bl_id = blTemp.Id;
                this.blzdList = (List<Mz_blzd>)mz_blzdBll.getList(blzdParam, null, null)[0];

                this.initDataGridViewForBlzd(this.blzdList);

            }
            else
            {
                this.rtfRichTextBox_主诉.Clear();
                this.rtfRichTextBox_现病史.Clear();
                this.rtfRichTextBox_既往史.Clear();
                this.rtfRichTextBox_过敏史.Clear();
                this.skinNumericUpDown_体温.Value = 0;
                this.skinNumericUpDown_呼吸.Value = 0;
                this.skinNumericUpDown_脉搏.Value = 0;
                this.skinNumericUpDown_BP1.Value = 0;
                this.skinNumericUpDown_心率.Value = 0;
                this.skinNumericUpDown_空腹血糖值.Value = 0;
                this.rtfRichTextBox_查体.Clear();
                this.rtfRichTextBox_处理意见.Clear();
                this.oldBl = null;
                this.blzdList = null;
                this.skinDataGridView_blzd.DataSource = null;
            }

            //查此挂号的医嘱
            initDataGridView_医嘱();

        }


    }
}

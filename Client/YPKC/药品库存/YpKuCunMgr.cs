using client.Common;
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
using BLL.YPKC.药品库存_库存表;
using Model.YPKC;
using Model.JC;
using Model.Common;

namespace client.YPKC.药品库存
{
    public partial class YpKuCunMgr : Form
    {
        private Main main = null;//主窗体引用
        private Ypkc_kcBLL kcBll = new Ypkc_kcBLLImp();

        public YpKuCunMgr()
        {
            InitializeComponent();
            throw new Exception(FormHelper.INIT_ERROR);

        }

        public YpKuCunMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(this.skinButton_查询);
        }

        private void YpKuCunMgr_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBoxHelper.initComboBoxForKswh_YfYk(skinComboBox1);
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        private void initDataGridView()
        {
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);
            Ypkc_kc kcParam = new Ypkc_kc();
            kcParam.Fk_keshi_id = Jc_kswh.ConvertToJc_kswh(skinComboBox1.SelectedItem).Id;
            List<object> objs = kcBll.getListContactObject(kcParam, null, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView1, objs[0]);


            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView1.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView1.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView1.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView1.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）
            if (null == skinDataGridView1.DataSource)
            {
                return;
            }

            skinDataGridView1.Columns[Ypkc_kc.ID].Visible = false;//主键
            skinDataGridView1.Columns[Ypkc_kc.ID].HeaderText = "主键";

            skinDataGridView1.Columns[Ypkc_kc.FK_KESHI_ID].Visible = false;//科室外键（关联科室表）
            skinDataGridView1.Columns[Ypkc_kc.FK_KESHI_ID].HeaderText = "科室外键（关联科室表）";

            skinDataGridView1.Columns[Ypkc_kc.KSBH].Visible = false;//科室编号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.KSBH].HeaderText = "科室编号（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.KSMC].Visible = false;//科室名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.KSMC].HeaderText = "科室名称（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.FK_YP_ID].Visible = false;//药品字典外键（关联药品字典表）
            skinDataGridView1.Columns[Ypkc_kc.FK_YP_ID].HeaderText = "药品字典外键（关联药品字典表）";

            //skinDataGridView1.Columns[Ypkc_kc.YPBH].Visible = false;//药品编号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPBH].HeaderText = "药品编号（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.YPMC].Visible = false;//药品名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPMC].HeaderText = "药品名称（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.YPTYMC].Visible = false;//药品通用名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPTYMC].HeaderText = "药品通用名称（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.YPGG].Visible = false;//药品规格（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPGG].HeaderText = "药品规格（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.JX].Visible = false;//剂型（冗余）
            skinDataGridView1.Columns[Ypkc_kc.JX].HeaderText = "剂型（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.PYM].Visible = false;//拼音码（冗余）
            skinDataGridView1.Columns[Ypkc_kc.PYM].HeaderText = "拼音码（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.DDW].Visible = false;//大单位（冗余）
            skinDataGridView1.Columns[Ypkc_kc.DDW].HeaderText = "大单位（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.XDW].Visible = false;//小单位（冗余）
            skinDataGridView1.Columns[Ypkc_kc.XDW].HeaderText = "小单位（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.DWLX_CODE].Visible = false;//药品单位类型（关联代码表，单位类型）
            skinDataGridView1.Columns[Ypkc_kc.DWLX_CODE].HeaderText = "药品单位类型（关联代码表，单位类型）";

            skinDataGridView1.Columns[Ypkc_kc.HSBL].Visible = false;//换算比例（冗余）
            skinDataGridView1.Columns[Ypkc_kc.HSBL].HeaderText = "换算比例（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.PZWH].Visible = false;//批准文号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.PZWH].HeaderText = "批准文号（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.GYZZ].Visible = false;//国药准字（冗余）
            skinDataGridView1.Columns[Ypkc_kc.GYZZ].HeaderText = "国药准字（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.CJMC].Visible = false;//生产厂家名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.CJMC].HeaderText = "生产厂家名称（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.PH].Visible = false;//批号
            skinDataGridView1.Columns[Ypkc_kc.PH].HeaderText = "批号";

            //skinDataGridView1.Columns[Ypkc_kc.YXQ].Visible = false;//有效期
            skinDataGridView1.Columns[Ypkc_kc.YXQ].HeaderText = "有效期";
            skinDataGridView1.Columns[Ypkc_kc.YXQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView1.Columns[Ypkc_kc.JJ].Visible = false;//进价
            skinDataGridView1.Columns[Ypkc_kc.JJ].HeaderText = "进价";

            //skinDataGridView1.Columns[Ypkc_kc.LSJ].Visible = false;//零售价
            skinDataGridView1.Columns[Ypkc_kc.LSJ].HeaderText = "零售价";

            //skinDataGridView1.Columns[Ypkc_kc.SL].Visible = false;//数量
            skinDataGridView1.Columns[Ypkc_kc.SL].HeaderText = "数量";

            skinDataGridView1.Columns[Ypkc_kc.YKSL].Visible = false;//预扣数量
            skinDataGridView1.Columns[Ypkc_kc.YKSL].HeaderText = "预扣数量";

            skinDataGridView1.Columns[Ypkc_kc.ZFBZ].Visible = false;//作废标志
            skinDataGridView1.Columns[Ypkc_kc.ZFBZ].HeaderText = "作废标志";
            skinDataGridView1.Columns[Ypkc_kc.YPFL_CODE].Visible = false;//药品类型（关联代码表，西药、成药、中药、卫材）
            skinDataGridView1.Columns[Ypkc_kc.YPFL_CODE].HeaderText = "药品类型（关联代码表，西药、成药、中药、卫材）";


            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换
            skinDataGridView1.Columns["dwlxCode"].Visible = false;//药品单位类型（关联代码表，单位类型）
            skinDataGridView1.Columns["ypflCode"].Visible = false;//药品类型（关联代码表，西药、成药、中药、卫材）
            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换
            SkinDataGridViewHelper.endDataGridView(skinDataGridView1);


        }

        private void skinButton_查询_Click(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}

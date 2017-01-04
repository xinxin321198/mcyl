using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.JC;
using BLL.JC.基础_发票领用管理;
using BLL.JC.基础_工作人员;
using Model.Common;
using client.Common;
using Model.RBAC;

namespace client.JC.发票管理
{
    public partial class FplyMgr : Form
    {
        private Jc_fplyBLL jc_fpBll = new Jc_fplyBLLImp();

        private Jc_renyuanBLL jc_renyanBll = new Jc_renyuanBLLImp();

        private PageInfo page_renyuan = null;

        private PageInfo page_fp = null;
        private Main main = null;//主窗体引用


        public FplyMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_add);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_renyuan);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_fp);
        }



        /// <summary>
        /// 比较两个对象里的值是否相等，不比较ID，相等返回true，不相等返回false
        /// </summary>
        /// <param Name="oldJc_fply"></param>
        /// <param Name="newJc_fply"></param>
        /// <returns>相等true，不相等false</returns>
        private bool checkJc_fplyIsEqual(Jc_fply oldJc_fply, Jc_fply newJc_fply)
        {
            bool flag = true;

            //流水号
            if (oldJc_fply.Lsh != newJc_fply.Lsh)
            {
                flag = false;
            }

            //领用人编号
            if (oldJc_fply.Lyr_id != newJc_fply.Lyr_id)
            {
                flag = false;
            }

            //领用时间
            if (oldJc_fply.Lysj != newJc_fply.Lysj)
            {
                flag = false;
            }

            //起始发票号
            if (oldJc_fply.Fph_start != newJc_fply.Fph_start)
            {
                flag = false;
            }

            //终止发票号
            if (oldJc_fply.Fph_end != newJc_fply.Fph_end)
            {
                flag = false;
            }

            //操作员编号
            if (oldJc_fply.Czy_id != newJc_fply.Czy_id)
            {
                flag = false;
            }

            return flag;
        }


        /// <summary>
        /// 校验Jc_fply类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param Name="Jc_fply"></param>
        private void checkJc_fplyIsNull(Jc_fply jc_fply)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            if (null == jc_fply.Id || "" == jc_fply.Id)
            {
                flag = true;
                sb.Append("请指定‘主键’的值\n");
            }



            //领用人编号
            if (null == jc_fply.Lyr_id || "" == jc_fply.Lyr_id)
            {
                flag = true;
                sb.Append("请指定‘领用人编号’的值\n");
            }

            //领用时间
            if (null == jc_fply.Lysj || DateTime.MinValue == jc_fply.Lysj)
            {
                flag = true;
                sb.Append("请指定‘领用时间’的值\n");
            }

            //起始发票号
            if (null == jc_fply.Fph_start || "" == jc_fply.Fph_start)
            {
                flag = true;
                sb.Append("请指定‘起始发票号’的值\n");
            }

            //终止发票号
            if (null == jc_fply.Fph_end || "" == jc_fply.Fph_end)
            {
                flag = true;
                sb.Append("请指定‘终止发票号’的值\n");
            }

            //操作员编号
            if (null == jc_fply.Czy_id || "" == jc_fply.Czy_id)
            {
                flag = true;
                sb.Append("请指定‘操作员编号’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void initUI()
        {
            this.initDataGridView_renyuan();
            this.initDataGridView_fp();
        }

        private void initDataGridView_renyuan()
        {

            Jc_renyuan renyuanParam = new Jc_renyuan();
            renyuanParam.Rylx_code = CommonCode.代码值_工作人员类型.医生;
            List<object> objs = jc_renyanBll.getList(renyuanParam, null, null);
            List<Jc_renyuan> renyuanList = (List<Jc_renyuan>)objs[0];
            this.page_renyuan = (PageInfo)objs[1];
            SkinDataGridViewHelper.bindingList(skinDataGridView_renyuan, renyuanList);


            if (skinDataGridView_renyuan.DataSource == null)
            {
                return;
            }

            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.XM].HeaderText = "姓 名";
            skinDataGridView_renyuan.Columns[Jc_renyuan.SFZH].HeaderText = "身份证号";
            skinDataGridView_renyuan.Columns[Jc_renyuan.BYXX].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.BZ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.DZ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.HYZK_CODE].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.JG].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.LXDH].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.MZ_CODE].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.QQ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.RYLX_CODE].Visible = false;

            skinDataGridView_renyuan.Columns[Jc_renyuan.XB_CODE].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.XL_CODE].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.YX].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZFBZ].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZY].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZZMM_CODE].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.PYM].Visible = false;
            skinDataGridView_renyuan.Columns[Jc_renyuan.WBM].Visible = false;
            skinDataGridView_renyuan.Columns["xbCode"].Visible = false;//性别（关联基础字典表）

            skinDataGridView_renyuan.Columns["mzCode"].Visible = false;//民族（关联基础字典表）

            skinDataGridView_renyuan.Columns["zzmmCode"].Visible = false;//政治面貌（关联基础字典表）

            skinDataGridView_renyuan.Columns["hyzkCode"].Visible = false;//婚姻状况（关联基础字典表）

            skinDataGridView_renyuan.Columns["xlCode"].Visible = false;//学历（关联基础字典表）

            skinDataGridView_renyuan.Columns["rylxCode"].Visible = false;//人员类型（关联基础字典表）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_renyuan);
        }

        private void initDataGridView_fp()
        {
            jc_fpBll.getListByPage(null, this.page_fp,null,null);
        }


        private void FplyMgr_Load(object sender, EventArgs e)
        {
            try
            {
                initUI();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            Jc_renyuan renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
            FplyEdit fplyedit = new FplyEdit(renyuan);
            fplyedit.ShowDialog();

            Jc_fply fplyParam = new Jc_fply();
            fplyParam.Lyr_id = renyuan.Id;
            List<object> objs = jc_fpBll.getList(fplyParam,null,null);
            List<Jc_fply> fpList = (List<Jc_fply>)objs[0];
            this.page_fp = (PageInfo)objs[1];
            SkinDataGridViewHelper.bindingList(skinDataGridView_renyuan,fpList);

        }

        private void dataGridView_renyuan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_renyuan renyuan = new Jc_renyuan();
                renyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
                label_name.Text = renyuan.Xm;
                this.initDataGridView_fp(renyuan.Id);

               
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
           
        }

        private void initDataGridView_fp(string renyuanId)
        {
            Jc_fply fplyParam = new Jc_fply();
            fplyParam.Lyr_id = renyuanId;
            List<object> objs = jc_fpBll.getList(fplyParam, null, null);
            List<Jc_fply> fpList = (List<Jc_fply>)objs[0];
            this.page_fp = (PageInfo)objs[1];
            SkinDataGridViewHelper.bindingList(skinDataGridView_fp, fpList);
            if (skinDataGridView_fp.DataSource == null)
            {
                return;
            }
            skinDataGridView_fp.Columns[Jc_fply.CZY_ID].Visible = false;
            skinDataGridView_fp.Columns[Jc_fply.ID].Visible = false;
            skinDataGridView_fp.Columns[Jc_fply.LSH].Visible = false;
            skinDataGridView_fp.Columns[Jc_fply.LYR_ID].Visible = false;
            skinDataGridView_fp.Columns[Jc_fply.FPLX].HeaderText = "发票类型";
            skinDataGridView_fp.Columns[Jc_fply.FPH_END].HeaderText = "终止号";
            skinDataGridView_fp.Columns[Jc_fply.FPH_START].HeaderText = "起始号";
            skinDataGridView_fp.Columns[Jc_fply.LYSJ].HeaderText = "领用时间";
            skinDataGridView_fp.Columns[Jc_fply.FPLX].DisplayIndex = 0;
            skinDataGridView_fp.Columns[Jc_fply.FPH_START].DisplayIndex = 1;
            skinDataGridView_fp.Columns[Jc_fply.FPH_END].DisplayIndex = 2;

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_fp);
        }



    }
}

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
using BLL.JC.基础_诊疗项目管理;
using Model.RBAC;
using Model.Common;

namespace client.JC.诊疗项目管理
{
    public partial class ZlxmMgr : Form
    {
        private Jc_zlxmBLL zlxmBLL = new Jc_zlxmBLLImp();
        private Main main = null;//主窗体引用
        private PageInfo page = null;




        public ZlxmMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_zlxm);
            SkinButtonHelper.initButton(skinButton新增);
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



        private void ZlxmMgr_Load(object sender, EventArgs e)
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

        private void initUI()
        {
            this.initDataGridView_zlxm();
            
            
        }


       private void initDataGridView_zlxm()
       {
           Jc_zlxm zlxmParam = new Jc_zlxm();
           List<object> objs = zlxmBLL.getListContactObjectByPage(zlxmParam, this.page, null, null);
           List<Jc_zlxm> zlxmList = (List<Jc_zlxm>)objs[0];
           this.page = (PageInfo)objs[1];
           SkinDataGridViewHelper.bindingList(skinDataGridView_zlxm, zlxmList);

           this.initPageControl();

           if (skinDataGridView_zlxm.DataSource == null)
           {
               return;
           }

           #region 隐藏或显示基本字段

           skinDataGridView_zlxm.Columns[Jc_zlxm.ID].Visible = false;//
           skinDataGridView_zlxm.Columns[Jc_zlxm.ID].HeaderText = "";

          // skinDataGridView_zlxm.Columns[Jc_zlxm.XMBH].Visible = false;//项目编码
           skinDataGridView_zlxm.Columns[Jc_zlxm.XMBH].HeaderText = "项目编码";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.XMMC].Visible = false;//项目名称
           skinDataGridView_zlxm.Columns[Jc_zlxm.XMMC].HeaderText = "项目名称";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.DW].Visible = false;//单位
           skinDataGridView_zlxm.Columns[Jc_zlxm.DW].HeaderText = "单位";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.DJ].Visible = false;//单价
           skinDataGridView_zlxm.Columns[Jc_zlxm.DJ].HeaderText = "单价";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.ZGXJ].Visible = false;//最高限价
           skinDataGridView_zlxm.Columns[Jc_zlxm.ZGXJ].HeaderText = "最高限价";

           skinDataGridView_zlxm.Columns[Jc_zlxm.FL_CODE].Visible = false;//分类(关联代码表)
           skinDataGridView_zlxm.Columns[Jc_zlxm.FL_CODE].HeaderText = "分类(关联代码表，诊疗项目分类)";

           skinDataGridView_zlxm.Columns[Jc_zlxm.FYGL_CODE].Visible = false;//费用归类(关联代码表)
           skinDataGridView_zlxm.Columns[Jc_zlxm.FYGL_CODE].HeaderText = "费用归类(关联代码表，诊疗项目费用归类)";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.PYM].Visible = false;//拼音码
           skinDataGridView_zlxm.Columns[Jc_zlxm.PYM].HeaderText = "拼音码";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.SZM].Visible = false;//数字码
           skinDataGridView_zlxm.Columns[Jc_zlxm.SZM].HeaderText = "数字码";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.XMNR].Visible = false;//项目内容
           skinDataGridView_zlxm.Columns[Jc_zlxm.XMNR].HeaderText = "项目内容";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.CWNR].Visible = false;//除外内容
           skinDataGridView_zlxm.Columns[Jc_zlxm.CWNR].HeaderText = "除外内容";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.NOTE].Visible = false;//说明
           skinDataGridView_zlxm.Columns[Jc_zlxm.NOTE].HeaderText = "说明";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.JCFF].Visible = false;//检查方法
           skinDataGridView_zlxm.Columns[Jc_zlxm.JCFF].HeaderText = "检查方法";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.BIAOZHUAN].Visible = false;//标准
           skinDataGridView_zlxm.Columns[Jc_zlxm.BIAOZHUAN].HeaderText = "标准";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.JINJIAN].Visible = false;//禁检
           skinDataGridView_zlxm.Columns[Jc_zlxm.JINJIAN].HeaderText = "禁检";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.YINJI].Visible = false;//应急
           skinDataGridView_zlxm.Columns[Jc_zlxm.YINJI].HeaderText = "应急";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].Visible = false;//公布时间
           skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].HeaderText = "公布时间";
           skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

           //skinDataGridView_zlxm.Columns[Jc_zlxm.GBJG].Visible = false;//公布机构
           skinDataGridView_zlxm.Columns[Jc_zlxm.GBJG].HeaderText = "公布机构";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.YBBM].Visible = false;//医保编码
           skinDataGridView_zlxm.Columns[Jc_zlxm.YBBM].HeaderText = "医保编码";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.NHBM].Visible = false;//农合编码
           skinDataGridView_zlxm.Columns[Jc_zlxm.NHBM].HeaderText = "农合编码";

           skinDataGridView_zlxm.Columns[Jc_zlxm.NHSFLB_CODE].Visible = false;//农合收费类别(关联代码表)
           skinDataGridView_zlxm.Columns[Jc_zlxm.NHSFLB_CODE].HeaderText = "农合收费类别（关联代码表）";

           skinDataGridView_zlxm.Columns[Jc_zlxm.ZFBZ].Visible = false;//作废
           skinDataGridView_zlxm.Columns[Jc_zlxm.ZFBZ].HeaderText = "作废";

           //skinDataGridView_zlxm.Columns[Jc_zlxm.WBM].Visible = false;//作废
           skinDataGridView_zlxm.Columns[Jc_zlxm.WBM].HeaderText = "五笔码";
           #endregion

           #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

           //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "flCode", "flCodeName", "诊疗项目分类", CommonCode.实体类名称.基础_代码字典实体类名);

           //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "fyglCode", "fyglCodeName", "费用归类", CommonCode.实体类名称.基础_代码字典实体类名);

           //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "nhsflbCode", "nhsflbCodeName", "农合收费类别", CommonCode.实体类名称.基础_代码字典实体类名);

           #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）
          
           #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

           skinDataGridView_zlxm.Columns["flCode"].Visible = false;//诊疗项目分类(关联代码表，诊疗项目分类)

           skinDataGridView_zlxm.Columns["fyglCode"].Visible = false;//费用归类(关联代码表，诊疗项目费用归类)

           skinDataGridView_zlxm.Columns["nhsflbCode"].Visible = false;//农合收费类别（关联代码表）

           #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换



           SkinDataGridViewHelper.endDataGridView(skinDataGridView_zlxm);
          
       }
       private void button新增_Click(object sender, EventArgs e)
       {
           ZlxmEdit zlxmedit =new ZlxmEdit();
           zlxmedit.ShowDialog();
           this.page = null;
           initDataGridView_zlxm();
          
           
       }

       private void dataGridView_zlxm_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           try
           {
               Jc_zlxm zlxm = (Jc_zlxm)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_zlxm);
               ZlxmEdit zlxmEdit = new ZlxmEdit(zlxm);
               zlxmEdit.ShowDialog();
               this.initDataGridView_zlxm();
           }
           catch (Exception ex)
           {
               MyMessageBox.Show(ex.Message);
           }
       }

       private void toolStripButton_startPage_Click(object sender, EventArgs e)
       {//首页按钮代码
           try
           {
               this.page.CurrentPage = 1;
               this.initDataGridView_zlxm();
           }
           catch (Exception ex)
           {

               MyMessageBox.Show(ex.Message);
           }
       }

       private void toolStripButton_prevPage_Click(object sender, EventArgs e)
       {//上一页按钮代码
           try
           {
               if (this.page.PrevPage == 0)
               {
                   return;
               }
               this.page.CurrentPage = this.page.PrevPage;

               this.initDataGridView_zlxm();
           }
           catch (Exception ex)
           {

               MyMessageBox.Show(ex.Message);
           }
       }

       private void toolStripButton_nextPage_Click(object sender, EventArgs e)
       {//下一页按钮代码
           try
           {
               if (this.page.NextPage == 0)
               {
                   return;
               }
               this.page.CurrentPage = this.page.NextPage;
               this.initDataGridView_zlxm();
           }
           catch (Exception ex)
           {

               MyMessageBox.Show(ex.Message);
           }
       }

       private void toolStripButton_endPage_Click(object sender, EventArgs e)
       {//尾页按钮代码
           try
           {
               this.page.CurrentPage = this.page.PageCount;
               this.initDataGridView_zlxm();
           }
           catch (Exception ex)
           {

               MyMessageBox.Show(ex.Message);
           }
       }

       private void 删除ToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           try
           {
               Jc_zlxm zlxm = (Jc_zlxm)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_zlxm);
               DialogResult dr = MessageBox.Show(@"是否删除项目编码为""" + zlxm.Xmbh + @"""", "提示", MessageBoxButtons.YesNo);
               if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
               {
                   return;
               }
               bool flag = zlxmBLL.deleteById(zlxm.Id);
               if (flag)
               {
                   MyMessageBox.Show("删除成功");
               }
               else
               {
                   MyMessageBox.Show("删除失败");
               }
               this.page = null;
               this.initDataGridView_zlxm();
               
           }
           catch (Exception ex)
           {

               MyMessageBox.Show(ex.Message);
           }

       }

       private void skinButton1_Click(object sender, EventArgs e)//测试模糊查询时使用
       {
           ZlxmSearch Search = new ZlxmSearch();
           Search.ShowDialog();
          // this.page = null;
           initDataGridView_zlxm();
          
       }







    }
}

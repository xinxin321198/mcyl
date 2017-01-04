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
using Model.Common;
using BLL.JC.基础_ICD10编码对应疾病类型;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10TypeRelation : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private PageInfo page = null;

        private Jc_icd10_relationBLL icd10RelationBll = new Jc_icd10_relationBLLImp();

        private Jc_icd10_type oldIcd10Type = null;

        public ICD10TypeRelation()
        {
            InitializeComponent();
        }

        public ICD10TypeRelation(Jc_icd10_type icd10Type)
        {
            this.oldIcd10Type = icd10Type;
            InitializeComponent();
            FormHelper.initForm(this);
        }


        private void ICD10TypeRelation_Load(object sender, EventArgs e)
        {
            try
            {
                this.initUI();
                this.initDataGridView();
                this.initPageControl();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void initUI()
        {
            this.label_名称.Text = this.oldIcd10Type.Name;
            this.label_编码.Text = this.oldIcd10Type.Code;
            this.label_英文名.Text = this.oldIcd10Type.En_name;
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);
        }

        private void initDataGridView()
        {
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);

            Jc_icd10_relation relationParam = new Jc_icd10_relation();
            relationParam.Fk_jc_icd10_type = this.oldIcd10Type.Id;
            List<object> objs = icd10RelationBll.getListByPage(relationParam, this.page, null,null);
            List<Jc_icd10_relation> relationList = (List<Jc_icd10_relation>)objs[0];
            this.page = (PageInfo)objs[1];

            SkinDataGridViewHelper.bindingList(skinDataGridView1, relationList);


            if (skinDataGridView1.DataSource == null)
            {
                return;
            }

             #region UI,datagridview隐藏基本字段，start
        //隱藏列start
        //.Columns["ID"].Visible = false;//隐藏此列
        //.Columns["ID"].HeaderText = "主键";//设置列名
        //.Columns["ID"].DisplayIndex = 0;//列的顺序
        //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        skinDataGridView1.Columns[Jc_icd10_relation.ID].Visible = false;//主键
        skinDataGridView1.Columns[Jc_icd10_relation.ID].HeaderText = "主键";

        skinDataGridView1.Columns[Jc_icd10_relation.FK_JC_ICD10_TYPE].Visible = false;//疾病种类外键
        skinDataGridView1.Columns[Jc_icd10_relation.FK_JC_ICD10_TYPE].HeaderText = "疾病种类外键";

        //skinDataGridView1.Columns[Jc_icd10_relation.ICD10_CODE_SCOPE].Visible = false;//所属icd-10编码范围（编码的前几位）
        skinDataGridView1 .Columns[Jc_icd10_relation.ICD10_CODE_SCOPE].HeaderText = "所属icd-10编码范围（编码的前几位）";
        skinDataGridView1.Columns[Jc_icd10_relation.ICD10_CODE_SCOPE].Width = 500;
        skinDataGridView1.Columns[Jc_icd10_relation.ZFBZ].Visible = false;//作废标志
        skinDataGridView1.Columns[Jc_icd10_relation.ZFBZ].HeaderText = "作废标志";

        #endregion UI,datagridview隐藏基本字段，end

        #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

        //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView1, "jc_icd10_type", "jc_icd10_typeName", "疾病种类外键", CommonCode.实体类名称.基础_IDC10疾病种类实体类名);

        #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

        #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

        skinDataGridView1.Columns["jc_icd10_type"].Visible = false;//疾病种类外键

        #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换


        SkinDataGridViewHelper.endDataGridView(skinDataGridView1);
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
            toolStrip_page.Dock = DockStyle.Bottom;

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

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox_icd10codeScope.Text;
                Jc_icd10_relation relationSave = new Jc_icd10_relation();
                relationSave.Icd10_code_scope = code;
                relationSave.Fk_jc_icd10_type = this.oldIcd10Type.Id;
                relationSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_zfbz.SelectedItem).Value;

                bool flag =  icd10RelationBll.save(relationSave);
                if (flag)
                {
                    MyMessageBox.Show("添加成功");
                }
                else
                {
                    MyMessageBox.Show("添加失败");
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }





    }
}

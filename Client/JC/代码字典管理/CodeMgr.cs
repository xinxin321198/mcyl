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
using BLL.JC.基础_代码字典;
using BLL.JC.基础_代码类型字典;
using BLL.JC.代码;
using Model.RBAC;

namespace client.JC.代码字典管理
{
    public partial class CodeMgr : Form
    {
        Jc_code_typeBLL jc_codeTypeBLL = new Jc_code_typeBLLImp();
        CodeBLL codeBll = new CodeBLLImp();
        Jc_codeBLL jc_codeBLL = new Jc_codeBLLImp();
        Jc_code_type codeTypeOld = null;

        private Main main = null;//主窗体引用

        public CodeMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_add, skinButton_addCode, skinButton_codeTypeSave, skinButton_importExcel);
            SkinListViewHelper.initListView(skinListView_codeType);
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);//初始化作废标志
            SkinListViewHelper.initSkinListView(skinListView_codeType);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_code);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_排序码, NumericUpDownHelper.数值控件模式.整型);
        }

        /// <summary>
        /// 界面载入
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void CodeMgr_Load(object sender, EventArgs e)
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

            this.clearUI();//清空界面


            this.initListView();//刷新listview
            skinButton_codeTypeSave.Enabled = false;//禁用保存按钮
            Jc_code_type codeTypeCountLike = new Jc_code_type();
            codeTypeCountLike.Name = "类";
            label_typecount.Text = jc_codeTypeBLL.getCount(null, codeTypeCountLike).ToString();

           
        }
        /// <summary>
        /// 点击按钮
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void button_codeTypeSave_Click(object sender, EventArgs e)
        {

            try
            {


                //从界面取值构建要保存对象
               Jc_code_type codeTypeSave = new Jc_code_type();
                codeTypeSave.Name = textBox_codeTypeName.Text;
                codeTypeSave.Value = textBox_codeTypeValue.Text;
                codeTypeSave.Pym = textBox_拼音码.Text;
                codeTypeSave.Wbm = textBox_五笔码.Text;
               Jc_code zfbz = (Jc_code)comboBox_zfbz.SelectedItem;
                codeTypeSave.Zfbz = zfbz.Value;
                codeTypeSave.Remark = richTextBox_remark.Text;
                codeTypeSave.Sort = skinNumericUpDown_排序码.Value;

                //校验界面空值，会抛异常
                this.checkJc_code_typeIsNull(codeTypeSave);

                bool flag = false;
                if (null == codeTypeOld)
                {
                    flag = jc_codeTypeBLL.save(codeTypeSave);//直接保存，对象中没有主键，所以会执行insert
                }
                else
                {
                    this.checkJc_code_typeIsEqual(this.codeTypeOld,codeTypeSave);
                    codeTypeSave.Id = codeTypeOld.Id;
                    flag = jc_codeTypeBLL.save(codeTypeSave);//修改，对象中已存在主键，会执行update
                    if (flag)
                    {
                        MyMessageBox.Show("保存成功");
                    }
                    else
                    {
                        MyMessageBox.Show("保存失败");
                    }
                }
                this.clearUI();//清空界面
                this.initListView();
                             
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 右键listview点击删除
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
           {
               Jc_code_type codeType = Jc_code_type.ConvertToJc_code_type(SkinListViewHelper.getCurrentListViewItem(skinListView_codeType));//得到当前选中的listview中的项

           DialogResult dr = MessageBox.Show(@"是否删除""" + codeType.Name + @"""代码类型", "提示", MessageBoxButtons.YesNo);
            if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
            {
                return;
            }

            if (codeBll.deleteAndCodeByCodeTypeId(codeType.Id))
               {
                   MyMessageBox.Show("删除成功");

               }
               else
               {
                   MyMessageBox.Show("删除失败");
               }
               this.clearUI();//清空界面
               this.initListView();//刷新listview
               skinButton_codeTypeSave.Enabled = false;//禁用保存按钮
           }
           catch (Exception ex)
           {
               MyMessageBox.Show(ex.Message);
           }
        }

        /// <summary>
        /// 双击listview中的项
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void listView_codeType_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            try
            {
                codeTypeOld = Jc_code_type.ConvertToJc_code_type(SkinListViewHelper.getCurrentListViewItem(skinListView_codeType));//把双击过的项的对象保存进codeTypeOld中
                //再把codeTypeOld中的值放到用户输入界面上
                textBox_codeTypeName.Text = codeTypeOld.Name;
                textBox_codeTypeValue.Text = codeTypeOld.Value;
                textBox_拼音码.Text = codeTypeOld.Pym;
                textBox_五笔码.Text = codeTypeOld.Wbm;
                richTextBox_remark.Text = codeTypeOld.Remark;
                skinNumericUpDown_排序码.Value = (decimal)codeTypeOld.Sort;
                comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, codeTypeOld.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);//设置combobox中的值为当前选中的codeType对应的值
                this.initDataGridViewCodeByCodeTypeValue(codeTypeOld.Value);// 初始化datagridView

            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            skinButton_codeTypeSave.Enabled = true;
        }

        

        private void listView_codeType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.删除ToolStripMenuItem_Click(sender, e);
            }
        }

        private void button_addCode_Click(object sender, EventArgs e)
        {

            if (codeTypeOld == null)
            {
                MyMessageBox.Show("请从左边列表双击选择一个代码类别");
                return;
            }
            else
            {
                CodeEdit codeEdit = new CodeEdit(codeTypeOld);
                codeEdit.Owner = this;
                codeEdit.ShowDialog();
                this.initDataGridViewCodeByCodeTypeValue(codeTypeOld.Value);
            }
     
        }



     


        /// <summary>
        /// 初始化datagridView
        /// </summary>
        /// <param Name="value"></param>
        private void initDataGridViewCodeByCodeTypeValue(string value)
        {
            Jc_code codeParam = new Jc_code();
            Jc_code_type codeType = new Jc_code_type();
            codeType.Value = value;
            codeParam.Jc_code_type = codeType;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_code.SORT));
            SkinDataGridViewHelper.bindingList(skinDataGridView_code, jc_codeBLL.getListContactObject(codeParam, null, sortList)[0]);
            label_codeCount.Text = skinDataGridView_code.RowCount.ToString();

            if (skinDataGridView_code.DataSource == null)
            {
                return;
            }
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_code.Columns[Jc_code.ID].Visible = false;//主键
            skinDataGridView_code.Columns[Jc_code.ID].HeaderText = "主键";
            //dataGridView_code.Columns[Jc_code.NAME].Visible = false;//代码名称
            skinDataGridView_code.Columns[Jc_code.NAME].HeaderText = "代码名称";
            //dataGridView_code.Columns[Jc_code.VALUE].Visible = false;//代码值
            skinDataGridView_code.Columns[Jc_code.VALUE].HeaderText = "代码值";
            skinDataGridView_code.Columns[Jc_code.FK_CODE_TYPE].Visible = false;//代码所属类型(关联到代码类型表id)
            //skinDataGridView_code.Columns[Jc_code.FK_CODE_TYPE].HeaderText = "代码所属类型(关联到代码类型表id)";
            skinDataGridView_code.Columns[Jc_code.PYM].Visible = false;//拼音码
            skinDataGridView_code.Columns[Jc_code.PYM].HeaderText = "拼音码";
            skinDataGridView_code.Columns[Jc_code.WBM].Visible = false;//五笔码
            skinDataGridView_code.Columns[Jc_code.WBM].HeaderText = "五笔码";
            //skinDataGridView_code.Columns[Jc_code.REMARK].Visible = false;//备注
            skinDataGridView_code.Columns[Jc_code.REMARK].HeaderText = "备注";
            skinDataGridView_code.Columns[Jc_code.ZFBZ].Visible = false;//作废废标志（0禁用，1启用）
            skinDataGridView_code.Columns[Jc_code.ZFBZ].HeaderText = "作废废标志（0禁用，1启用）";
            //skinDataGridView_code.Columns[Jc_code.SORT].Visible = false;//排序码
            skinDataGridView_code.Columns[Jc_code.SORT].HeaderText = "排序码";
            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //DataGridViewHelper.dataGridViewObjectConvertToValue(dataGridView_code, "jc_code_type", "jc_code_typeName", "代码所属类型(关联到代码类型表id)", CommonCode.实体类名称.基础_代码类型字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_code.Columns["jc_code_type"].Visible = false;//代码所属类型(关联到代码类型表id)

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_code);
        }




        /// <summary>
        /// 比较Jc_code_type类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_code_type"></param>
        /// <param name="newJc_code_type"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_code_typeIsEqual(Jc_code_type oldJc_code_type, Jc_code_type newJc_code_type)
        {
            bool flag = false;

            //代码类型名称
            if (oldJc_code_type.Name != newJc_code_type.Name)
            {
                flag = true;
            }

            //代码类型值
            if (oldJc_code_type.Value != newJc_code_type.Value)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_code_type.Pym != newJc_code_type.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_code_type.Wbm != newJc_code_type.Wbm)
            {
                flag = true;
            }

            //备注
            if (oldJc_code_type.Remark != newJc_code_type.Remark)
            {
                flag = true;
            }

            //作废标志（0禁用，1启用）
            if (oldJc_code_type.Zfbz != newJc_code_type.Zfbz)
            {
                flag = true;
            }
            if (oldJc_code_type.Sort != newJc_code_type.Sort)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }


        /// <summary>
        /// 清空界面用户输入控件
        /// </summary>
        private void clearUI()
        {
            textBox_codeTypeName.Clear();
            textBox_codeTypeValue.Clear();
            richTextBox_remark.Clear();
            comboBox_zfbz.SelectedIndex = -1;
            textBox_拼音码.Clear();
            textBox_五笔码.Clear();
            this.codeTypeOld = null;
            skinDataGridView_code.DataSource = null;
        }


        /// <summary>
        /// 校验Jc_code_type类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_code_type"></param>
        private void checkJc_code_typeIsNull(Jc_code_type jc_code_type)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_code_type.Id || "" == jc_code_type.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //代码类型名称
            if (null == jc_code_type.Name || "" == jc_code_type.Name)
            {
                flag = true;
                sb.Append("请指定‘代码类型名称’的值\n");
            }

            //代码类型值
            if (null == jc_code_type.Value || "" == jc_code_type.Value)
            {
                flag = true;
                sb.Append("请指定‘代码类型值’的值\n");
            }

            //拼音码
            if (null == jc_code_type.Pym || "" == jc_code_type.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }

            //五笔码
            if (null == jc_code_type.Wbm || "" == jc_code_type.Wbm)
            {
                flag = true;
                sb.Append("请指定‘五笔码’的值\n");
            }

            //备注
            if (null == jc_code_type.Remark || "" == jc_code_type.Remark)
            {
                flag = true;
                sb.Append("请指定‘备注’的值\n");
            }

            //作废标志（0禁用，1启用）
            if (null == jc_code_type.Zfbz || "" == jc_code_type.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志（0禁用，1启用）’的值\n");
            }

            //排序码
            if (null == jc_code_type.Sort||0==jc_code_type.Sort)
            {
                flag = true;
                sb.Append("请指定‘排序码’的值\n");
            }
            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        /// <summary>
        /// 刷新codeType的listView控件
        /// </summary>
        private void initListView()
        {
            skinListView_codeType.Clear();
            List<SortInfo> sortList = new List<SortInfo>();
            SortInfo namesort = new SortInfo();
            namesort.ColumnName = Jc_code_type.SORT;
            namesort.SortType = "ASC";
            sortList.Add(namesort);
            List<Jc_code_type> codeTypes = (List<Jc_code_type>)jc_codeTypeBLL.getList(null, null, sortList)[0];//得到所有代码类型

            //创建列头
            skinListView_codeType.Columns.Add("index", "索引");
            skinListView_codeType.Columns.Add("name", "名称");
            skinListView_codeType.Columns.Add("value", "值");
            skinListView_codeType.Columns.Add("remark", "备注");
            for (int i = 0; i < codeTypes.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Clear();
                listItem.Text = i.ToString();//0
                listItem.SubItems.Add(codeTypes[i].Name);//1
                listItem.SubItems.Add(codeTypes[i].Value);//2
                listItem.SubItems.Add(codeTypes[i].Remark);//3
                listItem.Tag = codeTypes[i];
                skinListView_codeType.Items.Add(listItem);//列值添加进listview
            }
            skinListView_codeType.Columns["index"].Width = -2;//根据标题设置宽度
            skinListView_codeType.Columns["name"].Width = -1;//根据内容
            skinListView_codeType.Columns["value"].Width = -1;
            skinListView_codeType.Columns["remark"].Width = -1;
            SkinListViewHelper.setForeColorForControl(skinListView_codeType);
        }



        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_code code = (Jc_code)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_code);//得到当前选中的listview中的项

                DialogResult dr = MessageBox.Show(@"是否删除""" + code.Name + @"""代码", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
                {
                    return;
                }

                if (jc_codeBLL.deleteById(code.Id))
                {
                    MyMessageBox.Show("删除成功");

                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);//初始化作废标志
                this.initDataGridViewCodeByCodeTypeValue(this.codeTypeOld.Value);
                skinButton_codeTypeSave.Enabled = false;//禁用保存按钮
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }



        private void dataGridView_code_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            skinDataGridView_code.ClearSelection();
        }

        private void dataGridView_code_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_code code = (Jc_code)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_code);
                CodeEdit codeEdit = new client.JC.代码字典管理.CodeEdit(code);
                codeEdit.ShowDialog();
                this.initDataGridViewCodeByCodeTypeValue(code.Jc_code_type.Value);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.clearUI();
            skinButton_codeTypeSave.Enabled = true;
            comboBox_zfbz.SelectedIndex = 0;
        }

        private void button_importExcel_Click(object sender, EventArgs e)
        {
            if (codeTypeOld == null)
            {
                MyMessageBox.Show("请从左边列表双击选择一个代码类别");
                return;
            }
            else
            {
                CodeImportForExcel importExcel = new CodeImportForExcel(this.codeTypeOld);
                importExcel.ShowDialog();
                this.initDataGridViewCodeByCodeTypeValue(this.codeTypeOld.Value);
            }
        }

        private void dataGridView_code_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.删除ToolStripMenuItem1_Click(sender, e);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_codeTypeName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_拼音码.Text = PinYinConverter.GetFirst( textBox_codeTypeName.Text);
                textBox_五笔码.Text = WuBiConverter.GetWBCode( textBox_codeTypeName.Text);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void textBox_codeTypeName_VisibleChanged(object sender, EventArgs e)
        {

        }








    }
}

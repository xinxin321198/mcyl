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
using BLL.JC.基础_行政区划;
using Model.RBAC;
using BLL.JC.行政区划;

namespace client.JC.行政区划管理
{
    public partial class AreaMgr : Form
    {

        private Jc_areaBLL jc_areaBLL = new Jc_areaBLLImp();
        private AreaBLL areaBLL = new AreaBLLImp();

        private Jc_area parentArea = null;

        private Jc_area oldArea = null;
        private Main main = null;//主窗体引用


        public AreaMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_add, skinButton_save);
            textBox_parentName.Enabled = false;
            textBox_name.Enabled = false;
            textBox_code.Enabled = false;
            ComboBoxHelper.initComboBoxForCode(comboBox_level, CommonCode.代码类型值.行政区划等级, CommonCode.代码值_作废标志代码值.启用);
            comboBox_level.Enabled = false;
            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);
            comboBox_zfbz.Enabled = false;
            skinButton_save.Enabled = false;
            richTextBox_remark.Enabled = false;
            textBox_城乡分类.Enabled = false;
        }


        /// <summary>
        /// 校验Jc_area类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_area"></param>
        private void checkJc_areaIsNull(Jc_area jc_area)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_area.Id || "" == jc_area.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //名称
            if (null == jc_area.Name || "" == jc_area.Name)
            {
                flag = true;
                sb.Append("请指定‘名称’的值\n");
            }

            //行政区划代码
            if (null == jc_area.Code || "" == jc_area.Code)
            {
                flag = true;
                sb.Append("请指定‘行政区划代码’的值\n");
            }

            //父级行政区划id
            //if (null == jc_area.Pid || "" == jc_area.Pid)
            //{
            //    flag = true;
            //    sb.Append("请指定‘父级行政区划id’的值\n");
            //}

            //父级行政区划代码
            //if (null == jc_area.Pcode || "" == jc_area.Pcode)
            //{
            //    flag = true;
            //    sb.Append("请指定‘父级行政区划代码’的值\n");
            //}

            //作废标志
            if (null == jc_area.Zfbz || "" == jc_area.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            //行政区划等级
            if (null == jc_area.Level_code || "" == jc_area.Level_code)
            {
                flag = true;
                sb.Append("请指定‘行政区划等级’的值\n");
            }

            //城乡分类（仅居委会有效）
            //if (null == jc_area.Type_code || "" == jc_area.Type_code)
            //{
            //    flag = true;
            //    sb.Append("请指定‘城乡分类（仅居委会有效）’的值\n");
            //}

            //备注
            //if (null == jc_area.Remark || "" == jc_area.Remark)
            //{
            //    flag = true;
            //    sb.Append("请指定‘备注’的值\n");
            //}

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        /// <summary>
        /// 比较Jc_area类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_area"></param>
        /// <param name="newJc_area"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_areaIsEqual(Jc_area oldJc_area, Jc_area newJc_area)
        {
            bool flag = false;

            //名称
            if (oldJc_area.Name != newJc_area.Name)
            {
                flag = true;
            }

            //行政区划代码
            if (oldJc_area.Code != newJc_area.Code)
            {
                flag = true;
            }

            //父级行政区划id
            if (oldJc_area.Pid != newJc_area.Pid)
            {
                flag = true;
            }

            //父级行政区划代码
            if (oldJc_area.Pcode != newJc_area.Pcode)
            {
                flag = true;
            }

            //作废标志
            if (oldJc_area.Zfbz != newJc_area.Zfbz)
            {
                flag = true;
            }

            //行政区划等级
            if (oldJc_area.Level_code != newJc_area.Level_code)
            {
                flag = true;
            }

            //城乡分类（仅居委会有效）
            if (oldJc_area.Type_code != newJc_area.Type_code)
            {
                flag = true;
            }

            //备注
            if (oldJc_area.Remark != newJc_area.Remark)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }




        private void AreaMgr_Load(object sender, EventArgs e)
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

            this.initTreeView();
        }

        private void initTreeView()
        {
            treeView_area.Nodes.Clear();
            Jc_area areaParam = new Jc_area();
            areaParam.Level_code = CommonCode.代码值_行政区划等级.省级;
            List<object> shengObjs = jc_areaBLL.getListContactObject(areaParam, null, null);
            List<Jc_area> shengList = (List<Jc_area>)shengObjs[0];

            Jc_area areaParam2 = new Jc_area();
            areaParam2.Level_code = CommonCode.代码值_行政区划等级.州市级;
            List<object> zsObjs = jc_areaBLL.getListContactObject(areaParam2, null, null);
            List<Jc_area> zsList = (List<Jc_area>)zsObjs[0];

            Jc_area areaParam3 = new Jc_area();
            areaParam3.Level_code = CommonCode.代码值_行政区划等级.区县级;
            List<object> xqObjs = jc_areaBLL.getListContactObject(areaParam3, null, null);
            List<Jc_area> xqList = (List<Jc_area>)xqObjs[0];

            Jc_area areaParam4 = new Jc_area();
            areaParam4.Level_code = CommonCode.代码值_行政区划等级.乡镇级;
            List<object> xzObjs = jc_areaBLL.getListContactObject(areaParam4, null, null);
            List<Jc_area> xzList = (List<Jc_area>)xzObjs[0];

            Jc_area areaParam5 = new Jc_area();
            areaParam5.Level_code = CommonCode.代码值_行政区划等级.村委会级;
            List<object> cunObjs = jc_areaBLL.getListContactObject(areaParam5, null, null);
            List<Jc_area> cunList = (List<Jc_area>)cunObjs[0];

            //循环添省start
            for (int i = 0; i < shengList.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = shengList[i].Name;
                node.Tag = shengList[i];
                //循环添加州市start
                for (int j = 0; j < zsList.Count; j++)
                {
                    if (zsList[j].Pid==shengList[i].Id)
                    {
                        TreeNode nodezs = new TreeNode();
                        nodezs.Text = zsList[j].Name;
                        nodezs.Tag = zsList[j];

                        //循环添加区县start
                        for (int k = 0; k < xqList.Count; k++)
                        {
                            if (xqList[k].Pid == zsList[j].Id)
                            {
                                TreeNode nodexq = new TreeNode();
                                nodexq.Text = xqList[k].Name;
                                nodexq.Tag = xqList[k];

                                //循环添加乡镇start
                                for (int l = 0; l < xzList.Count; l++)
                                {
                                    if (xzList[l].Pid == xqList[k].Id)
                                    {
                                        TreeNode nodexz = new TreeNode();
                                        nodexz.Text = xzList[l].Name;
                                        nodexz.Tag = xzList[l];
                                        //循环添加村委会start
                                        for (int m = 0; m < cunList.Count; m++)
                                        {
                                            if (cunList[m].Pid == xzList[l].Id)
                                            {
                                                TreeNode nodecun = new TreeNode();
                                                nodecun.Text = cunList[m].Name;
                                                nodecun.Tag = cunList[m];
                                                nodexz.Nodes.Add(nodecun);
                                            }
                                        }
                                        //循环添加村委会end
                                        nodexq.Nodes.Add(nodexz);
                                    }
                                }
                                //循环添加乡镇end
                                nodezs.Nodes.Add(nodexq);
                            }
                        }
                        //循环添加区县end
                        node.Nodes.Add(nodezs);
                    }
                }
                //循环添加州市end
                treeView_area.Nodes.Add(node);
            }
            //循环添省end



        }



        private void button_add_Click(object sender, EventArgs e)
        {
            this.clearUI();
            this.changeEnableUI(true);
            comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.省级, CommonCode.实体类名称.基础_代码字典实体类名);
            skinButton_save.Enabled = true;
            comboBox_zfbz.SelectedIndex = 1;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                
                Jc_area areaSave = new Jc_area();
                areaSave.Name = textBox_name.Text.Trim();

                //补全12位行政区划代码
                StringBuilder code = new StringBuilder( textBox_code.Text.Trim());
                if (code.Length!=12)
                {
                    int count = 12 - code.Length;
                    for (int i = 0; i < count; i++)
                    {
                        code.Append("0");
                    }
                }
                areaSave.Code = code.ToString();

                areaSave.Remark = richTextBox_remark.Text.Trim();
                areaSave.Type_code = textBox_城乡分类.Text.Trim();
                if (parentArea!=null)
                {
                    areaSave.Pid = parentArea.Id;
                    areaSave.Pcode = parentArea.Code;
                }

                areaSave.Level_code = Jc_code.ConvertToJc_code(comboBox_level.SelectedItem).Value;
                areaSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_zfbz.SelectedItem).Value;

                this.checkJc_areaIsNull(areaSave);
                bool flag = false;

                if (oldArea == null)
                {
                    flag = jc_areaBLL.save(areaSave);

                }
                else
                {
                    this.checkJc_areaIsEqual(this.oldArea,areaSave);
                    areaSave.Id = oldArea.Id;
                    flag = jc_areaBLL.save(areaSave);
                }

                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }
                this.initTreeView();
                this.clearUI();
                this.changeEnableUI(false);
                textBox_城乡分类.Enabled = false;
                textBox_城乡分类.Clear();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }

        }

        private void clearUI()
        {
            this.oldArea = null;
            textBox_name.Clear();
            textBox_code.Clear();
            textBox_parentName.Clear();
            richTextBox_remark.Clear();
            comboBox_level.SelectedIndex = -1;
            comboBox_zfbz.SelectedIndex =-1;
        }

        private void changeEnableUI(bool state)
        {
            textBox_name.Enabled = state;
            textBox_code.Enabled = state;
            richTextBox_remark.Enabled = state;
            comboBox_zfbz.Enabled = state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMessageBox.Show(treeView_area.SelectedNode.Text);
        }

        private void 添加下级行政区划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.changeEnableUI(true);
                this.clearUI();
                parentArea = Jc_area.ConvertToJc_area(treeView_area.SelectedNode.Tag);
                textBox_parentName.Text = parentArea.Name;

                //根据当前的父节点行政区划等级决定下级行政区划
                if (parentArea.Level_code ==CommonCode.代码值_行政区划等级.省级)
                {
                    comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.州市级, CommonCode.实体类名称.基础_代码字典实体类名);
                }
                else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.州市级)
                {
                    comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.区县级, CommonCode.实体类名称.基础_代码字典实体类名);
                } 
                else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.区县级)
                {
                    comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.乡镇级, CommonCode.实体类名称.基础_代码字典实体类名);
                }
                else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.乡镇级)
                {
                    comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.村委会级, CommonCode.实体类名称.基础_代码字典实体类名);
                    textBox_城乡分类.Enabled = true;

                }
                else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.村委会级)
                {
                    throw new Exception("村委会为最下级行政区划，不允许再添加下级行政区划");
                }
                else
                {
                    throw new Exception("错误：没有上级行政区划");
                }
                
                comboBox_zfbz.Enabled = true;
                comboBox_zfbz.SelectedIndex = -1;
                richTextBox_remark.Enabled = true;
                richTextBox_remark.Clear();
                skinButton_save.Enabled = true;
                comboBox_zfbz.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void 删除当前行政区划及所有下级行政区划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                Jc_area currentArea = Jc_area.ConvertToJc_area(TreeViewHelper.getCurrentTreeViewNodeItem(treeView_area));
                DialogResult dr = MessageBox.Show(@"是否删除""" + currentArea.Name + @"""", "提示", MessageBoxButtons.YesNo);
                if (dr != DialogResult.Yes)
                {
                    return;
                }

                bool flag = areaBLL.deleteAndChildNodeById(currentArea.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.initTreeView();
                this.clearUI();
                this.changeEnableUI(false);
                }
                
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }

        }

        private void treeView_area_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView_area.SelectedNode;
                if (null==node)
                {
                    throw new Exception("请选中一个节点");
                }
                this.oldArea = Jc_area.ConvertToJc_area(node.Tag);
                if (treeView_area.SelectedNode.Parent != null)//不是省级
                {
                    Jc_area parentaArea = Jc_area.ConvertToJc_area(treeView_area.SelectedNode.Parent.Tag);
                    textBox_parentName.Text = parentaArea.Name;
                }
                else
                {
                    textBox_parentName.Text = "";
                }

                if (oldArea.Level_code == CommonCode.代码值_行政区划等级.村委会级)
                {
                    textBox_城乡分类.Enabled = true;
                }
                else
                {
                    textBox_城乡分类.Enabled = false;

                }

                this.changeEnableUI(true);
                skinButton_save.Enabled = true;
                textBox_name.Text = oldArea.Name;
                textBox_code.Text = oldArea.Code;
                comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, oldArea.Level_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, oldArea.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
                richTextBox_remark.Text = oldArea.Remark;
                textBox_城乡分类.Text = oldArea.Type_code;
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_addChild_Click(object sender, EventArgs e)
        {
            try
            {
                this.changeEnableUI(true);
                this.clearUI();
                TreeNode node = treeView_area.SelectedNode;
                if (null == node)//没有选中，是顶级行政区划
                {
                    this.comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.省级, CommonCode.实体类名称.基础_代码字典实体类名);
                }
                else
                {
                    this.parentArea = Jc_area.ConvertToJc_area(node.Tag);
                    textBox_parentName.Text = parentArea.Name;

                    //根据当前的父节点行政区划等级决定下级行政区划
                    if (parentArea.Level_code == CommonCode.代码值_行政区划等级.省级)
                    {
                        this.comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.州市级, CommonCode.实体类名称.基础_代码字典实体类名);
                    }
                    else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.州市级)
                    {
                        this.comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.区县级, CommonCode.实体类名称.基础_代码字典实体类名);

                    }
                    else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.区县级)
                    {
                        this.comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.乡镇级, CommonCode.实体类名称.基础_代码字典实体类名);

                    }
                    else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.乡镇级)
                    {
                        this.comboBox_level.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_level, CommonCode.代码值_行政区划等级.村委会级, CommonCode.实体类名称.基础_代码字典实体类名);

                        textBox_城乡分类.Enabled = true;
                    }
                    else if (parentArea.Level_code == CommonCode.代码值_行政区划等级.村委会级)
                    {
                        this.changeEnableUI(false);
                        throw new Exception("村委会为最下级行政区划，不允许再添加下级行政区划");
                    }
                    else
                    {
                        this.changeEnableUI(false);

                        throw new Exception("错误：没有上级行政区划");
                    }
                }

                
                

                comboBox_zfbz.Enabled = true;
                comboBox_zfbz.SelectedIndex = -1;
                richTextBox_remark.Enabled = true;
                richTextBox_remark.Clear();
                skinButton_save.Enabled = true;
                comboBox_zfbz.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }



        private void textBox_code_Leave(object sender, EventArgs e)
        {
            //补全12位行政区划代码
            StringBuilder code = new StringBuilder(textBox_code.Text.Trim());
            if (code.Length != 12)
            {
                int count = 12 - code.Length;
                for (int i = 0; i < count; i++)
                {
                    code.Append("0");
                }
            }
            textBox_code.Text = code.ToString();
        }

        private void treeView_area_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode selectnode = this.treeView_area.GetNodeAt(e.Location);
            if (selectnode == null)
            {
                this.treeView_area.SelectedNode = null;

            }  
        }

        private void treeView_area_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeView treeView = (TreeView)sender;

                if (treeView.SelectedNode != null)
                {
                    Jc_area area = (Jc_area)treeView.SelectedNode.Tag;
                    if (area.Level_code == CommonCode.代码值_行政区划等级.村委会级)
                    {
                        skinButton_add.Enabled = false;
                    }
                    else
                    {
                        skinButton_add.Enabled = true;
                    }
                }


            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_exp_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Filter = "excel2003格式(*.xls)|*.xls|excel2007格式(*.xlsx)|*.xlsx";
                DialogResult dr = saveFileDialog.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    List<Jc_area> areaList = (List<Jc_area>)jc_areaBLL.getList(null, null, null)[0];
                    List<List<string>> stringList = new List<List<string>>();
                    for (int i = 0; i < areaList.Count; i++)
                    {
                        List<string> rowList = new List<string>();
                        rowList.Add(areaList[i].Id);
                        rowList.Add(areaList[i].Name);
                        rowList.Add(areaList[i].Code);
                        rowList.Add(areaList[i].Level_code);
                        rowList.Add(areaList[i].Pcode);
                        rowList.Add(areaList[i].Pid);
                        rowList.Add(areaList[i].Type_code);
                        rowList.Add(areaList[i].Zfbz);

                        stringList.Add(rowList);
                    }

                    List<string> columns = new List<string>();
                    columns.Add(Jc_area.ID);
                    columns.Add(Jc_area.NAME);
                    columns.Add(Jc_area.CODE);
                    columns.Add(Jc_area.LEVEL_CODE);
                    columns.Add(Jc_area.PCODE);
                    columns.Add(Jc_area.PID);
                    columns.Add(Jc_area.TYPE_CODE);
                    columns.Add(Jc_area.ZFBZ);
                    bool flag = NpoiHelper.exportExcelForXlsx(saveFileDialog.FileName, Jc_area.TABEL_NAME, columns, stringList);
                    if (flag)
                    {
                        MyMessageBox.Show("导出成功！");
                    }
                    else
                    {
                        MyMessageBox.Show("导出失败！");

                    }
                }

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


    }
}

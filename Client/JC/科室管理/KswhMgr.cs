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
using BLL.JC.基础_代码字典;
using BLL.JC.基础_科室;
using Model.JC;
using Model.RBAC;

namespace client.JC.科室管理
{
    public partial class KswhMgr : Form
    {


        Jc_kswh old_kswh = null;
        Jc_kswhBLL jc_kswhBLL = new Jc_kswhBLLImp();
        Jc_codeBLL jc_codeBLL = new Jc_codeBLLImp();
        PageInfo page = null;

        private Main main = null;//主窗体引用

        public KswhMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_add, skinButton_save);
            ComboBoxHelper.initComboBoxForZfbz(skinComboBox_zfbz);//初始化作废标志
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_kswh);
            SkinRadioButtonHelper.initSkinRadioButton(skinRadioButton_mzbz, skinRadioButton_ssbz, skinRadioButton_yfbz, skinRadioButton_yjbz, skinRadioButton_ykbz, skinRadioButton_zybz);
            this.changeUIEnabled(false);//禁用所有按钮，新增除外

        }

        private void Kswh_Load(object sender, EventArgs e)
        {

            try
            {
                this.initUI();//初始化用户界面
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void initUI()
        {


            this.initDataGridView_kswh();//初始化datagridview
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MyMessageBox.Show("科室不允许删除，请设为禁用");
            try
            {
                Jc_kswh kswh = (Jc_kswh)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_kswh);

                DialogResult dr = MessageBox.Show(@"是否删除""" + kswh.Ksmc + @"""", "提示", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != dr)//如果用户点击NO，就不删除
                {
                    return;
                }
                bool flag = this.jc_kswhBLL.deleteContactRecord(kswh);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.page = null;

                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            this.changeUIEnabled(true);
            this.clearUI();//清空界面

        }

        private void button_save_Click(object sender, EventArgs e)
        {

            try
            {
                Jc_kswh jc_kswhSave = new Jc_kswh();
                jc_kswhSave.Ksbh = textBox_ksbh.Text;
                jc_kswhSave.Ksmc = textBox_ksmc.Text;
                jc_kswhSave.Zfbz = Jc_code.ConvertToJc_code(skinComboBox_zfbz.SelectedItem).Value;
                jc_kswhSave.Mzbz_code = skinRadioButton_mzbz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                jc_kswhSave.Zybz_code = skinRadioButton_zybz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                jc_kswhSave.Ykbz_code = skinRadioButton_ykbz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                jc_kswhSave.Yfbz_code = skinRadioButton_yfbz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                jc_kswhSave.Yjbz_code = skinRadioButton_yjbz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                jc_kswhSave.Ssbz_code = skinRadioButton_yjbz.Checked ? CommonCode.代码值_勾叉.勾 : CommonCode.代码值_勾叉.叉;
                this.checkJc_kswhIsNull(jc_kswhSave);

                bool flag = false;
                if (old_kswh == null)
                {
                    flag = jc_kswhBLL.save(jc_kswhSave);
                }
                else
                {
                    //验证是否需要保存信息（方法验证listview中双击过的行的值与用户输入框构建的对象是否相等）
                   this.checkJc_kswhIsEqual(old_kswh, jc_kswhSave);
                   jc_kswhSave.Id = old_kswh.Id;
                   flag = jc_kswhBLL.save(jc_kswhSave);

                }
               
                if (flag)
                { 
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }
                this.page = null;

                this.initDataGridView_kswh();//刷新datagridview
                this.changeUIEnabled(false);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 比较Jc_kswh类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_kswh"></param>
        /// <param name="newJc_kswh"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_kswhIsEqual(Jc_kswh oldJc_kswh, Jc_kswh newJc_kswh)
        {
            bool flag = false;

            //科室标志
            if (oldJc_kswh.Ksbh != newJc_kswh.Ksbh)
            {
                flag = true;
            }

            //科室名称
            if (oldJc_kswh.Ksmc != newJc_kswh.Ksmc)
            {
                flag = true;
            }

            //门诊标志（与代码表关联）
            if (oldJc_kswh.Mzbz_code != newJc_kswh.Mzbz_code)
            {
                flag = true;
            }

            //住院标志（与代码表关联）
            if (oldJc_kswh.Zybz_code != newJc_kswh.Zybz_code)
            {
                flag = true;
            }

            //药库标志（与代码表关联）
            if (oldJc_kswh.Ykbz_code != newJc_kswh.Ykbz_code)
            {
                flag = true;
            }

            //药房标志（与代码表关联）
            if (oldJc_kswh.Yfbz_code != newJc_kswh.Yfbz_code)
            {
                flag = true;
            }

            //医技标志（与代码表关联）
            if (oldJc_kswh.Yjbz_code != newJc_kswh.Yjbz_code)
            {
                flag = true;
            }

            //手术标志（与代码表关联）
            if (oldJc_kswh.Ssbz_code != newJc_kswh.Ssbz_code)
            {
                flag = true;
            }

            //作废标志
            if (oldJc_kswh.Zfbz != newJc_kswh.Zfbz)
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
        /// 校验Jc_kswh类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_kswh"></param>
        private void checkJc_kswhIsNull(Jc_kswh jc_kswh)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_kswh.Id || "" == jc_kswh.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //科室标志
            if (null == jc_kswh.Ksbh || "" == jc_kswh.Ksbh)
            {
                flag = true;
                sb.Append("请指定‘科室标志’的值\n");
            }

            //科室名称
            if (null == jc_kswh.Ksmc || "" == jc_kswh.Ksmc)
            {
                flag = true;
                sb.Append("请指定‘科室名称’的值\n");
            }

            //门诊标志（与代码表关联）
            if (null == jc_kswh.Mzbz_code || "" == jc_kswh.Mzbz_code)
            {
                flag = true;
                sb.Append("请指定‘门诊标志（与代码表关联）’的值\n");
            }

            //住院标志（与代码表关联）
            if (null == jc_kswh.Zybz_code || "" == jc_kswh.Zybz_code)
            {
                flag = true;
                sb.Append("请指定‘住院标志（与代码表关联）’的值\n");
            }

            //药库标志（与代码表关联）
            if (null == jc_kswh.Ykbz_code || "" == jc_kswh.Ykbz_code)
            {
                flag = true;
                sb.Append("请指定‘药库标志（与代码表关联）’的值\n");
            }

            //药房标志（与代码表关联）
            if (null == jc_kswh.Yfbz_code || "" == jc_kswh.Yfbz_code)
            {
                flag = true;
                sb.Append("请指定‘药房标志（与代码表关联）’的值\n");
            }

            //医技标志（与代码表关联）
            if (null == jc_kswh.Yjbz_code || "" == jc_kswh.Yjbz_code)
            {
                flag = true;
                sb.Append("请指定‘医技标志（与代码表关联）’的值\n");
            }

            //手术标志（与代码表关联）
            if (null == jc_kswh.Ssbz_code || "" == jc_kswh.Ssbz_code)
            {
                flag = true;
                sb.Append("请指定‘手术标志（与代码表关联）’的值\n");
            }

            //作废标志
            if (null == jc_kswh.Zfbz || "" == jc_kswh.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //清空界面
        private void clearUI()
        {
            this.textBox_ksbh.Clear();
            this.textBox_ksmc.Clear();
            this.skinComboBox_zfbz.SelectedIndex = -1;
            this.skinRadioButton_mzbz.Checked = false;
            this.skinRadioButton_ssbz.Checked =false;
            this.skinRadioButton_yfbz.Checked = false;
            this.skinRadioButton_yjbz.Checked = false;
            this.skinRadioButton_ykbz.Checked = false;
            this.skinRadioButton_zybz.Checked = false;
            this.old_kswh = null;
        }

        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl()
        {
                        //分页控件
            toolStripLabel_currentPage.Text = page.CurrentPage.ToString();
            toolStripLabel_allCount.Text = page.AllCount.ToString();
            toolStripLabel_pageCount.Text = page.PageCount.ToString(); ;
            toolStripLabel_pageSize.Text = page.PageSize.ToString();
        }

        //初始化科室列表
        private void initDataGridView_kswh()
        {

            List<object> objectList = jc_kswhBLL.getListContactObjectByPage(null, this.page,null,null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_kswh, objectList[0]);

            page = (PageInfo)objectList[1];
            this.initPageControl();

            if (skinDataGridView_kswh.DataSource == null)
            {
                return;
            }

            //#region UI,datagridview隐藏基本字段，start
            ////隱藏列start
            ////skinDataGridView_kswh.Columns["ID"].Visible = false;//隐藏此列
            ////skinDataGridView_kswh.Columns["ID"].HeaderText = "主键";//设置列名
            ////skinDataGridView_kswh.Columns["ID"].DisplayIndex = 0;//列的顺序
            ////skinDataGridView_kswh.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_kswh.Columns[Jc_kswh.ID].Visible = false;//主键
            //skinDataGridView_kswh.Columns[Jc_kswh.ID].HeaderText = "主键";

            //skinDataGridView_kswh.Columns[Jc_kswh.KSBH].Visible = false;//科室标志
            skinDataGridView_kswh.Columns[Jc_kswh.KSBH].HeaderText = "科室编号";

            //skinDataGridView_kswh.Columns[Jc_kswh.KSMC].Visible = false;//科室名称
            skinDataGridView_kswh.Columns[Jc_kswh.KSMC].HeaderText = "科室名称";

            skinDataGridView_kswh.Columns[Jc_kswh.MZBZ_CODE].Visible = false;//门诊标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.MZBZ_CODE].HeaderText = "门诊标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.ZYBZ_CODE].Visible = false;//住院标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.ZYBZ_CODE].HeaderText = "住院标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.YKBZ_CODE].Visible = false;//药库标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.YKBZ_CODE].HeaderText = "药库标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.YFBZ_CODE].Visible = false;//药房标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.YFBZ_CODE].HeaderText = "药房标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.YJBZ_CODE].Visible = false;//医技标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.YJBZ_CODE].HeaderText = "医技标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.SSBZ_CODE].Visible = false;//手术标志（与代码表关联）
            //skinDataGridView_kswh.Columns[Jc_kswh.SSBZ_CODE].HeaderText = "手术标志（与代码表关联）";

            skinDataGridView_kswh.Columns[Jc_kswh.ZFBZ].Visible = false;//作废标志
            //skinDataGridView_kswh.Columns[Jc_kswh.ZFBZ].HeaderText = "作废标志";

            //#endregion UI,datagridview隐藏基本字段，end

            //#region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "mzbzCode", "mzbzCodeName", "门诊标志", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "zybzCode", "zybzCodeName", "住院标志", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "ykbzCode", "ykbzCodeName", "药库标志", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "yfbzCode", "yfbzCodeName", "药房标志", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "yjbzCode", "yjbzCodeName", "医技标志", CommonCode.实体类名称.基础_代码字典实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_kswh, "ssbzCode", "ssbzCodeName", "手术标志", CommonCode.实体类名称.基础_代码字典实体类名);

            //#endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //#region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            ////skinDataGridView_kswh.Columns["mzbzCode"].Visible = false;//门诊标志（与代码表关联）

            ////skinDataGridView_kswh.Columns["zybzCode"].Visible = false;//住院标志（与代码表关联）

            ////skinDataGridView_kswh.Columns["ykbzCode"].Visible = false;//药库标志（与代码表关联）

            ////skinDataGridView_kswh.Columns["yfbzCode"].Visible = false;//药房标志（与代码表关联）

            ////skinDataGridView_kswh.Columns["yjbzCode"].Visible = false;//医技标志（与代码表关联）

            ////skinDataGridView_kswh.Columns["ssbzCode"].Visible = false;//手术标志（与代码表关联）

            //#endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_kswh);
        }


        /// <summary>
        /// 改变用户界面上是否禁用的状态
        /// </summary>
        /// <param Name="state"></param>
        private void changeUIEnabled(bool state)
        {
            skinButton_save.Enabled = state;
            textBox_ksbh.Enabled = state;
            textBox_ksmc.Enabled = state;
            skinComboBox_zfbz.Enabled = state;
            skinRadioButton_mzbz.Enabled = state;
            skinRadioButton_zybz.Enabled = state;
            skinRadioButton_ykbz.Enabled = state;
            skinRadioButton_yfbz.Enabled = state;
            skinRadioButton_yjbz.Enabled = state;
            skinRadioButton_ssbz.Enabled = state;
        }





        private void button_下一页_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    throw new Exception("已经没有下一页");
                }
                this.page.CurrentPage = this.page.NextPage;
                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void button_上一页_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage==0)
                {
                    throw new Exception("已经没有上一页");
                }
                this.page.CurrentPage = this.page.PrevPage;

                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.PrevPage;

                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.NextPage;
                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_尾页_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = this.page.PageCount;
                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;
                this.initDataGridView_kswh();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_kswh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.clearUI();
                //把选中的值显示在用户界面上
                old_kswh = (Jc_kswh)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_kswh);//得到当前选中的listview中的项
                //启用用户界面
                this.changeUIEnabled(true);
                textBox_ksbh.Text = old_kswh.Ksbh;
                textBox_ksmc.Text = old_kswh.Ksmc;
                skinComboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_zfbz, old_kswh.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);

                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Mzbz_code)
                {
                    skinRadioButton_mzbz.Checked = true;
                }
                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Zybz_code)
                {
                    skinRadioButton_zybz.Checked = true;
                }
                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Ykbz_code)
                {
                    skinRadioButton_ykbz.Checked = true;
                }
                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Yfbz_code)
                {
                    skinRadioButton_yfbz.Checked = true;
                }
                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Yjbz_code)
                {
                    skinRadioButton_yjbz.Checked = true;
                }
                if (CommonCode.代码值_勾叉.勾 == this.old_kswh.Ssbz_code)
                {
                    skinRadioButton_ssbz.Checked = true;
                }

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



    }
}

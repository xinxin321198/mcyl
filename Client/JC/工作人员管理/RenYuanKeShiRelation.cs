using Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC;
using BLL.JC.基础_工作人员;
using BLL.JC.基础_科室;
using BLL.JC.基础_工作人员所属科室关系;
using Model.JC;
using client.Common;
using BLL.JC.工作人员;



namespace client.JC.工作人员管理
{
    public partial class RenYuanKeShiRelation : Form
    {
        private Jc_ry_ksBLL jc_ry_ksBLL = new Jc_ry_ksBLLImp();
        private Jc_renyuan oldRenyuan = null;
        private RenyuanBLL renyuanBll = new RenyuanBLLImp();



        public RenYuanKeShiRelation( Jc_renyuan renyuan)
        {
            this.oldRenyuan = renyuan;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton( skinButton_save);
            SkinListViewHelper.initListViewCheckBoxMultiSelection(this.listView_keshi);
            //初始化科室到listview
            SkinListViewHelper.initListViewDataForKeshi(this.listView_keshi);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenYuanKeShiRelation_Load(object sender, EventArgs e)
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
            textBox_xm.Text = oldRenyuan.Xm;
            textBox_xm.ReadOnly = true;
            textBox_sfzh.Text = oldRenyuan.Sfzh;
            textBox_sfzh.ReadOnly = true;
            
            this.initListViewKeShi();
        }

        private void initListViewKeShi()
        {


            //让用户所属的科室为选中
            List<Jc_ry_ks> ry_ksList = new List<Jc_ry_ks>();
            Jc_ry_ks ry_ksParam = new Jc_ry_ks();
            ry_ksParam.Fk_renyuan_id = oldRenyuan.Id;
            ry_ksList = (List<Jc_ry_ks>)jc_ry_ksBLL.getListContactObjectByPage(ry_ksParam, null, null, null)[0];

            for (int i = 0; i < ry_ksList.Count; i++)
            {
                Jc_ry_ks ry_ks = ry_ksList[i];
                for (int j = 0; j < listView_keshi.Items.Count; j++)
                {
                    ListViewItem item = listView_keshi.Items[j];
                    Jc_kswh ks = (Jc_kswh)item.Tag;
                    if (ry_ks.Fk_keshi_id == ks.Id)
                    {
                        item.Checked = true;
                    }
                }
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                //得到所选择的科室的list
                List<Jc_kswh> checkedKsList = new List<Jc_kswh>();
                for (int i = 0; i < listView_keshi.CheckedIndices.Count; i++)
                {
                    int index = listView_keshi.CheckedIndices[i];
                    Jc_kswh keshi = new Jc_kswh();
                    keshi.Id = Jc_kswh.ConvertToJc_kswh(listView_keshi.Items[index].Tag).Id;
                    checkedKsList.Add(keshi);
                }

                //构建保存关系的对象
                List<Jc_ry_ks> ry_ksListSave = new List<Jc_ry_ks>();
                for (int i = 0; i < checkedKsList.Count; i++)
                {
                    Jc_ry_ks tmp = new Jc_ry_ks();
                    tmp.Fk_renyuan_id = oldRenyuan.Id;
                    tmp.Fk_keshi_id = checkedKsList[i].Id;
                    tmp.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;
                    ry_ksListSave.Add(tmp);
                }

                bool flag = renyuanBll.refreshRy_ksByRenyuanId(ry_ksListSave,oldRenyuan.Id);
                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin.SkinControl;
using System.Windows.Forms;
using System.Drawing;
using Model.Common;
using Model.JC;
using Model.RBAC;
using System.Reflection;
using BLL.JC.基础_科室;
using BLL.RBAC.RBAC_用户;

namespace client.Common
{
    public class SkinListViewHelper
    {

        private static Jc_kswhBLL jc_kswhBLL = new Jc_kswhBLLImp();
        private static Rbac_userBLL userBLL = new Rbac_userBLLImp();


        public static void initListView(ListView lv)
        {
            lv.FullRowSelect = true;//整行选取
            lv.View = View.Details;//详细模式
            lv.Cursor = Cursors.Hand;//光标样式
            lv.Clear();//清空listview
            lv.MultiSelect = false;//禁止多选
        }


        public static void initSkinListView(SkinListView lv)
        {
            initListView(lv);
            lv.SelectedColor = SystemColors.ActiveCaption;
            lv.HeadColor = SystemColors.ActiveCaption;
            lv.RowBackColor2 = Color.PapayaWhip;

        }


        /// <summary>
        /// 设置listview控件为单选
        /// </summary>
        /// <param name="lv"></param>
        public static void initListViewCheckBoxSingleSelection(ListView lv)
        {
            initListView(lv);
            lv.CheckBoxes = true;
            lv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(setSingleSelection);//设置选中的事件
        }

        /// <summary>
        /// 设置listview控件为多选
        /// </summary>
        /// <param name="lv"></param>
        public static void initListViewCheckBoxMultiSelection(ListView lv)
        {
            initListView(lv);
            lv.CheckBoxes = true;
        }

        private static void setSingleSelection(object sender, ItemCheckedEventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.CheckedItems.Count == 2)//2个以上才需要判断，事实上最多有2个
            {
                ListViewItem newItem;
                if (e.Item == lv.CheckedItems[0])//当前项为选中集中第一个，即[0]，则去[1]
                {
                    newItem = lv.CheckedItems[1];
                    newItem.Checked = false;
                }
                else
                {
                    newItem = lv.CheckedItems[0];
                    newItem.Checked = false;
                }
            }


        }

        /// <summary>
        /// 初始化listview，查询出科室
        /// </summary>
        /// <param name="lv"></param>
        public static void initListViewDataForKeshi(ListView lv)
        {
            Jc_kswh ksParam = new Jc_kswh();
            ksParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<object> objectList = jc_kswhBLL.getList(ksParam, null, null);
            List<Jc_kswh> data_list = (List<Jc_kswh>)objectList[0];
            //准备listview的列
            ColumnHeader chIndex = new ColumnHeader();
            ColumnHeader chKsbh = new ColumnHeader();
            ColumnHeader chKsMc = new ColumnHeader();
            chIndex.Text = "索引";
            chKsbh.Text = "科室编号";
            chKsMc.Text = "科室名称";
            lv.Columns.Add(chIndex);
            lv.Columns.Add(chKsbh);
            lv.Columns.Add(chKsMc);
            for (int i = 0; i < data_list.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = i.ToString();
                listItem.SubItems.Add(data_list[i].Ksbh);
                listItem.SubItems.Add(data_list[i].Ksmc);
                listItem.Tag = data_list[i];
                lv.Items.Add(listItem);//列值添加进listview
            }

        }

        /// <summary>
        /// 初始化listview，查询出没有被指定过人员的账户
        /// </summary>
        /// <param name="lv"></param>
        public static void initListViewDataForUser(ListView lv)
        {
            Rbac_user userParam = new Rbac_user();
            userParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<object> objectList = userBLL.getListContactObject(userParam, null, null);
            List<Rbac_user> data_list = (List<Rbac_user>)objectList[0];
            //准备listview的列
            ColumnHeader chIndex = new ColumnHeader();
            ColumnHeader chZhm = new ColumnHeader();
            ColumnHeader chZhlx = new ColumnHeader();
            ColumnHeader chZhbz = new ColumnHeader();
            chIndex.Text = "索引";
            chZhm.Text = "账户名";
            chZhlx.Text = "账户类型";
            chZhbz.Text = "备注";
            lv.Columns.Add(chIndex);
            lv.Columns.Add(chZhm);
            lv.Columns.Add(chZhlx);
            lv.Columns.Add(chZhbz);
            for (int i = 0; i < data_list.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = i.ToString();
                listItem.SubItems.Add(data_list[i].Name);
                listItem.SubItems.Add(data_list[i].LxCode.Name);
                listItem.SubItems.Add(data_list[i].Remark);
                listItem.Tag = data_list[i];
                lv.Items.Add(listItem);//列值添加进listview
            }

        }


        /// <summary>
        /// 得到当前选中项的关联数据对象
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        public static object getCurrentListViewItem(SkinListView lv)
        {
            if (lv.SelectedItems.Count > 1)
            {
                throw new Exception("不允许选择多行");
            }

            return lv.SelectedItems[0].Tag;
        }

        /// <summary>
        /// 设置控件中作废标志为禁用的行的前景色（颜色配置在配置文件中）
        /// </summary>
        /// <param Name="dgv"></param>
        public static void setForeColorForControl(ListView lv)
        {
            System.Drawing.Color color = AppConfigHelper.getDisableForeColor();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                Model.Base.IBaseModel model = (Model.Base.IBaseModel)lv.Items[i].Tag;
                if (model.Zfbz == Model.Common.CommonCode.代码值_作废标志代码值.禁用)//如果作废
                {
                    for (int j = 0; j < lv.Items[i].SubItems.Count; j++)
                    {
                        lv.Items[i].SubItems[j].ForeColor = color;
                    }
                }

            }
        }


    }
}

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
using BLL.Common;
using BLL.JC.基础_代码字典;
using BLL.JC.代码;
using System.Collections;
using System.Reflection;

namespace client.Common
{
    public class SkinDataGridViewHelper
    {
        public static readonly string checkBox列名称 = "checkBox";

        private static CommonBLL commonBll = new CommonBLLImp();

        private static Jc_codeBLL jc_codeBll = new Jc_codeBLLImp();
        private static  CodeBLL codeBll = new CodeBLLImp();





        /// <summary>
        /// 初始化datagridview的一些参数(开始运行)
        /// </summary>
        /// <param name="dgv"></param>
        public static void initDataGridView(SkinDataGridView dgv)
        {
            dgv.MultiSelect = false;//禁止选择多个行
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//点击整行选取
            dgv.ClearSelection();//取消选择当前行
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgv.BackgroundColor = System.Drawing.Color.White;//datagridview背景色
            //单元格样式
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowTemplate.Height = 50;


            //skin特有属性
            dgv.TitleBackColorEnd = SystemColors.ActiveCaption;//标题行背景色
        }




        /// <summary>
        /// 初始化datagridview完成后处理一些末尾事情
        /// </summary>
        /// <param name="dgv"></param>
        public static void endDataGridView(SkinDataGridView dgv)
        {
            dgv.ClearSelection();
            setForeColorForControl(dgv);
        }

        /// <summary>
        /// 为datagridview绑定数据(为解决绑定数量0的list的BUG)
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="data"></param>
        public static void bindingList(SkinDataGridView dgv, object obj)
        {
            IList ilist = (IList)obj;

            if (ilist != null && ilist.Count > 0)//如果list不为null，数量大于1才绑定
            {
                dgv.DataSource = ilist;
                //所有列设为禁用
                Type type = ilist[0].GetType();
                foreach (PropertyInfo pi in type.GetProperties())
                {
                    string name = pi.Name;//获得属性名字
                    dgv.Columns[name].ReadOnly = true;
                }
            }
            else if (ilist != null && ilist.Count == 0)//如果list不为null,数量等于0，控件的数据源置为null
            {
                dgv.DataSource = null;
                dgv.Columns.Clear();//清空新增的列头
            }
        }


        /// <summary>
        /// 为datagridview绑定数据(为解决绑定数量0的list的BUG)
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="data"></param>
        public static void bindingListForCheckBox(SkinDataGridView dgv, object obj)
        {
            IList ilist = (IList)obj;

            if (ilist != null && ilist.Count > 0)//如果list不为null，数量大于1才绑定
            {
                dgv.DataSource = ilist;
                //所有列设为禁用
                Type type = ilist[0].GetType();
                foreach (PropertyInfo pi in type.GetProperties())
                {
                    string name = pi.Name;//获得属性名字
                    dgv.Columns[name].ReadOnly = true;
                }
            }
            else if (ilist != null && ilist.Count == 0)//如果list不为null,数量等于0，控件的数据源置为null
            {
                dgv.DataSource = null;
                dgv.Columns.Clear();//清空新增的列头
            }
        }
        /// <summary>
        /// 为datagridview添加checkBox
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="data"></param>
        public static void addCheckBox(SkinDataGridView dgv)
        {
            if (dgv.DataSource==null)
            {
                return;
            }
            if (dgv.Columns[checkBox列名称] == null)
            {
                //添加checkbox
                DataGridViewCheckBoxColumn dgvCheckBoxColumn = new DataGridViewCheckBoxColumn();
                dgvCheckBoxColumn.ReadOnly = false;
                dgvCheckBoxColumn.HeaderText = "选择";
                dgvCheckBoxColumn.Name = checkBox列名称;
                dgvCheckBoxColumn.DisplayIndex = 0;
                dgv.Columns.Add(dgvCheckBoxColumn);

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells[checkBox列名称].Value = false;
                }
            }

        }


        /// <summary>
        /// 传入一个bool值，指示是否重构list对象,相对牺牲效率（为解决datagridview绑定过list后，在list中增加元素，datagridview不会增加的问题）
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="obj"></param>
        /// <param name="isResetList"></param>
        public static void bindingList(SkinDataGridView dgv, object obj,bool isResetList)
        {
            IList ilist = (IList)obj;
            if (ilist != null && ilist.Count > 0)//如果list不为null，数量大于1才绑定
            {
                if (isResetList)
                {
                    ilist = resetList(ilist);
                }
                dgv.DataSource = ilist;

            }
            else if (ilist != null && ilist.Count == 0)//如果list不为null,数量等于0，控件的数据源置为null
            {
                dgv.DataSource = null;
                dgv.Columns.Clear();//清空新增的列头
            }
        }

        /// <summary>
        /// 重构List对象，重新new一个，如果在原来的基础上增加，datagridview控件不会刷新数据
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList resetList(IList list)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            object obj = list.GetType().Assembly.CreateInstance(list.GetType().FullName);
            IList newList = (IList)obj;
            foreach (var item in list)
            {
                newList.Add(item);
            }
            return newList;
        }

        /// <summary>
        /// 指定一个datagridview，把保存对象的列隐藏，新建一列，把对象中需要显示的值显示出来
        /// </summary>
        /// <param Name="dv">指定datagridview对象</param>
        /// <param Name="hiddenColumnName">需要转换的对象列名</param>
        /// <param Name="newColumnName">新列的name(取值用的名称)</param>
        ///<param Name="newColumnText">新列的text(在界面上显示的名称)</param>
        ///<param Name="newColumnText">转换的列所保存的实体对象类名</param>
        public static void dataGridViewObjectConvertToValue(SkinDataGridView dv, string hiddenColumnName, string newColumnName, string newColumnText, string objectTypeName)
        {
            if (dv.DataSource == null)//如果数据源是null，就不新增转换的字段
            {
                return;
            }
            dv.Columns[hiddenColumnName].Visible = false;//隐藏对象列
            if (dv.Columns[newColumnName] == null)//如果新的列名不存在才可以添加新列
            {
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                DataGridViewColumn column = new DataGridViewColumn(cell);
                column.Name = newColumnName;//设置列的键名
                column.HeaderText = newColumnText;//设置列显示出来的名称
                column.ReadOnly = true;//新增的列只读
                dv.Columns.Add(column);

            }
            switch (objectTypeName)
            {
                case CommonCode.实体类名称.基础_代码类型字典实体类名:
                    {
                        //循环从codeType中把name取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Jc_code_type codeType = (Jc_code_type)dv.Rows[i].Cells[hiddenColumnName].Value;
                            dv.Rows[i].Cells[newColumnName].Value = codeType.Name;
                        }
                    } break;
                case CommonCode.实体类名称.基础_代码字典实体类名:
                    {
                        //循环从code中把name取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Jc_code Code = (Jc_code)dv.Rows[i].Cells[hiddenColumnName].Value;
                            dv.Rows[i].Cells[newColumnName].Value = Code.Name;
                        }
                    } break;
                case CommonCode.实体类名称.基础_科室实体类名:
                    {
                        //循环从keswh对象中把ksmc取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Jc_kswh kswh = (Jc_kswh)dv.Rows[i].Cells[hiddenColumnName].Value;
                            dv.Rows[i].Cells[newColumnName].Value = kswh.Ksmc;
                        }
                    } break;
                case CommonCode.实体类名称.基础_工作人员实体类名:
                    {
                        //循环从renyuan对象中把xm取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Jc_renyuan renyuan = (Jc_renyuan)dv.Rows[i].Cells[hiddenColumnName].Value;
                            dv.Rows[i].Cells[newColumnName].Value = renyuan.Xm;
                        }
                    } break;
                case CommonCode.实体类名称.RBAC_用户实体类名:
                    {
                        //循环从user对象中把zh取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Rbac_user user = (Rbac_user)dv.Rows[i].Cells[hiddenColumnName].Value;
                            dv.Rows[i].Cells[newColumnName].Value = user.Name;
                        }
                    } break;
                case CommonCode.实体类名称.基础_居民实体类名:
                    {
                        //循环从user对象中把zh取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Jc_jm jm = (Jc_jm)dv.Rows[i].Cells[hiddenColumnName].Value;
                            switch (newColumnName)
                            {
                                case "jm_xm":
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = jm.Xm;

                                    } break;
                                case "jm_xb":
                                    {
                                        if (jm.XbCode==null)
                                        {
                                            dv.Rows[i].Cells[newColumnName].Value = codeBll.getCodeByValue(jm.Xb_code, CommonCode.代码类型值.性别类型值).Name;
                                        }
                                        else
                                        {
                                            dv.Rows[i].Cells[newColumnName].Value = jm.XbCode.Name;
                                        }

                                    } break;
                                case "jm_sfzh":
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = jm.Sfzh;
                                    } break;
                                case "jm_lxdh":
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = jm.Lxdh;
                                    } break;
                                case "jm_age"://年龄，根据出生日期与当前日期算出
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = DateTimePickerHelper.getAgeForYear((DateTime)jm.Csrq);
                                    } break;
                                default:
                                    {
                                        throw new Exception("没有指定要显示" + objectTypeName + "的哪个属性，请到Client.Common.UIHelper类的DataGridViewObjectConvertToValue（）方法中添加");
                                    }
                            }
                        }
                    } break;
                case CommonCode.实体类名称.RBAC_角色实体类名:
                    {
                        //循环从user对象中把zh取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Rbac_role role = (Rbac_role)dv.Rows[i].Cells[hiddenColumnName].Value;
                            switch (newColumnName)
                            {
                                case "rbac_roleName":
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = role.Name;

                                    } break;
                                default:
                                    {
                                        throw new Exception("没有指定要显示" + objectTypeName + "的哪个属性，请到Client.Common.UIHelper类的DataGridViewObjectConvertToValue（）方法中添加");
                                    }
                            }
                        }
                    } break;
                case CommonCode.实体类名称.RBAC_模块实体类名:
                    {
                        //循环从user对象中把zh取出来放到新的一列中，然后添加进每一行中
                        for (int i = 0; i < dv.Rows.Count; i++)
                        {
                            Rbac_modules m = (Rbac_modules)dv.Rows[i].Cells[hiddenColumnName].Value;
                            switch (newColumnName)
                            {
                                case "rbac_modulesName":
                                    {
                                        dv.Rows[i].Cells[newColumnName].Value = m.Name;

                                    } break;
                                default:
                                    {
                                        throw new Exception("没有指定要显示" + objectTypeName + "的哪个属性，请到Client.Common.UIHelper类的DataGridViewObjectConvertToValue（）方法中添加");
                                    }
                            }
                        }
                    } break;
                default:
                    {
                        throw new Exception("暂无" + objectTypeName + "对象的转换实现方法，请到Client.Common.UIHelper类的DataGridViewObjectConvertToValue方法中添加此对象的DataGridViewObjectConvertToValue（）方法实现");
                    }
            }
        }

        /// <summary>
        /// 从datagridview的当前选中行中得到指定的对象
        /// </summary>
        /// <param Name="dgv">datagridview</param>
        /// <param Name="model">指定要返回的实体类的实体对象</param>
        /// <returns>object对象，转换为自己的对象</returns>
        public static object getCurrentDataGridViewItem(SkinDataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                throw new Exception("请至少选择一行数据");
            }
            if (dgv.SelectedRows.Count > 1)
            {
                throw new Exception("此方法不允许dataGridView选择多行");
            }
            object model = dgv.SelectedRows[0].DataBoundItem;
            return model;

            //Type type = model.GetType();
            //foreach (PropertyInfo pi in type.GetProperties())
            //{
            //    //object value = pi.GetValue(modelType);获得属性值
            //    string name = pi.Name;//获得属性名字
            //    pi.SetValue(model, dgv.SelectedRows[0].Cells[name].Value);
            //}
        }

        /// <summary>
        /// 从datagridview的当前选中行的索引
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static int getCurrentDataGridViewItemIndex(SkinDataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                throw new Exception("请至少选择一行数据");
            }
            if (dgv.SelectedRows.Count > 1)
            {
                throw new Exception("此方法不允许dataGridView选择多行");
            }
            return dgv.SelectedRows[0].Index;
        }

        public static object getKeyPreesEnterCurrentDataGridViewItem(SkinDataGridView dgv)
        {
            object model =null;

            if (dgv.SelectedRows.Count == 0)
            {
                throw new Exception("请至少选择一行数据");
            }
            if (dgv.SelectedRows.Count > 1)
            {
                throw new Exception("此方法不允许dataGridView选择多行");
            }
            if (dgv.Rows.Count == 1 || dgv.SelectedRows[0].Index == dgv.Rows.Count - 1)//只有一行数据或者选了最后一行数据
            {
                model = dgv.SelectedRows[0].DataBoundItem;
            }
            else if (dgv.SelectedRows[0].Index==1)//如果是选第一条数据（因为enter后会跳到第二行）
            {
                model = dgv.Rows[dgv.SelectedRows[0].Index - 1].DataBoundItem;
            }
            else
            {
                model = dgv.Rows[ dgv.SelectedRows[0].Index-1].DataBoundItem;
            }
            return model;
        }
        /// <summary>
        /// 设置控件中作废标志为禁用的行的前景色（颜色配置在配置文件中）
        /// </summary>
        /// <param Name="dgv"></param>
        public static void setForeColorForControl(SkinDataGridView dgv)
        {
            System.Drawing.Color color = AppConfigHelper.getDisableForeColor();
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    Model.Base.IBaseModel model = (Model.Base.IBaseModel)item.DataBoundItem;
                    if (CommonCode.代码值_作废标志代码值.禁用 == model.Zfbz)
                    {
                        item.DefaultCellStyle.ForeColor = color;
                    }
                }
            }



        }
    }
}

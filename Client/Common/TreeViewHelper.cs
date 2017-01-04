using BLL.RBAC.RBAC_模块;
using Model.Common;
using Model.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    /// <summary>
    /// 树控件的帮助类
    /// </summary>
    class TreeViewHelper
    {
        public static Rbac_modulesBLL modulesBll = new Rbac_modulesBLLImp();

        /// <summary>
        /// 得到当前选中节点的关联对象
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public static object getCurrentTreeViewNodeItem(TreeView tv)
        {
            if (tv.SelectedNode==null)
            {
                throw new Exception("请至少选择一个节点");
            }
            return tv.SelectedNode.Tag;
        }

        /// <summary>
        /// 递归遍历得到树控件中的所有树节点，传入一个list参数接收
        /// </summary>
        /// <param name="treeViewNodes"></param>
        /// <param name="returnNodes"></param>
        public static void getNodes(TreeNodeCollection treeViewNodes, List<TreeNode> returnNodes)
        {
            if (treeViewNodes.Count == 0)
            {
                return;
            }
            for (int i = 0; i < treeViewNodes.Count; i++)
            {
                TreeNode treeViewNode = treeViewNodes[i];
                returnNodes.Add(treeViewNode);
                getNodes(treeViewNode.Nodes, returnNodes);
            }
        }

        /// <summary>
        /// 设置控件中作废标志为禁用的行的前景色（颜色配置在配置文件中）
        /// </summary>
        /// <param Name="dgv"></param>
        public static void setForeColorForControl(TreeView treeView)
        {
            System.Drawing.Color color = AppConfigHelper.getDisableForeColor();

                List<TreeNode> returnNodes = new List<TreeNode>();
                getNodes(treeView.Nodes, returnNodes);
                for (int i = 0; i < returnNodes.Count; i++)
                {
                    TreeNode node = returnNodes[i];
                    Model.Base.IBaseModel model = (Model.Base.IBaseModel)node.Tag;
                    if (model.Zfbz == CommonCode.代码值_作废标志代码值.禁用)
                    {
                        node.ForeColor = color;
                    }
                }

        }



        /// <summary>
        /// 用模块数据初始化树控件，带一个作废标志的条件，全部显示传null
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="Zfbz"></param>
        public static void initTreeViewForRbac_modules(TreeView treeView, string zfbz)
        {
            treeView.Nodes.Clear();

            Rbac_modules menuModulesParam = new Rbac_modules();
            menuModulesParam.Type_code = CommonCode.RBAC_模块类型.菜单;
            menuModulesParam.Zfbz = zfbz;
            List<SortInfo> menuSortList = new List<SortInfo>();
            menuSortList.Add(new SortInfo(Rbac_modules.SORT));
            List<Rbac_modules> menuModulesList = (List<Rbac_modules>)modulesBll.getListContactObject(menuModulesParam, null, menuSortList)[0];


            Rbac_modules funModulesParam = new Rbac_modules();
            funModulesParam.Type_code = CommonCode.RBAC_模块类型.功能点;
            funModulesParam.Zfbz = zfbz;
            List<SortInfo> funSortList = new List<SortInfo>();
            funSortList.Add(new SortInfo(Rbac_modules.SORT));
            List<Rbac_modules> funModulesParamList = (List<Rbac_modules>)modulesBll.getListContactObject(funModulesParam, null, funSortList)[0];



            for (int i = 0; i < menuModulesList.Count; i++)
            {
                TreeNode menuNode = new TreeNode();
                Rbac_modules menuModules = menuModulesList[i];
                menuNode.Text = menuModules.Name;
                menuNode.Tag = menuModules;

                for (int j = 0; j < funModulesParamList.Count; j++)
                {
                    Rbac_modules funModules = funModulesParamList[j];
                    if (menuModules.Id == funModules.Pid)
                    {
                        TreeNode funNode = new TreeNode();
                        funNode.Text = funModules.Name;
                        funNode.Tag = funModules;
                        menuNode.Nodes.Add(funNode);
                    }
                }
                treeView.Nodes.Add(menuNode);
            }

            TreeViewHelper.setForeColorForControl(treeView);
        }
    }
}

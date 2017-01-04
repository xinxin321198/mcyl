using Model.YPKC;
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
using BLL.YPKC.药品库存_单据主表;
using BLL.YPKC.药品库存_单据子表;
using BLL.YPKC.药品入库;
using client.JC.药品管理;
using BLL.JC.基础_科室;
using client.YPKC.Common;

namespace client.YPKC.药品入库
{
    public partial class YpRuKuEdit : Form
    {
        private Jc_kswhBLL jc_ksBLL = new Jc_kswhBLLImp();
        private Ypkc_RuKuBLL rukuBll = new Ypkc_RuKuBLLImp();
        private Ypkc_djmxBLL djmxBll = new Ypkc_djmxBLLImp();
        private Jc_renyuan workRenyuan = null;//打开此窗体的工作人员

        private Ypkc_dj oldDj = null;

        private Jc_code djLx = null;//新增，打开此窗体时候的开单类型
        private Jc_code ypLx = null;//新增，开单的药品类型 

        List<Ypkc_djmx> djmxList = new List<Ypkc_djmx>();
        private Ypkc_djmx oldDjmx = null;//修改时候的单据明细
        private int oldDjMxIndex = -1;

        //药品选择
        YpSearch ypSearch = new YpSearch();
        private Jc_yp selectedYp = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workRenyuan"></param>
        /// <param name="djLx">单据类型</param>
        public YpRuKuEdit(Jc_renyuan workRenyuan, Jc_code djLx, Jc_code ypLx)
        {
            this.workRenyuan = workRenyuan;
            this.djLx = djLx;
            this.ypLx = ypLx;
            InitializeComponent();
            this.initUI();

        }
        public YpRuKuEdit( Jc_renyuan workRenyuan,Ypkc_dj oldDj)
        {
            this.oldDj = oldDj;
            this.djLx = this.oldDj.DjlxCode;
            this.workRenyuan = workRenyuan;
            InitializeComponent();
            this.initUI();

        }

        private void YpEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.oldDj!=null)
                {
                    this.label_number.Text = "NO." + this.oldDj.Djh;
                    label_djlx.Text = this.oldDj.YpflCode.Name + this.oldDj.DjlxCode.Name;
                    this.ypLx = this.oldDj.YpflCode;
                    skinComboBox_供应商.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_供应商, this.oldDj.Fk_lygys, CommonCode.实体类名称.基础_供应商实体类名);
                    skinComboBox_收货科室.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_收货科室, this.oldDj.Fk_mdks, CommonCode.实体类名称.基础_科室实体类名);
                    skinComboBox_采购方式.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_采购方式, this.oldDj.Caigoufs_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinComboBox_配送方式.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_配送方式, this.oldDj.Peisongfs_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinComboBox_验收.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_验收, this.oldDj.Yanshou_code, CommonCode.实体类名称.基础_代码字典实体类名);
                    rtfRichTextBox_remark.Text = this.oldDj.Remark;

                    Ypkc_djmx djmx = new Ypkc_djmx();
                    djmx.Fk_dj_id = this.oldDj.Id;
                    this.djmxList = (List<Ypkc_djmx>)djmxBll.getList(djmx, null, null)[0];


                    if (this.oldDj.Jzzt_code == CommonCode.代码值_是否.是)//已经记账，不允许修改和多次记账
                    {
                        skinButton_save.Enabled = false;
                        skinButton_记账.Enabled = false;
                        skinButton_ypAdd.Enabled = false;
                    }
                    else
                    {
                        skinButton_save.Enabled = true;
                        skinButton_记账.Enabled = true;
                    }
                    this.initDataGridView();
                }
                else//新增打开
                {
                    label_djlx.Text = this.ypLx.Name + this.djLx.Name;

                }
                    
                

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        private void initUI()
        {
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(skinButton_save, skinButton_ypAdd, skinButton_记账);
            LabelHelper.initTitleLabel(label_djlx, label_number, label_ypxx);


            ComboBoxHelper.initComboBoxForGys(skinComboBox_供应商, null, CommonCode.代码值_作废标志代码值.启用);

            //初始化有药库标志的科室
            Jc_kswh ksParam = new Jc_kswh();
            ksParam.Ykbz_code = CommonCode.代码值_勾叉.勾;
            ComboBoxHelper.initComboBoxForKswh(skinComboBox_收货科室,ksParam,CommonCode.代码值_作废标志代码值.启用);

            ComboBoxHelper.initComboBoxForCode(skinComboBox_采购方式, CommonCode.代码类型值.库存_采购方式, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_配送方式, CommonCode.代码类型值.库存_配送方式, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_验收, CommonCode.代码类型值.库存_验收, CommonCode.代码值_作废标志代码值.启用);


            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);

            textBox_制单人姓名.ReadOnly = true;
            //查询得到当前登录用户所属的人员名称
            textBox_制单人姓名.Text = this.workRenyuan.Xm;



            //药品信息
            textBox_包装单位.ReadOnly = true;
            textBox_换算比例.ReadOnly = true;
            textBox_批准文号.ReadOnly = true;
            textBox_药品编号.ReadOnly = true;
            textBox_药品名称.ReadOnly = true;
            textBox_国药准字.ReadOnly = true;
            textBox_剂型.ReadOnly = true;
            textBox_药品规格.ReadOnly = true;
            textBox_生产厂家.ReadOnly = true;
            textBox_进价总金额.ReadOnly = true;
            textBox_零售价总金额.ReadOnly = true;
            textBox_发药单位.ReadOnly = true;


            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_进价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_零售价, NumericUpDownHelper.数值控件模式.三位小数);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_数量, NumericUpDownHelper.数值控件模式.整型);
            textBox_进价总金额.Text = "0";
            textBox_零售价总金额.Text = "0";

            skinButton_记账.Enabled = false;

            
        }


        private void initDataGridView()
        {
            SkinDataGridViewHelper.bindingList(skinDataGridView1,this.djmxList,true);
            if (skinDataGridView1.DataSource==null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView1.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView1.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView1.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView1.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView1.Columns[Ypkc_djmx.ID].Visible = false;//主键
            skinDataGridView1.Columns[Ypkc_djmx.ID].HeaderText = "主键";

            skinDataGridView1.Columns[Ypkc_djmx.DJH].Visible = false;//所属入库单据流水号
            skinDataGridView1.Columns[Ypkc_djmx.DJH].HeaderText = "所属入库单据流水号";

            skinDataGridView1.Columns[Ypkc_djmx.FK_DJ_ID].Visible = false;//单据主表记录外键（关联单据主表）
            skinDataGridView1.Columns[Ypkc_djmx.FK_DJ_ID].HeaderText = "单据主表记录外键（关联单据主表）";

            skinDataGridView1.Columns[Ypkc_djmx.FK_YP].Visible = false;//药品字典外键
            skinDataGridView1.Columns[Ypkc_djmx.FK_YP].HeaderText = "药品字典外键";

            //skinDataGridView1.Columns[Ypkc_djmx.YPBH].Visible = false;//药品编号（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.YPBH].HeaderText = "药品编号";

            //skinDataGridView1.Columns[Ypkc_djmx.YPMC].Visible = false;//药品名称（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.YPMC].HeaderText = "药品名称";

            skinDataGridView1.Columns[Ypkc_djmx.YPTYMC].Visible = false;//药品通用名称（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.YPTYMC].HeaderText = "药品通用名称（冗余）";

            //skinDataGridView1.Columns[Ypkc_djmx.DDW].Visible = false;//包装单位，大单位（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.DDW].HeaderText = "大单位";

            //skinDataGridView1.Columns[Ypkc_djmx.XDW].Visible = false;//发药单位，小单位（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.XDW].HeaderText = "小单位";

            skinDataGridView1.Columns[Ypkc_djmx.HSBL].Visible = false;//换算比例（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.HSBL].HeaderText = "换算比例（冗余）";

            //skinDataGridView1.Columns[Ypkc_djmx.PZWH].Visible = false;//批准文号（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.PZWH].HeaderText = "批准文号";

            skinDataGridView1.Columns[Ypkc_djmx.GYZZ].Visible = false;//国药准字（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.GYZZ].HeaderText = "国药准字（冗余）";

            //skinDataGridView1.Columns[Ypkc_djmx.JX].Visible = false;//剂型（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.JX].HeaderText = "剂型";

            //skinDataGridView1.Columns[Ypkc_djmx.YPGG].Visible = false;//药品规格（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.YPGG].HeaderText = "药品规格";

            //skinDataGridView1.Columns[Ypkc_djmx.CJMC].Visible = false;//生产厂家名称（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.CJMC].HeaderText = "生产厂家名称";

            skinDataGridView1.Columns[Ypkc_djmx.PYM].Visible = false;//拼音码（冗余）
            skinDataGridView1.Columns[Ypkc_djmx.PYM].HeaderText = "拼音码（冗余）";

            //skinDataGridView1.Columns[Ypkc_djmx.PH].Visible = false;//批号
            skinDataGridView1.Columns[Ypkc_djmx.PH].HeaderText = "批号";

            skinDataGridView1.Columns[Ypkc_djmx.YXQ].Visible = false;//有效期
            skinDataGridView1.Columns[Ypkc_djmx.YXQ].HeaderText = "有效期";
            skinDataGridView1.Columns[Ypkc_djmx.YXQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView1.Columns[Ypkc_djmx.JJ].Visible = false;//进价
            skinDataGridView1.Columns[Ypkc_djmx.JJ].HeaderText = "进价";

            //skinDataGridView1.Columns[Ypkc_djmx.LSJ].Visible = false;//零售价
            skinDataGridView1.Columns[Ypkc_djmx.LSJ].HeaderText = "零售价";

            //skinDataGridView1.Columns[Ypkc_djmx.SL].Visible = false;//数量
            skinDataGridView1.Columns[Ypkc_djmx.SL].HeaderText = "数量";

            skinDataGridView1.Columns[Ypkc_djmx.JJJE].Visible = false;//进价金额合计
            skinDataGridView1.Columns[Ypkc_djmx.JJJE].HeaderText = "进价金额合计";

            skinDataGridView1.Columns[Ypkc_djmx.LSJJE].Visible = false;//零售价金额合计
            skinDataGridView1.Columns[Ypkc_djmx.LSJJE].HeaderText = "零售价金额合计";

            skinDataGridView1.Columns[Ypkc_djmx.ZFBZ].Visible = false;//作废标志
            skinDataGridView1.Columns[Ypkc_djmx.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end
            SkinDataGridViewHelper.endDataGridView(skinDataGridView1);
        }



        /// <summary>
        /// 校验Ypkc_dj类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Ypkc_dj"></param>
        private void checkYpkc_djIsNull(Ypkc_dj ypkc_dj)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();



            //来源供应商外键（关联供应商表）
            if (null == ypkc_dj.Fk_lygys || "" == ypkc_dj.Fk_lygys)
            {
                flag = true;
                sb.Append("请指定‘来源供应商外键（关联供应商表）’的值\n");
            }

            //来源编号（冗余）
            if (null == ypkc_dj.Lybh || "" == ypkc_dj.Lybh)
            {
                flag = true;
                sb.Append("请指定‘来源编号（冗余）’的值\n");
            }

            //来源名称（冗余）
            if (null == ypkc_dj.Lymc || "" == ypkc_dj.Lymc)
            {
                flag = true;
                sb.Append("请指定‘来源名称（冗余）’的值\n");
            }

            //目的科室外键（关联科室表，药库/药房）
            if (null == ypkc_dj.Fk_mdks || "" == ypkc_dj.Fk_mdks)
            {
                flag = true;
                sb.Append("请指定‘目的科室外键（关联科室表，药库/药房）’的值\n");
            }


            //目的编号（冗余）
            if (null == ypkc_dj.Mdbh || "" == ypkc_dj.Mdbh)
            {
                flag = true;
                sb.Append("请指定‘目的编号（冗余）’的值\n");
            }

            //目的名称（冗余）
            if (null == ypkc_dj.Mdmc || "" == ypkc_dj.Mdmc)
            {
                flag = true;
                sb.Append("请指定‘目的名称（冗余）’的值\n");
            }

            //制单人姓名(冗余)
            if (null == ypkc_dj.Zdr || "" == ypkc_dj.Zdr)
            {
                flag = true;
                sb.Append("请指定‘制单人姓名(冗余)’的值\n");
            }

            //制单人外键
            if (null == ypkc_dj.Fk_renyuan_zdr || "" == ypkc_dj.Fk_renyuan_zdr)
            {
                flag = true;
                sb.Append("请指定‘制单人外键’的值\n");
            }


            //采购方式（关联代码表）
            if (null == ypkc_dj.Caigoufs_code || "" == ypkc_dj.Caigoufs_code)
            {
                flag = true;
                sb.Append("请指定‘采购方式（关联代码表）’的值\n");
            }

            //配送方式（关联代码表）
            if (null == ypkc_dj.Peisongfs_code || "" == ypkc_dj.Peisongfs_code)
            {
                flag = true;
                sb.Append("请指定‘配送方式（关联代码表）’的值\n");
            }

       


            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        /// <summary>
        /// 校验Ypkc_djmx类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Ypkc_djmx"></param>
        private void checkYpkc_djmxIsNull(Ypkc_djmx ypkc_djmx)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

       

            //药品字典外键
            if (null == ypkc_djmx.Fk_yp || "" == ypkc_djmx.Fk_yp)
            {
                flag = true;
                sb.Append("请从药品检索出检索选择一种药品再进行添加\n");
            }

            //药品编号（冗余）
            if (null == ypkc_djmx.Ypbh || "" == ypkc_djmx.Ypbh)
            {
                flag = true;
                sb.Append("请从药品检索出检索选择一种药品再进行添加\n");
            }

            //药品名称（冗余）
            if (null == ypkc_djmx.Ypmc || "" == ypkc_djmx.Ypmc)
            {
                flag = true;
                sb.Append("请指定‘药品名称（冗余）’的值\n");
            }

            //包装单位（冗余）
            if (null == ypkc_djmx.Ddw || "" == ypkc_djmx.Ddw)
            {
                flag = true;
                sb.Append("请指定‘包装单位（冗余）’的值\n");
            }

            //换算比例（冗余）
            if (null == ypkc_djmx.Hsbl || 0 == ypkc_djmx.Hsbl)
            {
                flag = true;
                sb.Append("请指定‘换算比例（冗余）’的值\n");
            }

            //批准文号（冗余）
            if (null == ypkc_djmx.Pzwh || "" == ypkc_djmx.Pzwh)
            {
                flag = true;
                sb.Append("请指定‘批准文号（冗余）’的值\n");
            }

            //国药准字（冗余）
            if (null == ypkc_djmx.Gyzz || "" == ypkc_djmx.Gyzz)
            {
                flag = true;
                sb.Append("请指定‘国药准字（冗余）’的值\n");
            }

            //剂型（冗余）
            if (null == ypkc_djmx.Jx || "" == ypkc_djmx.Jx)
            {
                flag = true;
                sb.Append("请指定‘剂型（冗余）’的值\n");
            }

            //药品规格（冗余）
            if (null == ypkc_djmx.Ypgg || "" == ypkc_djmx.Ypgg)
            {
                flag = true;
                sb.Append("请指定‘药品规格（冗余）’的值\n");
            }

            //生产厂家名称（冗余）
            if (null == ypkc_djmx.Cjmc || "" == ypkc_djmx.Cjmc)
            {
                flag = true;
                sb.Append("请指定‘生产厂家名称（冗余）’的值\n");
            }

            //批号
            if (null == ypkc_djmx.Ph || "" == ypkc_djmx.Ph)
            {
                flag = true;
                sb.Append("请指定‘批号’的值\n");
            }

            //有效期
            if (null == ypkc_djmx.Yxq || DateTime.MinValue == ypkc_djmx.Yxq)
            {
                flag = true;
                sb.Append("请指定‘有效期’的值\n");
            }

            //进价
            if (null == ypkc_djmx.Jj || 0 == ypkc_djmx.Jj)
            {
                flag = true;
                sb.Append("请指定‘进价’的值\n");
            }

            //零售价
            if (null == ypkc_djmx.Lsj || 0 == ypkc_djmx.Lsj)
            {
                flag = true;
                sb.Append("请指定‘零售价’的值\n");
            }

            //数量
            if (null == ypkc_djmx.Sl || 0 == ypkc_djmx.Sl)
            {
                flag = true;
                sb.Append("请指定‘数量’的值\n");
            }

            //进价金额合计
            if (null == ypkc_djmx.Jjje || 0 == ypkc_djmx.Jjje)
            {
                flag = true;
                sb.Append("请指定‘进价金额合计’的值\n");
            }

            //零售价金额合计
            if (null == ypkc_djmx.Lsjje || 0 == ypkc_djmx.Lsjje)
            {
                flag = true;
                sb.Append("请指定‘零售价金额合计’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }



        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {

                Ypkc_dj djSave = new Ypkc_dj();
                //入库，来源供应商
                djSave.Fk_lygys = Jc_gys.ConvertToJc_gys(skinComboBox_供应商.SelectedItem).Id;
                djSave.Lybh = Jc_gys.ConvertToJc_gys(skinComboBox_供应商.SelectedItem).Gysbh;
                djSave.Lymc = Jc_gys.ConvertToJc_gys(skinComboBox_供应商.SelectedItem).Gysmc;
                //目的，科室
                djSave.Fk_mdks = Jc_kswh.ConvertToJc_kswh(skinComboBox_收货科室.SelectedItem).Id;
                djSave.Mdbh = Jc_kswh.ConvertToJc_kswh(skinComboBox_收货科室.SelectedItem).Ksbh;
                djSave.Mdmc = Jc_kswh.ConvertToJc_kswh(skinComboBox_收货科室.SelectedItem).Ksmc;
                //制单人
                djSave.Zdr = this.workRenyuan.Xm;
                djSave.Fk_renyuan_zdr = this.workRenyuan.Id;


                djSave.Remark = rtfRichTextBox_remark.Text.Trim();

                djSave.Caigoufs_code = Jc_code.ConvertToJc_code(skinComboBox_采购方式.SelectedItem).Value;

                djSave.Peisongfs_code = Jc_code.ConvertToJc_code(skinComboBox_配送方式.SelectedItem).Value;

                djSave.Yanshou_code = Jc_code.ConvertToJc_code(skinComboBox_验收.SelectedItem).Value;

                djSave.Djlx_code = CommonCode.药品库存_单据类型.入库;//单据类型为“入库”
                djSave.Ypfl_code = this.ypLx.Value;//药品类型
                djSave.Jzzt_code = CommonCode.代码值_是否.否;//是否记账为“否”
                djSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;


                this.checkYpkc_djIsNull(djSave);
                if (this.djmxList.Count==0)
                {
                    throw new Exception("请添加至少一条药品信息");
                }
                bool falg = false;
                if (this.oldDj == null)//新增
                {
                    falg = rukuBll.addRuKuDj(djSave,this.djmxList);//新增一个入库单
                }
                else//修改
                {
                    if (this.oldDj.Jzzt_code == CommonCode.代码值_是否.是)
                    {
                        throw new Exception("此单据已经记账，不允许修改");
                    }
                    djSave.Id = this.oldDj.Id;
                    djSave.Djh = this.oldDj.Djh;
                    falg = rukuBll.modifyRuKuDj(djSave, this.djmxList);

                }

                if (falg)
                {
                    MyMessageBox.Show("保存成功");
                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("保存失败");

                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void skinButton_ypAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ypkc_djmx djmxSave = new Ypkc_djmx();

                djmxSave.Ph = textBox_批号.Text.Trim();
                djmxSave.Yxq = (DateTime?)this.dateTimePicker_有效期.Value;
                djmxSave.Jj = (decimal?)this.skinNumericUpDown_进价.Value;
                djmxSave.Lsj = (decimal?)this.skinNumericUpDown_零售价.Value;
                djmxSave.Sl = (decimal?)this.skinNumericUpDown_数量.Value;
                djmxSave.Jjje = Convert.ToDecimal(this.textBox_进价总金额.Text);
                djmxSave.Lsjje = Convert.ToDecimal(this.textBox_零售价总金额.Text);
                djmxSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;


                if (this.oldDjmx == null)//新增
                {
                    if (this.selectedYp==null)
                    {
                        return;
                    }
                    djmxSave.Fk_yp = this.selectedYp.Id;//主键
                    djmxSave.Ypbh = this.selectedYp.Ypbm;//药品编号
                    djmxSave.Ypmc = this.selectedYp.Ypmc;//药品名称
                    djmxSave.Yptymc = this.selectedYp.Yptymc;//药品通用名称
                    djmxSave.Ddw = this.selectedYp.DdwCode.Name;//药品包装单位
                    djmxSave.Xdw = this.selectedYp.XdwCode.Name;//发药单位（小单位）
                    djmxSave.Hsbl = this.selectedYp.Hsbl;//换算比例
                    djmxSave.Pzwh = this.selectedYp.Yppzwh;//药品批准文号
                    djmxSave.Gyzz = this.selectedYp.Gyzz;//国药准字
                    djmxSave.Jx = this.selectedYp.YpjxCode.Name;//剂型
                    djmxSave.Ypgg = this.selectedYp.Ypgg;//规格
                    djmxSave.Cjmc = this.selectedYp.Scqy;//生产厂商
                    djmxSave.Pym = this.selectedYp.Pym;//拼音码
                    this.checkYpkc_djmxIsNull(djmxSave);


                    YpkcCommon.checkDjmxIsRepeat(djmxSave, djmxList, this.oldDjMxIndex);
                    djmxList.Add(djmxSave);
                }
                else//修改
                {
                    if (djmxList.Count == 0)//可能双击了准备修改数据时，再把这条数据删了，才来保存
                    {
                        return;
                    }
                    djmxSave.Fk_yp = this.oldDjmx.Fk_yp;//主键
                    djmxSave.Ypbh = this.oldDjmx.Ypbh;//药品编号
                    djmxSave.Ypmc = this.oldDjmx.Ypmc;//药品名称
                    djmxSave.Yptymc = this.oldDjmx.Yptymc;//药品通用名称
                    djmxSave.Ddw = this.oldDjmx.Ddw;//药品包装单位
                    djmxSave.Xdw = this.oldDjmx.Xdw;//发药单位（小单位）
                    djmxSave.Hsbl = this.oldDjmx.Hsbl;//换算比例
                    djmxSave.Pzwh = this.oldDjmx.Pzwh;//药品批准文号
                    djmxSave.Gyzz = this.oldDjmx.Gyzz;//国药准字
                    djmxSave.Jx = this.oldDjmx.Jx;//剂型
                    djmxSave.Ypgg = this.oldDjmx.Ypgg;//规格
                    djmxSave.Cjmc = this.oldDjmx.Cjmc;//生产厂商
                    djmxSave.Pym = this.oldDjmx.Pym;//拼音码

                    YpkcCommon.checkDjmxIsRepeat(djmxSave, djmxList,this.oldDjMxIndex);


                    djmxList[this.oldDjMxIndex] = djmxSave;
                }

                this.initDataGridView();
                this.clearYpUI();
                this.skinButton_记账.Enabled = false;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
          

        }


        private void clearYpUI()
        {
            this.selectedYp = null;
            this.oldDjmx = null;
            this.oldDjMxIndex = -1;
            textBox_包装单位.Clear();
            textBox_发药单位.Clear();
            textBox_换算比例.Clear();
            textBox_批准文号.Clear();
            textBox_药品编号.Clear(); 
            textBox_药品名称.Clear(); 
            textBox_国药准字.Clear();
            textBox_剂型.Clear();
            textBox_药品规格.Clear();
            textBox_生产厂家.Clear();
            textBox_批号.Clear();
            skinNumericUpDown_进价.Value = 0;
            skinNumericUpDown_零售价.Value = 0;
            skinNumericUpDown_数量.Value = 0;
            textBox_进价总金额.Text = "0";
            textBox_零售价总金额.Text="0";
            skinButton_ypAdd.Text = "添加";
        }

        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.djmxList.RemoveAt(SkinDataGridViewHelper.getCurrentDataGridViewItemIndex(skinDataGridView1));
                SkinDataGridViewHelper.bindingList(skinDataGridView1, djmxList,true);
                this.clearYpUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

   

        private void skinNumericUpDown_数量_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_进价总金额.Text = YpkcCommon.figure_jjje(skinNumericUpDown_进价.Value, skinNumericUpDown_数量.Value).ToString();
                textBox_零售价总金额.Text = YpkcCommon.figure_lsjje(skinNumericUpDown_零售价.Value, skinNumericUpDown_数量.Value).ToString();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinNumericUpDown_零售价_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_零售价总金额.Text = YpkcCommon.figure_lsjje(skinNumericUpDown_零售价.Value, skinNumericUpDown_数量.Value).ToString();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinNumericUpDown_进价_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_进价总金额.Text = YpkcCommon.figure_jjje(skinNumericUpDown_进价.Value, skinNumericUpDown_数量.Value).ToString();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

      

        private void skinButton_记账_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(@"是否要对此单据进行记账，记账后的单据不允许修改和删除", "提示", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    bool flag = rukuBll.jizhangRuKuDjById(this.oldDj.Id);
                    if (flag)
                    {
                        MyMessageBox.Show("记账成功，药品库存已增加");
                        this.skinButton_记账.Enabled = false;
                        this.skinButton_save.Enabled = false;
                        this.skinButton_ypAdd.Enabled = false;
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.Show("记账失败");
                    }
                }
              
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void textBox_queryString_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ypSearch.YpflCode = this.ypLx;//药品的类型
                ypSearch.QueryString = textBox_queryString.Text.Trim();
                if (ypSearch.QueryString == null || ypSearch.QueryString == "")
                {
                    return;
                }
                if (!ypSearch.Visible)
                {
                    ypSearch.ShowDialog();
                    
                }
                textBox_queryString.Clear();
                if (ypSearch.SelectedYp != null)
                {
                    this.oldDjmx = null;
                    this.selectedYp = ypSearch.SelectedYp;
                    textBox_包装单位.Text = this.selectedYp.DdwCode.Name;
                    textBox_发药单位.Text = this.selectedYp.XdwCode.Name;
                    textBox_换算比例.Text = this.selectedYp.Hsbl.ToString();
                    textBox_批准文号.Text = this.selectedYp.Yppzwh;
                    textBox_药品编号.Text = this.selectedYp.Ypbm;
                    textBox_药品名称.Text = this.selectedYp.Ypmc;
                    textBox_国药准字.Text = this.selectedYp.Gyzz;
                    textBox_剂型.Text = this.selectedYp.YpjxCode.Name;
                    textBox_药品规格.Text = this.selectedYp.Ypgg;
                    textBox_生产厂家.Text = this.selectedYp.Scqy;


                    //重置，手动填写
                    skinNumericUpDown_进价.Value = 0;
                    skinNumericUpDown_零售价.Value = 0;
                    skinNumericUpDown_数量.Value = 0;
                    textBox_进价总金额.Text = "0";
                    textBox_零售价总金额.Text = "0";
                    skinButton_ypAdd.Text = "添加";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }

        private void skinDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.modifyDjMx();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void modifyDjMx()
        {
            this.oldDjmx = (Ypkc_djmx)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView1);
            this.oldDjMxIndex = skinDataGridView1.SelectedRows[0].Index;
            textBox_包装单位.Text = this.oldDjmx.Ddw;
            textBox_发药单位.Text = this.oldDjmx.Xdw;
            textBox_换算比例.Text = Convert.ToString(this.oldDjmx.Hsbl);
            textBox_批准文号.Text = this.oldDjmx.Pzwh;
            textBox_药品编号.Text = this.oldDjmx.Ypbh;
            textBox_药品名称.Text = this.oldDjmx.Ypmc;
            textBox_国药准字.Text = this.oldDjmx.Gyzz;
            textBox_剂型.Text = this.oldDjmx.Jx;
            textBox_药品规格.Text = this.oldDjmx.Ypgg;
            textBox_生产厂家.Text = this.oldDjmx.Cjmc;
            textBox_批号.Text = this.oldDjmx.Ph;
            dateTimePicker_有效期.Value = (DateTime)this.oldDjmx.Yxq;
            skinNumericUpDown_进价.Value = (decimal)this.oldDjmx.Jj;
            skinNumericUpDown_零售价.Value = (decimal)this.oldDjmx.Lsj;
            skinNumericUpDown_数量.Value = (decimal)this.oldDjmx.Sl;
            textBox_进价总金额.Text = Convert.ToString(this.oldDjmx.Jjje);
            textBox_零售价总金额.Text = Convert.ToString(this.oldDjmx.Lsjje);

            skinButton_ypAdd.Text = "保存修改";
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.modifyDjMx();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }




    }
}

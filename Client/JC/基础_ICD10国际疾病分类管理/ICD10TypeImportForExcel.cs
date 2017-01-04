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
using BLL.JC.基础_IDC10疾病种类;
using Model.Common;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10TypeImportForExcel : Form
    {

        private Jc_icd10_typeBLL jc_icd10_typeBll = new Jc_icd10_typeBLLImp();
        private List<Jc_icd10_type> jc_icd10_typeList = new List<Jc_icd10_type>();
        public ICD10TypeImportForExcel()
        {
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_import,skinButton_openFile);
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    List<List<string>> stringList = NpoiHelper.importExcelFormExcel(fileName, 4);
                    jc_icd10_typeList = NpoiHelper.stringlistConvertToJc_icd10_typeList(stringList);
                    for (int i = 0; i < jc_icd10_typeList.Count; i++)
                    {
                        jc_icd10_typeList[i].Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    }
                    SkinDataGridViewHelper.bindingList(skinDataGridView1, jc_icd10_typeList);

                    this.label3.Text = jc_icd10_typeList.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            finally
            {
                openFileDialog1.Dispose();

            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = jc_icd10_typeBll.inertList(this.jc_icd10_typeList);
                if (flag)
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

        private void ICD10ImportForExcel_Load(object sender, EventArgs e)
        {

        }
    }
}

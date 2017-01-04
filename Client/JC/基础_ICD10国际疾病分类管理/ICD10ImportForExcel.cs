using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Common;
using Model.JC;
using client.Common;
using BLL.JC.基础_ICD10;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10ImportForExcel : Form
    {

        private Jc_icd10BLL icd10Bll = new Jc_icd10BLLImp();

        private List<Jc_icd10> icd10List = new List<Jc_icd10>();

        public const int columnsCount = 4;

        public ICD10ImportForExcel()
        {
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(skinButton_import,skinButton_openFile);
        }


        private void ICD10ImportForExcel_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    List<List<string>> stringList = NpoiHelper.importExcelFormExcel(fileName, columnsCount);
                    icd10List = NpoiHelper.stringlistConvertToJc_icd10List(stringList);
                    for (int i = 0; i < icd10List.Count; i++)
                    {
                        icd10List[i].Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    }
                    SkinDataGridViewHelper.bindingList(skinDataGridView1, icd10List);
                    this.label3.Text = icd10List.Count.ToString();
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
                bool flag = icd10Bll.inertList(this.icd10List);
                if (flag)
                {
                    MyMessageBox.Show("插入成功");
                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("插入失败");
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}

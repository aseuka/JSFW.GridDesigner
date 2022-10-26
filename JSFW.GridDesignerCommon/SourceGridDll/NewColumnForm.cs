using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesignerCommon.SourceGridDll
{
    public partial class NewColumnForm : Form
    {
        /// <summary>
        /// 컬럼 추가 방향 0은 앞으로, 1은 뒤로
        /// </summary>
        public int ArrowAddColumn { get; private set; } = 0;

        public string ColumnID { get; set; } = "";
        public string ColumnHeader { get; set; } = "";


        public NewColumnForm()
        {
            InitializeComponent();
        }

        private void btnBeforAdd_Click(object sender, EventArgs e)
        {
            if (ValidationColumnInfo())
            {
                ColumnID = textBox1.Text.Trim();
                ColumnHeader = textBox2.Text.Trim();
                if (string.IsNullOrWhiteSpace(ColumnHeader))
                {
                    ColumnHeader = ColumnID;
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
         
        private void btnAfterAdd_Click(object sender, EventArgs e)
        {
            if (ValidationColumnInfo())
            { 
                ColumnID = textBox1.Text.Trim();
                ColumnHeader = textBox2.Text.Trim();
                if (string.IsNullOrWhiteSpace(ColumnHeader))
                {
                    ColumnHeader = ColumnID;
                }
                ArrowAddColumn = 1;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidationColumnInfo()
        {
            bool isValidate = true;

            ArrowAddColumn = 0;
            ColumnID = "";
            ColumnHeader = "";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("컬럼ID 필수");
                isValidate = false;
            }
            return isValidate;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
    }
}

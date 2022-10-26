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
    public partial class CellEditForm : Form
    {
        public CellEditForm()
        {
            InitializeComponent();
        }

        public string ColumnText
        {
            get { return textBox1.Text.Trim(); }
            set { textBox1.Text = value; }
        }
  
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (0 < textBox1.Text.Length)
            {
                textBox1.SelectAll();
            }
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}

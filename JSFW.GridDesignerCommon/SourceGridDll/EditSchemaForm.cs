using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesigner
{
    public partial class EditSchemaForm : Form
    {
        public string SchemaInfo { get { return txtSchema.Text; } }

        public EditSchemaForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSchema.Text = @"
aaa:에이
bbb:비
ccc:씨
ddd:디".Trim();
        }
    }
}

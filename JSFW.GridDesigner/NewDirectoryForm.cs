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
    public partial class NewDirectoryForm : Form
    {
        public string ProjectText { get; set; } = "";

        public NewDirectoryForm()
        {
            InitializeComponent();
        }

        string _Root { get; set; }
        public NewDirectoryForm(string root) : this()
        {
            _Root = root;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (string.IsNullOrWhiteSpace(_Root))
            {
                MessageBox.Show($@"Root Directory가 등록되지 않아 새 프로젝트를 등록할 수 없습니다.{Environment.NewLine}프로그램을 재시작해 주십시오.");
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text.Trim()))
            {
                MessageBox.Show("새 프로젝트명을 입력하십시오.");
                return;
            }

            string dirPath = _Root + txtProjectName.Text.Trim(System.IO.Path.GetInvalidFileNameChars());

            if (System.IO.Directory.Exists(dirPath))
            {
                MessageBox.Show("이미 존재하는 프로젝트명입니다.");
                return;
            }

            ProjectText = txtProjectName.Text.Trim(System.IO.Path.GetInvalidFileNameChars());
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProjectText = "";
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtProjectName_Enter(object sender, EventArgs e)
        {
            txtProjectName.SelectAll();
        }
    }
}

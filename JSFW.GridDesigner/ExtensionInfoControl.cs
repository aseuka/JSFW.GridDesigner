using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSFW.GridDesignerCommon;

namespace JSFW.GridDesigner
{
    internal partial class ExtensionInfoControl : UserControl
    {
        public event Action<ExtensionInfo> Execute = null;

        private ExtensionInfo Info = null;

        public ExtensionInfoControl()
        {
            InitializeComponent();
            this.Disposed += ExtensionInfoControl_Disposed;
        }

        private void ExtensionInfoControl_Disposed(object sender, EventArgs e)
        {
            Info = null; 
        }

        public void Set(ExtensionInfo info)
        {
            Info = info;

            Display(Info);
        }

        private void Display(ExtensionInfo info)
        {
            if (info == null) return;

            label1.Text = info.Name;
            btnExecute.Text = info.Description;
            btnExecute.Enabled = true;

            if (string.IsNullOrWhiteSpace(info.ErrorMessage) == false)
            {
                btnExecute.Text = info.ErrorMessage;
                btnExecute.Enabled = false;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Execute?.Invoke(Info);
        }
    }
}

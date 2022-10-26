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
    public partial class ColumnMovingSetPoisition : Form
    {
        public MovingPosition MovingPosition { get; set; } = MovingPosition.None;

        public ColumnMovingSetPoisition()
        {
            InitializeComponent();
        }

        bool isShownForm = false;
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            isShownForm = true;
        }

        private void rdoBefore_CheckedChanged(object sender, EventArgs e)
        {
            if (isShownForm && rdoBefore.Checked)
            {
                MovingPosition = MovingPosition.Before;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void rdoAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (isShownForm && rdoAfter.Checked)
            {
                MovingPosition = MovingPosition.After;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public enum MovingPosition
    { 
        None,
        Before,
        After
    }
}

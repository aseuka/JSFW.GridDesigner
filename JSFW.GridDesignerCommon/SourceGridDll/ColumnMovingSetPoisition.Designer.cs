namespace JSFW.GridDesignerCommon.SourceGridDll
{
    partial class ColumnMovingSetPoisition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoBefore = new System.Windows.Forms.RadioButton();
            this.rdoAfter = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoBefore
            // 
            this.rdoBefore.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBefore.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBefore.Location = new System.Drawing.Point(25, 12);
            this.rdoBefore.Name = "rdoBefore";
            this.rdoBefore.Size = new System.Drawing.Size(143, 55);
            this.rdoBefore.TabIndex = 0;
            this.rdoBefore.Text = "앞으로";
            this.rdoBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBefore.UseVisualStyleBackColor = true;
            this.rdoBefore.CheckedChanged += new System.EventHandler(this.rdoBefore_CheckedChanged);
            // 
            // rdoAfter
            // 
            this.rdoAfter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAfter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAfter.Location = new System.Drawing.Point(191, 12);
            this.rdoAfter.Name = "rdoAfter";
            this.rdoAfter.Size = new System.Drawing.Size(143, 55);
            this.rdoAfter.TabIndex = 0;
            this.rdoAfter.Text = "뒤로";
            this.rdoAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAfter.UseVisualStyleBackColor = true;
            this.rdoAfter.CheckedChanged += new System.EventHandler(this.rdoAfter_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ColumnMovingSetPoisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 87);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdoAfter);
            this.Controls.Add(this.rdoBefore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColumnMovingSetPoisition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "위치 지정";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoBefore;
        private System.Windows.Forms.RadioButton rdoAfter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace JSFW.GridDesignerCommon.SourceGridDll
{
    partial class NewColumnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBeforAdd = new System.Windows.Forms.Button();
            this.btnAfterAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "컬럼ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "컬럼 Header";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // btnBeforAdd
            // 
            this.btnBeforAdd.Location = new System.Drawing.Point(293, 24);
            this.btnBeforAdd.Name = "btnBeforAdd";
            this.btnBeforAdd.Size = new System.Drawing.Size(75, 53);
            this.btnBeforAdd.TabIndex = 2;
            this.btnBeforAdd.Text = "앞으로 \r\n추가";
            this.btnBeforAdd.UseVisualStyleBackColor = true;
            this.btnBeforAdd.Click += new System.EventHandler(this.btnBeforAdd_Click);
            // 
            // btnAfterAdd
            // 
            this.btnAfterAdd.Location = new System.Drawing.Point(374, 24);
            this.btnAfterAdd.Name = "btnAfterAdd";
            this.btnAfterAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAfterAdd.TabIndex = 3;
            this.btnAfterAdd.Text = "뒤로\r\n추가";
            this.btnAfterAdd.UseVisualStyleBackColor = true;
            this.btnAfterAdd.Click += new System.EventHandler(this.btnAfterAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 97);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAfterAdd);
            this.Controls.Add(this.btnBeforAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewColumnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "컬럼 끼워넣기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBeforAdd;
        private System.Windows.Forms.Button btnAfterAdd;
        private System.Windows.Forms.Button button3;
    }
}
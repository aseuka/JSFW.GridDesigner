namespace JSFW.GridDesigner
{
    partial class DesignForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid1 = new SourceGrid.Grid();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGetDBSchema = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshExtension = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateExtProject = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lbGridGUID = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid1.EnableSort = false;
            this.grid1.Location = new System.Drawing.Point(12, 64);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(1102, 193);
            this.grid1.TabIndex = 0;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1019, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 51);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(646, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 49);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGetDBSchema
            // 
            this.btnGetDBSchema.Location = new System.Drawing.Point(829, 9);
            this.btnGetDBSchema.Name = "btnGetDBSchema";
            this.btnGetDBSchema.Size = new System.Drawing.Size(110, 49);
            this.btnGetDBSchema.TabIndex = 2;
            this.btnGetDBSchema.Text = "스키마 가져오기";
            this.btnGetDBSchema.UseVisualStyleBackColor = true;
            this.btnGetDBSchema.Click += new System.EventHandler(this.btnGetDBSchema_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1102, 183);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // btnRefreshExtension
            // 
            this.btnRefreshExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshExtension.Location = new System.Drawing.Point(121, 263);
            this.btnRefreshExtension.Name = "btnRefreshExtension";
            this.btnRefreshExtension.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshExtension.TabIndex = 4;
            this.btnRefreshExtension.Text = "새로고침";
            this.btnRefreshExtension.UseVisualStyleBackColor = true;
            this.btnRefreshExtension.Click += new System.EventHandler(this.btnRefreshExtension_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "확장 ( 플러그 인 )";
            // 
            // btnCreateExtProject
            // 
            this.btnCreateExtProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateExtProject.Location = new System.Drawing.Point(202, 264);
            this.btnCreateExtProject.Name = "btnCreateExtProject";
            this.btnCreateExtProject.Size = new System.Drawing.Size(140, 23);
            this.btnCreateExtProject.TabIndex = 6;
            this.btnCreateExtProject.Text = "확장 C# 프로젝트 생성";
            this.btnCreateExtProject.UseVisualStyleBackColor = true;
            this.btnCreateExtProject.Visible = false;
            this.btnCreateExtProject.Click += new System.EventHandler(this.btnCreateExtProject_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(734, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 49);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "초기화";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lbGridGUID
            // 
            this.lbGridGUID.Location = new System.Drawing.Point(121, 9);
            this.lbGridGUID.Name = "lbGridGUID";
            this.lbGridGUID.Size = new System.Drawing.Size(519, 23);
            this.lbGridGUID.TabIndex = 8;
            this.lbGridGUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(274, 36);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(366, 21);
            this.txtFileName.TabIndex = 9;
            this.txtFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFileName_KeyDown);
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "파일명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "GUID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(121, 36);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(147, 20);
            this.cboProject.TabIndex = 10;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1126, 488);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGridGUID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCreateExtProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshExtension);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnGetDBSchema);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grid1);
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "DesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그리드 디자인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SourceGrid.Grid grid1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetDBSchema;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefreshExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateExtProject;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbGridGUID;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProject;
    }
}


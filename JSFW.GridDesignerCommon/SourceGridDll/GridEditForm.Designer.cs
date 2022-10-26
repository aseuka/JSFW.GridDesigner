namespace JSFW.GridDesignerCommon.SourceGridDll
{
    partial class GridEditForm
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
            this.grid1 = new SourceGrid.Grid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGridName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdo_Lv2_일반 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv2_날짜 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv2_코드파인드 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv2_YN = new System.Windows.Forms.RadioButton();
            this.rdo_Lv2_DataMap = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdo_Lv1_문자 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv1_숫자 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv1_콤보 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv1_체크 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkIsVisible = new System.Windows.Forms.CheckBox();
            this.chkIsRequired = new System.Windows.Forms.CheckBox();
            this.chkAllowMerge = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdo_Lv3_일반 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_년월일 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_년월 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_년도 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_N0 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_N1 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_N2 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_N3 = new System.Windows.Forms.RadioButton();
            this.rdo_Lv3_N4 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoAlign_Left = new System.Windows.Forms.RadioButton();
            this.rdoAlign_Center = new System.Windows.Forms.RadioButton();
            this.rdoAlign_Right = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHeaderMinus = new System.Windows.Forms.Button();
            this.btnHeaderPlus = new System.Windows.Forms.Button();
            this.btnReadOnly = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnDelColumn = new System.Windows.Forms.Button();
            this.chkColumnSwap = new System.Windows.Forms.CheckBox();
            this.chkColumnMoving = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCol = new System.Windows.Forms.TextBox();
            this.btnSearchCol = new System.Windows.Forms.Button();
            this.btnVisibleInvert = new System.Windows.Forms.Button();
            this.pnlSCDesign = new System.Windows.Forms.Panel();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.btnSchema = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSUM = new System.Windows.Forms.CheckBox();
            this.chkFrozen = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.pnlSCDesign.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowDrop = true;
            this.grid1.AllowOverlappingCells = true;
            this.grid1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid1.ClipboardMode = ((SourceGrid.ClipboardMode)((((SourceGrid.ClipboardMode.Copy | SourceGrid.ClipboardMode.Cut) 
            | SourceGrid.ClipboardMode.Paste) 
            | SourceGrid.ClipboardMode.Delete)));
            this.tableLayoutPanel1.SetColumnSpan(this.grid1, 9);
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnableSort = false;
            this.grid1.Location = new System.Drawing.Point(3, 59);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForColumns;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(1073, 245);
            this.grid1.TabIndex = 1;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            this.grid1.DragDrop += new System.Windows.Forms.DragEventHandler(this.grid1_DragDrop);
            this.grid1.DragEnter += new System.Windows.Forms.DragEventHandler(this.grid1_DragEnter);
            this.grid1.DragOver += new System.Windows.Forms.DragEventHandler(this.grid1_DragOver);
            this.grid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseDown);
            this.grid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseMove);
            this.grid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.grid1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGridName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchCol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchCol, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVisibleInvert, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSCDesign, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.chkFrozen, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1079, 473);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(343, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(74, 22);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "그리드 ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "컬럼 ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Level2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Level3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGridName
            // 
            this.txtGridName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGridName.Location = new System.Drawing.Point(103, 3);
            this.txtGridName.Name = "txtGridName";
            this.txtGridName.Size = new System.Drawing.Size(234, 21);
            this.txtGridName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(103, 310);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(234, 21);
            this.txtID.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 7);
            this.flowLayoutPanel2.Controls.Add(this.rdo_Lv2_일반);
            this.flowLayoutPanel2.Controls.Add(this.rdo_Lv2_날짜);
            this.flowLayoutPanel2.Controls.Add(this.rdo_Lv2_코드파인드);
            this.flowLayoutPanel2.Controls.Add(this.rdo_Lv2_YN);
            this.flowLayoutPanel2.Controls.Add(this.rdo_Lv2_DataMap);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(100, 361);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(959, 28);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // rdo_Lv2_일반
            // 
            this.rdo_Lv2_일반.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv2_일반.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv2_일반.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv2_일반.Location = new System.Drawing.Point(3, 3);
            this.rdo_Lv2_일반.Name = "rdo_Lv2_일반";
            this.rdo_Lv2_일반.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv2_일반.TabIndex = 6;
            this.rdo_Lv2_일반.Text = "일반";
            this.rdo_Lv2_일반.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv2_일반.UseVisualStyleBackColor = true;
            this.rdo_Lv2_일반.CheckedChanged += new System.EventHandler(this.rdo_Lv2_일반_CheckedChanged);
            // 
            // rdo_Lv2_날짜
            // 
            this.rdo_Lv2_날짜.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv2_날짜.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv2_날짜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv2_날짜.Location = new System.Drawing.Point(89, 3);
            this.rdo_Lv2_날짜.Name = "rdo_Lv2_날짜";
            this.rdo_Lv2_날짜.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv2_날짜.TabIndex = 7;
            this.rdo_Lv2_날짜.Text = "날짜";
            this.rdo_Lv2_날짜.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv2_날짜.UseVisualStyleBackColor = true;
            this.rdo_Lv2_날짜.CheckedChanged += new System.EventHandler(this.rdo_Lv2_날짜_CheckedChanged);
            // 
            // rdo_Lv2_코드파인드
            // 
            this.rdo_Lv2_코드파인드.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv2_코드파인드.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv2_코드파인드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv2_코드파인드.Location = new System.Drawing.Point(175, 3);
            this.rdo_Lv2_코드파인드.Name = "rdo_Lv2_코드파인드";
            this.rdo_Lv2_코드파인드.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv2_코드파인드.TabIndex = 8;
            this.rdo_Lv2_코드파인드.Text = "코드파인드";
            this.rdo_Lv2_코드파인드.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv2_코드파인드.UseVisualStyleBackColor = true;
            this.rdo_Lv2_코드파인드.CheckedChanged += new System.EventHandler(this.rdo_Lv2_코드파인드_CheckedChanged);
            // 
            // rdo_Lv2_YN
            // 
            this.rdo_Lv2_YN.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv2_YN.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv2_YN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv2_YN.Location = new System.Drawing.Point(261, 3);
            this.rdo_Lv2_YN.Name = "rdo_Lv2_YN";
            this.rdo_Lv2_YN.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv2_YN.TabIndex = 9;
            this.rdo_Lv2_YN.Text = "Y|N";
            this.rdo_Lv2_YN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv2_YN.UseVisualStyleBackColor = true;
            this.rdo_Lv2_YN.CheckedChanged += new System.EventHandler(this.rdo_Lv2_YN_CheckedChanged);
            // 
            // rdo_Lv2_DataMap
            // 
            this.rdo_Lv2_DataMap.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv2_DataMap.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv2_DataMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv2_DataMap.Location = new System.Drawing.Point(347, 3);
            this.rdo_Lv2_DataMap.Name = "rdo_Lv2_DataMap";
            this.rdo_Lv2_DataMap.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv2_DataMap.TabIndex = 10;
            this.rdo_Lv2_DataMap.Text = "DataMap";
            this.rdo_Lv2_DataMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv2_DataMap.UseVisualStyleBackColor = true;
            this.rdo_Lv2_DataMap.CheckedChanged += new System.EventHandler(this.rdo_Lv2_DataMap_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.rdo_Lv1_문자);
            this.flowLayoutPanel1.Controls.Add(this.rdo_Lv1_숫자);
            this.flowLayoutPanel1.Controls.Add(this.rdo_Lv1_콤보);
            this.flowLayoutPanel1.Controls.Add(this.rdo_Lv1_체크);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 333);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(410, 28);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // rdo_Lv1_문자
            // 
            this.rdo_Lv1_문자.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv1_문자.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv1_문자.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv1_문자.Location = new System.Drawing.Point(3, 3);
            this.rdo_Lv1_문자.Name = "rdo_Lv1_문자";
            this.rdo_Lv1_문자.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv1_문자.TabIndex = 5;
            this.rdo_Lv1_문자.Text = "문자";
            this.rdo_Lv1_문자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv1_문자.UseVisualStyleBackColor = true;
            this.rdo_Lv1_문자.CheckedChanged += new System.EventHandler(this.rdo_Lv1_문자_CheckedChanged);
            // 
            // rdo_Lv1_숫자
            // 
            this.rdo_Lv1_숫자.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv1_숫자.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv1_숫자.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv1_숫자.Location = new System.Drawing.Point(89, 3);
            this.rdo_Lv1_숫자.Name = "rdo_Lv1_숫자";
            this.rdo_Lv1_숫자.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv1_숫자.TabIndex = 6;
            this.rdo_Lv1_숫자.Text = "숫자";
            this.rdo_Lv1_숫자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv1_숫자.UseVisualStyleBackColor = true;
            this.rdo_Lv1_숫자.CheckedChanged += new System.EventHandler(this.rdo_Lv1_숫자_CheckedChanged);
            // 
            // rdo_Lv1_콤보
            // 
            this.rdo_Lv1_콤보.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv1_콤보.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv1_콤보.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv1_콤보.Location = new System.Drawing.Point(175, 3);
            this.rdo_Lv1_콤보.Name = "rdo_Lv1_콤보";
            this.rdo_Lv1_콤보.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv1_콤보.TabIndex = 7;
            this.rdo_Lv1_콤보.Text = "콤보";
            this.rdo_Lv1_콤보.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv1_콤보.UseVisualStyleBackColor = true;
            this.rdo_Lv1_콤보.CheckedChanged += new System.EventHandler(this.rdo_Lv1_콤보_CheckedChanged);
            // 
            // rdo_Lv1_체크
            // 
            this.rdo_Lv1_체크.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv1_체크.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv1_체크.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv1_체크.Location = new System.Drawing.Point(261, 3);
            this.rdo_Lv1_체크.Name = "rdo_Lv1_체크";
            this.rdo_Lv1_체크.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv1_체크.TabIndex = 8;
            this.rdo_Lv1_체크.Text = "CHK";
            this.rdo_Lv1_체크.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv1_체크.UseVisualStyleBackColor = true;
            this.rdo_Lv1_체크.CheckedChanged += new System.EventHandler(this.rdo_Lv1_체크_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.chkIsVisible);
            this.flowLayoutPanel3.Controls.Add(this.chkIsRequired);
            this.flowLayoutPanel3.Controls.Add(this.chkAllowMerge);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(648, 307);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(411, 26);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // chkIsVisible
            // 
            this.chkIsVisible.Checked = true;
            this.chkIsVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsVisible.Location = new System.Drawing.Point(3, 3);
            this.chkIsVisible.Name = "chkIsVisible";
            this.chkIsVisible.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkIsVisible.Size = new System.Drawing.Size(75, 20);
            this.chkIsVisible.TabIndex = 0;
            this.chkIsVisible.Text = "표시";
            this.chkIsVisible.UseVisualStyleBackColor = true;
            this.chkIsVisible.CheckedChanged += new System.EventHandler(this.chkIsVisible_CheckedChanged);
            // 
            // chkIsRequired
            // 
            this.chkIsRequired.Location = new System.Drawing.Point(84, 3);
            this.chkIsRequired.Name = "chkIsRequired";
            this.chkIsRequired.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkIsRequired.Size = new System.Drawing.Size(75, 20);
            this.chkIsRequired.TabIndex = 0;
            this.chkIsRequired.Text = "필수";
            this.chkIsRequired.UseVisualStyleBackColor = true;
            this.chkIsRequired.CheckedChanged += new System.EventHandler(this.chkIsRequired_CheckedChanged);
            // 
            // chkAllowMerge
            // 
            this.chkAllowMerge.Location = new System.Drawing.Point(165, 3);
            this.chkAllowMerge.Name = "chkAllowMerge";
            this.chkAllowMerge.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkAllowMerge.Size = new System.Drawing.Size(75, 20);
            this.chkAllowMerge.TabIndex = 0;
            this.chkAllowMerge.Text = "병합";
            this.chkAllowMerge.UseVisualStyleBackColor = true;
            this.chkAllowMerge.Visible = false;
            this.chkAllowMerge.CheckedChanged += new System.EventHandler(this.chkAllowMerge_CheckedChanged);
            // 
            // flowLayoutPanel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 7);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_일반);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_년월일);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_년월);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_년도);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_N0);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_N1);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_N2);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_N3);
            this.flowLayoutPanel4.Controls.Add(this.rdo_Lv3_N4);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(100, 389);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(959, 28);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // rdo_Lv3_일반
            // 
            this.rdo_Lv3_일반.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_일반.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_일반.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_일반.Location = new System.Drawing.Point(3, 3);
            this.rdo_Lv3_일반.Name = "rdo_Lv3_일반";
            this.rdo_Lv3_일반.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_일반.TabIndex = 10;
            this.rdo_Lv3_일반.Text = "일반";
            this.rdo_Lv3_일반.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_일반.UseVisualStyleBackColor = true;
            this.rdo_Lv3_일반.CheckedChanged += new System.EventHandler(this.rdo_Lv3_일반_CheckedChanged);
            // 
            // rdo_Lv3_년월일
            // 
            this.rdo_Lv3_년월일.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_년월일.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_년월일.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_년월일.Location = new System.Drawing.Point(89, 3);
            this.rdo_Lv3_년월일.Name = "rdo_Lv3_년월일";
            this.rdo_Lv3_년월일.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_년월일.TabIndex = 13;
            this.rdo_Lv3_년월일.Text = "년월일";
            this.rdo_Lv3_년월일.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_년월일.UseVisualStyleBackColor = true;
            this.rdo_Lv3_년월일.CheckedChanged += new System.EventHandler(this.rdo_Lv3_년월일_CheckedChanged);
            // 
            // rdo_Lv3_년월
            // 
            this.rdo_Lv3_년월.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_년월.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_년월.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_년월.Location = new System.Drawing.Point(175, 3);
            this.rdo_Lv3_년월.Name = "rdo_Lv3_년월";
            this.rdo_Lv3_년월.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_년월.TabIndex = 12;
            this.rdo_Lv3_년월.Text = "년월";
            this.rdo_Lv3_년월.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_년월.UseVisualStyleBackColor = true;
            this.rdo_Lv3_년월.CheckedChanged += new System.EventHandler(this.rdo_Lv3_년월_CheckedChanged);
            // 
            // rdo_Lv3_년도
            // 
            this.rdo_Lv3_년도.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_년도.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_년도.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_년도.Location = new System.Drawing.Point(261, 3);
            this.rdo_Lv3_년도.Name = "rdo_Lv3_년도";
            this.rdo_Lv3_년도.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_년도.TabIndex = 11;
            this.rdo_Lv3_년도.Text = "년도";
            this.rdo_Lv3_년도.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_년도.UseVisualStyleBackColor = true;
            this.rdo_Lv3_년도.CheckedChanged += new System.EventHandler(this.rdo_Lv3_년도_CheckedChanged);
            // 
            // rdo_Lv3_N0
            // 
            this.rdo_Lv3_N0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_N0.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_N0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_N0.Location = new System.Drawing.Point(347, 3);
            this.rdo_Lv3_N0.Name = "rdo_Lv3_N0";
            this.rdo_Lv3_N0.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_N0.TabIndex = 14;
            this.rdo_Lv3_N0.Text = "#,##0";
            this.rdo_Lv3_N0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_N0.UseVisualStyleBackColor = true;
            this.rdo_Lv3_N0.CheckedChanged += new System.EventHandler(this.rdo_Lv3_N0_CheckedChanged);
            // 
            // rdo_Lv3_N1
            // 
            this.rdo_Lv3_N1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_N1.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_N1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_N1.Location = new System.Drawing.Point(433, 3);
            this.rdo_Lv3_N1.Name = "rdo_Lv3_N1";
            this.rdo_Lv3_N1.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_N1.TabIndex = 15;
            this.rdo_Lv3_N1.Text = "#,##0.0";
            this.rdo_Lv3_N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_N1.UseVisualStyleBackColor = true;
            this.rdo_Lv3_N1.CheckedChanged += new System.EventHandler(this.rdo_Lv3_N1_CheckedChanged);
            // 
            // rdo_Lv3_N2
            // 
            this.rdo_Lv3_N2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_N2.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_N2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_N2.Location = new System.Drawing.Point(519, 3);
            this.rdo_Lv3_N2.Name = "rdo_Lv3_N2";
            this.rdo_Lv3_N2.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_N2.TabIndex = 17;
            this.rdo_Lv3_N2.Text = "#,##0.#0";
            this.rdo_Lv3_N2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_N2.UseVisualStyleBackColor = true;
            this.rdo_Lv3_N2.CheckedChanged += new System.EventHandler(this.rdo_Lv3_N2_CheckedChanged);
            // 
            // rdo_Lv3_N3
            // 
            this.rdo_Lv3_N3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_N3.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_N3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_N3.Location = new System.Drawing.Point(605, 3);
            this.rdo_Lv3_N3.Name = "rdo_Lv3_N3";
            this.rdo_Lv3_N3.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_N3.TabIndex = 16;
            this.rdo_Lv3_N3.Text = "#,##0.##0";
            this.rdo_Lv3_N3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_N3.UseVisualStyleBackColor = true;
            this.rdo_Lv3_N3.CheckedChanged += new System.EventHandler(this.rdo_Lv3_N3_CheckedChanged);
            // 
            // rdo_Lv3_N4
            // 
            this.rdo_Lv3_N4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_Lv3_N4.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdo_Lv3_N4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_Lv3_N4.Location = new System.Drawing.Point(691, 3);
            this.rdo_Lv3_N4.Name = "rdo_Lv3_N4";
            this.rdo_Lv3_N4.Size = new System.Drawing.Size(80, 24);
            this.rdo_Lv3_N4.TabIndex = 18;
            this.rdo_Lv3_N4.Text = "#,##0.###0";
            this.rdo_Lv3_N4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_Lv3_N4.UseVisualStyleBackColor = true;
            this.rdo_Lv3_N4.CheckedChanged += new System.EventHandler(this.rdo_Lv3_N4_CheckedChanged);
            // 
            // flowLayoutPanel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Controls.Add(this.rdoAlign_Left);
            this.flowLayoutPanel5.Controls.Add(this.rdoAlign_Center);
            this.flowLayoutPanel5.Controls.Add(this.rdoAlign_Right);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(648, 333);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(411, 28);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // rdoAlign_Left
            // 
            this.rdoAlign_Left.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAlign_Left.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdoAlign_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAlign_Left.Location = new System.Drawing.Point(3, 3);
            this.rdoAlign_Left.Name = "rdoAlign_Left";
            this.rdoAlign_Left.Size = new System.Drawing.Size(75, 22);
            this.rdoAlign_Left.TabIndex = 0;
            this.rdoAlign_Left.TabStop = true;
            this.rdoAlign_Left.Text = "왼쪽";
            this.rdoAlign_Left.UseVisualStyleBackColor = true;
            this.rdoAlign_Left.CheckedChanged += new System.EventHandler(this.rdoAlign_Left_CheckedChanged);
            // 
            // rdoAlign_Center
            // 
            this.rdoAlign_Center.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAlign_Center.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdoAlign_Center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAlign_Center.Location = new System.Drawing.Point(84, 3);
            this.rdoAlign_Center.Name = "rdoAlign_Center";
            this.rdoAlign_Center.Size = new System.Drawing.Size(75, 22);
            this.rdoAlign_Center.TabIndex = 0;
            this.rdoAlign_Center.TabStop = true;
            this.rdoAlign_Center.Text = "가운데";
            this.rdoAlign_Center.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAlign_Center.UseVisualStyleBackColor = true;
            this.rdoAlign_Center.CheckedChanged += new System.EventHandler(this.rdoAlign_Center_CheckedChanged);
            // 
            // rdoAlign_Right
            // 
            this.rdoAlign_Right.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAlign_Right.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rdoAlign_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAlign_Right.Location = new System.Drawing.Point(165, 3);
            this.rdoAlign_Right.Name = "rdoAlign_Right";
            this.rdoAlign_Right.Size = new System.Drawing.Size(75, 22);
            this.rdoAlign_Right.TabIndex = 0;
            this.rdoAlign_Right.TabStop = true;
            this.rdoAlign_Right.Text = "오른쪽";
            this.rdoAlign_Right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoAlign_Right.UseVisualStyleBackColor = true;
            this.rdoAlign_Right.CheckedChanged += new System.EventHandler(this.rdoAlign_Right_CheckedChanged);
            // 
            // flowLayoutPanel6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel6, 3);
            this.flowLayoutPanel6.Controls.Add(this.btnHeaderMinus);
            this.flowLayoutPanel6.Controls.Add(this.btnHeaderPlus);
            this.flowLayoutPanel6.Controls.Add(this.btnReadOnly);
            this.flowLayoutPanel6.Controls.Add(this.btnAddColumn);
            this.flowLayoutPanel6.Controls.Add(this.btnDelColumn);
            this.flowLayoutPanel6.Controls.Add(this.chkColumnSwap);
            this.flowLayoutPanel6.Controls.Add(this.chkColumnMoving);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(510, 28);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(549, 28);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // btnHeaderMinus
            // 
            this.btnHeaderMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderMinus.Location = new System.Drawing.Point(13, 3);
            this.btnHeaderMinus.Name = "btnHeaderMinus";
            this.btnHeaderMinus.Size = new System.Drawing.Size(58, 23);
            this.btnHeaderMinus.TabIndex = 4;
            this.btnHeaderMinus.TabStop = false;
            this.btnHeaderMinus.Text = "헤더 -";
            this.btnHeaderMinus.UseVisualStyleBackColor = true;
            this.btnHeaderMinus.Click += new System.EventHandler(this.btnHeaderMinus_Click);
            // 
            // btnHeaderPlus
            // 
            this.btnHeaderPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderPlus.Location = new System.Drawing.Point(77, 3);
            this.btnHeaderPlus.Name = "btnHeaderPlus";
            this.btnHeaderPlus.Size = new System.Drawing.Size(58, 23);
            this.btnHeaderPlus.TabIndex = 5;
            this.btnHeaderPlus.TabStop = false;
            this.btnHeaderPlus.Text = "헤더 +";
            this.btnHeaderPlus.UseVisualStyleBackColor = true;
            this.btnHeaderPlus.Click += new System.EventHandler(this.btnHeaderPlus_Click);
            // 
            // btnReadOnly
            // 
            this.btnReadOnly.Location = new System.Drawing.Point(141, 3);
            this.btnReadOnly.Name = "btnReadOnly";
            this.btnReadOnly.Size = new System.Drawing.Size(75, 23);
            this.btnReadOnly.TabIndex = 10;
            this.btnReadOnly.Text = "읽기전용";
            this.btnReadOnly.UseVisualStyleBackColor = true;
            this.btnReadOnly.Click += new System.EventHandler(this.btnReadOnly_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(237, 3);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(58, 23);
            this.btnAddColumn.TabIndex = 0;
            this.btnAddColumn.Text = "추가 +";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnDelColumn
            // 
            this.btnDelColumn.Location = new System.Drawing.Point(301, 3);
            this.btnDelColumn.Name = "btnDelColumn";
            this.btnDelColumn.Size = new System.Drawing.Size(58, 23);
            this.btnDelColumn.TabIndex = 1;
            this.btnDelColumn.Text = "제거 -";
            this.btnDelColumn.UseVisualStyleBackColor = true;
            this.btnDelColumn.Click += new System.EventHandler(this.btnDelColumn_Click);
            // 
            // chkColumnSwap
            // 
            this.chkColumnSwap.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkColumnSwap.FlatAppearance.CheckedBackColor = System.Drawing.Color.Coral;
            this.chkColumnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkColumnSwap.Location = new System.Drawing.Point(377, 3);
            this.chkColumnSwap.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.chkColumnSwap.Name = "chkColumnSwap";
            this.chkColumnSwap.Size = new System.Drawing.Size(70, 24);
            this.chkColumnSwap.TabIndex = 11;
            this.chkColumnSwap.Text = "위치교환";
            this.chkColumnSwap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkColumnSwap.UseVisualStyleBackColor = true;
            this.chkColumnSwap.CheckedChanged += new System.EventHandler(this.chkColumnSwap_CheckedChanged);
            // 
            // chkColumnMoving
            // 
            this.chkColumnMoving.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkColumnMoving.FlatAppearance.CheckedBackColor = System.Drawing.Color.Coral;
            this.chkColumnMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkColumnMoving.Location = new System.Drawing.Point(453, 3);
            this.chkColumnMoving.Name = "chkColumnMoving";
            this.chkColumnMoving.Size = new System.Drawing.Size(70, 24);
            this.chkColumnMoving.TabIndex = 12;
            this.chkColumnMoving.Text = "위치이동";
            this.chkColumnMoving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkColumnMoving.UseVisualStyleBackColor = true;
            this.chkColumnMoving.CheckedChanged += new System.EventHandler(this.chkColumnMoving_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 22);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 28);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "컬럼 검색";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchCol
            // 
            this.txtSearchCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchCol.Location = new System.Drawing.Point(103, 31);
            this.txtSearchCol.Name = "txtSearchCol";
            this.txtSearchCol.Size = new System.Drawing.Size(234, 21);
            this.txtSearchCol.TabIndex = 3;
            this.txtSearchCol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCol_KeyDown);
            // 
            // btnSearchCol
            // 
            this.btnSearchCol.Location = new System.Drawing.Point(343, 31);
            this.btnSearchCol.Name = "btnSearchCol";
            this.btnSearchCol.Size = new System.Drawing.Size(74, 22);
            this.btnSearchCol.TabIndex = 10;
            this.btnSearchCol.Text = "검색";
            this.btnSearchCol.UseVisualStyleBackColor = true;
            this.btnSearchCol.Click += new System.EventHandler(this.btnSearchCol_Click);
            // 
            // btnVisibleInvert
            // 
            this.btnVisibleInvert.Location = new System.Drawing.Point(651, 3);
            this.btnVisibleInvert.Name = "btnVisibleInvert";
            this.btnVisibleInvert.Size = new System.Drawing.Size(75, 22);
            this.btnVisibleInvert.TabIndex = 12;
            this.btnVisibleInvert.Text = "표시(다수)";
            this.btnVisibleInvert.UseVisualStyleBackColor = true;
            this.btnVisibleInvert.Click += new System.EventHandler(this.btnVisibleInvert_Click);
            // 
            // pnlSCDesign
            // 
            this.pnlSCDesign.Controls.Add(this.chkVisible);
            this.pnlSCDesign.Controls.Add(this.btnSchema);
            this.pnlSCDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSCDesign.Location = new System.Drawing.Point(730, 0);
            this.pnlSCDesign.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSCDesign.Name = "pnlSCDesign";
            this.pnlSCDesign.Size = new System.Drawing.Size(329, 28);
            this.pnlSCDesign.TabIndex = 14;
            this.pnlSCDesign.Visible = false;
            // 
            // chkVisible
            // 
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(96, 2);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(62, 24);
            this.chkVisible.TabIndex = 14;
            this.chkVisible.Text = "표시";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // btnSchema
            // 
            this.btnSchema.Location = new System.Drawing.Point(4, 3);
            this.btnSchema.Name = "btnSchema";
            this.btnSchema.Size = new System.Drawing.Size(82, 22);
            this.btnSchema.TabIndex = 13;
            this.btnSchema.Text = "스키마 설정";
            this.btnSchema.UseVisualStyleBackColor = true;
            this.btnSchema.Click += new System.EventHandler(this.btnSchema_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Level4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // flowLayoutPanel7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel7, 7);
            this.flowLayoutPanel7.Controls.Add(this.chkSUM);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(100, 417);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(959, 28);
            this.flowLayoutPanel7.TabIndex = 7;
            // 
            // chkSUM
            // 
            this.chkSUM.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSUM.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.chkSUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSUM.Location = new System.Drawing.Point(3, 3);
            this.chkSUM.Name = "chkSUM";
            this.chkSUM.Size = new System.Drawing.Size(80, 24);
            this.chkSUM.TabIndex = 0;
            this.chkSUM.Text = "합계";
            this.chkSUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSUM.UseVisualStyleBackColor = true;
            this.chkSUM.Visible = false;
            this.chkSUM.CheckedChanged += new System.EventHandler(this.chkSUM_CheckedChanged);
            // 
            // chkFrozen
            // 
            this.chkFrozen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFrozen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFrozen.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.chkFrozen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFrozen.Location = new System.Drawing.Point(342, 309);
            this.chkFrozen.Margin = new System.Windows.Forms.Padding(2);
            this.chkFrozen.Name = "chkFrozen";
            this.chkFrozen.Size = new System.Drawing.Size(76, 22);
            this.chkFrozen.TabIndex = 15;
            this.chkFrozen.Text = "열고정";
            this.chkFrozen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFrozen.UseVisualStyleBackColor = true;
            this.chkFrozen.CheckedChanged += new System.EventHandler(this.chkFrozen_CheckedChanged);
            // 
            // GridEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GridEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그리드 설정";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.pnlSCDesign.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SourceGrid.Grid grid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGridName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkIsVisible;
        private System.Windows.Forms.CheckBox chkIsRequired;
        private System.Windows.Forms.CheckBox chkAllowMerge;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoAlign_Left;
        private System.Windows.Forms.RadioButton rdoAlign_Center;
        private System.Windows.Forms.RadioButton rdoAlign_Right;
        private System.Windows.Forms.RadioButton rdo_Lv2_일반;
        private System.Windows.Forms.RadioButton rdo_Lv2_코드파인드;
        private System.Windows.Forms.RadioButton rdo_Lv2_날짜;
        private System.Windows.Forms.RadioButton rdo_Lv2_YN;
        private System.Windows.Forms.RadioButton rdo_Lv2_DataMap;
        private System.Windows.Forms.RadioButton rdo_Lv1_문자;
        private System.Windows.Forms.RadioButton rdo_Lv1_숫자;
        private System.Windows.Forms.RadioButton rdo_Lv1_콤보;
        private System.Windows.Forms.RadioButton rdo_Lv1_체크;
        private System.Windows.Forms.RadioButton rdo_Lv3_일반;
        private System.Windows.Forms.RadioButton rdo_Lv3_년월일;
        private System.Windows.Forms.RadioButton rdo_Lv3_년월;
        private System.Windows.Forms.RadioButton rdo_Lv3_년도;
        private System.Windows.Forms.RadioButton rdo_Lv3_N0;
        private System.Windows.Forms.RadioButton rdo_Lv3_N1;
        private System.Windows.Forms.RadioButton rdo_Lv3_N2;
        private System.Windows.Forms.RadioButton rdo_Lv3_N3;
        private System.Windows.Forms.RadioButton rdo_Lv3_N4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button btnHeaderMinus;
        private System.Windows.Forms.Button btnHeaderPlus;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReadOnly;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelColumn;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.CheckBox chkColumnSwap;
        private System.Windows.Forms.CheckBox chkColumnMoving;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCol;
        private System.Windows.Forms.Button btnSearchCol;
        private System.Windows.Forms.Button btnVisibleInvert;
        private System.Windows.Forms.Button btnSchema;
        private System.Windows.Forms.Panel pnlSCDesign;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.CheckBox chkFrozen;
        private System.Windows.Forms.CheckBox chkSUM;
    }
}
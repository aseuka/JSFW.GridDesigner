using JSFW.GridDesigner;
using SourceGrid;
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
    internal partial class GridEditForm : Form
    {
        internal GridSettings Setting { get; private set; }

        public GridEditForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            pnlSCDesign.Visible = GridSettings.UseScreenDefinition;

            this.Disposed += GridEditForm_Disposed;
        }

        private void GridEditForm_Disposed(object sender, EventArgs e)
        {
            Setting?.Dispose();
            Setting = null;
        }

        internal void Set(GridSettings setting)
        {
            if (setting == null) return;
             
            Setting = setting;

            if (GridSettings.UseScreenDefinition)
            {
                chkVisible.Checked = Setting.Visible;
            }

            txtGridName.Text = Setting?.GridName;

            if (string.IsNullOrWhiteSpace(txtGridName.Text))
            {
                txtGridName.Text = "grdData";
            }

            Setting?.ToEdit(grid1);

            txtSearchCol.AutoCompleteCustomSource.Clear();
            foreach (var col in Setting.Columns)
            {
                txtSearchCol.AutoCompleteCustomSource.Add(col.Name);
                UpdateToGrid(col);
            }
            CurrentColumnIndex = -999;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            grid1.Selection.EnableMultiSelection = true;
        }

        void Lv1_UnVisible()
        {
            rdo_Lv1_문자.Visible = rdo_Lv1_문자.Checked = false;
            rdo_Lv1_숫자.Visible = rdo_Lv1_숫자.Checked = false;
            rdo_Lv1_콤보.Visible = rdo_Lv1_콤보.Checked = false;
            rdo_Lv1_체크.Visible = rdo_Lv1_체크.Checked = false;
        }

        void Lv1_Visible()
        {
            rdo_Lv1_문자.Visible = true;
            rdo_Lv1_숫자.Visible = true;
            rdo_Lv1_콤보.Visible = true;
            rdo_Lv1_체크.Visible = true; 
        }

        void Lv2_UnVisible()
        {
            rdo_Lv2_일반.Visible = rdo_Lv2_일반.Checked = false;
            rdo_Lv2_코드파인드.Visible = rdo_Lv2_코드파인드.Checked = false;
            rdo_Lv2_날짜.Visible = rdo_Lv2_날짜.Checked = false;
            rdo_Lv2_YN.Visible = rdo_Lv2_YN.Checked = false;
            rdo_Lv2_DataMap.Visible = rdo_Lv2_DataMap.Checked = false;

            label7.Visible = false;
            chkSUM.Visible = false;
        }

        void Lv2_Visible()
        {
            rdo_Lv2_일반.Visible = true;
            rdo_Lv2_코드파인드.Visible = true;
            rdo_Lv2_날짜.Visible = true;
            rdo_Lv2_YN.Visible = true;
            rdo_Lv2_DataMap.Visible = true;

            label7.Visible = false;
            chkSUM.Visible = false;
        }
 
        void Lv3_UnVisible()
        {
            rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = false;
            rdo_Lv3_년월일.Visible = rdo_Lv3_년월일.Checked = false;
            rdo_Lv3_년월.Visible = rdo_Lv3_년월.Checked = false;
            rdo_Lv3_년도.Visible = rdo_Lv3_년도.Checked = false;
            rdo_Lv3_N0.Visible = rdo_Lv3_N0.Checked = false;
            rdo_Lv3_N1.Visible = rdo_Lv3_N1.Checked = false;
            rdo_Lv3_N2.Visible = rdo_Lv3_N2.Checked = false;
            rdo_Lv3_N3.Visible = rdo_Lv3_N3.Checked = false;
            rdo_Lv3_N4.Visible = rdo_Lv3_N4.Checked = false;
        }

        void Lv3_Visible()
        {
            rdo_Lv3_일반.Visible = true;
            rdo_Lv3_년월일.Visible = true;
            rdo_Lv3_년월.Visible = true;
            rdo_Lv3_년도.Visible = true;
            rdo_Lv3_N0.Visible = true;
            rdo_Lv3_N1.Visible = true;
            rdo_Lv3_N2.Visible = true;
            rdo_Lv3_N3.Visible = true;
            rdo_Lv3_N4.Visible = true;
        }

        private void rdo_Lv1_문자_CheckedChanged(object sender, EventArgs e)
        {
            Lv2_UnVisible();
            Lv3_UnVisible();

            if (rdo_Lv1_문자.Checked)
            {
                rdo_Lv2_일반.Visible = rdo_Lv2_일반.Checked = true;
                rdo_Lv2_날짜.Visible = true;
                rdo_Lv2_코드파인드.Visible = true; 
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv1_숫자_CheckedChanged(object sender, EventArgs e)
        {
            Lv2_UnVisible();
            Lv3_UnVisible();
            if (rdo_Lv1_숫자.Checked)
            {
                rdo_Lv2_일반.Visible = rdo_Lv2_일반.Checked = true;
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = false;
                rdo_Lv3_N4.Visible = true;
                rdo_Lv3_N3.Visible = true;
                rdo_Lv3_N2.Visible = true;
                rdo_Lv3_N1.Visible = true;
                rdo_Lv3_N0.Visible = rdo_Lv3_N0.Checked = true;

                rdoAlign_Center.Checked = false;
                rdoAlign_Left.Checked = false;
                rdoAlign_Right.Checked = true;

                label7.Visible = true;
                chkSUM.Visible = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv1_콤보_CheckedChanged(object sender, EventArgs e)
        {
            Lv2_UnVisible();
            Lv3_UnVisible();
            if (rdo_Lv1_콤보.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
                rdo_Lv2_YN.Visible = true;
                rdo_Lv2_DataMap.Visible = rdo_Lv2_DataMap.Checked = true;

                rdoAlign_Left.Checked = false;
                rdoAlign_Right.Checked = false;
                rdoAlign_Center.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv1_체크_CheckedChanged(object sender, EventArgs e)
        {
            Lv2_UnVisible();
            Lv3_UnVisible();
            if (rdo_Lv1_체크.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
                rdo_Lv2_일반.Visible = rdo_Lv2_일반.Checked = true; 
            }
            UpdateColumnInfo();
        }

        private void rdo_Lv2_일반_CheckedChanged(object sender, EventArgs e)
        {
            Lv3_UnVisible();
            // 일반 
            if (rdo_Lv2_일반.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
            }

            UpdateColumnInfo();
        }
         
        private void rdo_Lv2_날짜_CheckedChanged(object sender, EventArgs e)
        {
            Lv3_UnVisible();

            if (rdo_Lv2_날짜.Checked)
            {
                rdo_Lv3_년도.Visible = true;
                rdo_Lv3_년월.Visible = true;
                rdo_Lv3_년월일.Visible = true;

                rdoAlign_Left.Checked = false;
                rdoAlign_Right.Checked = false;
                rdoAlign_Center.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv2_코드파인드_CheckedChanged(object sender, EventArgs e)
        {
            Lv3_UnVisible();
            if (rdo_Lv2_코드파인드.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;

                rdoAlign_Left.Checked = false;
                rdoAlign_Right.Checked = false;
                rdoAlign_Center.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv2_YN_CheckedChanged(object sender, EventArgs e)
        {
            Lv3_UnVisible();
            if (rdo_Lv2_YN.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void rdo_Lv2_DataMap_CheckedChanged(object sender, EventArgs e)
        {
            Lv3_UnVisible();
            if (rdo_Lv2_DataMap.Checked)
            {
                rdo_Lv3_일반.Visible = rdo_Lv3_일반.Checked = true;
            }

            UpdateColumnInfo();
        }

        private void chkIsVisible_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void chkIsRequired_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void chkAllowMerge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdoAlign_Left_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdoAlign_Center_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdoAlign_Right_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_일반_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_년월일_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_년월_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_년도_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_N0_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_N1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_N2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_N3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void rdo_Lv3_N4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnInfo();
        }

        private void chkSUM_CheckedChanged(object sender, EventArgs e)
        {
            //sum!
            UpdateColumnInfo();
        }

        private void chkFrozen_CheckedChanged(object sender, EventArgs e)
        {
            // 틀고정
            UpdateColumnInfo();
        }

        private void UpdateColumnInfo()
        {
            if (IsColumnDataBind) return;

            Column colInfo = null;
            try
            {
                colInfo = Setting.Columns[CurrentColumnIndex];

                if (chkFrozen.Checked)
                {
                    Setting.Columns.ForEach( c => c.Frozen = false );
                } 
            }
            catch
            {
                colInfo = null;
            }

            if (colInfo != null)
            {
                if (rdoAlign_Center.Checked)
                {
                    colInfo.TextAlign = TEXTALIGN.CENTER;
                }
                else if (rdoAlign_Right.Checked)
                {
                    colInfo.TextAlign = TEXTALIGN.RIGHT;
                }
                else
                {
                    colInfo.TextAlign = TEXTALIGN.LEFT;                    
                }

                colInfo.Visible = chkIsVisible.Checked;
                colInfo.Required = chkIsRequired.Checked;
                colInfo.Merge = chkAllowMerge.Checked; 
                colInfo.Frozen = chkFrozen.Checked; 

                if (rdo_Lv1_체크.Checked) 
                {
                    colInfo.Lv1 = LEVEL1.체크;
                }
                else if (rdo_Lv1_콤보.Checked)
                {
                    colInfo.Lv1 = LEVEL1.콤보;
                }
                else if (rdo_Lv1_숫자.Checked)
                {
                    colInfo.Lv1 = LEVEL1.숫자;
                }
                else  
                {
                    colInfo.Lv1 = LEVEL1.문자;
                }

                if (rdo_Lv2_DataMap.Checked)
                {
                    colInfo.Lv2 = LEVEL2.DataMap;
                }
                else if (rdo_Lv2_YN.Checked)
                {
                    colInfo.Lv2 = LEVEL2.YN;
                }
                else if (rdo_Lv2_코드파인드.Checked)
                {
                    colInfo.Lv2 = LEVEL2.코드파인드;
                }
                else if (rdo_Lv2_날짜.Checked)
                {
                    colInfo.Lv2 = LEVEL2.날짜;
                }
                else 
                {
                    colInfo.Lv2 = LEVEL2.일반;
                }

                if (rdo_Lv3_년월일.Checked)
                {
                    colInfo.Lv3 = LEVEL3.년월일;
                }
                else if (rdo_Lv3_년월.Checked)
                {
                    colInfo.Lv3 = LEVEL3.년월;
                }
                else if (rdo_Lv3_년도.Checked)
                {
                    colInfo.Lv3 = LEVEL3.년도;
                }
                else if (rdo_Lv3_N0.Checked)
                {
                    colInfo.Lv3 = LEVEL3.N;
                }
                else if (rdo_Lv3_N1.Checked)
                {
                    colInfo.Lv3 = LEVEL3.N_N;
                }
                else if (rdo_Lv3_N2.Checked)
                {
                    colInfo.Lv3 = LEVEL3.N_NN;
                }
                else if (rdo_Lv3_N3.Checked)
                {
                    colInfo.Lv3 = LEVEL3.N_NNN;
                }
                else if (rdo_Lv3_N4.Checked)
                {
                    colInfo.Lv3 = LEVEL3.N_NNNN;
                }
                else
                {
                    colInfo.Lv3 = LEVEL3.일반;
                }

                colInfo.IsSumColumn = chkSUM.Checked;
            }

            UpdateToGrid(colInfo);
        }

        private void UpdateToGrid(Column col)
        {
            if (col == null) return;

            for (int rIndex = 0; rIndex < grid1.Rows.Count; rIndex++)
            {
                if (col.Visible)
                {
                    grid1[rIndex, col.Index].View.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    grid1[rIndex, col.Index].View.ForeColor = System.Drawing.Color.LightGray;
                }

                if (col.Merge)
                {
                    // 병합..은?
                }

                if (col.ReadOnly)
                {
                    grid1[rIndex, col.Index].View.BackColor = System.Drawing.Color.DarkGray;
                }
                else
                {
                    grid1[rIndex, col.Index].View.BackColor = System.Drawing.Color.White;
                }

                if (col.Required)
                {
                    grid1[rIndex, col.Index].View.Font = new Font(Font, FontStyle.Underline | FontStyle.Bold);
                }
                else
                {
                    grid1[rIndex, col.Index].View.Font = new Font(Font, FontStyle.Regular);
                }
                
                if (col.TextAlign == TEXTALIGN.LEFT)
                {
                    grid1[rIndex, col.Index].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft;
                }
                else if (col.TextAlign == TEXTALIGN.RIGHT)
                {
                    grid1[rIndex, col.Index].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight;
                }
                else
                {
                    grid1[rIndex, col.Index].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                } 
            }

            grid1.Refresh();
        }

        int CurrentColumnIndex { get; set; }

        bool IsColumnDataBind = false;

        bool IsColumnMoving = false;
        Point pt;

        private void grid1_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkColumnSwap.Checked || chkColumnMoving.Checked)
            {
                IsColumnMoving = e.Button == MouseButtons.Left;
                pt = e.Location; 
                return;
            }

            var ps = grid1.PositionAtPoint(e.Location);
             
            if (e.Button == MouseButtons.Right)
            {
                if (ps.Column < 0 || ps.Row < 0)
                {
                    return;
                }

                //Cell 내용 편집 
                using (CellEditForm cef = new CellEditForm())
                {
                    cef.ColumnText = "" + grid1[ps].Value;
                    
                    if (cef.ShowDialog(this) == DialogResult.OK)
                    {
                        var rng = grid1.Selection.GetSelectionRegion();

                        if (0 < rng.Count)
                        {
                            var cell = rng[0];
                            {
                                for (int row = cell.Start.Row; row <= cell.End.Row; row++)
                                {
                                    for (int col = cell.Start.Column; col <= cell.End.Column; col++)
                                    {
                                        if (grid1[row, col] is SourceGrid.Cells.CheckBox)
                                        {
                                            continue;
                                        }

                                        if (grid1[row, col] != null)
                                        {
                                            grid1[row, col].Value = cef.ColumnText;
                                        }
                                    }
                                }
                            }
                        }
                        grid1.Selection.ResetSelection(false);
                    }
                }
            }
            else
            {
                if (CurrentColumnIndex == ps.Column) return;
                SetColumnView(ps.Column);
            }
        }

        private void SetColumnView(int colIndex)
        {
            Column colInfo = null;
            try
            {
                colInfo = Setting.Columns[colIndex];
            }
            catch
            {
                colInfo = null;
            }

            IsColumnDataBind = true;

            Lv3_UnVisible();
            Lv2_UnVisible();
            Lv1_UnVisible();

            rdoAlign_Left.Checked = false;
            rdoAlign_Center.Checked = false;
            rdoAlign_Right.Checked = false;

            chkIsVisible.Checked = true;
            chkIsRequired.Checked = false;
            chkAllowMerge.Checked = false;

            txtID.Clear();

            try
            {
                if (colInfo != null)
                {
                    CurrentColumnIndex = colInfo.Index;

                    txtID.Text = colInfo.Name;
                    chkIsVisible.Checked = colInfo.Visible;
                    chkIsRequired.Checked = colInfo.Required;
                    chkAllowMerge.Checked = colInfo.Merge;
                    chkFrozen.Checked = colInfo.Frozen;
                    chkSUM.Checked = colInfo.IsSumColumn;

                    switch (colInfo.TextAlign)
                    {
                        default:
                        case TEXTALIGN.CENTER:
                            rdoAlign_Center.Checked = true;
                            break;
                        case TEXTALIGN.LEFT:
                            rdoAlign_Left.Checked = true;
                            break;
                        case TEXTALIGN.RIGHT:
                            rdoAlign_Right.Checked = true;
                            break;
                    }

                    Lv1_Visible();
                    // lv1
                    switch (colInfo.Lv1)
                    {
                        default:
                        case LEVEL1.문자:
                            {
                                rdo_Lv1_문자.Checked = true;

                                rdo_Lv2_일반.Visible = true;
                                rdo_Lv2_날짜.Visible = true;
                                rdo_Lv2_코드파인드.Visible = true;
                            }
                            break;
                        case LEVEL1.숫자:
                            {
                                rdo_Lv1_숫자.Checked = true;

                                rdo_Lv2_일반.Visible = true;
                            }
                            break;
                        case LEVEL1.콤보:
                            {
                                rdo_Lv1_콤보.Checked = true;

                                rdo_Lv2_YN.Visible = true;
                                rdo_Lv2_DataMap.Visible = true;
                            }
                            break;
                        case LEVEL1.체크:
                            {
                                rdo_Lv1_체크.Checked = true;

                                rdo_Lv2_일반.Visible = true;
                            }
                            break;
                    }

                    switch (colInfo.Lv2)
                    {
                        default:
                        case LEVEL2.일반:
                            {
                                rdo_Lv2_일반.Checked = true;

                                if (rdo_Lv1_숫자.Checked)
                                {
                                    rdo_Lv3_N0.Visible = true;
                                    rdo_Lv3_N1.Visible = true;
                                    rdo_Lv3_N2.Visible = true;
                                    rdo_Lv3_N3.Visible = true;
                                    rdo_Lv3_N4.Visible = true;

                                    switch (colInfo.Lv3)
                                    {
                                        case LEVEL3.N: rdo_Lv3_N0.Checked = true; break;
                                        case LEVEL3.N_N: rdo_Lv3_N1.Checked = true; break;
                                        case LEVEL3.N_NN: rdo_Lv3_N2.Checked = true; break;
                                        case LEVEL3.N_NNN: rdo_Lv3_N3.Checked = true; break;
                                        case LEVEL3.N_NNNN: rdo_Lv3_N4.Checked = true; break;
                                    }
                                }
                                else
                                {
                                    rdo_Lv3_일반.Visible = true;
                                }
                            }
                            break;
                        case LEVEL2.날짜:
                            {
                                rdo_Lv2_날짜.Checked = true;

                                rdo_Lv3_년월일.Visible = true;
                                rdo_Lv3_년월.Visible = true;
                                rdo_Lv3_년도.Visible = true;

                                switch (colInfo.Lv3)
                                {
                                    case LEVEL3.년월일: rdo_Lv3_년월일.Checked = true; break;
                                    case LEVEL3.년월: rdo_Lv3_년월.Checked = true; break;
                                    case LEVEL3.년도: rdo_Lv3_년도.Checked = true; break;
                                }
                            }
                            break;
                        case LEVEL2.코드파인드:
                            {
                                rdo_Lv2_코드파인드.Checked = true;

                                rdo_Lv3_일반.Visible = true;
                            }
                            break;
                        case LEVEL2.YN:
                            {
                                rdo_Lv2_YN.Checked = true;

                                rdo_Lv3_일반.Visible = true;
                            }
                            break;
                        case LEVEL2.DataMap:
                            {
                                rdo_Lv2_DataMap.Checked = true;

                                rdo_Lv3_일반.Visible = true;
                            }
                            break;
                    }

                    switch (colInfo.Lv3)
                    {
                        case LEVEL3.일반: rdo_Lv3_일반.Checked = true; break;
                    }
                }
                else
                {
                    CurrentColumnIndex = -999;
                }
            }
            finally
            {
                IsColumnDataBind = false;
            }
        }

        private void grid1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((chkColumnSwap.Checked || chkColumnMoving.Checked) && IsColumnMoving)
            {
                int x = e.Location.X - pt.X;
                int y = e.Location.Y - pt.Y;
                int z = (int)Math.Sqrt(Math.Pow((double)Math.Abs(x), 2d) + Math.Pow((double)Math.Abs(y), 2d));
                if (4 < z)
                {
                    var ps = grid1.PositionAtPoint(pt);
                    DoDragDrop(new DragDropItem() { Column = ps.Column }, DragDropEffects.Move);
                }
            }
        }

        private void grid1_MouseUp(object sender, MouseEventArgs e)
        { 
            IsColumnMoving = false;
            chkColumnSwap.Checked = chkColumnMoving.Checked = IsColumnMoving;
        }

        private void btnHeaderMinus_Click(object sender, EventArgs e)
        {
            if (Setting == null) return;

            if (Setting.Rows.Count <= 1) return;

            Setting.Rows.RemoveAt(0);
            int reRowIndex = 0;
            Setting.Rows.ForEach(reRow =>
            {
                reRow.Index = reRowIndex++;
                reRow.Cells.ForEach(reCell => reCell.Row = reRow.Index);
            });

            try
            {
                IsColumnDataBind = true;
                grid1.SuspendLayout();
                //for (int row = 0; row < Setting.Rows.Count; row++)
                //{
                //    for (int col = 0; col < Setting.Columns.Count; col++)
                //    {
                //        Setting.Rows[row].Cells[col].Value = grid1[row, col].Value;
                //    }
                //}

                Setting.ToEdit(grid1);

                foreach (Column col in Setting.Columns)
                {
                    UpdateToGrid(col);
                }
            }
            finally
            {
                grid1.ResumeLayout(true);
                IsColumnDataBind = false;
            }
        }

        private void btnHeaderPlus_Click(object sender, EventArgs e)
        {
            if (Setting == null) return;

            //현재 그리드 셀정보를 업데이트 안해서... 
            Setting.Rows.ForEach(reRow =>
            {               
                reRow.Cells.ForEach(reCell => reCell.Value = grid1[reCell.Row, reCell.Col].Value );
            }); 
            int rIndex = 0;
            Row r = new Row(rIndex);
            Setting.Rows.Insert(0, r);
            int reRowIndex = 0;
            Setting.Rows.ForEach(reRow =>
            {
                reRow.Index = reRowIndex++;
                reRow.Cells.ForEach(reCell => reCell.Row = reRow.Index);
            });

            foreach (Column col in Setting.Columns)
            {
                r.Add(new CellInfo() { Col = col.Index, Value = grid1[ rIndex, col.Index ].Value });
            }
            try
            {
                IsColumnDataBind = true; 
                grid1.SuspendLayout(); 
                //for (int row = 0; row < Setting.Rows.Count - 1; row++)
                //{
                //    for (int col = 0; col < Setting.Columns.Count; col++)
                //    {
                //        Setting.Rows[row].Cells[col].Value = grid1[row, col].Value;
                //    }
                //}
                Setting.ToEdit(grid1);
                foreach (Column col in Setting.Columns)
                {
                    UpdateToGrid(col);
                } 
            }
            finally
            {
                IsColumnDataBind = false;
                grid1.ResumeLayout(true);
            }
        }

        private void btnReadOnly_Click(object sender, EventArgs e)
        {
            var rng = grid1.Selection.GetSelectionRegion();

            if (0 < rng.Count)
            {
                List<int> colIndexs = new List<int>();
                for (int loop = 0; loop < rng.Count; loop++)
                {
                    for (int col = rng[loop].Start.Column; col <= rng[loop].End.Column; col++)
                    {
                        if (colIndexs.Contains(col) == false)
                        {
                            colIndexs.Add(col);
                        }
                    }
                }
                try
                {
                    grid1.SuspendLayout();
                    foreach (int col in colIndexs)
                    {
                        Setting.Columns[col].ReadOnly = !Setting.Columns[col].ReadOnly;
                        UpdateToGrid(Setting.Columns[col]);
                    }
                }
                finally 
                {
                    grid1.ResumeLayout(true);
                    grid1.Selection.ResetSelection(false);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (GridSettings.UseScreenDefinition)
            {
                Setting.Visible = chkVisible.Checked;
            }

            for (int row = 0; row < Setting.Rows.Count; row++)
            {
                for (int col = 0; col < Setting.Columns.Count; col++)
                {
                    Setting.Rows[row].Cells[col].Value = grid1[row, col].Value;
                }
            }

            List<Row> tempRows = new List<Row>();
            for (int rIndex = 0; rIndex < grid1.RowsCount; rIndex++)
            {
                Row r = new Row(rIndex);
                for (int cIndex = 0; cIndex < grid1.ColumnsCount; cIndex++)
                {
                    r.Add(new CellInfo() { Row = rIndex, Col = cIndex, Value = grid1[rIndex, cIndex].Value });
                }
                tempRows.Add(r);
            }

            for (int cIndex = 0; cIndex < Setting.Columns.Count; cIndex++)
            {
                Column c = Setting.Columns[cIndex];
                List<string> headers = new List<string>();
                for (int rIndex = 0; rIndex < Setting.Rows.Count; rIndex++)
                {
                    string celltext = "" +Setting.Rows[rIndex][cIndex].Value;

                    if (headers.Contains(celltext) == false)
                    {
                        headers.Add(celltext);
                    }
                }
                c.Header = string.Join(".", headers.ToArray());
            }
            Setting.Rows.Clear();
            Setting.Rows.AddRange(tempRows.ToArray());

            Setting.GridName = txtGridName.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            // 컬럼 추가 
            //grid1.Selection.GetSelectionRegion()[0].Start.Column
            var rng = grid1.Selection.GetSelectionRegion();

            int sIndex = -1;

            if (0 < rng.Count)
            {
               var ps = rng[0].Start;
                if (ps != null)
                {
                    sIndex = ps.Column;
                }
            }

            if (sIndex < 0) return;
            // 컬럼명, 헤더 정보 입력받고 등록하여 새 컬럼 생성
 
            using (NewColumnForm ncf = new NewColumnForm())
            {
                if (ncf.ShowDialog() == DialogResult.OK)
                {
                    // 뒤로 넣는거랑
                    sIndex = sIndex + ncf.ArrowAddColumn; 
                    Column newColumn = new Column() { Index = sIndex, Name = ncf.ColumnID, Header = ncf.ColumnHeader };
                    Setting.Columns.Insert(sIndex, newColumn);
                    for (int cIndex = sIndex; cIndex < Setting.Columns.Count; cIndex++)
                    {
                        Setting.Columns[cIndex].Index = cIndex;
                    }
                    for (int rIndex = 0; rIndex < Setting.Rows.Count; rIndex++)
                    {
                        Setting.Rows[rIndex].Cells.Insert(sIndex, new CellInfo() { Col = sIndex, Row = rIndex, Value = newColumn.Header });
                        for (int cIndex = sIndex; cIndex < Setting.Columns.Count; cIndex++)
                        {
                            Setting.Rows[rIndex].Cells[cIndex].Col = cIndex;
                        }
                    }  
                    Set(Setting);
                    SetColumnView(newColumn.Index);
                }
            }
        }

        private void btnDelColumn_Click(object sender, EventArgs e)
        {
            // 컬럼 삭제
            var rng = grid1.Selection.GetSelectionRegion();

            int sIndex = -1;

            if (0 < rng.Count)
            {
                var ps = rng[0].Start;
                if (ps != null)
                {
                    sIndex = ps.Column;
                }
            }

            if (sIndex < 0) return;

            if (0 <= sIndex && sIndex < Setting.Columns.Count)
            {
                Setting.Columns.RemoveAt(sIndex);
                for (int cIndex = sIndex; cIndex < Setting.Columns.Count; cIndex++)
                {
                    Setting.Columns[cIndex].Index = cIndex;
                }
                for (int rIndex = 0; rIndex < Setting.Rows.Count; rIndex++)
                {
                    Setting.Rows[rIndex].Cells.RemoveAt(sIndex);
                    for (int cIndex = sIndex; cIndex < Setting.Columns.Count; cIndex++)
                    {
                        Setting.Rows[rIndex].Cells[cIndex].Col = cIndex;
                    }
                }
                Set(Setting);
                SetColumnView(-1);
            }
        }

        private void grid1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.Move && e.Data.GetDataPresent(typeof( DragDropItem )))
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void grid1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.Move && e.Data.GetDataPresent(typeof(DragDropItem)))
            {
                try
                {
                    DragDropItem ddi = e.Data.GetData(typeof(DragDropItem)) as DragDropItem;
                    if (ddi == null) return;
                    var ps = grid1.PositionAtPoint( grid1.PointToClient( new Point(e.X, e.Y)));
                    System.Diagnostics.Debug.WriteLine($"{ddi.Column}, {ps.Column}");

                    if (ddi.Column == ps.Column) return;

                    if (chkColumnSwap.Checked)
                    {
                        SwapColumn(ddi.Column, ps.Column);
                        SetColumnView(ps.Column);
                    }
                    else if (chkColumnMoving.Checked)
                    {
                        //앞, 뒤 선택
                        using (ColumnMovingSetPoisition pos = new ColumnMovingSetPoisition())
                        {
                            if (pos.ShowDialog() == DialogResult.OK)
                            {
                                MovingColumn(pos.MovingPosition, ddi.Column, ps.Column);
                                SetColumnView(ps.Column);
                            }
                        }
                    }
                }
                finally 
                {
                    IsColumnMoving = false;
                    chkColumnSwap.Checked = false;
                    chkColumnMoving.Checked = false;
                }
            }
        }

        private void MovingColumn(MovingPosition  allow, int moveColumnIndex, int baseColumnIndex)
        {
            // baseColumn앞으로 
            if (allow == MovingPosition.Before)
            {
                Column moveColumn = Setting.Columns[moveColumnIndex];
                Setting.Columns.Remove(moveColumn);

                int insertColumnIndex = baseColumnIndex - 1;

                if (baseColumnIndex < moveColumnIndex)
                {
                    insertColumnIndex++;
                }

                if (insertColumnIndex < 0)
                {
                    insertColumnIndex = 0;
                }

                Setting.Columns.Insert(insertColumnIndex, moveColumn); 
                for (int col = 0; col < Setting.Columns.Count; col++)
                {
                    Setting.Columns[col].Index = col;
                }

                for (int row = 0; row < Setting.Rows.Count; row++)
                {
                    CellInfo moveCellInfo = Setting.Rows[row].Cells[moveColumnIndex];
                    Setting.Rows[row].Cells.Remove(moveCellInfo);
                    Setting.Rows[row].Cells.Insert(insertColumnIndex, moveCellInfo);
                    for (int col = 0; col < Setting.Columns.Count; col++)
                    {
                        Setting.Rows[row].Cells[col].Col = col;
                    }
                }
                Set(Setting);
            }
            else if (allow == MovingPosition.After)
            {
                Column moveColumn = Setting.Columns[moveColumnIndex];
                Setting.Columns.Remove(moveColumn);

                int insertColumnIndex = baseColumnIndex+1;

                if (moveColumnIndex < baseColumnIndex)
                {
                   insertColumnIndex--;
                }

                if (Setting.Columns.Count <= insertColumnIndex)
                {
                    insertColumnIndex = Setting.Columns.Count;
                }

                Setting.Columns.Insert(insertColumnIndex, moveColumn);
                for (int col = 0; col < Setting.Columns.Count; col++)
                {
                    Setting.Columns[col].Index = col;
                }

                for (int row = 0; row < Setting.Rows.Count; row++)
                {
                    CellInfo moveCellInfo = Setting.Rows[row].Cells[moveColumnIndex];
                    Setting.Rows[row].Cells.Remove(moveCellInfo);
                    Setting.Rows[row].Cells.Insert(insertColumnIndex, moveCellInfo);
                    for (int col = 0; col < Setting.Columns.Count; col++)
                    {
                        Setting.Rows[row].Cells[col].Col = col;
                    }
                }
                Set(Setting);
            }
        }

        private void SwapColumn(int col1, int col2)
        {
            Column tmp = Setting.Columns[col1]; 
            Setting.Columns[col1] = Setting.Columns[col2];
            Setting.Columns[col2] = tmp;

            for (int col = 0; col < Setting.Columns.Count; col++)
            {
                Setting.Columns[col].Index = col;
            }

            for (int row = 0; row < Setting.Rows.Count; row++)
            {
                CellInfo celltemp = Setting.Rows[row].Cells[col1];
                Setting.Rows[row].Cells[col1] = Setting.Rows[row].Cells[col2];
                Setting.Rows[row].Cells[col2] = celltemp;
                for (int col = 0; col < Setting.Columns.Count; col++)
                {
                    Setting.Rows[row].Cells[col].Col = col;
                }
            }
            Set(Setting);
        }

        int DragOverColumn = -1;
        Color DragOverColor;
        private void grid1_DragOver(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.Move && e.Data.GetDataPresent(typeof(DragDropItem)))
            {
                bool isRefresh = false;
                try
                {
                    DragDropItem ddi = e.Data.GetData(typeof(DragDropItem)) as DragDropItem;
                    if (ddi == null) return;
                    var ps1 = grid1.PositionAtPoint(grid1.PointToClient(new Point(e.X, e.Y)));

                    if (ps1.Column == DragOverColumn) return;

                    System.Diagnostics.Debug.WriteLine($"Start = {DragOverColumn},{DragOverColor }");
                    if (0 < grid1.Rows.Count && ps1.Column != DragOverColumn && (0 <= DragOverColumn && DragOverColumn < grid1.Columns.Count))
                    {
                        grid1[0, DragOverColumn].View.BackColor = DragOverColor;
                        DragOverColumn = -1;
                        isRefresh = true;
                    }
                    
                    System.Diagnostics.Debug.WriteLine($"Compare = {DragOverColumn},{DragOverColor }"); 
                    if (0 < grid1.Rows.Count && grid1[0, ps1.Column] != null && grid1[0, ps1.Column].View != null)
                    {
                        DragOverColumn = ps1.Column;
                        DragOverColor = grid1[0, ps1.Column].View.BackColor;
                        grid1[0, ps1.Column].View.BackColor = Color.Orange;
                        isRefresh = true;
                    } 
                    System.Diagnostics.Debug.WriteLine($"End = {DragOverColumn},{DragOverColor }");
                }
                catch (Exception ex)
                {
                    DragOverColumn = -1;
                }
                finally 
                {
                    if (isRefresh)
                    {
                        grid1.Refresh();
                    }
                }
            }
        } 

        private void chkColumnSwap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColumnSwap.Checked) 
            {
                chkColumnMoving.Checked = false;
                grid1.SelectionMode = SourceGrid.GridSelectionMode.Column;
                grid1.Selection.EnableMultiSelection = false;
                DragOverColumn = -1;

                /*그리드 제목 변경 후 이동시 원래값으로 복원되는것 방지*/
                for (int row = 0; row < Setting.Rows.Count; row++)
                {
                    for (int col = 0; col < Setting.Columns.Count; col++)
                    {
                        Setting.Rows[row].Cells[col].Value = grid1[row, col].Value;
                    }
                }
            }
            else
            {
                grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
                grid1.Selection.EnableMultiSelection = true; 

                if (0 < grid1.Rows.Count && 0 <= DragOverColumn && DragOverColumn < grid1.Columns.Count)
                {
                    grid1[0, DragOverColumn].View.BackColor = DragOverColor;
                    DragOverColumn = -1;
                    grid1.Refresh();
                }
            }
        }

        private void chkColumnMoving_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColumnMoving.Checked)
            {
                chkColumnSwap.Checked = false;
                grid1.SelectionMode = SourceGrid.GridSelectionMode.Column;
                grid1.Selection.EnableMultiSelection = false;
                DragOverColumn = -1;
                 
                /*그리드 제목 변경 후 이동시 원래값으로 복원되는것 방지*/
                for (int row = 0; row < Setting.Rows.Count; row++)
                {
                    for (int col = 0; col < Setting.Columns.Count; col++)
                    {
                        Setting.Rows[row].Cells[col].Value = grid1[row, col].Value;
                    }
                }

            }
            else
            {
                grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
                grid1.Selection.EnableMultiSelection = true;
                 
                if (0 < grid1.Rows.Count && 0 <= DragOverColumn && DragOverColumn < grid1.Columns.Count)
                {
                    grid1[0, DragOverColumn].View.BackColor = DragOverColor;
                    DragOverColumn = -1;
                    grid1.Refresh();
                }
            }
        }

        private void btnSearchCol_Click(object sender, EventArgs e)
        {
            //검색.
            if (string.IsNullOrWhiteSpace(txtSearchCol.Text)) return;

            for (int col = 0; col < Setting.Columns.Count; col++)
            {
                if (Setting.Columns[col].Name == txtSearchCol.Text)
                {
                    SetColumnView(col);
                    return;
                }
            }
        }

        private void txtSearchCol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCol.PerformClick();
            }
        }

        private void btnVisibleInvert_Click(object sender, EventArgs e)
        {
            var rng = grid1.Selection.GetSelectionRegion();

            if (0 < rng.Count)
            {
                List<int> colIndexs = new List<int>();
                for (int loop = 0; loop < rng.Count; loop++)
                {
                    for (int col = rng[loop].Start.Column; col <= rng[loop].End.Column; col++)
                    {
                        if (colIndexs.Contains(col) == false)
                        {
                            colIndexs.Add(col);
                        }
                    }
                }
                try
                {
                    grid1.SuspendLayout();
                    foreach (int col in colIndexs)
                    {
                        Setting.Columns[col].Visible = !Setting.Columns[col].Visible;
                        UpdateToGrid(Setting.Columns[col]);
                    }
                }
                finally
                {
                    grid1.ResumeLayout(true);
                    grid1.Selection.ResetSelection(false);
                }
            }
        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            using (EditSchemaForm efm = new EditSchemaForm())
            {
                if (efm.ShowDialog() == DialogResult.OK)
                {
                    if (0 < Setting.Rows.Count && MessageBox.Show("새 스키마 적용?", "확인", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    string schema = efm.SchemaInfo;

                    if (string.IsNullOrWhiteSpace(schema)) return;

                    string[] cols = schema.Replace("\r", "").Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    List<Tuple<string, string>> data = new List<Tuple<string, string>>();
                    foreach (var col in cols)
                    {
                        string name = "";
                        string header = "";
                        int pin = col.IndexOf(':');
                        if (0 < pin)
                        {
                            name = col.Substring(0, pin);
                            header = col.Substring(pin + 1);
                        }
                        else
                        {
                            name = col;
                        }

                        if (string.IsNullOrWhiteSpace(header)) header = name;

                        data.Add(Tuple.Create(name.Trim(), header.Trim()));
                    }
                    Setting.Set(grid1, data);
                    for (int cIndex = 0; cIndex < Setting.Columns.Count; cIndex++)
                    {
                        Column c = Setting.Columns[cIndex];
                        List<string> headers = new List<string>();
                        for (int rIndex = 0; rIndex < Setting.Rows.Count; rIndex++)
                        {
                            string celltext = "" + Setting.Rows[rIndex][cIndex].Value;

                            if (headers.Contains(celltext) == false)
                            {
                                headers.Add(celltext);
                            }
                        }
                        c.Header = string.Join(".", headers.ToArray());
                    }
                    // 수정가능하게 다시 설정.
                    Setting.ToEdit(grid1);
                }
            }
        } 
    }

    internal class DragDropItem
    {
        public DragDropItem()
        {
        }

        public int Column { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceGrid;

namespace JSFW.GridDesignerCommon
{
    public class GridSettings : ICloneable, IDisposable
    {
        public string GUID { get; set; }

        public string FileName { get; set; }

        public string GridName { get; set; }

        //ScreenDefinition 프로그램에서 그리드 표시여부로 연결되는 프로퍼티
        internal bool Visible { get; set; } = true;

        public List<Column> Columns { get; set; }

        public List<Row> Rows { get; set; } 

        public GridSettings()
        {
            Columns = new List<Column>();
            Rows = new List<Row>();
        }

        public static GridSettings FromObject(string settings)
        {
            if (string.IsNullOrWhiteSpace(settings)) return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<GridSettings>(settings);
        }

        public static string ToObject(GridSettings gridSettings)
        {
            if (gridSettings == null) return "";

            return Newtonsoft.Json.JsonConvert.SerializeObject(gridSettings, Newtonsoft.Json.Formatting.Indented);
        }

        internal System.Windows.Forms.DialogResult Edit()
        {
            System.Windows.Forms.DialogResult dialogResult = DialogResult.Cancel;

            using (SourceGridDll.GridEditForm editForm = new SourceGridDll.GridEditForm())
            {
                editForm.Set((GridSettings)this.Clone());
                dialogResult = editForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    this.GridName = editForm.Setting.GridName;
                    this.Visible = editForm.Setting.Visible;
                    this.Columns.Clear();
                    this.Columns.AddRange(editForm.Setting.Columns.ToArray());
                    this.Rows.Clear();
                    this.Rows.AddRange(editForm.Setting.Rows.ToArray());
                }
                return dialogResult;
            }
        }

        SourceGrid.Cells.Editors.TextBox SourcedGrid_HeaderTextBoxEdit { get; set; }
        SourceGrid.Cells.Editors.TextBox SourcedGrid_CellTextBoxEdit { get; set; }

        /// <summary>
        /// 화면정의 프로그램에서 사용.
        /// </summary>
        internal static bool UseScreenDefinition { get; set; } = false;

        private void InitGridEditor(bool enableEdit = true)
        {
            SourcedGrid_HeaderTextBoxEdit?.Dispose();
            SourcedGrid_HeaderTextBoxEdit = null;

            SourcedGrid_CellTextBoxEdit?.Dispose();
            SourcedGrid_CellTextBoxEdit = null;
             
            SourcedGrid_HeaderTextBoxEdit = new SourceGrid.Cells.Editors.TextBox(typeof(string)) { EnableEdit = enableEdit };
            SourcedGrid_CellTextBoxEdit = new SourceGrid.Cells.Editors.TextBox(typeof(string)) { EnableEdit = enableEdit };
        }
         
        internal void Set(Grid grid, List<Tuple<string, string>> data)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.RowsCount = 0;
            grid.ColumnsCount = 0;
            Columns.Clear();
            Rows.Clear();

            if (data == null) return;

            Row r = new Row(Rows.Count);
            Rows.Add(r);
            foreach (var tp in data)
            {
                Column column = new Column() { Index = Columns.Count, Name = tp.Item1, DataType = null };
                Columns.Add(column);
                r.Add(new CellInfo() { Row = 0, Col = column.Index, Value = tp.Item2 });
            } 
            To(grid); 
        }

        public void Set(SourceGrid.Grid grid, DataTable source)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.RowsCount = 0;
            grid.ColumnsCount = 0;
            Columns.Clear();
            Rows.Clear();

            if (source == null) return;

            Row r = new Row(Rows.Count);
            Rows.Add(r);
            foreach (DataColumn dc in source.Columns)
            {
                Column column = new Column() { Index = Columns.Count, Name = dc.ColumnName, DataType = dc.DataType };
                Columns.Add(column);
                r.Add(new CellInfo() { Row = 0, Col = column.Index, Value = column.Name });
            }
            To(grid);
        }

        internal void To(SourceGrid.Grid grid)
        {
            if (grid == null) return;

            GridSettings copySettings = this.Clone() as GridSettings;

            List<CellRange> mergeRange = GetMergeCellRange(copySettings, false);

            grid.Redim(0,0);
            grid.Redim(copySettings.Rows.Count, copySettings.Columns.Count);
            grid.FixedColumns = 0;
            grid.FixedRows = copySettings.Rows.Count;  // 설정하면 포커스 안들어감. 
            grid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;

            InitGridEditor(); 

            try
            {
                grid.SuspendLayout();

                foreach (var item in mergeRange)
                {
                    SourceGrid.Cells.ColumnHeader cell = grid[item.r1, item.c1] as SourceGrid.Cells.ColumnHeader;

                    if (cell == null)
                    {
                        cell = new SourceGrid.Cells.ColumnHeader(item.Value);
                        grid[item.r1, item.c1] = cell;                     
                    }
                     
                    cell.View = new SourceGrid.Cells.Views.ColumnHeader();
                    cell.View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    cell.View.Border = DevAge.Drawing.RectangleBorder.CreateInsetBorder(1, Color.Transparent, Color.LightGray);

                    cell.ColumnSpan = (item.c2 - item.c1) + 1;
                    cell.RowSpan = (item.r2 - item.r1) + 1;
                    cell.Value = item.Value;

                    Column info = copySettings.Columns[item.c1];
                    if (info != null)
                    {
                        if (info.Required)
                        {
                            cell.View.Font = new Font(grid.Font, FontStyle.Underline | FontStyle.Bold);
                        }

                        if (info.ReadOnly)
                        {
                            cell.View.BackColor = Color.LightGray;
                        }

                        if (info.Frozen)
                        {
                            grid.FixedColumns = info.Index;
                        }

                        if( info.IsSumColumn)
                        {
                            cell.View.ForeColor = Color.OrangeRed;
                        }
                    }
                }
                 
                foreach (Row r in copySettings.Rows)
                {
                    grid.Rows[r.Index].Height = 23;
                }

                foreach (Column col in copySettings.Columns)
                {
                    grid.Columns[col.Index].Visible = col.Visible;
                    if (col.Visible)
                    {
                        grid.Columns[col.Index].Width = col.Width;
                    }
                }

                grid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
                grid.Selection.EnableMultiSelection = true; 
            }
            finally {
                grid.ResumeLayout(true);
            }
        }

        // ignoreVisibleProperty : 화면정의 프로그램에서 그리드 표시할때 visible컬럼 모두 표시
        public static List<CellRange> GetMergeCellRange(GridSettings copySettings, bool ignoreVisibleProperty = false)
        {             
            for (int col = copySettings.Columns.Count - 1; col >= 0; col--)
            {
                if (ignoreVisibleProperty)
                {
                    copySettings.Columns[col].Visible = true;
                }

                if (copySettings.Columns[col].Visible == false)
                {
                    copySettings.Columns.RemoveAt(col);

                    for (int c = col; c < copySettings.Columns.Count; c++)
                    {
                        copySettings.Columns[c].Index = c;
                    }

                    for (int row = 0; row < copySettings.Rows.Count; row++)
                    {
                        copySettings.Rows[row].Cells.RemoveAt(col);
                        for (int c2 = 0; c2 < copySettings.Rows[row].Cells.Count; c2++)
                        {
                            copySettings.Rows[row].Cells[c2].Col = c2;
                        }
                    }
                }
            }

            int rowCount = copySettings.Rows.Count;
            int colCount = copySettings.Columns.Count;

            // Col Max 초기값 셋팅!
            int[] rowColMax = new int[rowCount];
            for (int loop = 0; loop < rowCount; loop++)
            {
                rowColMax[loop] = colCount;
            }

            // 동일한 셀목록
            Dictionary<int, List<int>> Cells = new Dictionary<int, List<int>>();

            // 병합된 셀 범위 목록
            List<CellRange> range = new List<CellRange>();

            // 탐색 좌표(x, y)
            int stRow = 0;
            int stCol = 0;

            int cnt = 0;
            while (stRow < rowCount && stCol < colCount)
            {               
                // 각 Row별 cell목록이 같은 목록을 구한다.
                if (copySettings.Rows[stRow][stCol] == null) break;

                if (copySettings.Columns[stCol].Visible == false)
                {
                    stCol++;
                    continue;
                }

                // CELL 값을 꺼낸다. 
                string cellValue = "" + copySettings.Rows[stRow][stCol].Value;
                
                // CELL 값이 같은 cell을 > 우측방향으로 탐색한다
                // CELL 값이 같은 경우 Cells에 담는다.
                for (int row = stRow; row < rowCount; row++)
                { 
                    if (copySettings.Rows[row][stCol] == null || cellValue != ("" + copySettings.Rows[row][stCol].Value))
                    {
                        rowColMax[row] = 0;
                        continue;
                    }

                    cellValue = "" + copySettings.Rows[row][stCol].Value;
                    Cells.Add(row, new List<int>());

                    for (int col = stCol; col < rowColMax[row]; col++)
                    {
                        if (copySettings.Columns[col].Visible && 
                            cellValue == "" + copySettings.Rows[row][col].Value)
                        {
                            // cellValue 와 동일한 값을 가진 Cell을 추가
                            Cells[row].Add(col);
                        }
                        else
                        {
                            if (col < colCount)
                            {
                                //각 row별 colmax 값 셋팅. (아래행 모두 최대값으로 설정하여 직사각형을 벗어나지 않게 )
                                for (int _row = row; _row < rowCount; _row++)
                                {
                                    rowColMax[_row] = col;
                                }
                            }
                            break;
                        }
                    }
                }
                 
                var cellrange = new CellRange() { Value = cellValue, r1 = stRow, c1 = stCol, r2 = stRow, c2 = stCol };
                range.Add(cellrange);

                //같은 값을 가진 cell들의 범위 확장 -> cellrange{ r1, c1, r2, c2 }
                for (int row = 0; row < Cells.Count; row++)
                {
                    var rowCells = Cells.ElementAt(row);
                    int colCnt = rowCells.Value.Count;
                    int colcnt_NextRow = colCnt;

                    if (row + 1 < Cells.Count)
                    {
                        colcnt_NextRow = Cells.ElementAt(row + 1).Value.Count;
                    }

                    if (colCnt == 0) continue;

                    if (colCnt == colcnt_NextRow)
                    {
                        cellrange.r2 = rowCells.Key;
                        cellrange.c2 = rowCells.Value[colCnt - 1];
                    }
                    else
                    {
                        if (rowCells.Key == 0)
                        {
                            cellrange.r2 = rowCells.Key;
                            cellrange.c2 = rowCells.Value[colCnt - 1];
                        }
                        break;
                    }
                }

                Cells.Clear();

                stRow = cellrange.r1;
                stCol = cellrange.c1;

                //다음에 시작할 탐색 좌표(x, y) 업데이트
                int idx = cellrange.r2 * colCount + cellrange.c2;
                if (idx >= (colCount * rowCount - 1)) break;

                if (cellrange.r2 + 1 < rowCount)
                {
                    if (rowColMax[cellrange.r2] > rowColMax[cellrange.r2 + 1])
                    {
                        for (int loop = cellrange.r2; loop < rowCount; loop++) rowColMax[loop] = rowColMax[cellrange.r2];
                        stRow = cellrange.r2 + 1;
                    }
                    else
                    {
                        if (stRow == 0)
                        {
                            stCol = cellrange.c2 + 1;
                            for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = colCount;
                        }
                        else
                        {
                            stRow--;
                            stCol = cellrange.c2 + 1;
                            for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = colCount;
                        }
                    }
                }
                else
                {
                    stRow = cellrange.r2;
                    if (stRow == 0)
                    {
                        rowColMax[stRow] = colCount;
                    }
                    else
                    {
                        do
                        {
                            if (rowColMax[stRow - 1] > rowColMax[stRow])
                            {
                                for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = rowColMax[stRow - 1];
                                break;
                            }
                            stRow--;

                            if (stRow == 0)
                            {
                                for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = colCount;
                                break;
                            }
                        } while (true);
                    }

                    stCol = cellrange.c2 + 1;

                    if (copySettings.Columns[stCol].Visible == false) continue;

                    // row증가를 시킬수 없을때 col Index 증가 가능 여부를 체크
                    if (stCol >= rowColMax[stRow])
                    {
                        // col 값이 꽉 찼을때 row -- 를 시켜 다음 진행 순서를 찾음.  
                        for (int loop = stRow - 1; loop >= 0; loop--)
                        {
                            if (stCol <= rowColMax[loop])
                            {
                                stRow = loop;
                                break;
                            }
                        }

                        if (stRow == 0)
                        {
                            for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = colCount;
                        }
                        else
                        {
                            // row를 찾고
                            if (rowColMax[stRow - 1] > rowColMax[stRow])
                            {
                                for (int loop = stRow; loop < rowCount; loop++) rowColMax[loop] = rowColMax[stRow - 1];
                            }
                        }
                    }
                }
                cnt++;
            }
            // cellranges 목록 병합 소스 ! 
            return range;
        } 

        internal void ToEdit(SourceGrid.Grid grid)
        {
            if (grid == null) return;

            grid.ColumnsCount = Columns.Count;
            grid.RowsCount = Rows.Count;
            grid.FixedColumns = 0;
            grid.FixedRows = 0;

            grid.OptimizeMode = SourceGrid.CellOptimizeMode.ForColumns;

            InitGridEditor();

            try
            {
                grid.SuspendLayout();
                 
                foreach (Column col in Columns)
                {
                    grid.Columns[col.Index].Width = col.Width;
                }

                foreach (Row r in Rows)
                {
                    grid.Rows[r.Index].Height = 22;
                    foreach (CellInfo cInfo in r.Cells)
                    {
                        grid[cInfo.Row, cInfo.Col] = new SourceGrid.Cells.Cell(cInfo.Value, SourcedGrid_HeaderTextBoxEdit);
                        grid[cInfo.Row, cInfo.Col].View = new SourceGrid.Cells.Views.Cell()
                        {
                            Border = DevAge.Drawing.RectangleBorder.CreateInsetBorder(1, Color.Transparent, Color.Gray),
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                        };
                    }
                }
                grid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
                grid.Selection.EnableMultiSelection = true;
            }
            finally
            {
                grid.ResumeLayout(true);
            }
        }

        public object Clone()
        {
            GridSettings setting = new GridSettings();
            setting.GridName = GridName;
            setting.Visible = Visible;
            setting.InitGridEditor();
            foreach (var col in Columns)
            {
                Column nc = new Column()
                {
                    Index = col.Index,
                    Name = col.Name,
                    DataType = col.DataType,
                    Required = col.Required,
                    Visible = col.Visible,
                    Merge = col.Merge,
                    ReadOnly = col.ReadOnly,
                    Width = col.Width,
                    Header = col.Header,
                    TextAlign = col.TextAlign,
                    Lv1 = col.Lv1,
                    Lv2 = col.Lv2,
                    Lv3 = col.Lv3,
                    IsSumColumn = col.IsSumColumn,
                    Frozen = col.Frozen,
                };
                setting.Columns.Add(nc);
            }

            foreach (var row in Rows)
            {
                Row nr = new Row(setting.Rows.Count);

                foreach (var cell in row.Cells)
                {
                    CellInfo ncell = new CellInfo()
                    {
                        Col = cell.Col,
                        Row = cell.Row,
                        Value = cell.Value
                    };
                    nr.Cells.Add(ncell);
                }
                setting.Rows.Add(nr);
            }
            return setting;
        }

        public void Dispose()
        {
            Rows?.Clear(); Rows = null;
            Columns?.Clear(); Columns = null;
            SourcedGrid_HeaderTextBoxEdit = null;
            SourcedGrid_CellTextBoxEdit = null;
        }
    }
     
    public class Column
    { 
        public int Index { get; set; }

        public string Name { get; set; }
        
        public Type DataType { get; set; }

        public bool Required { get; set; } = false;

        public bool Visible { get; set; } = true;

        public bool Merge { get; set; } = false;

        public bool ReadOnly { get; set; }

        public int Width { get; set; } = 100;

        public string Header { get; set; }

        public TEXTALIGN TextAlign { get; set; } = TEXTALIGN.CENTER;

        public LEVEL1 Lv1 { get; set; } = LEVEL1.문자;

        public LEVEL2 Lv2 { get; set; } = LEVEL2.일반;

        public LEVEL3 Lv3 { get; set; } = LEVEL3.일반;
        public bool IsSumColumn { get; set; } = false;
        public bool Frozen { get; set; } = false;

        public override string ToString()
        {
            return $"Index={Index}, Name={Name}, Header={Header}, TextAlign={TextAlign}, {Lv1}, {Lv2}, {Lv3}, {(Required?" 필수,":"")}{(ReadOnly ? " 읽기전용," : "편집가능, ")}{(!Visible?" 숨김," : "")}{(IsSumColumn ? " 합계열," : "")}{(Frozen ? " 열고정," : "")}";
        }
    }

    public class Row
    {
        public int Index { get; set; }

        public List<CellInfo> Cells { get; set; }

        public Row(int idx)
        {
            Index = idx;
            Cells = new List<CellInfo>();
        }

        public void Add(CellInfo cell)
        {
            if (cell == null) return;

            cell.Row = Index;
            Cells.Add(cell);
        }

        public CellInfo this[int col]
        {
            get 
            {
                if (0 <= col && col < Cells.Count && 0 < Cells.Count)
                {
                    return Cells[col];
                }
                else
                {
                    return null;
                }
            }
        }

        public override string ToString()
        {
            return $"row={Index}";
        }
    }

    public class CellInfo
    { 
        public int Row { get; set; }

        public int Col { get; set; }
       
        public object Value { get; set; }

        public override string ToString()
        {
            return $"R={Row}, C={Col}, V={Value}";
        }
    }

    public class CellRange
    {
        public int r1 { get; set; }
        public int r2 { get; set; }

        public int c1 { get; set; }
        public int c2 { get; set; }

        public object Value { get; set; }

        public override string ToString()
        {
            return $"[{r1,2},{c1,2}] [{r2,2},{c2,2}], V={Value}";
        }
    }

    public enum LEVEL1
    {
        문자,
        숫자,
        콤보,
        체크 
    }

    public enum LEVEL2
    { 
        일반,
        날짜,
        코드파인드,
        YN,
        DataMap
    }

    public enum LEVEL3
    { 
        일반,
        년월일,
        년월,
        년도,
        N,
        N_N,
        N_NN,
        N_NNN,
        N_NNNN
    }

    public enum TEXTALIGN
    { 
        LEFT,
        CENTER,
        RIGHT
    }
}

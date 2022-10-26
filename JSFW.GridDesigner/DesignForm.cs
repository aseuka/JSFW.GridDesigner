using JSFW.GridDesignerCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesigner
{
    public partial class DesignForm : Form
    {
        static string _DRIVE = GetDrive(@"D:\");
        /// <summary>
        /// D:\JSFW\GridDesigner\
        /// </summary>
        static string _ROOT = _DRIVE + @"JSFW\GridDesigner\";
        /// <summary>
        /// D:\JSFW\GridDesigner\Extension\
        /// </summary>
        static string _EXTENSION = _ROOT + @"Extension\";

        GridSettings settings { get; set; }

        public DesignForm()
        {
            InitializeComponent();

            if (!Directory.GetLogicalDrives().Contains(_DRIVE))
            {
                _DRIVE = Directory.GetLogicalDrives()[0];

                _ROOT = _DRIVE + @"JSFW\GridDesigner\";

                _EXTENSION = _ROOT + @"Extension\";
            }

            SetCboProjects();

            if (Directory.Exists(_EXTENSION) == false)
            {
                Directory.CreateDirectory(_EXTENSION);
            }
        }

        bool isSetProjects = false;
        private void SetCboProjects(string initProjectName = "")
        {
            try
            {
                isSetProjects = true;
                cboProject.SelectedIndex = -1;
                cboProject.Items.Clear();
                string[] projects = Directory.GetDirectories(_ROOT);
                cboProject.Items.Add("");
                cboProject.Items.Add("새로만들기");

                int initSelectedIndex = -1;
                foreach (string prj in projects)
                {
                    if (prj.EndsWith(_EXTENSION.TrimEnd('\\')))
                    {
                        continue;
                    }
                    string _prj = prj.Substring(_ROOT.Length, prj.Length - _ROOT.Length);
                    cboProject.Items.Add(_prj);

                    if (_prj == initProjectName)
                    {
                        initSelectedIndex = cboProject.Items.Count - 1;
                    }
                }
                cboProject.SelectedIndex = initSelectedIndex;

            }
            finally 
            {
                isSetProjects = false;

                string dir = ("" + cboProject.SelectedItem).TrimEnd();

                btnOpen.Enabled = dir != "새로만들기";
                btnNew.Enabled = dir != "새로만들기";
                btnGetDBSchema.Enabled = dir != "새로만들기";
                btnEdit.Enabled = dir != "새로만들기";
                flowLayoutPanel1.Enabled = dir != "새로만들기";

            }
        }

        private static string GetDrive(string drive)
        {
            if (!Directory.GetLogicalDrives().Contains(drive))
            {
                drive = Directory.GetLogicalDrives()[0];
            }
            return drive;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 로딩
            //DataTable source = new DataTable();
            //for (int loop = 1; loop <= 4; loop++)
            //{
            //    source.Columns.Add($"Col{loop:D2}");
            //}
            //settings.Set(grid1, source);


            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = $"그리드 디자인 - {ApplicationDeployment.CurrentDeployment.CurrentVersion}";
            }

            btnEdit.Enabled = false;
            btnGetDBSchema.Enabled = false;
            btnRefreshExtension.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("파일명 필수");
                txtFileName.ReadOnly = false;
                txtFileName.Focus();
                return;
            }

            if (settings.Edit() == DialogResult.OK)
            {
                grid1.Rows.Clear();
                grid1.Columns.Clear();

                grid1.FixedColumns = 0;
                grid1.FixedRows = 0;

                grid1.Redim(0, 0);

                settings.To(grid1);

                if (string.IsNullOrWhiteSpace(txtFileName.Text)) return;

                settings.FileName = txtFileName.Text.Trim();
                GridDesignerCommon.Ux.SaveFile<GridSettings>(settings, $"{_ROOT}{cboProject.SelectedItem}\\{settings.FileName}.{settings.GridName}.gdx");
            }            
        }

        private void btnRefreshExtension_Click(object sender, EventArgs e)
        {
            //새로고침.
            try
            {
                flowLayoutPanel1.SuspendLayout();
                for (int loop = flowLayoutPanel1.Controls.Count - 1; loop >= 0; loop--)
                {
                    ExtensionInfoControl extension = flowLayoutPanel1.Controls[loop] as ExtensionInfoControl;
                    if (extension == null)
                    {
                        flowLayoutPanel1.Controls.RemoveAt(loop); continue;
                    }
                    using (extension)
                    {
                        flowLayoutPanel1.Controls.Remove(extension);
                        // 이벤트 제거.
                        extension.Execute += InfoControl_Execute;
                    }
                }

                // 읽어들이기.
                string[] dirs = System.IO.Directory.GetDirectories(_EXTENSION);

                if (0 < dirs.Length)
                {
                    foreach (var dir in dirs)
                    {
                        string extName = Path.GetDirectoryName(dir);

                        string[] files = Directory.GetFiles(dir, "JSFW.*.dll");

                        foreach (var file in files)
                        {
                            string fileName = Path.GetFileName(file);
                            if (fileName == "JSFW.GridDesignerCommon.dll") continue;
                            if (fileName == "Newtonsoft.Json.dll") continue;
                            if (fileName == "SourceGrid.dll") continue;

                            //for (int loop = 0; loop < 15; loop++)
                            {
                                ExtensionInfo extension = GridDesignerExtensionPlugInAttribute.Load(file);
                                ExtensionInfoControl infoControl = new ExtensionInfoControl();
                                infoControl.Set(extension);
                                infoControl.Execute += InfoControl_Execute;
                                flowLayoutPanel1.Controls.Add(infoControl);
                            }
                        }
                    }
                }
            }
            finally
            {
                flowLayoutPanel1.ResumeLayout(true);
            }
        }

        private void InfoControl_Execute(ExtensionInfo info)
        {
            info.Execute(GridSettings.ToObject(settings));
        }

        private void btnCreateExtProject_Click(object sender, EventArgs e)
        {
            // 확장 프로젝트 생성!!

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // 초기화
            btnEdit.Enabled = false;
            settings?.Dispose();
            settings = new GridSettings() { GUID = Guid.NewGuid().ToString("N") };
            DisplayInfo(settings);
            settings.To( grid1);
            btnGetDBSchema.Enabled = settings != null;
        }

        private void DisplayInfo(GridSettings settings)
        {
            lbGridGUID.Text = "";
            txtFileName.Clear();

            if (settings == null) return;

            lbGridGUID.Text = settings.GUID;
            txtFileName.Text = settings.FileName;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // open!
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "(*.gdx)|*.gdx";
                ofd.InitialDirectory = _ROOT + cboProject.SelectedItem;
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    GridSettings temp = GridDesignerCommon.Ux.LoadFile<GridSettings>( ofd.FileName );
                    if (temp == null)
                    {
                        MessageBox.Show("열기 실패");
                        return;
                    }
                    
                    string prjName = Path.GetDirectoryName(ofd.FileName);
                    if (_ROOT.Length < prjName.Length)
                    {
                        prjName = prjName.Substring(_ROOT.Length, prjName.Length - _ROOT.Length);
                        int prjIndex = cboProject.Items.IndexOf(prjName);
                        cboProject.SelectedIndex = prjIndex;
                    }
                    else
                    {
                        int prjIndex = cboProject.Items.IndexOf("");
                        cboProject.SelectedIndex = prjIndex;
                    }

                    settings?.Dispose();
                    settings = null;
                    settings = temp;
                    DisplayInfo(settings);
                    settings.To(grid1);
                }
                btnGetDBSchema.Enabled = settings != null;
                btnEdit.Enabled = true;
            }
        }

        private void btnGetDBSchema_Click(object sender, EventArgs e)
        {
            // 스키마 설정.
            using (EditSchemaForm efm = new EditSchemaForm())
            {
                if (efm.ShowDialog() == DialogResult.OK)
                {
                    if (0 < settings.Rows.Count && MessageBox.Show("새 스키마 적용?", "확인", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    string schema = efm.SchemaInfo;

                    if (string.IsNullOrWhiteSpace(schema)) return;

                    string[] cols = schema.Replace("\r", "").Split( new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    List<Tuple<string, string>> data = new List<Tuple<string, string>>();
                    foreach (var col in cols)
                    {
                        string name = "";
                        string header = "";
                        int pin = col.IndexOf(':');
                        if (0 < pin)
                        {
                            name = col.Substring(0, pin);
                            header = col.Substring(pin+1);
                        }
                        else
                        {
                            name = col;
                        }

                        if (string.IsNullOrWhiteSpace(header)) header = name;

                        data.Add(Tuple.Create(name.Trim(), header.Trim()));
                    }
                    settings.Set(grid1, data);
                     
                    for (int cIndex = 0; cIndex < settings.Columns.Count; cIndex++)
                    {
                        Column c = settings.Columns[cIndex];
                        List<string> headers = new List<string>();
                        for (int rIndex = 0; rIndex < settings.Rows.Count; rIndex++)
                        {
                            string celltext = "" + settings.Rows[rIndex][cIndex].Value;

                            if (headers.Contains(celltext) == false)
                            {
                                headers.Add(celltext);
                            }
                        }
                        c.Header = string.Join(".", headers.ToArray());
                    }
                    btnEdit.Enabled = true;
                }
            }
        }

        private void txtFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //수정.
                if (settings != null)
                {
                    txtFileName.ReadOnly = false;
                }
                else
                {
                    txtFileName.ReadOnly = true;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.SendWait("{TAB}");
            }
        }

        private void txtFileName_Leave(object sender, EventArgs e)
        {
            txtFileName.ReadOnly = true;
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
           
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSetProjects) return;

            btnNew.PerformClick();

            string dir = ("" + cboProject.SelectedItem).TrimEnd();

            btnOpen.Enabled = dir != "새로만들기";
            btnNew.Enabled = dir != "새로만들기";
            btnGetDBSchema.Enabled = dir != "새로만들기";
            btnEdit.Enabled = dir != "새로만들기";
            flowLayoutPanel1.Enabled = dir != "새로만들기";

            if (dir == "새로만들기")
            { 
                using (NewDirectoryForm fm = new NewDirectoryForm(_ROOT))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        Directory.CreateDirectory(_ROOT + fm.ProjectText);
                        SetCboProjects(fm.ProjectText);
                    }
                    else
                    {
                        cboProject.SelectedIndex = -1;
                    }
                }
            }            
        }
    }
}

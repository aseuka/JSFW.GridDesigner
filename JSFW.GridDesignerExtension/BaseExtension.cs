using JSFW.GridDesignerCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesignerExtension
{
    // 프로젝트 빌드 후 이벤트 
    // xcopy /e /y /r "$(TargetDir)*" "D:\JSFW\GridDesigner\Extension\$(ProjectName)\" 
    [GridDesignerExtensionPlugIn( Name = "테스트 외부기능", Description = "테스트 확장기능임.")] 
    public class TestExtension : BaseExtension
    {
        public override void Execute(string settings) 
        {
            GridSettings grdInfo = GridSettings.FromObject(settings);
            if (grdInfo == null) return;

            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.WriteLine($"grid.Name={grdInfo.GridName}");

                foreach (var r in grdInfo.Rows)
                {
                    sw.WriteLine($"- row : {r.Index + 1}");
                    foreach (var c in grdInfo.Columns)
                    {
                        sw.WriteLine($"   - col : {c}");
                    }
                    sw.WriteLine("");
                }
                sw.WriteLine("");

                //GridSettings cloneGridInfo = grdInfo.Clone() as GridSettings;
                List <CellRange> merge = GridSettings.GetMergeCellRange(grdInfo);
                foreach (var mr in merge)
                {
                    sw.WriteLine($"merge : {mr}");
                }
            }
            MessageBox.Show("" + sb);
        }
    }
}

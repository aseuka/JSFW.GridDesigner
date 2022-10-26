using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JSFW.GridDesignerCommon
{
    public class GridDesignerExtensionPlugInAttribute : Attribute
    {
        protected bool Used { get; set; } = true;
         
        public string Name { get; set; }

        public string Description { get; set; }

        public GridDesignerExtensionPlugInAttribute() : base()
        {

        }

        public GridDesignerExtensionPlugInAttribute(bool isUsed) : this()
        {
            Used = isUsed;
        }

        internal static ExtensionInfo Load(string path)
        {
            ExtensionInfo exInfo = new ExtensionInfo();
            exInfo.Path = path;

            if (string.IsNullOrWhiteSpace(path))
            {
                exInfo.ErrorMessage = "File 없음";
                return exInfo;
            }

            try
            {
                Assembly asm = Assembly.LoadFile(path);
                Type[] ts = asm.GetTypes();
                foreach (var t in ts)
                {
                    GridDesignerExtensionPlugInAttribute atts = t.GetCustomAttribute(typeof(GridDesignerExtensionPlugInAttribute)) as GridDesignerExtensionPlugInAttribute;
                    if (atts != null)
                    {
                        exInfo.Name = atts.Name;
                        exInfo.TypeName = t.FullName;
                        exInfo.Description = atts.Description;
                    }
                }
                asm = null;
            }
            catch (Exception ex)
            {
                exInfo.ErrorMessage = ""+ ex;
            }
            return exInfo;
        }
    }
     
    internal class ExtensionInfo
    { 
        public string Path { get; internal set; }
         
        public string Name { get; internal set; }
        public string TypeName { get; internal set; }
        public string Description { get; internal set; }

        public string ErrorMessage { get; internal set; }

        internal void Execute(string gridSettings)
        { 
            if (string.IsNullOrWhiteSpace(Path))
            {
                return;
            }

            try
            {
                Assembly asm = Assembly.LoadFile(Path);
                Type[] ts = asm.GetTypes();
                foreach (var t in ts)
                {
                    GridDesignerExtensionPlugInAttribute atts = t.GetCustomAttribute(typeof(GridDesignerExtensionPlugInAttribute)) as GridDesignerExtensionPlugInAttribute;
                    if (atts != null)
                    {
                        BaseExtension exe = asm.CreateInstance(t.FullName) as BaseExtension;
                        if (exe == null)
                        {
                            continue;
                        }
                        exe.Execute(gridSettings);
                        //MethodInfo executeMethod = t.GetMethod(nameof(BaseExtension.Execute), BindingFlags.Public | BindingFlags.Instance);
                        //if (executeMethod != null)
                        //{
                        //    executeMethod.Invoke(exe, new object[] { gridSettings });
                        //}
                    }
                }
                asm = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

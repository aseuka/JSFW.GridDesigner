using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSFW.GridDesignerCommon
{
    [GridDesignerExtensionPlugIn(false)]
    public abstract class BaseExtension
    {
        public abstract void Execute(string settings);
    }
}

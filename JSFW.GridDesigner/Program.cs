using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesigner
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String mtxName = System.Diagnostics.Process.GetCurrentProcess()?.ProcessName ?? "JSFW.GridDesigner";
            Boolean mtxSuccess;

            System.Threading.Mutex mtx = new System.Threading.Mutex(true, mtxName, out mtxSuccess);
            if (!mtxSuccess)
            {
                MessageBox.Show("이미실행중입니다.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DesignForm());

            mtx.ReleaseMutex();
        }
    }
}

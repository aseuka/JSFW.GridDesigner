using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSFW.GridDesignerExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string setting = @"{""GUID"":""66e07bae635a4ed68b57c28f39461e53"",""FileName"":""aaa"",""GridName"":""grdData"",""Columns"":[{""Index"":0,""Name"":""aaa"",""DataType"":null,""Required"":false,""Visible"":true,""Merge"":false,""ReadOnly"":false,""Width"":100,""TextAlign"":1,""Lv1"":0,""Lv2"":0,""Lv3"":0},{""Index"":1,""Name"":""bbb"",""DataType"":null,""Required"":false,""Visible"":true,""Merge"":false,""ReadOnly"":false,""Width"":100,""TextAlign"":1,""Lv1"":0,""Lv2"":0,""Lv3"":0},{""Index"":2,""Name"":""ccc"",""DataType"":null,""Required"":true,""Visible"":true,""Merge"":false,""ReadOnly"":false,""Width"":100,""TextAlign"":1,""Lv1"":0,""Lv2"":0,""Lv3"":0},{""Index"":3,""Name"":""ddd"",""DataType"":null,""Required"":false,""Visible"":true,""Merge"":false,""ReadOnly"":false,""Width"":100,""TextAlign"":1,""Lv1"":0,""Lv2"":0,""Lv3"":0}],""Rows"":[{""Index"":0,""Cells"":[{""Row"":0,""Col"":0,""Value"":""aaa""},{""Row"":0,""Col"":1,""Value"":""bbb""},{""Row"":0,""Col"":2,""Value"":""ccc""},{""Row"":0,""Col"":3,""Value"":""ddd""}]}]}";
            TestExtension test = new TestExtension();
            test.Execute(setting);
        }
    }
}

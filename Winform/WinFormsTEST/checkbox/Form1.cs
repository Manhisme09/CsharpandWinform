using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tBvalue.Text;
            string gay = cBvalue.CheckState == CheckState.Checked ? "bị" : cBvalue.CheckState == CheckState.Unchecked ? "ko bị" : "bị cũng ko bị";
            string showString = string.Format("Chào bạn {0} bạn {1} gay", name, gay);
            MessageBox.Show(showString);
        }
    }
}

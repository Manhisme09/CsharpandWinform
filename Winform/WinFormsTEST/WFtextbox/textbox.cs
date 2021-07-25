using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFtextbox
{
    public partial class textbox : Form
    {
        public textbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toan, van, anh, su, tongDiem;
            toan = Convert.ToDouble(tBtoan.Text);
            van = Convert.ToDouble(tBvan.Text);
            anh = Convert.ToDouble(tBanh.Text);
            su = Convert.ToDouble(tBsu.Text);
            tongDiem = toan * 2 + van * 2 + anh + su;
            TongDiem.Text = tongDiem.ToString();

            if (Convert.ToInt32(TongDiem.Text) > 35)
            {
                KQ.Text = "Chuc Mung ban da trung tuyen";
            }
            else
            {
                KQ.Text = "BAn da truot";
            }
        }
    }
}

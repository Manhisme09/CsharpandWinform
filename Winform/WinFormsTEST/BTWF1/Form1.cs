using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addNgay();
            addThang();
            addNam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng ký thành công");
        }

        void addNgay()
        {
            List<int> num = new List<int>();
            for (int i = 1; i < 32; i++)
            {
                num.Add(i);
            }
            cBngay.DataSource = num;
        }
        void addThang()
        {
            List<int> num = new List<int>();
            for (int i = 1; i < 13; i++)
            {
                num.Add(i);
            }
            cBthang.DataSource = num;
        }
        void addNam()
        {
            List<int> num = new List<int>();
            for (int i = 1980; i <= 2021; i++)
            {
                num.Add(i);
            }
            cBnam.DataSource = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rTBKetqua.Text = tboten.Text + "\n" + cBngay.Text + "/" + cBthang.Text + "/" + cBnam.Text + "\n" + tbsothich.Text;
        }
    }
}

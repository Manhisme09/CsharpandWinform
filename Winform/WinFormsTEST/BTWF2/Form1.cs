using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWF2
{
    public partial class Form1 : Form
    {
        private bool ktra = true;
        private string beforeValue, pheptoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "1";
            ktra = false;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "2";
            ktra = false;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "3";
            ktra = false;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "4";
            ktra = false;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "5";
            ktra = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "6";
            ktra = false;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "7";
            ktra = false;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "8";
            ktra = false;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "9";
            ktra = false;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ktra) ketQua.Clear();
            ketQua.Text = ketQua.Text + "0";
            ktra = false;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            beforeValue = ketQua.Text;
            pheptoan = "+";
            ktra = true;
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            beforeValue = ketQua.Text;
            pheptoan = "-";
            ktra = true;
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            beforeValue = ketQua.Text;
            pheptoan = "*";
            ktra = true;
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            beforeValue = ketQua.Text;
            pheptoan = "/";
            ktra = true;
        }

        private void btn_bang_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(beforeValue);
            b = Convert.ToInt32(ketQua.Text);
            if (pheptoan == "+")
            {
                ketQua.Text = Convert.ToString(a + b);

            }
            else if(pheptoan=="-")
            {
                ketQua.Text = Convert.ToString(a - b);
            }
            else if(pheptoan=="*")
            {
                ketQua.Text = Convert.ToString(a * b);
            }
            else
            {
                ketQua.Text = Convert.ToString(a / b);
            }
        }

        private void btn_am_Click(object sender, EventArgs e)
        {
            ketQua.Text =  "-";
            ktra = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ketQua.Clear();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWF3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        bool ktra(int n)
        {
            int dem = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    dem++;              
            }
            if (dem == 0) return true;

            else
                return false;
        }
        private void tBox_nhapn_TextChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tBox_nhapn.Text);
            if (ktra(num))
            {
                tBox_ktra.Text = Convert.ToString(num) +" " + "là số nguyên tố";
            }
            else
            {
                tBox_ktra.Text = Convert.ToString(num) + " " + " không là số nguyên tố";
            }

            string ketqua = "";
            for (int i = 1; i < num; i++)
            {
                if (ktra(i))
                {
                    ketqua = ketqua + i.ToString() + " ";
                }
                tBox_in.Text = ketqua;
            }

        }
    }
}

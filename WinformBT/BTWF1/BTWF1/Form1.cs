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
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            if (chb_hienthitb.Checked == true)
            {
                if (rad_do.Checked == true)
                {
                    lb_hienthi.ForeColor = Color.Red;
                    lb_hienthi.Text = tB_ten.Text + "," + tB_thongbao.Text;
                }  
                if (rad_tim.Checked == true)
                {
                    lb_hienthi.ForeColor = Color.Violet;
                    lb_hienthi.Text = tB_ten.Text + "," + tB_thongbao.Text;
                }  
                if (rad_vang.Checked == true)
                {
                    lb_hienthi.ForeColor = Color.Yellow;
                    lb_hienthi.Text = tB_ten.Text + "," + tB_thongbao.Text;
                }  
                if (rad_xanh.Checked == true)
                {
                    lb_hienthi.ForeColor = Color.Blue;
                    lb_hienthi.Text = tB_ten.Text + "," + tB_thongbao.Text;
                }
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tB_ten.Clear();
            tB_thongbao.Clear();

            lb_hienthi.Text = String.Empty;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Quản_lý_khác_sạn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5IID40;Initial Catalog=QLNV;Integrated Security=True");
            try
            {
                con.Open();
                string tk = tB_taikhoan.Text;
                string mk = tB_matkhau.Text;
                string sql = "select * from Login where taikhoan = '"+tk+"' and matkhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

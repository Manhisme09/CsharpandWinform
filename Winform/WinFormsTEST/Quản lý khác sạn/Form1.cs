using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_khác_sạn
{
    public partial class Form1 : Form
    {
        QLNVEntities db = new QLNVEntities();
        public Form1()
        {
            
            InitializeComponent();
            loadData();
            //addBinding();
            addTT();
            
            
        }


        void loadData()
        {
            var resuilt = from c in db.nhanviens
                          select new {
                              c.manv,
                              c.tennv,
                              c.luong,
                              c.tinhtrang,
                          };
            dataGV_NV.DataSource = resuilt.ToList();
        }
        //void addBinding()
        //{
        //    tB_manv.DataBindings.Add(new Binding("Text", dataGV_NV.DataSource,"manv", true, DataSourceUpdateMode.Never));
        //    tB_Tennv.DataBindings.Add(new Binding("Text", dataGV_NV.DataSource, "tennv", true, DataSourceUpdateMode.Never));
        //    tB_luong.DataBindings.Add(new Binding("Text", dataGV_NV.DataSource, "luong",true,DataSourceUpdateMode.Never));
        //    cB_tinhtrang.DataBindings.Add(new Binding("Text", dataGV_NV.DataSource, "tinhtrang", true, DataSourceUpdateMode.Never));
        //}
           
          
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(tB_luong.Text);
            string manv = dataGV_NV.SelectedCells[0].OwningRow.Cells["manv"].Value.ToString();
        
            nhanvien nv = db.nhanviens.Find(manv);
            nv.manv = tB_manv.Text;
            nv.tennv = tB_Tennv.Text;
            nv.luong = salary;
            nv.tinhtrang = cB_tinhtrang.Text;
            db.SaveChanges();
            loadData();
            

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            nhanvien nv = new nhanvien() { manv = tB_manv.Text, tennv = tB_Tennv.Text, luong = Convert.ToInt32(tB_luong.Text), tinhtrang = cB_tinhtrang.Text };
            db.nhanviens.Add(nv);
            db.SaveChanges();
            loadData();
            

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            int salary = Convert.ToInt32(tB_luong.Text);
            nhanvien nv = db.nhanviens.Where(p => p.luong == salary && p.manv == tB_manv.Text && p.tennv == tB_Tennv.Text && p.tinhtrang == cB_tinhtrang.Text).SingleOrDefault();
            db.nhanviens.Remove(nv);
            db.SaveChanges();
            loadData();
            



            //nhanvien nv = db.nhanviens.Find("SV03");
            //db.nhanviens.Remove(nv);
            //db.SaveChanges();
            //loadData();
        }

        void addTT()
        {
            List<string> listTT;
            listTT = new List<string>();
            listTT.Add("Tốt");
            listTT.Add("Kém");
            listTT.Add("Trung bình");
            cB_tinhtrang.DataSource = listTT;
        }

        private void dataGV_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGV_NV.Rows[e.RowIndex];
                tB_manv.Text = row.Cells[0].Value.ToString();
                tB_Tennv.Text = row.Cells[1].Value.ToString();
                tB_luong.Text = row.Cells[2].Value.ToString();
                cB_tinhtrang.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}




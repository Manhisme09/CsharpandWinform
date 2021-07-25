using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEntity
{
    public partial class Form1 : Form
    {
        KteamEntities db = new KteamEntities();
        public Form1()
        {
            InitializeComponent();
            loadData();
            addBinding();
        }

        void addBinding()
        {
            tB_id.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "masv"));
            tB_show.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "tensv"));
        }
        void loadData()
        {

            //KteamEntities db = new KteamEntities();
            //dtgvData.DataSource = db.SinhViens.ToList();

            
                var resuilt = from c in db.SinhViens
                              select new { 
                                  c.masv,
                                  c.tensv,
                                  c.malop,
                                  c.Lop.tenlop,
                              };


                //var resuilt = from c in db.SinhViens
                //              from d in db.Lops
                //              where c.malop == d.malop
                //              select new {
                //                  c.tensv,
                //                  d.tenlop,
                //              };

                dtgvData.DataSource = resuilt.ToList();
            
        }

        void AddSv()
        {
            SinhVien sv = new SinhVien() { masv = "SV100", tensv = "M9", malop = "L02" };

            db.SinhViens.Add(sv);
            db.SaveChanges();
            
        }

        void DeleteSv()
        {
            SinhVien sv = db.SinhViens.Find("SV02");
            db.SinhViens.Remove(sv);
            db.SaveChanges();
        }

        void EditSv()
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSv();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteSv();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditSv();
        }
    }
}

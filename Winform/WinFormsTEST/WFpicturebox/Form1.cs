using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFpicturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadImage();
        }

        void loadImage()
        {
            List<string> listImage = new List<string>()
            {
                "gai3.jpg",
                "image.jpg",
                "gai2.jpg"
            };

            comboBox1.DataSource = listImage;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\"+cb.SelectedValue.ToString());
                pictureBox1.Image = bm;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            newLabel();
        }

        void newLabel()
        {
            Label lb = new Label();
            lb.Text = "abc";
            lb.ForeColor = Color.Black;
            this.Controls.Add(lb);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
            Form2 f = new Form2();
            f.Show();
            f.lb2.Text = "cc";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "dmm";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Hieu";
        }
    }
}

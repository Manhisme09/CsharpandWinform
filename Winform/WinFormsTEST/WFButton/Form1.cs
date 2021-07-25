using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            addButton();
           
        }
        void addButton()
        {

            Random rand = new Random();
            Button btn = new Button() { Text = i.ToString(), Location = new Point(rand.Next(1, 100), rand.Next(1, 100)) };
           
            this.Controls.Add(btn);
            
            i++;
            btn.Click += Btn_Click1;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
    }
}

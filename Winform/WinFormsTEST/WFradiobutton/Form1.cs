using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFradiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void show(Label lb,Panel pnl)
        {
            RadioButton rbtn = new RadioButton();
            foreach (RadioButton item in pnl.Controls)
            {
                
                if(item.Checked)
                {
                    rbtn = item;
                    break;
                }
            }
            if (rbtn != null)
            {
                lb.Text = rbtn.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            show(label1, panel1);
            show(label2, panel2);
            show(label3, panel3);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if(radio.Checked)
            {
                label1.Text = radio.Text;
            }
        }
    }
}

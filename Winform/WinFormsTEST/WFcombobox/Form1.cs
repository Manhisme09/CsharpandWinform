using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    MessageBox.Show(cb.SelectedIndex.ToString());
        //}

        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    MessageBox.Show(cb.SelectedItem.ToString());
        //}

        
        private void button1_Click(object sender, EventArgs e)
        {
            List<Food> listItem = new List<Food>() 
            {
                new Food(){Name="Com rang",Price = 30000},
                new Food(){Name="Ga ran",Price = 50000},
                new Food(){Name="Thit kho",Price = 60000},

            };
            comboBox1.DataSource = listItem;
            comboBox1.DisplayMember = "Name";

            
        }

        public class Food
        {
            private string name;
            private double price;
            public string  Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Price
            {
                get { return price; }
                set { price = value; }
            }
        }
        //void AddBinding()
        //{
        //    textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        //}
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                Food f = cb.SelectedValue as Food;
                textBox1.Text = f.Price.ToString();

            }
        }
    }
}

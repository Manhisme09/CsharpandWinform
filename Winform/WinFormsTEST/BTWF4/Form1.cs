using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTWF4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadFood();
            loadDrink();
            loadslFood();
            loadslDrink();
        }

        void loadslFood()
        {
            List<int> item1 = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                item1.Add(i);
            }
            cB_slFood.DataSource = item1;
        }
        void loadslDrink()
        {
            List<int> item2 = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                item2.Add(i);
            }
            cB_slDrink.DataSource = item2;
        }
        void loadFood()
        {
            List<Food> listItem = new List<Food>()
            {
                new Food() { NameF = "Mỳ cay", PriceF = 20000 },
                new Food() { NameF="Gà không lối thoát",PriceF=100000},
                new Food() { NameF = "Bò luc lắc", PriceF = 200000 },
                new Food() { NameF = "Chim quay", PriceF = 90000 },
                new Food() { NameF = "Phở xào", PriceF = 70000 },

            };
            cB_food.DataSource = listItem;
            cB_food.DisplayMember = "NameF";


        }

        void loadDrink()
        {
            List<Drink> listItem1 = new List<Drink>()
            {
                new Drink(){NameD="Coca",PriceD=20000},
                new Drink(){NameD="Trà đá",PriceD=5000},
                new Drink(){NameD="Nước cam",PriceD=30000},
                new Drink(){NameD="Nước chanh",PriceD=15000},
                new Drink(){NameD="Nước táo",PriceD=40000},

            };
            cB_drink.DataSource = listItem1;
            cB_drink.DisplayMember = "NameD";
        }


        public class Food
        {
            private string nameF;
            private int priceF;

            public string NameF
            {
                get { return nameF; }
                set { nameF = value; }
            }

            public int PriceF
            {
                get { return priceF; }
                set { priceF = value; }
            }
        }

        public class Drink
        {
            private string nameD;
            private int priceD;

            public string NameD
            {
                get { return nameD; }
                set { nameD = value; }
            }

            public int PriceD
            {
                get { return priceD; }
                set { priceD = value; }
            }
        }

        private void cB_food_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbFood = sender as ComboBox;
            if (cbFood.SelectedValue != null)
            {
                Food f = cbFood.SelectedValue as Food;
                tB_giaF.Text = f.PriceF.ToString();

            }
        }

        private void cB_drink_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbDrink = sender as ComboBox;
            if (cbDrink.SelectedValue != null)
            {
                Drink d = cbDrink.SelectedValue as Drink;
                tB_giaD.Text = d.PriceD.ToString();

            }
        }

        private void btn_tinhTien_Click(object sender, EventArgs e)
        {
            //int tienFood = Convert.ToInt32(tB_giaF);
            //int tienDrink = Convert.ToInt32(tB_giaD);

            Food f = cB_food.SelectedValue as Food;
            int tienFood = f.PriceF * Convert.ToInt32(cB_slFood.Text);

            Drink d = cB_drink.SelectedValue as Drink;
            int tienDrink = d.PriceD * Convert.ToInt32(cB_slDrink.Text);
            
            
            tB_tienF.Text = Convert.ToString(tienFood.ToString());
            tB_tienD.Text = Convert.ToString(tienDrink.ToString());

            tB_tong.Text = (tienDrink + tienFood).ToString();
        }
    }
}


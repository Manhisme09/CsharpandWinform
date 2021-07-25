
namespace BTWF4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cB_food = new System.Windows.Forms.ComboBox();
            this.cB_drink = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_slFood = new System.Windows.Forms.ComboBox();
            this.cB_slDrink = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_tienF = new System.Windows.Forms.TextBox();
            this.tB_tienD = new System.Windows.Forms.TextBox();
            this.tB_tong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_giaF = new System.Windows.Forms.TextBox();
            this.tB_giaD = new System.Windows.Forms.TextBox();
            this.btn_tinhTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // cB_food
            // 
            this.cB_food.FormattingEnabled = true;
            this.cB_food.Location = new System.Drawing.Point(146, 116);
            this.cB_food.Name = "cB_food";
            this.cB_food.Size = new System.Drawing.Size(121, 21);
            this.cB_food.TabIndex = 1;
            this.cB_food.SelectedValueChanged += new System.EventHandler(this.cB_food_SelectedValueChanged);
            // 
            // cB_drink
            // 
            this.cB_drink.FormattingEnabled = true;
            this.cB_drink.Location = new System.Drawing.Point(146, 175);
            this.cB_drink.Name = "cB_drink";
            this.cB_drink.Size = new System.Drawing.Size(121, 21);
            this.cB_drink.TabIndex = 2;
            this.cB_drink.SelectedIndexChanged += new System.EventHandler(this.cB_drink_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "đồ ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "nước uống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "đơn giá";
            // 
            // cB_slFood
            // 
            this.cB_slFood.FormattingEnabled = true;
            this.cB_slFood.Location = new System.Drawing.Point(526, 116);
            this.cB_slFood.Name = "cB_slFood";
            this.cB_slFood.Size = new System.Drawing.Size(40, 21);
            this.cB_slFood.TabIndex = 9;
            // 
            // cB_slDrink
            // 
            this.cB_slDrink.FormattingEnabled = true;
            this.cB_slDrink.Location = new System.Drawing.Point(526, 175);
            this.cB_slDrink.Name = "cB_slDrink";
            this.cB_slDrink.Size = new System.Drawing.Size(40, 21);
            this.cB_slDrink.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SL";
            // 
            // tB_tienF
            // 
            this.tB_tienF.Location = new System.Drawing.Point(650, 116);
            this.tB_tienF.Name = "tB_tienF";
            this.tB_tienF.Size = new System.Drawing.Size(100, 20);
            this.tB_tienF.TabIndex = 12;
            // 
            // tB_tienD
            // 
            this.tB_tienD.Location = new System.Drawing.Point(650, 176);
            this.tB_tienD.Name = "tB_tienD";
            this.tB_tienD.Size = new System.Drawing.Size(100, 20);
            this.tB_tienD.TabIndex = 12;
            // 
            // tB_tong
            // 
            this.tB_tong.Location = new System.Drawing.Point(650, 242);
            this.tB_tong.Name = "tB_tong";
            this.tB_tong.Size = new System.Drawing.Size(100, 20);
            this.tB_tong.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "thành tiền";
            // 
            // tB_giaF
            // 
            this.tB_giaF.Location = new System.Drawing.Point(330, 116);
            this.tB_giaF.Name = "tB_giaF";
            this.tB_giaF.Size = new System.Drawing.Size(100, 20);
            this.tB_giaF.TabIndex = 15;
            // 
            // tB_giaD
            // 
            this.tB_giaD.Location = new System.Drawing.Point(333, 175);
            this.tB_giaD.Name = "tB_giaD";
            this.tB_giaD.Size = new System.Drawing.Size(100, 20);
            this.tB_giaD.TabIndex = 16;
            // 
            // btn_tinhTien
            // 
            this.btn_tinhTien.Location = new System.Drawing.Point(287, 232);
            this.btn_tinhTien.Name = "btn_tinhTien";
            this.btn_tinhTien.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhTien.TabIndex = 17;
            this.btn_tinhTien.Text = "Tinhtien";
            this.btn_tinhTien.UseVisualStyleBackColor = true;
            this.btn_tinhTien.Click += new System.EventHandler(this.btn_tinhTien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tinhTien);
            this.Controls.Add(this.tB_giaD);
            this.Controls.Add(this.tB_giaF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_tong);
            this.Controls.Add(this.tB_tienD);
            this.Controls.Add(this.tB_tienF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cB_slDrink);
            this.Controls.Add(this.cB_slFood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_drink);
            this.Controls.Add(this.cB_food);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_food;
        private System.Windows.Forms.ComboBox cB_drink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_slFood;
        private System.Windows.Forms.ComboBox cB_slDrink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_tienF;
        private System.Windows.Forms.TextBox tB_tienD;
        private System.Windows.Forms.TextBox tB_tong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_giaF;
        private System.Windows.Forms.TextBox tB_giaD;
        private System.Windows.Forms.Button btn_tinhTien;
    }
}


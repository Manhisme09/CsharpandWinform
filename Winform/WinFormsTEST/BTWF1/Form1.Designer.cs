
namespace BTWF1
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
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbsothich = new System.Windows.Forms.Label();
            this.tboten = new System.Windows.Forms.TextBox();
            this.tbsothich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cBngay = new System.Windows.Forms.ComboBox();
            this.cBthang = new System.Windows.Forms.ComboBox();
            this.cBnam = new System.Windows.Forms.ComboBox();
            this.rTBKetqua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(180, 50);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(54, 13);
            this.lbhoten.TabIndex = 0;
            this.lbhoten.Text = "Họ và tên";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(180, 85);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbngaysinh.TabIndex = 0;
            this.lbngaysinh.Text = "Ngày sinh";
            // 
            // lbsothich
            // 
            this.lbsothich.AutoSize = true;
            this.lbsothich.Location = new System.Drawing.Point(180, 119);
            this.lbsothich.Name = "lbsothich";
            this.lbsothich.Size = new System.Drawing.Size(48, 13);
            this.lbsothich.TabIndex = 0;
            this.lbsothich.Text = "Sở thích";
            // 
            // tboten
            // 
            this.tboten.Location = new System.Drawing.Point(261, 50);
            this.tboten.Name = "tboten";
            this.tboten.Size = new System.Drawing.Size(100, 20);
            this.tboten.TabIndex = 1;
            // 
            // tbsothich
            // 
            this.tbsothich.Location = new System.Drawing.Point(261, 112);
            this.tbsothich.Name = "tbsothich";
            this.tbsothich.Size = new System.Drawing.Size(100, 20);
            this.tbsothich.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đăng ký";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBngay
            // 
            this.cBngay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBngay.FormattingEnabled = true;
            this.cBngay.Location = new System.Drawing.Point(261, 76);
            this.cBngay.Name = "cBngay";
            this.cBngay.Size = new System.Drawing.Size(35, 21);
            this.cBngay.TabIndex = 4;
            // 
            // cBthang
            // 
            this.cBthang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBthang.FormattingEnabled = true;
            this.cBthang.Location = new System.Drawing.Point(302, 76);
            this.cBthang.Name = "cBthang";
            this.cBthang.Size = new System.Drawing.Size(35, 21);
            this.cBthang.TabIndex = 4;
            // 
            // cBnam
            // 
            this.cBnam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBnam.FormattingEnabled = true;
            this.cBnam.Location = new System.Drawing.Point(343, 76);
            this.cBnam.Name = "cBnam";
            this.cBnam.Size = new System.Drawing.Size(48, 21);
            this.cBnam.TabIndex = 4;
            // 
            // rTBKetqua
            // 
            this.rTBKetqua.Location = new System.Drawing.Point(196, 196);
            this.rTBKetqua.Name = "rTBKetqua";
            this.rTBKetqua.Size = new System.Drawing.Size(127, 96);
            this.rTBKetqua.TabIndex = 5;
            this.rTBKetqua.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTBKetqua);
            this.Controls.Add(this.cBnam);
            this.Controls.Add(this.cBthang);
            this.Controls.Add(this.cBngay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbsothich);
            this.Controls.Add(this.tboten);
            this.Controls.Add(this.lbsothich);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbhoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbsothich;
        private System.Windows.Forms.TextBox tboten;
        private System.Windows.Forms.TextBox tbsothich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cBngay;
        private System.Windows.Forms.ComboBox cBthang;
        private System.Windows.Forms.ComboBox cBnam;
        private System.Windows.Forms.RichTextBox rTBKetqua;
    }
}


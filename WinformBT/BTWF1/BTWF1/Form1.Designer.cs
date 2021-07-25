
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_ten = new System.Windows.Forms.TextBox();
            this.tB_thongbao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_do = new System.Windows.Forms.RadioButton();
            this.rad_vang = new System.Windows.Forms.RadioButton();
            this.rad_xanh = new System.Windows.Forms.RadioButton();
            this.rad_tim = new System.Windows.Forms.RadioButton();
            this.chb_hienthitb = new System.Windows.Forms.CheckBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lb_hienthi = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_thongbao);
            this.groupBox1.Controls.Add(this.tB_ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông báo";
            // 
            // tB_ten
            // 
            this.tB_ten.Location = new System.Drawing.Point(111, 19);
            this.tB_ten.Multiline = true;
            this.tB_ten.Name = "tB_ten";
            this.tB_ten.Size = new System.Drawing.Size(236, 30);
            this.tB_ten.TabIndex = 1;
            // 
            // tB_thongbao
            // 
            this.tB_thongbao.Location = new System.Drawing.Point(111, 69);
            this.tB_thongbao.Multiline = true;
            this.tB_thongbao.Name = "tB_thongbao";
            this.tB_thongbao.Size = new System.Drawing.Size(236, 30);
            this.tB_thongbao.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_tim);
            this.groupBox2.Controls.Add(this.rad_xanh);
            this.groupBox2.Controls.Add(this.rad_vang);
            this.groupBox2.Controls.Add(this.rad_do);
            this.groupBox2.Location = new System.Drawing.Point(44, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu";
            // 
            // rad_do
            // 
            this.rad_do.AutoSize = true;
            this.rad_do.Location = new System.Drawing.Point(27, 35);
            this.rad_do.Name = "rad_do";
            this.rad_do.Size = new System.Drawing.Size(39, 17);
            this.rad_do.TabIndex = 0;
            this.rad_do.TabStop = true;
            this.rad_do.Text = "Đỏ";
            this.rad_do.UseVisualStyleBackColor = true;
            // 
            // rad_vang
            // 
            this.rad_vang.AutoSize = true;
            this.rad_vang.Location = new System.Drawing.Point(27, 58);
            this.rad_vang.Name = "rad_vang";
            this.rad_vang.Size = new System.Drawing.Size(50, 17);
            this.rad_vang.TabIndex = 0;
            this.rad_vang.TabStop = true;
            this.rad_vang.Text = "Vàng";
            this.rad_vang.UseVisualStyleBackColor = true;
            // 
            // rad_xanh
            // 
            this.rad_xanh.AutoSize = true;
            this.rad_xanh.Location = new System.Drawing.Point(27, 81);
            this.rad_xanh.Name = "rad_xanh";
            this.rad_xanh.Size = new System.Drawing.Size(50, 17);
            this.rad_xanh.TabIndex = 0;
            this.rad_xanh.TabStop = true;
            this.rad_xanh.Text = "Xanh";
            this.rad_xanh.UseVisualStyleBackColor = true;
            // 
            // rad_tim
            // 
            this.rad_tim.AutoSize = true;
            this.rad_tim.Location = new System.Drawing.Point(27, 104);
            this.rad_tim.Name = "rad_tim";
            this.rad_tim.Size = new System.Drawing.Size(44, 17);
            this.rad_tim.TabIndex = 0;
            this.rad_tim.TabStop = true;
            this.rad_tim.Text = "Tím";
            this.rad_tim.UseVisualStyleBackColor = true;
            // 
            // chb_hienthitb
            // 
            this.chb_hienthitb.AutoSize = true;
            this.chb_hienthitb.Location = new System.Drawing.Point(331, 219);
            this.chb_hienthitb.Name = "chb_hienthitb";
            this.chb_hienthitb.Size = new System.Drawing.Size(113, 17);
            this.chb_hienthitb.TabIndex = 2;
            this.chb_hienthitb.Text = "Hiển thị thông báo";
            this.chb_hienthitb.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(272, 390);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lb_hienthi
            // 
            this.lb_hienthi.Location = new System.Drawing.Point(328, 246);
            this.lb_hienthi.Name = "lb_hienthi";
            this.lb_hienthi.Size = new System.Drawing.Size(116, 94);
            this.lb_hienthi.TabIndex = 6;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(104, 390);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi.TabIndex = 7;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(439, 390);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.lb_hienthi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.chb_hienthitb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_thongbao;
        private System.Windows.Forms.TextBox tB_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_tim;
        private System.Windows.Forms.RadioButton rad_xanh;
        private System.Windows.Forms.RadioButton rad_vang;
        private System.Windows.Forms.RadioButton rad_do;
        private System.Windows.Forms.CheckBox chb_hienthitb;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lb_hienthi;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button btn_thoat;
    }
}


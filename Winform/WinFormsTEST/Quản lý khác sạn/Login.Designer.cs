
namespace Quản_lý_khác_sạn
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dn = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.tB_taikhoan = new System.Windows.Forms.TextBox();
            this.tB_matkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tài khoản";
            // 
            // btn_dn
            // 
            this.btn_dn.Location = new System.Drawing.Point(74, 145);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(75, 23);
            this.btn_dn.TabIndex = 1;
            this.btn_dn.Text = "Đăng nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(210, 145);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // tB_taikhoan
            // 
            this.tB_taikhoan.Location = new System.Drawing.Point(157, 55);
            this.tB_taikhoan.Name = "tB_taikhoan";
            this.tB_taikhoan.Size = new System.Drawing.Size(100, 20);
            this.tB_taikhoan.TabIndex = 2;
            // 
            // tB_matkhau
            // 
            this.tB_matkhau.Location = new System.Drawing.Point(157, 91);
            this.tB_matkhau.Name = "tB_matkhau";
            this.tB_matkhau.PasswordChar = '*';
            this.tB_matkhau.Size = new System.Drawing.Size(100, 20);
            this.tB_matkhau.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 224);
            this.Controls.Add(this.tB_matkhau);
            this.Controls.Add(this.tB_taikhoan);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox tB_taikhoan;
        private System.Windows.Forms.TextBox tB_matkhau;
    }
}
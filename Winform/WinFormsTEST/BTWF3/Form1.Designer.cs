
namespace BTWF3
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
            this.tBox_nhapn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_ktra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n";
            // 
            // tBox_nhapn
            // 
            this.tBox_nhapn.Location = new System.Drawing.Point(279, 78);
            this.tBox_nhapn.Name = "tBox_nhapn";
            this.tBox_nhapn.Size = new System.Drawing.Size(100, 20);
            this.tBox_nhapn.TabIndex = 1;
            this.tBox_nhapn.TextChanged += new System.EventHandler(this.tBox_nhapn_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểm tra SNT";
            // 
            // tBox_ktra
            // 
            this.tBox_ktra.Location = new System.Drawing.Point(279, 127);
            this.tBox_ktra.Name = "tBox_ktra";
            this.tBox_ktra.Size = new System.Drawing.Size(100, 20);
            this.tBox_ktra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SNT nhỏ hơn n";
            // 
            // tBox_in
            // 
            this.tBox_in.Location = new System.Drawing.Point(279, 169);
            this.tBox_in.Name = "tBox_in";
            this.tBox_in.Size = new System.Drawing.Size(100, 20);
            this.tBox_in.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBox_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBox_ktra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBox_nhapn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_nhapn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_ktra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_in;
    }
}


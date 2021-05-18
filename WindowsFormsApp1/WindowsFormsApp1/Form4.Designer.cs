namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chietkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenkhachhang = new System.Windows.Forms.ComboBox();
            this.sanpham = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Don Hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten khach hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "dịa chị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "sản phẩm";
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(266, 131);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(210, 22);
            this.diachi.TabIndex = 3;
            this.diachi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "gửi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chietkhau
            // 
            this.chietkhau.Location = new System.Drawing.Point(266, 244);
            this.chietkhau.Name = "chietkhau";
            this.chietkhau.Size = new System.Drawing.Size(210, 22);
            this.chietkhau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "chiết khấu";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DisplayMember = "cusname";
            this.tenkhachhang.FormattingEnabled = true;
            this.tenkhachhang.Location = new System.Drawing.Point(266, 69);
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.Size = new System.Drawing.Size(210, 24);
            this.tenkhachhang.TabIndex = 7;
            this.tenkhachhang.ValueMember = "id";
            this.tenkhachhang.SelectedIndexChanged += new System.EventHandler(this.tenkhachhang_SelectedIndexChanged);
            // 
            // sanpham
            // 
            this.sanpham.DisplayMember = "proName";
            this.sanpham.FormattingEnabled = true;
            this.sanpham.Location = new System.Drawing.Point(266, 181);
            this.sanpham.Name = "sanpham";
            this.sanpham.Size = new System.Drawing.Size(210, 24);
            this.sanpham.TabIndex = 7;
            this.sanpham.ValueMember = "id";
            this.sanpham.SelectedIndexChanged += new System.EventHandler(this.sanpham_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.sanpham);
            this.Controls.Add(this.tenkhachhang);
            this.Controls.Add(this.chietkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chietkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tenkhachhang;
        private System.Windows.Forms.ComboBox sanpham;
    }
}
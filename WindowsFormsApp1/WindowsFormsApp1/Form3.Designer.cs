namespace WindowsFormsApp1
{
    partial class Form3
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
            this.proname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idkho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chietkhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "san pham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ten san pham";
            // 
            // proname
            // 
            this.proname.Location = new System.Drawing.Point(281, 87);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(250, 22);
            this.proname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "code";
            // 
            // idkho
            // 
            this.idkho.Location = new System.Drawing.Point(281, 133);
            this.idkho.Name = "idkho";
            this.idkho.Size = new System.Drawing.Size(250, 22);
            this.idkho.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "chiet khau";
            // 
            // chietkhau
            // 
            this.chietkhau.Location = new System.Drawing.Point(281, 183);
            this.chietkhau.Name = "chietkhau";
            this.chietkhau.Size = new System.Drawing.Size(250, 22);
            this.chietkhau.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "gia";
            // 
            // gia
            // 
            this.gia.Location = new System.Drawing.Point(281, 241);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(250, 22);
            this.gia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "so luong";
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(281, 307);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(250, 22);
            this.soluong.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chietkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idkho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idkho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chietkhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.Button button1;
    }
}
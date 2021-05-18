using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        khachhangDAO kha = new khachhangDAO();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadkhachhang();
            loadsanpham();
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void loadkhachhang()
        {
            tenkhachhang.DataSource = kha.allkhachhang();
            tenkhachhang.DisplayMember = "cusname";
            tenkhachhang.ValueMember = "id";
        }
        protected void loadsanpham()
        {
            sanpham.DataSource = kha.allsanpham();
            sanpham.DisplayMember = "proName";
            sanpham.ValueMember = "id";
        }
 

        private void tenkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String makh = kha.Laydiachi(tenkhachhang.Text);
            int chietkhau123 = kha.laychietkhau(tenkhachhang.Text);
       /*     int chietkhau12 = kha.laychietkhauSP(sanpham.Text);*/
            diachi.Text = makh.ToString();
            if ( chietkhau123 == 0)
            {
                chietkhau.Text = chietkhau123.ToString();
            }
            else
            {
                chietkhau.Text = chietkhau123.ToString();
            }
        }

        private void sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chietkhau12 = kha.laychietkhauSP(sanpham.Text);
            
            int chietkhau123 = kha.laychietkhau(tenkhachhang.Text);
            if (chietkhau123 == 0)
            {
                chietkhau.Text = chietkhau12.ToString();
            }
        }
    }
}

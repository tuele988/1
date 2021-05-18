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
    public partial class Form2 : Form
    {
        khachhangDAO kha = new khachhangDAO();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cusname.Text == "" || address.Text == "" || sdt.Text == "" || chietkhau.Text == "")
                    throw new Exception("bạn nhập thiếu trương");
                string ten = cusname.Text;
                string add = address.Text;
                string SDT = sdt.Text;
                int chietkhau12 = int.Parse(chietkhau.Text);
                string Email = email.Text;
                khachhang kh = new khachhang(ten, add, SDT, Email, chietkhau12);
                kha.Themkhachhang(kh);
                MessageBox.Show("Thêm  khach hang thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        khachhangDAO kha = new khachhangDAO();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (proname.Text == "" || gia.Text == "" || chietkhau.Text == "" || soluong.Text == "")
                    throw new Exception("bạn nhập thiếu trương");
                string ten = proname.Text;
                int sotreid = int.Parse(idkho.Text);
                float G = float.Parse(gia.Text);
                int chietkhau12 = int.Parse(chietkhau.Text);
                int SL = int.Parse(soluong.Text);
                sanpham kh = new sanpham(ten, sotreid, chietkhau12, G, SL);
                kha.ThemSanpham(kh);
                MessageBox.Show("Thêm  khach hang thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

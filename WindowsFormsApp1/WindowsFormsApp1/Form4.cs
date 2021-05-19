using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
            loadsanpham12();
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
        protected void loadsanpham12()
        {
            this.sanpham123.DataSource = kha.allsanpham();
            sanpham123.DisplayMember = "proName";
            sanpham123.ValueMember = "id";
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
        int vtchon = -1;

        private void GVdonhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            vtchon = e.RowIndex;
            if (vtchon < 0 || vtchon >= GVdonhang.Rows.Count)
            {
                return;
            }
            string comboboxSelectedValue = string.Empty;
            if (GVdonhang.Columns["sanpham123"].GetType() == typeof(DataGridViewComboBoxColumn))
                comboboxSelectedValue = GVdonhang.Rows[vtchon].Cells["sanpham123"].Value.ToString();
            float gia = kha.Giasanpham(int.Parse(comboboxSelectedValue.ToString()));
            GVdonhang.Rows[vtchon].Cells["gia123"].Value = gia;
            DataGridViewRow gv = GVdonhang.CurrentRow;
            int soluong31=0;
            try
            {
                soluong31 = int.Parse((string)(gv.Cells["soluong123"].Value == DBNull.Value ? " " : gv.Cells["soluong123"].Value));
            }
            catch (Exception ex)
            {

            }
            float tongtien = gia * soluong31;
            GVdonhang.Rows[vtchon].Cells["tongtien"].Value  = tongtien;
            xuatMA.Text = soluong31.ToString();
        }

        private void GVdonhang_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }
    }
}

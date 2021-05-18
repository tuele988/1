using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class sanpham
    {
        public int id { get; set; }
        public String proName { get; set; }
        public int idkho { get; set; }
        public int chietkhau { get; set; }
        public float gia { get; set; }
        public int soluong { get; set; }

        public sanpham() { }
        public sanpham(string name, int idkho, int chietkhau, float gia, int soluong)
        {
            this.proName = name;
            this.idkho = idkho;
            this.chietkhau = chietkhau;
            this.gia = gia;
            this.soluong = soluong;
        }
    }
}

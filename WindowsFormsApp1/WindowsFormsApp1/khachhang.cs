using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class khachhang
    {
        public int id { get; set; }
        public String cusname { get; set; }
        public String cusaddress { get; set; }
        public String SDT { get; set; }
        public String Email { get; set; }
        public int chiekhau { get; set; }

        public khachhang() { }
        public khachhang(string name,string address,string sdt,string cusemail,int chietkhaucus)
        {
            this.cusname = name;
            this.cusaddress = address;
            this.SDT = sdt;
            this.Email = cusemail;
            this.chiekhau = chietkhaucus;
        }

    }
}


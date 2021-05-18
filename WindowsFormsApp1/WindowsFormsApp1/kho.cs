using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class kho
    {
        public int id { get; set; }
        public float code { get; set; }
        public String tenkho { get; set; }


        public kho() { }
        public kho(float Code, string Tenkho)
        {
            this.code = Code;
            this.tenkho = Tenkho;
        }
    }
}

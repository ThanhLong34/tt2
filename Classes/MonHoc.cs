using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Vidu2
{
    public class MonHoc
    {
        // Properties
        public int Id { get; set; }
        public int SoTC { get; set; }
        public string TenMH { get; set; }

        // Methods
        public MonHoc() { }

        public MonHoc(string ten) 
        { 
            TenMH = ten;
        }

        public MonHoc(int id, int stc, string ten) 
        {
            Id = id;
            SoTC = stc;
            TenMH = ten;
        }

        public override string ToString()
        {
            return TenMH;
        }
    }
}

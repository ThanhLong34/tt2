using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Vidu2
{
    public class DSMonHoc
    {
        // Properties
        public ArrayList ds;

        // Methods
        public DSMonHoc() 
        {
            ds = new ArrayList();
        }

        public MonHoc this[int index] 
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }

        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }

        public override string ToString()
        {
            string s = "Danh sách môn học: ";
            foreach (MonHoc mh in ds)
            {
                s += mh + ";";
            }
            return s;
        }
    }
}

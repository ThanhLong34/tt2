using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Vidu2
{
    public class GiaoVien
    {
        #region PROPERTIES

        public string maSo { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh;
        public DSMonHoc dsMonHoc;
        public string gioiTinh;
        public string[] ngoaiNgu;
        public string soDT;
        public string mail;

        #endregion

        #region METHODS

        public GiaoVien()
        {
            dsMonHoc = new DSMonHoc();
            ngoaiNgu = new string[10];
        }

        public GiaoVien(
            string maSo,
            string hoTen,
            DateTime ngaySinh,
            DSMonHoc dsMonHoc,
            string gioiTinh,
            string[] ngoaiNgu,
            string soDT,
            string mail
        )
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.dsMonHoc = dsMonHoc;
            this.gioiTinh = gioiTinh;
            this.ngoaiNgu = ngoaiNgu;
            this.soDT = soDT;
            this.mail = mail;
        }

        public override string ToString()
        {
            string s =
                "Mã số: " + maSo + "\n" +
                "Họ tên: " + hoTen + "\n" +
                "Ngày sinh: " + ngaySinh.ToString() + "\n" +
                "Giới tính: " + gioiTinh + "\n" +
                "Số DT: " + soDT + "\n" +
                "Mail: " + mail + "\n";

            string sNgoaiNgu = "Ngoại ngữ: ";
            foreach (string t in ngoaiNgu)
            {
                sNgoaiNgu += t + ";";
            }

            string sDSMonHoc = "Danh sách môn dạy: ";
            foreach (MonHoc mh in dsMonHoc.ds)
            {
                sDSMonHoc += mh + ";";
            }

            s += sNgoaiNgu + "\n" + sDSMonHoc;

            return s;
        }

        #endregion
    }
}

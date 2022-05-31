using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Vidu2
{
    public partial class frmGiaoVien : Form
    {
        #region Properties

        #endregion

        #region Constructor

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        #endregion

        #region METHODS

        public GiaoVien createGiaoVien()
        {
            GiaoVien gv = new GiaoVien();

            gv.maSo = cbMaSo.Text;
            gv.gioiTinh = rdNam.Checked ? rdNam.Text : rdNu.Text;


            gv.hoTen = txtHoTen.Text;
            gv.ngaySinh = dtpNgaySinh.Value;

            var dsMH = new DSMonHoc();
            foreach (var item in lbMonHocDay.Items)
            {
                dsMH.Them(new MonHoc(item.ToString()));
            }
            gv.dsMonHoc = dsMH;

            var dsNN = new List<string>();
            foreach (var item in chklbNgoaiNgu.CheckedItems)
            {
                dsNN.Add(item.ToString());
            }
            gv.ngoaiNgu = dsNN.ToArray();

            gv.soDT = mtxtSoDT.Text;
            gv.mail = txtMail.Text;

            return gv;
        }

        #endregion

        #region EVENTS

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://www.youtube.com/";
            linklblWebsite.Links.Add(0, lienHe.Length, lienHe);

            cbMaSo.SelectedItem = cbMaSo.Items[0];
        }

        private void tradingMonHoc(ListBox trader, ListBox receiver)
        {
            int i = trader.SelectedItems.Count;
            while (i > 0)
            {
                receiver.Items.Add(trader.SelectedItem);
                trader.Items.Remove(trader.SelectedItem);
                i--;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tradingMonHoc(lbDSMonHoc, lbMonHocDay);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tradingMonHoc(lbMonHocDay, lbDSMonHoc);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mess = createGiaoVien().ToString();
            var form = new frmTBGiaoVien(mess);
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbMaSo.Text = cbMaSo.Items[0].ToString();
            txtHoTen.Text = null;
            rdNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            mtxtSoDT.Text = null;
            txtMail.Text = null;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }

            foreach (var item in lbMonHocDay.Items)
            {
                lbDSMonHoc.Items.Add(item);
            }
            lbMonHocDay.Items.Clear();
        }

        private void linklblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Vidu2
{
    public partial class frmTBGiaoVien : Form
    {
        public frmTBGiaoVien()
        {
            InitializeComponent();
        }

        public frmTBGiaoVien(string messsage)
        {
            InitializeComponent();

            lblTBGiaoVien.Text = messsage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuVienControls;
namespace Main
{
    public partial class Form_QLDienNuoc : Form
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_DienNuoc qldn = new QL_DienNuoc();
        gd_QLDienNuoc gd = new gd_QLDienNuoc();

        public Form_QLDienNuoc()
        {
            InitializeComponent();
            loadHoaDonDienNuoc();

            flowLayoutPanel1.Controls.Add(gd);
        }
        public void loadHoaDonDienNuoc()
        {
            gd.loadHoaDon();
            gd.loadFullCBX();
            gd.btnLocClick += Gd_btnLocClick;
            gd.btnGhiDienNuocClick += Gd_btnGhiDienNuocClick;
            gd.btnSuaDonGiaClick += Gd_btnSuaDonGiaClick;
            gd.clickDataGrid += Gd_clickDataGrid;
        }

        private void Gd_clickDataGrid(object sender, EventArgs e)
        {
            int mahd = gd.layMaHoaDon();
            Form_ThongTinHoaDonDienNuoc form = new Form_ThongTinHoaDonDienNuoc(mahd);
            form.Show();
        }

        private void Gd_btnSuaDonGiaClick(object sender, EventArgs e)
        {
            Form_QLBangGiaDienNuoc form = new Form_QLBangGiaDienNuoc();
            form.Show();
        }

        private void Gd_btnGhiDienNuocClick(object sender, EventArgs e)
        {
            gd.ghiDienNuoc();
        }

        private void Gd_btnLocClick(object sender, EventArgs e)
        {
            gd.loadHoaDonDaLoc();
        }
    }
}

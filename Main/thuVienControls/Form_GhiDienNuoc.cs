using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class Form_GhiDienNuoc : Form
    {
        Ql_SinhVien qlsv = new Ql_SinhVien();
        gd_GhiDienNuoc gd = new gd_GhiDienNuoc();
        private string tenPhong;
        public Form_GhiDienNuoc()
        {

            InitializeComponent();
            loadForm();
        }
        public Form_GhiDienNuoc(string tenPhong)
        {
            InitializeComponent();
            this.tenPhong = tenPhong;
            loadForm();
        }
        public void loadForm()
        {

            gd.loadThongTinPhong(tenPhong);
            gd.xacNhansclick += Gd_xacNhansclick;
            gd.huyclick += Gd_huyclick;
            flowLayoutPanel1.Controls.Add(gd);
        }

        private void Gd_huyclick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gd_xacNhansclick(object sender, EventArgs e)
        {
            gd.xacNhanGhiDienNuoc(this.tenPhong);
        }

        private void gd_GhiDienNuoc1_Load(object sender, EventArgs e)
        {

        }
    }
}

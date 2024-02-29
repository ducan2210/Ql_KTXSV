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
    public partial class Form_ThongTinPhong : Form
    {
        QL_Phong qlp = new QL_Phong();
        private string SoPhong;
        public Form_ThongTinPhong()
        {
            InitializeComponent();
            loadThongTin();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public Form_ThongTinPhong(string soPhong)
        {
            InitializeComponent();
            this.SoPhong = soPhong;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            loadThongTin();
        }

        public void loadThongTin()
        {
            Phong p = qlp.loadThongTinPhong(this.SoPhong);
            gd_ThongTinPhong gd = new gd_ThongTinPhong();
            gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, p.tang.ToString(), qlp.DemSoSinhVienTrongPhong(this.SoPhong));
            DataGridView dgv = new DataGridView();
            dgv.DataSource = qlp.loadDanhSachSinhVienTheoPhong(this.SoPhong);
            gd.loadGridSinhVien(dgv);
            flowLayoutPanel1.Controls.Add(gd);
            gd.thoat_Click += Gd_thoat_Click;
        }

        private void Gd_thoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

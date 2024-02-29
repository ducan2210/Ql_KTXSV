using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;

namespace thuVienControls
{
    public partial class gd_ThongTinHoaDonDienNuoc : UserControl
    {
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_ThongTinHoaDonDienNuoc()
        {
            InitializeComponent();
            loadGiaoDien();
        }


        public event EventHandler clickHuy;
        private void btn_huy_Click(object sender, EventArgs e)
        {
            clickHuy?.Invoke(this, e);
        }

        public void loadGiaoDien()
        {
            string[] trangThai = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = trangThai;
        }

        public void loadThongTinHoaDon(int maHD)
        {
            HoaDonDienNuoc hd = qldn.loadTTHoaDonDienNuocTheoMa(maHD);
            txt_maHD.Text = hd.hoa_don_id.ToString();
            txt_namGhi.Text = hd.nam.ToString();
            txt_soPhong.Text = hd.Phong.so_phong.ToString();
            txt_soDienTieuThu.Text = hd.so_dien.ToString();
            txt_soNuocTieuThu.Text = hd.so_khoi_nuoc.ToString();
            txt_thangGhi.Text = hd.thang.ToString();
            txt_tongTien.Text = hd.tong_tien.ToString();
            cbx_trangThai.SelectedItem = hd.trang_thai.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txt_maHD.Text.ToString());
            int soDien = int.Parse(txt_soDienTieuThu.Text.ToString());
            int soNuoc = int.Parse(txt_soNuocTieuThu.Text.ToString());
            string trangThai = cbx_trangThai.Text.ToString();
            double tongTien = double.Parse(txt_tongTien.Text.ToString());
            if(qldn.capNhatHoaDonDienNuoc(maHD, soDien, soNuoc,tongTien, trangThai))
            {
                MessageBox.Show("Cập nhật hóa đơn thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại");
            }
        }

        private void btn_inhoadondiennuoc_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\HoaDonDienNuoc.doc");

            ////Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "ngaygio" }, new[] { string.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            //---------------Bên A
            baoCao.MailMerge.Execute(new[] { "SoHoaDon" }, new[] { txt_maHD.Text });
            baoCao.MailMerge.Execute(new[] { "Thang" }, new[] { txt_thangGhi.Text });
            baoCao.MailMerge.Execute(new[] { "Nam" }, new[] { txt_namGhi.Text });
            baoCao.MailMerge.Execute(new[] { "SoPhong" }, new[] { txt_soPhong.Text });
            baoCao.MailMerge.Execute(new[] { "SoDienTieuThu" }, new[] { txt_soDienTieuThu.Text });
            baoCao.MailMerge.Execute(new[] { "SoKhoiNuocTieuThu" }, new[] { txt_soNuocTieuThu.Text });
            baoCao.MailMerge.Execute(new[] { "ThanhTien" }, new[] { txt_tongTien.Text });

            baoCao.MailMerge.Execute(new[] { "TenTruong" }, new[] { "Đại Học Công Thương" });
            baoCao.SaveAndOpenFile("BaoCaoHoaDonDienNuoc.doc");
        }

        private void txt_maHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_thangGhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_soPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_namGhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_soDienTieuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txt_soNuocTieuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txt_tongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            int soDien = int.Parse(txt_soDienTieuThu.Text);
            int soNuoc = int.Parse(txt_soNuocTieuThu.Text);
            double tongTien = qldn.TinhTienDien(soDien) + qldn.TinhTienNuoc(soNuoc);
            txt_tongTien.Text = tongTien.ToString();
        }
    }
}

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
    public partial class gd_ThongTinHopDong : UserControl
    {

        QL_HopDongThuePhong qlhd = new QL_HopDongThuePhong();
        QL_Phong qlp = new QL_Phong();
        public gd_ThongTinHopDong()
        {
            InitializeComponent();
            loadCBXTrangThai();
        }

        public void loadCBXTrangThai()
        {
            string[] tt = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = tt;
        }

        public void loadThongTinHopDong(int maHD)
        {
            HopDongThuePhong hd = qlhd.loadHopDongThuePhong(maHD);
            txt_maHD.Text = hd.hop_dong_id.ToString();
            txt_soPhong.Text = hd.Phong.so_phong.ToString();
            txt_tenSV.Text = hd.SinhVien.ho_ten.ToString();
            txt_tienThu.Text = hd.tienthu.ToString();
            dtp_ngayBatDau.Value = (DateTime)hd.ngay_bat_dau_thue;
            dtp_ngayKetThuc.Value = (DateTime)hd.ngay_ket_thuc_thue;
            dtp_ngayLap.Value= (DateTime)hd.ngay_lap;
            cbx_trangThai.SelectedItem = hd.trangthai.ToString(); 
        }

        public event EventHandler huyBoClick;
        private void button3_Click(object sender, EventArgs e)
        {
            huyBoClick?.Invoke(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi trên?", "Lưu", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                int maHD = int.Parse(txt_maHD.Text.ToString());
                HopDongThuePhong hd = qlhd.loadHopDongThuePhong(maHD);
                string tenLoaiPhong = qlp.layLoaiPhong(int.Parse(hd.phong_id.ToString()));

                if (qlhd.CapNhatHopDongThuePhong(maHD, tenLoaiPhong, dtp_ngayLap.Value,dtp_ngayBatDau.Value, dtp_ngayKetThuc.Value,cbx_trangThai.SelectedItem.ToString()))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại");
                }    
                
            }    
        }

        private void btn_inhopdong_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            Document baoCao = new Document("Template\\Hop-dong-thue-cho-noi-tru.doc");
            //---------------Bên A
            baoCao.MailMerge.Execute(new[] { "SoHopDong" }, new[] { txt_maHD.Text });
            baoCao.MailMerge.Execute(new[] { "Ngay" }, new[] { homNay.Day.ToString() });
            baoCao.MailMerge.Execute(new[] { "Thang" }, new[] { homNay.Month.ToString() });
            baoCao.MailMerge.Execute(new[] { "Nam" }, new[] { homNay.Year.ToString() });
            baoCao.MailMerge.Execute(new[] { "TenDaiDien" }, new[] { "Lê Doãn" });
            baoCao.MailMerge.Execute(new[] { "DonViCongTac" }, new[] { "Đại Học Công Thương" });
            baoCao.MailMerge.Execute(new[] { "ChucVu" }, new[] { "Quản Lý Ký Túc Xá" });
            baoCao.MailMerge.Execute(new[] { "SoDienThoai" }, new[] { "0343543538" });



            //----------------Bên B
            HopDongThuePhong hd = qlhd.loadHopDongThuePhong(int.Parse(txt_maHD.Text));

            string ngay = hd.SinhVien.ngay_sinh.ToString();
            string sdt = hd.SinhVien.so_dien_thoai.ToString();
            baoCao.MailMerge.Execute(new[] { "HoTenSV" }, new[] { txt_tenSV.Text });
            baoCao.MailMerge.Execute(new[] { "GioiTinh" }, new[] { "Nam" });
            baoCao.MailMerge.Execute(new[] { "NamSinh" }, new[] { ngay });
            baoCao.MailMerge.Execute(new[] { "MaSSV" }, new[] { hd.SinhVien.ma_sinh_vien.ToString() });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { sdt });
            baoCao.MailMerge.Execute(new[] { "Email" }, new[] { hd.SinhVien.email.ToString() });
            baoCao.MailMerge.Execute(new[] { "DiaChi" }, new[] { hd.SinhVien.dia_chi.ToString() });
            baoCao.MailMerge.Execute(new[] { "SoDienThoai" }, new[] { hd.SinhVien.so_dien_thoai.ToString() });

            //-----------------------------------------

            baoCao.MailMerge.Execute(new[] { "SoPhong" }, new[] { txt_soPhong.Text });
            baoCao.MailMerge.Execute(new[] { "SoTang" }, new[] { "2" });
            baoCao.MailMerge.Execute(new[] { "GiaThue" }, new[] { hd.tienthu.ToString() });
            baoCao.MailMerge.Execute(new[] { "NgayBD" }, new[] { hd.ngay_bat_dau_thue.ToString() });
            baoCao.MailMerge.Execute(new[] { "NgayKT" }, new[] { hd.ngay_ket_thuc_thue.ToString() });

            baoCao.MailMerge.Execute(new[] { "TenTruong" }, new[] { "Đại Học Công Thương" });
            baoCao.SaveAndOpenFile("BaoCao.doc");
        }

        private void txt_maHD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_tenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_tienThu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtp_ngayKetThuc_CloseUp(object sender, EventArgs e)
        {
            DateTime ngaykt = dtp_ngayKetThuc.Value;
            if (ngaykt < dtp_ngayBatDau.Value)
            {
                MessageBox.Show("Ngày tháng  hợp đồng không hợp lệ !");
                dtp_ngayKetThuc.Value = DateTime.Now;
            }
        }

        private void dtp_ngayBatDau_CloseUp(object sender, EventArgs e)
        {
            DateTime ngaysinh = dtp_ngayBatDau.Value;
            if (ngaysinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ !");
                dtp_ngayBatDau.Value = DateTime.Now;
            }
        }
    }
}

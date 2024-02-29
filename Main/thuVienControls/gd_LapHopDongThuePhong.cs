using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using thietKeControls;

namespace thuVienControls
{
    public partial class gd_LapHopDongThuePhong : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        Ql_SinhVien qlsv = new Ql_SinhVien();
        QL_Phong qlp = new QL_Phong();
        QL_HopDongThuePhong qlhd = new QL_HopDongThuePhong();

        public gd_LapHopDongThuePhong()
        {
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            cbx_loaiPhong.DataSource = qlp.layDSLoaiPhong();
            cbx_loaiPhong.DisplayMember = "ten_loai_phong";
            string[] trangThai = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = trangThai;
            string[] phai = { "Nam", "Nữ" };
            cbx_gioiTinh.DataSource = phai;
            cbx_phong.DataSource = qlp.LayDanhSachPhongChuaDayTheoLoaiPhong("2 người");
            cbx_phong.DisplayMember = "so_phong";
        }

        public void load_thongtin(string massv)
        {
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(massv);
            txt_maSV.Text = sv.ma_sinh_vien.ToString();
            dtp_ngaySinh.Value = sv.ngay_sinh.Value;
            cbx_gioiTinh.SelectedItem = sv.gioi_tinh.ToString();
            txt_tenSV.Text = sv.ho_ten;
            txt_CCCD.Text = sv.CCCD;
            txt_SDT.Text = sv.so_dien_thoai;
            txt_diaChi.Text = sv.dia_chi;
            txt_email.Text = sv.email;
        }



        private void dateTimePicker3_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayKetThuc.Value = DateTime.Now;
            }
        }

        private void dtp_ngayBatDau_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayBatDau.Value = DateTime.Now;
            }

        }

        private void dtp_ngayLap_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayLap.Value = DateTime.Now;
            }

        }

        private void txn_lapHD_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            string masv = txt_maSV.Text;
            string hoTen = txt_tenSV.Text;
            string cccd = txt_CCCD.Text;
            DateTime ngaySinh = dtp_ngaySinh.Value;
            string gioiTinh = cbx_gioiTinh.Text;
            string loaiPhong = cbx_loaiPhong.Text;
            string sdt = txt_SDT.Text;
            string diaChi = txt_diaChi.Text;
            string email = txt_email.Text;
            string trangThai = cbx_trangThai.Text;
            string tienThu = txt_tienThu.Text;
            string xepPhong  = cbx_phong.Text;
            Ql_SinhVien ql_sv=new Ql_SinhVien();



            if(string.IsNullOrEmpty(tienThu))
            {
                MessageBox.Show("vui lòng xếp phòng cho sinh viên bằng cách nhấn vào xếp phòng hoặc chọn phòng cho sinh viên!");
            }    
            if (!string.IsNullOrEmpty(tienThu) && IsEmailValid(email))
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập hợp đồng cho sinh viên " + txt_tenSV.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int kq = qlhd.lapHopDongThuePhong(masv, hoTen, ngaySinh, cccd, gioiTinh, loaiPhong, sdt, diaChi, email, ngayLap, startDate, endDate, trangThai, xepPhong, double.Parse(tienThu));
                    if (kq == 0)
                    {
                        MessageBox.Show("Không thể lập hợp đồng do sinh viên đang có hợp đồng còn giá trị!");
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Lập hợp đồng thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Lập hợp đồng thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thành công !");
                }
            }
            else
            {
                MessageBox.Show("Hãy điền hay chọn đầy đủ thông tin hợp lệ cho hợp đồng !");
            }    
        }

        private void txt_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_CCCD.Text.Length >= 12 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_SDT.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_diaChi_KeyPress(object sender, KeyPressEventArgs e)
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
        public bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            string loaiPhong = cbx_loaiPhong.Text;
            txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, loaiPhong).ToString();
        }

        private void dtp_ngaySinh_CloseUp(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtp_ngaySinh.Value;
            if (ngaySinh > DateTime.Now)
            { 
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngaySinh.Value = DateTime.Now;
            }
        }

        private void btn_xepPhong_Click(object sender, EventArgs e)
        {
            ThuatToanKMeans tt = new ThuatToanKMeans();
            string gioiTinh = cbx_gioiTinh.Text.ToString() ;
            string loaiPhong = cbx_loaiPhong.Text.ToString();
            string kq = tt.TimPhongPhuHop(gioiTinh, loaiPhong);
            if (kq != "Không có phòng phù hợp")
            { 
                cbx_phong.Text =  kq; 
            }
            else
            {
                MessageBox.Show("không còn phòng nào phù hợp!");
            }
        }

        private void txt_xepPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbx_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiPhong = cbx_loaiPhong.Text.ToString();
            cbx_phong.DataSource = qlp.LayDanhSachPhongChuaDayTheoLoaiPhong(loaiPhong);
            cbx_phong.DisplayMember = "so_phong";
        }
    }
}

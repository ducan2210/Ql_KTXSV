using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thietKeControls;
using thuVienControls;

namespace Main
{
    public partial class Form_ThongTinSinhVien : Form
    {
        Ql_SinhVien qlsv = new Ql_SinhVien();
        QL_Phong qlp = new QL_Phong();
        private string MaSV;
        public Form_ThongTinSinhVien()
        {
            InitializeComponent();
            loadCBXGioiTinh();
            loadSinhVien();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public Form_ThongTinSinhVien(string masv)
        {
            InitializeComponent();
            this.MaSV = masv;
            loadCBXGioiTinh();
            loadCBXPhong();
            loadSinhVien();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        public void loadCBXPhong()
        {
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(this.MaSV);
            Phong p = qlp.loadThongTinPhong(sv.so_phong);
            if(p!=null)
            {
                List<Phong> dsp = qlp.LayDanhSachPhongChuaDayTheoLoaiPhong(p.LoaiPhong.ten_loai_phong);
                dsp.Add(p);
                cbx_phong.DataSource = dsp;
                cbx_phong.DisplayMember = "so_phong";
                cbx_phong.Enabled = true;
            }    
            else
            {
                cbx_phong.Enabled = false;
            }    
        }

        public void loadCBXGioiTinh()
        {
            cbx_gioiTinh.Items.Add("Nam");
            cbx_gioiTinh.Items.Add("Nữ");
        }

        public void loadSinhVien()
        {
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(this.MaSV);
            txt_diaChi.Text = sv.dia_chi;
            txt_hoTen.Text = sv.ho_ten;
            txt_maSV.Text = sv.ma_sinh_vien;
            txt_sdt.Text = sv.so_dien_thoai;
            cbx_phong.Text = sv.so_phong;
            cbx_phong.Text = sv.so_phong;
            dtp_ngaySinh.Value = sv.ngay_sinh.Value;
            txt_email.Text = sv.email;
            string gioiTinh = sv.gioi_tinh;

            if (cbx_gioiTinh.Items.Contains(gioiTinh))
            {
                cbx_gioiTinh.SelectedItem = gioiTinh;
            }
            if (sv.trang_thai == "Đang ở" || sv.trang_thai=="Đã duyệt")
            {
                btn_duyet.Visible = false;
                btn_khongDuyet.Visible = false;
            }
            if(sv.trang_thai=="Chờ duyệt")
            {
                btn_luu.Visible=false;
            }    
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
                string maSV = txt_maSV.Text;
                string hoTen = txt_hoTen.Text;
                DateTime ngaysinh = dtp_ngaySinh.Value;
                string gioiTinh = cbx_gioiTinh.Text.ToString();
                string sdt = txt_sdt.Text;
                string diaChi = txt_diaChi.Text;
            string soPhong = cbx_phong.Text;
                string email = txt_email.Text;
      
                if (qlsv.UpdateSinhVien(maSV, hoTen, ngaysinh, gioiTinh, sdt, diaChi, soPhong, email))
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại");
                }
        }

        private void btn_duyet_Click(object sender, EventArgs e)
        {
            Ql_SinhVien ql=new Ql_SinhVien();
            
           if(ql.capNhatTrangThai(txt_maSV.Text, "Đã duyệt"))
            {
                Ql_NguoiDung qlnd = new Ql_NguoiDung();
                if(qlnd.themTaiKhoanSinhVien(txt_maSV.Text,txt_sdt.Text))
                {
                    MessageBox.Show(txt_hoTen.Text + " được duyệt thành công", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }    
            }   
           else 
            {
                MessageBox.Show(txt_maSV.Text + " duyệt thật bại!", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private void btn_khongDuyet_Click(object sender, EventArgs e)
        {
            Ql_SinhVien ql= new Ql_SinhVien();
            if(ql.xoaSinhVienKhongDuyet(txt_maSV.Text))
            {
                MessageBox.Show("Sinh viên:"+txt_hoTen.Text+" có mã số sinh viên: "+txt_maSV.Text+"không được duyệt ", "Thông Báo", MessageBoxButtons.OK);
                this.Close();
            }    
        }

        private void Form_ThongTinSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void txt_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_hoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_sdt.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_soPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 )
            {
                e.Handled = true;
            }
        }

        private void txt_diaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' )
            {
                e.Handled = true;
            }

        }

        private void dtp_ngaySinh_CloseUp(object sender, EventArgs e)
        {
            DateTime ngaysinh = dtp_ngaySinh.Value;
            if (ngaysinh>DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ !");
                dtp_ngaySinh.Value = DateTime.Now;
            }
        }
        public event EventHandler ThoatClick;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

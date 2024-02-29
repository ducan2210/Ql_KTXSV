using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace thuVienControls
{
    public class Ql_SinhVien
    {
        QL_KTXDataContext QL_KTX = new QL_KTXDataContext();
        QL_Phong QL_Phong = new QL_Phong();
        public Ql_SinhVien()
        {

        }



        public bool TaoMoiSinhVien(string maSV,string hoTen, DateTime ngaySinh, string cccd, string gioiTinh, string sdt, string diaChi,string email)
        {
            var sinhVien = QL_KTX.SinhViens.Where(t => t.ma_sinh_vien == maSV).FirstOrDefault();
            if(sinhVien !=null)
            {
                return false;
            }
            else
            {
                SinhVien sv = new SinhVien();

                sv.ma_sinh_vien = maSV;
                sv.ho_ten = hoTen;
                sv.ngay_sinh = ngaySinh;
                sv.CCCD = cccd;
                sv.gioi_tinh = gioiTinh;
                sv.so_dien_thoai = sdt;
                sv.dia_chi = diaChi;
                sv.email = email;
                sv.trang_thai = "Chờ duyệt";
                QL_KTX.SinhViens.InsertOnSubmit(sv);
                QL_KTX.SubmitChanges();
            }
            return true;
        }

        public bool xoaSinhVienKhongDuyet(string maSV)
        {
            var sinhVien = QL_KTX.SinhViens.Where(t => t.ma_sinh_vien == maSV).FirstOrDefault();
            if (sinhVien == null)
            {
                return false;
            }
            else
            {
                QL_KTX.SinhViens.DeleteOnSubmit(sinhVien);
                QL_KTX.SubmitChanges();
                return true;
            }
        }


        public object loadDanhSachSinhVien()
        {
            var dsSinhVien = from sv in QL_KTX.SinhViens select new { sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            return dsSinhVien.ToList();
        }

        public object loadDanhSachSinhVienTheoTrangThai(string trangThai)
        {
            var dsSinhVien = from sv in QL_KTX.SinhViens where sv.trang_thai == trangThai select new {sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            return dsSinhVien.ToList();
        }

        public SinhVien loadThongTinSinhVienTheoMa(string maSV)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == maSV select sv).FirstOrDefault();
            if (sinhVien != null)
            {
                return sinhVien;
            }
            else
            {
                return null;
            }
        }

        public bool kiemTraSinhVienCoTrongPhong(string maSV, string SoPhong)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == maSV && sv.so_phong == SoPhong select sv).FirstOrDefault();
            if(sinhVien!=null)
            {
                return true;
            }
            return false;
        }

        public bool capNhatTrangThai(string maSV,string trangThai)
        {
            var sv = QL_KTX.SinhViens.Where(t => t.ma_sinh_vien == maSV).FirstOrDefault();
            if(sv==null)
            {
                return false;
            }    
            else
            {
                sv.trang_thai = trangThai;
                QL_KTX.SubmitChanges();
                return true;
            }    

        }

        public int layIDSinhVien(string masv)
        {
            var sinhvien = QL_KTX.SinhViens.Where(t => t.ma_sinh_vien == masv).FirstOrDefault();
            return sinhvien.sinh_vien_id;
        }


        public bool UpdateSinhVien(string ma,string hoten, DateTime ngaysinh, string gioitinh, string sdt, string diachi,string soPhong, string email)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == ma select sv).FirstOrDefault();
            if (sinhVien != null)
            {
                sinhVien.ho_ten = hoten;
                sinhVien.ngay_sinh = ngaysinh;
                sinhVien.gioi_tinh = gioitinh;
                sinhVien.so_dien_thoai = sdt;
                sinhVien.dia_chi = diachi;
                sinhVien.so_phong = soPhong;
                sinhVien.email = email;
                    QL_KTX.SubmitChanges();
                    return true;
            }
            return false;
        }



        public bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }
    }
}

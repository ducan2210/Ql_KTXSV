using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuVienControls
{
    public class QL_HopDongThuePhong
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_Phong qlp = new QL_Phong();
        Ql_SinhVien qlsv = new Ql_SinhVien();
        Ql_NguoiDung qlnd = new Ql_NguoiDung();
        ThuatToanKMeans tt = new ThuatToanKMeans();
        public QL_HopDongThuePhong()
        {

        }

        public int lapHopDongThuePhong(string maSV, string hoTen, DateTime ngaySinh, string cccd, string gioiTinh, string loaiPhong, string sdt, string diaChi, string email,DateTime ngayLap, DateTime ngayBD, DateTime ngayKT, string trangThai,string xepPhong, double tienThu)
        {
            var sv = qlktx.SinhViens.Where(t => t.ma_sinh_vien == maSV).FirstOrDefault();
            
            var  tk=qlktx.NguoiDungs.Where(t=>t.ten_nguoi_dung==sv.ma_sinh_vien).Select(p=>p.nguoi_dung_id).FirstOrDefault();
            if (sv != null )
            {
                if (tk == 0)
                {
                    bool kq2 = qlnd.themTaiKhoanSinhVien(maSV, sdt);
                    if (kq2)
                    {
                        var hd = qlktx.HopDongThuePhongs.Where(t => t.sinh_vien_id == sv.sinh_vien_id && t.ngay_ket_thuc_thue > DateTime.Now).FirstOrDefault();
                        if (hd != null)
                        {
                            return 0;
                        }
                        else
                        {
                            HopDongThuePhong hdnew = new HopDongThuePhong();
                            hdnew.phong_id = qlp.layIDPhong(xepPhong);
                            hdnew.sinh_vien_id = qlsv.layIDSinhVien(maSV);
                            hdnew.ngay_lap = ngayLap;
                            hdnew.ngay_bat_dau_thue = ngayBD;
                            hdnew.ngay_ket_thuc_thue = ngayKT;
                            hdnew.tienthu = (int)tienThu;
                            hdnew.trangthai = trangThai;
                            qlktx.HopDongThuePhongs.InsertOnSubmit(hdnew);
                            qlktx.SubmitChanges();
                            return 2;
                        }
                    }
                    return 0;
                }
                else
                {

                    var hd = qlktx.HopDongThuePhongs.Where(t => t.sinh_vien_id == sv.sinh_vien_id && t.ngay_ket_thuc_thue > DateTime.Now).FirstOrDefault();
                    if (hd != null)
                    {
                        return 0;
                    }
                    else
                    {
                        HopDongThuePhong hdnew = new HopDongThuePhong();
                        hdnew.phong_id = qlp.layIDPhong(xepPhong);
                        hdnew.sinh_vien_id = qlsv.layIDSinhVien(maSV);
                        hdnew.ngay_lap = ngayLap;
                        hdnew.ngay_bat_dau_thue = ngayBD;
                        hdnew.ngay_ket_thuc_thue = ngayKT;
                        hdnew.tienthu = (int)tienThu;
                        hdnew.trangthai = trangThai;
                        qlktx.HopDongThuePhongs.InsertOnSubmit(hdnew);
                        qlktx.SubmitChanges();
                        return 2;
                    }
                }
            }
            else
            {
                bool kq1 = qlsv.TaoMoiSinhVien(maSV,hoTen,ngaySinh,cccd,gioiTinh,sdt,diaChi,email);
                bool kq2 = qlnd.themTaiKhoanSinhVien(maSV, sdt);
                if (kq1 && kq2)
                {
                    HopDongThuePhong hdnew = new HopDongThuePhong();
                    hdnew.phong_id = qlp.layIDPhong(xepPhong);
                    hdnew.sinh_vien_id = qlsv.layIDSinhVien(maSV);
                    hdnew.ngay_lap = ngayLap;
                    hdnew.ngay_bat_dau_thue = ngayBD;
                    hdnew.ngay_ket_thuc_thue = ngayKT;
                    hdnew.tienthu = (int)tienThu;
                    hdnew.trangthai = trangThai;

                    qlktx.HopDongThuePhongs.InsertOnSubmit(hdnew);
                    qlktx.SubmitChanges();
                    return 2;
                }
                else if(kq1 && !kq2)
                {
                    HopDongThuePhong hdnew = new HopDongThuePhong();
                    hdnew.phong_id = qlp.layIDPhong(xepPhong);
                    hdnew.sinh_vien_id = qlsv.layIDSinhVien(maSV);
                    hdnew.ngay_lap = ngayLap;
                    hdnew.ngay_bat_dau_thue = ngayBD;
                    hdnew.ngay_ket_thuc_thue = ngayKT;
                    hdnew.tienthu = (int)tienThu;
                    hdnew.trangthai = trangThai;

                    qlktx.HopDongThuePhongs.InsertOnSubmit(hdnew);
                    qlktx.SubmitChanges();
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        public double tinhTienThu(DateTime ngayBatDau, DateTime ngayKetThuc, string  tenLoaiPhong)
        {
            int soThang = ((ngayKetThuc.Year - ngayBatDau.Year) * 12) + (ngayKetThuc.Month - ngayBatDau.Month);
            double tienThu = 0;
            double tienPhong = qlp.layGiaTienPhong(tenLoaiPhong);
            if (soThang > 12 || soThang < 0)
            {
                return -1;
            }
            else if (soThang > 6)
            {
                tienThu = tienPhong * 2;
            }
            else
            {
                tienThu = tienPhong;
            }
            return tienThu;
        }

        public bool CapNhatHopDongThuePhong(int maHD, string tenLoaiPhong,DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai)
        {
            bool kq = false;
            int soThang = ((ngayKetThuc.Year - ngayBatDau.Year) * 12) + (ngayKetThuc.Month - ngayBatDau.Month);
            double tienThu = 0;
            double tienPhong = qlp.layGiaTienPhong(tenLoaiPhong);
            if (soThang > 12 || soThang < 0)
            {
                kq = false;
                return kq;
            }
            else if(soThang > 6)
            {
                tienThu = tienPhong * 2;
            }    
            else
            {
                tienThu = tienPhong;
            }
            if (ngayLap > ngayBatDau || ngayLap > ngayKetThuc)
            {
                kq = false;
                return kq;
            }
            else
            {
                HopDongThuePhong hd = qlktx.HopDongThuePhongs.Where(t => t.hop_dong_id == maHD).FirstOrDefault();
                if (hd != null)
                {
                    hd.ngay_lap = ngayLap;
                    hd.ngay_bat_dau_thue = ngayBatDau;
                    hd.ngay_ket_thuc_thue = ngayKetThuc;
                    hd.trangthai = trangThai;
                    hd.tienthu = (int)tienThu;
                    qlktx.SubmitChanges();
                    kq = true;
                }
            }
            return kq;
        }

        public object locHoaDon(int tuThang, int tuNam, int denThang, int denNam, string trangThai)
        {

            if (trangThai == "Tất cả")
            {
                var hopDongs = qlktx.HopDongThuePhongs.Select(t => new { t.hop_dong_id, t.Phong.so_phong, t.SinhVien.ho_ten, t.tienthu, t.trangthai }).ToList();
                return hopDongs;
            }
            else
            {
                var hopDongs = qlktx.HopDongThuePhongs
                .Where(t => t.ngay_lap.Value.Month >= tuThang && t.ngay_lap.Value.Month <= denThang && t.ngay_lap.Value.Year>=tuNam &&t.ngay_lap.Value.Year<= denNam && t.trangthai == trangThai)
                .Select(t => new { t.hop_dong_id, t.Phong.so_phong, t.SinhVien.ho_ten, t.tienthu, t.trangthai })
                .ToList();
                return hopDongs;
            }

        }

        public bool kiemTraKhoangThoiGian(DateTime date, int tuThang, int tuNam, int denThang, int denNam)
        {
            if (date.Year > tuNam && date.Year < denNam)
            {
                return true;
            }
            if (date.Year == tuNam && date.Month >= tuThang)
            {
                return true;
            }
            if (date.Year == denNam && date.Month <= denThang)
            {
                return true;
            }
            return false;
        }

        public object loadDSHopDongThuePhong()
        {
 
            var hopDongs = qlktx.HopDongThuePhongs.Select(t => new
            {
                t.hop_dong_id,
                t.Phong.so_phong,
                t.SinhVien.ho_ten,
                t.tienthu,
                t.trangthai
            }).ToList();

       
            return hopDongs.ToList();
        }

        public object loadDSHopDongThuePhongTheoMaSV(string maSV)
        {
           
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(maSV);
            if(sv == null)
            {
                return null;
            }    
            var hopDongs = qlktx.HopDongThuePhongs.Where(t=>t.sinh_vien_id== sv.sinh_vien_id).Select(t => new { t.hop_dong_id, t.Phong.so_phong, t.SinhVien.ho_ten, t.tienthu, t.trangthai }).ToList();
            return hopDongs;
        }


        public HopDongThuePhong loadHopDongThuePhong(int maHD)
        {
            var hopDong = qlktx.HopDongThuePhongs.Where(t => t.hop_dong_id == maHD).FirstOrDefault();
            return hopDong;
        }

        public bool kiemTraHopDongSinhVien(string maSV)
        {
            var hopDong = qlktx.HopDongThuePhongs.Where(t => t.SinhVien.ma_sinh_vien == maSV && t.trangthai == "Chưa thanh toán").FirstOrDefault();
            if(hopDong!=null)
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }
    }
}

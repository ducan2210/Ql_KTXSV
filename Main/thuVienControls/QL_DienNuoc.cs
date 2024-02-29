using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuVienControls
{
    public class QL_DienNuoc
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();

        public QL_DienNuoc()
        {

        }

        public double TinhTienDien(int soDien)
        {
            var giaDien = qlktx.GiaDiens.OrderBy(g => g.so_bat_dau).ToList();
            double tienDien = 0;
            int i = 0; // Bắt đầu từ mức giá đầu tiên

            while (soDien > 0 && i < giaDien.Count)
            {
                int soDienTrongBac = 0;

                if (i == 0)
                {
                    soDienTrongBac = Math.Min(soDien, (int)giaDien[i].so_bat_dau);
                }
                else
                {
                    soDienTrongBac = Math.Min(soDien, (int)giaDien[i].so_bat_dau - (int)giaDien[i - 1].so_bat_dau);
                }

                tienDien += soDienTrongBac * (double)giaDien[i].Gia;
                soDien -= soDienTrongBac;
                i++;
            }

            // Nếu số điện còn lại, tính với giá cao nhất
            if (soDien > 0)
            {
                double giaCaoNhat = (double)giaDien.Last().Gia;
                tienDien += soDien * (double)giaCaoNhat;
            }

            return tienDien;
        }


        public double TinhTienNuoc(int soNuoc)
        {
            var giaNuoc = qlktx.GiaNuocs.Select(g => g.Gia).FirstOrDefault();
            return (double)giaNuoc * soNuoc;
        }

        public bool themNacGiaDien(int soBatDau, double donGia)
        {
            bool kq = false;
                if (soBatDau == 0)
                {
                    kq = false;
                }
                else
                {
                    var giaBacDuoi = qlktx.GiaDiens.Where(g => g.so_bat_dau < soBatDau).OrderByDescending(g => g.so_bat_dau).FirstOrDefault();
                    var giaBacTren = qlktx.GiaDiens.Where(g => g.so_bat_dau > soBatDau).OrderBy(g => g.so_bat_dau).FirstOrDefault();

                    if (giaBacDuoi == null || (giaBacTren != null && donGia > (double)giaBacDuoi.Gia && donGia < (double)giaBacTren.Gia))
                    {
                        // Tạo một đối tượng GiaDien mới
                        GiaDien newGiaDien = new GiaDien
                        {
                            so_bat_dau = soBatDau,
                            Gia = (decimal)donGia
                        };
                        // Thêm đối tượng GiaDien mới vào bảng GiaDiens
                        qlktx.GiaDiens.InsertOnSubmit(newGiaDien);

                    // Lưu thay đổi xuống cơ sở dữ liệu
                    qlktx.SubmitChanges();
                        kq = true;
                    }
                    else
                    {
                        kq = false;
                    }
                
            }

            return kq;
        }

        public bool capNhatGiaNuoc(double gia)
        {
            var giaNuoc = qlktx.GiaNuocs.Where(t => t.ID == 1).FirstOrDefault();
            if(giaNuoc != null)
            {
                giaNuoc.Gia = (decimal)gia;
                qlktx.SubmitChanges();
            }
            return true;
        }

        public bool xoaNacDien(int soBatDau, double donGia)
        {
            bool kq = false;
            if(soBatDau == 0)
            {
                kq = false;
            }   
            else
            {
                var giaDien = qlktx.GiaDiens.Where(t => t.so_bat_dau == soBatDau && t.Gia == (decimal)donGia).FirstOrDefault();
                if(giaDien!= null)
                {
                    qlktx.GiaDiens.DeleteOnSubmit(giaDien);
                    qlktx.SubmitChanges();
                    kq = true;
                }    
            }
            return kq;
        }

        public bool CapNhatBangGiaDien(int i, int soBatDau, double donGia)
        {
            var giaDien = qlktx.GiaDiens.Where(t => t.ID == i).FirstOrDefault();

            if (giaDien != null)
            {
                var giaBacDuoi = qlktx.GiaDiens.Where(g => g.so_bat_dau < soBatDau).OrderByDescending(g => g.so_bat_dau).FirstOrDefault();
                var giaBacTren = qlktx.GiaDiens.Where(g => g.so_bat_dau > soBatDau).OrderBy(g => g.so_bat_dau).FirstOrDefault();

                if ((giaBacDuoi == null || (soBatDau > giaBacDuoi.so_bat_dau && donGia > (double)giaBacDuoi.Gia)) &&
                    (giaBacTren == null || (soBatDau < giaBacTren.so_bat_dau && donGia < (double)giaBacTren.Gia)))
                {
                    giaDien.so_bat_dau = soBatDau;
                    giaDien.Gia = (decimal)donGia;
                    qlktx.SubmitChanges();
                    return true;
                }
            }

            return false;
        }

        public GiaNuoc loadGiaNuoc()
        {
            var gia = qlktx.GiaNuocs.Select(t => t).FirstOrDefault();
            return gia;
        }

        public bool capNhatHoaDonDienNuoc(int maHD, int soDien, int soNuoc,double tongTien, string trangThai)
        {
            HoaDonDienNuoc hd = qlktx.HoaDonDienNuocs.Where(t => t.hoa_don_id == maHD).FirstOrDefault(); ;
            bool kq = false;
            if (hd != null)
            {
                hd.so_dien = soDien;
                hd.so_khoi_nuoc = soNuoc;
                hd.tong_tien = (decimal)tongTien;
                hd.trang_thai = trangThai;
                qlktx.SubmitChanges();
                kq = true;
            }
            else
            {
                kq = false;
            }
            return kq;
        }

        public bool ghiChiSoDienNuoc(int idPhong, int thang, int nam, int soDien, int soNuoc)
        {
            HoaDonDienNuoc hd = kiemTraHoaDon(idPhong, thang, nam);
            bool kq = false;
            double tongTien = TinhTienDien(soDien) + TinhTienNuoc(soNuoc);
            if (hd != null)
            {
                hd.so_dien = soDien;
                hd.so_khoi_nuoc = soNuoc;
                hd.tong_tien = (decimal)tongTien;
                qlktx.SubmitChanges();
                kq = true;
            }
            else
            {
                HoaDonDienNuoc hdMoi = new HoaDonDienNuoc();
                hdMoi.phong_id = idPhong;
                hdMoi.thang = thang;
                hdMoi.nam = nam;
                hdMoi.so_dien = soDien;
                hdMoi.so_khoi_nuoc = soNuoc;
                hdMoi.tong_tien = (decimal)tongTien;
                hdMoi.trang_thai = "Chưa thanh toán";
                qlktx.HoaDonDienNuocs.InsertOnSubmit(hdMoi);
                qlktx.SubmitChanges();
                kq = true;
            }
            return kq;
        }

        public HoaDonDienNuoc kiemTraHoaDon(int idPhong, int thang, int nam)
        {
            var hoaDon = qlktx.HoaDonDienNuocs.Where(t => t.phong_id == idPhong && t.thang == thang && t.nam == nam).FirstOrDefault();
            return hoaDon;
        }

        public object locHoaDon(int tuThang, int tuNam, int denThang, int denNam, string trangThai)
        {

            if (trangThai == "Tất cả")
            {
                var hoaDons = qlktx.HoaDonDienNuocs.Where(t => t.thang >= tuThang && t.nam >= tuNam && t.thang <= denThang && t.nam <= denNam).Select(t => new { t.hoa_don_id, t.Phong.so_phong, t.thang, t.nam, t.so_dien, t.so_khoi_nuoc, t.tong_tien, t.trang_thai }).ToList();
                return hoaDons;
            }
            else
            {
                var hoaDons = qlktx.HoaDonDienNuocs.Where(t => t.thang >= tuThang && t.nam >= tuNam && t.thang <= denThang && t.nam <= denNam && t.trang_thai == trangThai).Select(t => new { t.hoa_don_id, t.Phong.so_phong, t.thang, t.nam, t.so_dien, t.so_khoi_nuoc, t.tong_tien, t.trang_thai }).ToList();
                return hoaDons;
            }

        }

        public List<GiaDien> loadBangGiaDien()
        {
            var bangGia = qlktx.GiaDiens.Select(t => t).ToList();
            return bangGia;
        }

        public object loadHoaDonDienNuoc()
        {
            var hoaDons = qlktx.HoaDonDienNuocs.Select(t => new { t.hoa_don_id, t.Phong.so_phong, t.thang, t.nam, t.so_dien, t.so_khoi_nuoc, t.tong_tien, t.trang_thai }).ToList();
            return hoaDons;
        }

        public HoaDonDienNuoc loadTTHoaDonDienNuocTheoMa(int maHD)
        {
            var hoaDon = qlktx.HoaDonDienNuocs.Where(t => t.hoa_don_id == maHD).FirstOrDefault();
            return hoaDon;
        }
        public object loadDSHoaDonDienNuocTheoSP(string soPhong)
        {
            var hoaDons = qlktx.HoaDonDienNuocs.Where(t => t.Phong.so_phong == soPhong).Select(t => new { t.hoa_don_id, t.Phong.so_phong, t.thang, t.nam, t.so_dien, t.so_khoi_nuoc, t.tong_tien, t.trang_thai }).ToList();
            return hoaDons;
        }
    }
}

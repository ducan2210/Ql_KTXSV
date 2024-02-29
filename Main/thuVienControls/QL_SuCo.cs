using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuVienControls
{
    public class QL_SuCo
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        public QL_SuCo()
        {

        }

        public object loadDanhSachSuCo()
        {
            var sucos = qlktx.SuCos.Select(t => new { t.su_co_id, t.Phong.so_phong, t.ngay_bao_cao, t.mo_ta_su_co, t.trang_thai_xu_ly }).ToList();
            return sucos;
        }

        public object loadLocDanhSachSuCo(string trangThai, DateTime tuNgay, DateTime denNgay)
        {
            if (trangThai == "Tất cả")
            {
                var sucos = qlktx.SuCos.Where(t => t.ngay_bao_cao >= tuNgay && t.ngay_bao_cao <= denNgay).Select(t => new { t.su_co_id, t.Phong.so_phong, t.ngay_bao_cao, t.mo_ta_su_co, t.trang_thai_xu_ly }).ToList();
                return sucos;
            }
            else {
                var sucos = qlktx.SuCos.Where(t =>t.ngay_bao_cao>=tuNgay && t.ngay_bao_cao<=denNgay&&t.trang_thai_xu_ly==trangThai).Select(t => new { t.su_co_id, t.Phong.so_phong, t.ngay_bao_cao, t.mo_ta_su_co, t.trang_thai_xu_ly }).ToList();
                return sucos;
            }
            
        }

        public SuCo loadThongTinSuCo(int maSuCo)
        {
            var suco = qlktx.SuCos.Where(t => t.su_co_id == maSuCo).FirstOrDefault();
            return suco;
        }


        public bool capNhatThongTinSuCo(int maSC, string moTa, string trangThai)
        {
            var suco = qlktx.SuCos.Where(t => t.su_co_id == maSC).FirstOrDefault();
            if(suco==null)
            {
                return false;
            }
            suco.mo_ta_su_co = moTa;
            suco.trang_thai_xu_ly = trangThai;
            qlktx.SubmitChanges();
            return true;
        }
    }
}

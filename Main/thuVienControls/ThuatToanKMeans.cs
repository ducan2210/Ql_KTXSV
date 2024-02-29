using Accord.MachineLearning;
using Accord.Math.Distances;
using System.Collections.Generic;
using System.Linq;
namespace thuVienControls
{
    public class ThuatToanKMeans
    {
        QL_KTXDataContext QL_KTX = new QL_KTXDataContext();
        QL_Phong qlp = new QL_Phong();
        Ql_SinhVien QL_sv = new Ql_SinhVien();
        double[][] moHinhHuanLuyen =
              {
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 1 },
                    new double[] { 2 },
                    new double[] { 1 },
                    new double[] { 1 },
                    new double[] { 2 }
                };
        public ThuatToanKMeans()
        {
          

        }
        public int[] ttKmean(double[][] mauHuanLuyen, double[][] ttSinhVien, int k)
        {
            Accord.Math.Random.Generator.Seed = 0;


            KMeans kmeans = new KMeans(k: k);

            // Compute and retrieve the data centroids using the training model
            var clusters = kmeans.Learn(mauHuanLuyen);

            // Use the centroids to partition all the data
            int[] labels = clusters.Decide(ttSinhVien);
            return labels;
        }

        public string TimPhongPhuHop(string gioiTinh, string loaiPhong)
        {
            int gt;
            if(gioiTinh=="Nam")
            {
                gt = 1;
            }    
            else
            {
                gt = 2;
            }

            double[][] sinhVienData = {
                // Thay thế các giá trị sau đây bằng giới tính và loại phòng của sinh viên cụ thể
                new double[] { gt }
            };

            ThuatToanKMeans tt = new ThuatToanKMeans();
            QL_Phong qlp = new QL_Phong();
            List<string> dsten = qlp.LayDSTenPhongTheoLoaiPhong(loaiPhong);
            string[] tenPhong = dsten.ToArray();
            int[] phong = tt.ttKmean(moHinhHuanLuyen, sinhVienData, moHinhHuanLuyen.Length);

            List<Phong> danhSachPhong = qlp.loadDSPhong();

            string phongTrong = null; // Sử dụng một biến để lưu trữ phòng trống (nếu có)

            for (int i = 0; i < phong.Length; i++)
            {
                int phongIndex = phong[i];
                string tenPhongHienTai = tenPhong[phongIndex];

                // Tìm phòng hiện tại trong danh sách
                Phong phongHienTai = danhSachPhong.FirstOrDefault(p => p.so_phong == tenPhongHienTai);

                // Kiểm tra xem phòng đã đầy chưa
                if (phongHienTai != null && qlp.kiemTraSlotPhong(phongHienTai.so_phong))
                {
                    return tenPhongHienTai;
                }
                else
                {
                    // Nếu phòng đã đầy hoặc không tìm thấy phòng, tìm phòng khác còn trống
                    phongTrong = qlp.TimPhongTrong(tenPhong, qlp.kiemTraSoNguoiToiDa(tenPhongHienTai));
                    if (phongTrong != null)
                    {
                        return phongTrong;
                    }
                }
            }
            return phongTrong != null ? phongTrong : "Không có phòng phù hợp";
        }
    }
}

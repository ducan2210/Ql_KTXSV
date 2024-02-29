using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_QLHopDongThuePhong : UserControl
    {
        QL_HopDongThuePhong qlhd = new QL_HopDongThuePhong();
        public gd_QLHopDongThuePhong()
        {
            InitializeComponent();
            loadDanhSachHD();
            loadFullCBX();
        }

        public void loadDanhSachHD()
        {
            dgv_dsHD.DataSource = qlhd.loadDSHopDongThuePhong();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {

            int tuThang = int.Parse((cbx_tuThang.SelectedItem.ToString()).Substring(6)); // Lấy phần con số sau "Tháng "
            int denThang = int.Parse((cbx_denThang.SelectedItem.ToString()).Substring(6));
            int tuNam = (int)cbx_tuNam.SelectedItem;
            int denNam = (int)cbx_denNam.SelectedItem;
            string trangThai = cbx_trangThai.SelectedItem.ToString();
            dgv_dsHD.DataSource = qlhd.locHoaDon(tuThang, tuNam, denThang, denNam, trangThai);
        }

        public void loadFullCBX()
        {
            int currentYear = DateTime.Now.Year;
            List<int> yearsList = new List<int>();
            for (int i = currentYear - 20; i <= currentYear; i++)
            {
                yearsList.Add(i);
            }

            cbx_tuNam.DataSource = yearsList;
            cbx_denNam.DataSource = yearsList;
            cbx_denNam.SelectedItem = currentYear;
            cbx_tuNam.SelectedItem = currentYear;
            cbx_xuatNam.DataSource = yearsList;
            cbx_xuatNam.DataSource = yearsList;

            string[] months = new string[]
             {
                "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"
             };

            cbx_tuThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_tuThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            cbx_denThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_denThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            cbx_xuatThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_xuatThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            string[] trangThai = { "Tất cả", "Chưa thanh toán", "Đã thanh toán" };
            cbx_trangThai.Items.AddRange(trangThai);
            cbx_trangThai.SelectedItem = "Tất cả";
        }

        public event EventHandler clickDataGrid;

        public HopDongThuePhong layThongTinHopDong()
        {
            
            int maHD = int.Parse(dgv_dsHD.CurrentRow.Cells["hop_dong_id"].Value.ToString());
            var hdtp = qlhd.loadHopDongThuePhong(maHD);
            return hdtp;
        }

        public event EventHandler lapHDClick;

        private void btn_lapHopDong_Click(object sender, EventArgs e)
        {
       

                lapHDClick?.Invoke(this, e);
        }

        private void dgv_dsHD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clickDataGrid?.Invoke(this, e);
        }

        private void btn_xemHopDong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_maSinhVien.Text))
            {
                if (qlhd.loadDSHopDongThuePhongTheoMaSV(txt_maSinhVien.Text.ToString())==null)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại nhập lại !");
                }
                else
                {
                    dgv_dsHD.DataSource = qlhd.loadDSHopDongThuePhongTheoMaSV(txt_maSinhVien.Text.ToString());
                }    
               
                
               
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã số sinh viên !");
              
            }    
        }

        private void txt_maSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {

            loadDanhSachHD();
            txt_maSinhVien.Text=string.Empty;
            cbx_denNam.SelectedItem = 0;
            cbx_denThang.SelectedItem = 0;
            cbx_trangThai.SelectedItem = 0;
            cbx_tuNam.SelectedItem = 0;
            cbx_tuThang.SelectedItem = 0;
            cbx_xuatNam.SelectedItem = 0;
            cbx_xuatThang.SelectedItem = 0;
        }

        private void dgv_dsHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

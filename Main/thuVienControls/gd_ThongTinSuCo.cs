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

    public partial class gd_ThongTinSuCo : UserControl
    {
        QL_SuCo qlSuCo = new QL_SuCo();
        public gd_ThongTinSuCo()
        {
            InitializeComponent();
            loadCBXTrangThai();
        }

        public void loadCBXTrangThai()
        {
            string[] trangThai = {"Đã xử lý", "Chưa xử lý" };
            cbx_trangThai.DataSource = trangThai;
        }

        public void loadThongTinSuCo(int maSuCo)
        {
            SuCo sc = qlSuCo.loadThongTinSuCo(maSuCo);
            txt_maSuCo.Text = sc.su_co_id.ToString();
            txt_soPhong.Text = sc.Phong.so_phong.ToString();
            txt_moTa.Text = sc.mo_ta_su_co.ToString();
            dtp_ngayBaoCao.Value = sc.ngay_bao_cao.Value;
            cbx_trangThai.SelectedItem = sc.trang_thai_xu_ly.ToString();
        }

        public event EventHandler huyBoClick;
        private void btn_huy_Click(object sender, EventArgs e)
        {
            huyBoClick?.Invoke(this, e);
        }

        private void btn_luuThayDoi_Click(object sender, EventArgs e)
        {
            int maSC = int.Parse(txt_maSuCo.Text.ToString());
            string moTa = txt_moTa.Text.ToString();
            string trangThai = cbx_trangThai.SelectedItem.ToString();
            DialogResult r = MessageBox.Show("Bạn có chắc muốn cập nhật lại thông tin không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (qlSuCo.capNhatThongTinSuCo(maSC, moTa, trangThai))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }

        }

        private void txt_soPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
    }
}

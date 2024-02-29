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
    public partial class gd_QLBaoCaoSuCo : UserControl
    {
        QL_SuCo qlsuCo = new QL_SuCo();
        public gd_QLBaoCaoSuCo()
        {
            InitializeComponent();
            loadDanhSachSuCo();
            loadCBXTrangThai();
        }

        public void loadCBXTrangThai()
        {
            string[] trangThai = { "Tất cả","Đã xử lý", "Chưa xử lý" };
            cbx_trangThai.DataSource = trangThai;
        }

        public int layMaSuCo()
        {
            return int.Parse(dgv_dsSuCo.CurrentRow.Cells[0].Value.ToString());
        }

        public void loadDanhSachSuCo()
        {
           dgv_dsSuCo.DataSource =  qlsuCo.loadDanhSachSuCo();
        }

        public event EventHandler clickDatagrid;
        private void dgv_dsSuCo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clickDatagrid?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trangThai = cbx_trangThai.SelectedItem.ToString();
            dgv_dsSuCo.DataSource = qlsuCo.loadLocDanhSachSuCo(trangThai, dtp_tuNgay.Value, dtp_denNgay.Value);
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            loadDanhSachSuCo();
            cbx_trangThai.SelectedItem = 0;
        }

        private void dgv_dsSuCo_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

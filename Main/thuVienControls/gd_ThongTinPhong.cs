using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_ThongTinPhong : UserControl
    {

        
        public gd_ThongTinPhong()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong, string loaiPhong, string tang ,string soNguoi)
        {
            lb_tenPhong.Text += tenPhong;
            lb_loaiPhong.Text += loaiPhong;
            lb_tang.Text += tang;
            lb_soNguoi.Text += soNguoi;
        }

        public void loadGridSinhVien(DataGridView dgv)
        {
            grid_sinhVien.DataSource = dgv.DataSource;
        }

        private void grid_sinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public event EventHandler thoat_Click;
        private void button1_Click(object sender, EventArgs e)
        {
            thoat_Click?.Invoke(this, EventArgs.Empty);
        }
    }
}

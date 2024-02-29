using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_GhiDienNuoc : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_Phong qlPhong = new QL_Phong();
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_GhiDienNuoc()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong)
        {
            lb_tenPhong.Text += tenPhong;
            loadCBXNam();
            loadCBXThang();
        }
        public void loadCBXNam()
        {
            int currentYear = DateTime.Now.Year;
            List<int> yearsList = new List<int>();
            for (int i = currentYear - 20; i <= currentYear; i++)
            {
                yearsList.Add(i);
            }
            cbx_nam.DataSource = yearsList;
            cbx_nam.SelectedItem = currentYear;

        }
        public void loadCBXThang()
        {
            List<string> monthsList = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                string monthName = i.ToString();
                monthsList.Add(monthName);
            }

            cbx_thang.DataSource = monthsList;
            cbx_thang.SelectedItem = DateTime.Now.Month;
        }

        public event EventHandler xacNhansclick;
        public event EventHandler huyclick;

        public void xacNhanGhiDienNuoc(string tenPhong)
        {
            Phong p = qlPhong.loadThongTinPhong(tenPhong);
            int thang = int.Parse((cbx_thang.SelectedItem.ToString())); // Lấy phần con số sau "Tháng "
            int nam = int.Parse(cbx_nam.SelectedItem.ToString());

            if (!string.IsNullOrEmpty(txt_soDien.Text.ToString()) || !string.IsNullOrEmpty(txt_soNuoc.Text.ToString()))
            {
                int soDien = int.Parse(txt_soDien.Text.ToString());
                int soNuoc = int.Parse(txt_soNuoc.Text.ToString());
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (qldn.ghiChiSoDienNuoc(p.phong_id, thang, nam, soDien, soNuoc))
                    {
                        MessageBox.Show("Ghi số điện thành công");
                    }
                    else
                    {
                        MessageBox.Show("Ghi số điện thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
            }    
        }




        private void txt_soDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_soNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cbx_thang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            xacNhansclick?.Invoke(this, e);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            huyclick?.Invoke(this, e);
        }
    }
}

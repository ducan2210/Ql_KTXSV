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
    public partial class gd_GiaDien : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_GiaDien()
        {
            InitializeComponent();
        }
        public void loadGia(int stt, int soBatDau, double donGia)
        {
            txt_SoBatDau.Text = soBatDau.ToString();
            txt_DonGia.Text = donGia.ToString();
            lb_stt.Text = stt.ToString();
        }

        public void CapNhatDuLieu()
        {
            int soBatDau = int.Parse(txt_SoBatDau.Text);
            double donGia = double.Parse(txt_DonGia.Text);

            int id = int.Parse(lb_stt.Text);
            if(qldn.CapNhatBangGiaDien(id, soBatDau, donGia))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        private void txt_SoBatDau_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int soBatDau = int.Parse(txt_SoBatDau.Text);
            double donGia = double.Parse(txt_DonGia.Text);
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không?", "xóa", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (qldn.xoaNacDien(soBatDau, donGia))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}

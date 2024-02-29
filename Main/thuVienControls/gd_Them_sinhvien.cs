using Accord.Statistics.Kernels;
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
using thietKeControls;

namespace thuVienControls
{
    public partial class gd_Them_sinhvien : UserControl
    {
        public gd_Them_sinhvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ql_SinhVien sv = new Ql_SinhVien();
            if (kiemtra_dulieunhapdu() && sv.IsEmailValid(txtEmail1.Text))
            {
                DialogResult result = MessageBox.Show($"Bạn muốn thêm sinh viên {txt_hotensv.Text} này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DateTime ngaysinh = txt_masket_ngaysinh.Value;
               
                    bool kq= sv.TaoMoiSinhVien(
                        txt_masv.Text,
                        txt_hotensv.Text,
                        ngaysinh.Date,
                        txt_cccd.Text,
                        LayGiaTriRadioButton(),
                        txt_sodienthoai.Text,
                        txt_diachi.Text,
                        txtEmail1.Text
                    );
                    if( kq ) 
                    {
                        MessageBox.Show(txt_hotensv.Text + " đã được thêm vào danh sách !", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(txt_masv.Text + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                    }    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu hoặc viết thông tin sai cú pháp ?", "Thông báo", MessageBoxButtons.OK);
            }    
        }


        public bool kiemtra_dulieunhapdu()
        {
            return !string.IsNullOrWhiteSpace(txt_masv.Text) &&
                   !string.IsNullOrWhiteSpace(txt_hotensv.Text) &&
                   !string.IsNullOrWhiteSpace(txt_masket_ngaysinh.Text) &&
                   !string.IsNullOrWhiteSpace(txt_cccd.Text) &&
                   !string.IsNullOrWhiteSpace(txt_diachi.Text) &&
                   !string.IsNullOrWhiteSpace(txt_sodienthoai.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail1.Text);
        }


        private string LayGiaTriRadioButton()
        {
            string giaTri="";
            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;

                    if (radioButton.Checked)
                    {
                        giaTri = radioButton.Text;                                                   
                    }
                }
            }
            return giaTri;
        }

        private void ChuyenDoiNgaySinh()
        {
            string ngaySinhText = txt_masket_ngaysinh.Text;

            if (DateTime.TryParseExact(ngaySinhText, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
            {
                string ngaySinhYMD = ngaySinh.ToString("yyyy/MM/dd");

                txt_masket_ngaysinh.Text = ngaySinhYMD;
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public event EventHandler ThoatClick;




        private void txt_masv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_hotensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txt_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_cccd.Text.Length >= 12 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_sodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_sodienthoai.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            ThoatClick?.Invoke(this, e);
        }

        private void txt_masket_ngaysinh_CloseUp(object sender, EventArgs e)
        {
            DateTime ngaysinh = txt_masket_ngaysinh.Value;
            if (ngaysinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ !");
                txt_masket_ngaysinh.Value = DateTime.Now;
            }
        }

        private void txt_hotensv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_nguoidung : UserControl
    {
       NguoiDung_DAL nd=new NguoiDung_DAL();
        bool them = false;
        bool sua = false;
        public gd_nguoidung()
        {
            InitializeComponent();
            Load += Gd_nguoidung_Load;
            cbm_trangthai.Items.Add("Đang hoạt động");
            cbm_trangthai.Items.Add("Ngưng hoạt động");
        }

        private void Gd_nguoidung_Load(object sender, EventArgs e)
        {
            load_data();
         
            txt_tennguoidung.Enabled = false;
            txt_matkhau.Enabled = false;
        }
        public void load_data()
        {
            
            //------------------------------------------------

            List<string> list = nd.layList_tenvaitro();
            foreach (string item in list) 
            {
                cbm_vaitro.Items.Add(item);
            }
            data_nguoidung.DataSource = nd.getNguoiDung();
            data_nguoidung.Columns[5].Visible = false;
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_matkhau.Enabled = true;
            txt_tennguoidung.Enabled=true;
            them = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(them)
            {
                if (string.IsNullOrEmpty(txt_tennguoidung.Text) || string.IsNullOrEmpty(txt_matkhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    bool kq = nd.themTaiKhoanSinhVien(txt_tennguoidung.Text, txt_matkhau.Text);
                    if (kq)
                    {
                        MessageBox.Show("Tài khoản " + txt_tennguoidung.Text + " thêm thành công !", "Thông báo", MessageBoxButtons.OK);
                        load_data();
                        txt_tennguoidung.Text = "";
                        txt_matkhau.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản " + txt_tennguoidung.Text + " bị trùng !", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                them = false;
                txt_tennguoidung.Enabled = false;
                txt_matkhau.Enabled = false;
            }   
            else
            {
                if (string.IsNullOrEmpty(txt_tennguoidung.Text) || string.IsNullOrEmpty(txt_matkhau.Text)
                  || string.IsNullOrEmpty(cbm_trangthai.SelectedItem.ToString()) ||
                  string.IsNullOrEmpty(cbm_vaitro.SelectedItem.ToString()))
                {
                    MessageBox.Show("Không thể sửa dữ liệu này", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult r = MessageBox.Show("Bạn muốn sửa lại thông tin", "Chú ý", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        int mavaitro = nd.laymavaitro(cbm_vaitro.SelectedItem.ToString());
                        bool trangThai;
                        if(cbm_trangthai.Text == "Đang hoạt động")
                        {
                            trangThai = true;
                        }
                        else
                        {
                            trangThai = false;
                        }

                        bool kq = nd.suaTaiKhoanSinhVien(txt_tennguoidung.Text, txt_matkhau.Text,trangThai, mavaitro);
                        if (kq)
                        {
                            MessageBox.Show("Cập nhật thành công !", "Thông Báo", MessageBoxButtons.OK);
                            load_data();
                            txt_tennguoidung.Text = "";
                            txt_matkhau.Text = "";
                            txt_tennguoidung.Enabled = false;
                            txt_matkhau.Enabled = false;
                            
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_data();
            txt_matkhau.Text = "";
            txt_tennguoidung.Text = "";
            cbm_trangthai.SelectedItem = 0;
            cbm_vaitro.SelectedItem = 0;
        }

        private void txt_tennguoidung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void data_nguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_tennguoidung.Enabled = true;
                txt_matkhau.Enabled = true;
                data_nguoidung.ClearSelection();
                data_nguoidung.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = data_nguoidung.Rows[e.RowIndex];
                txt_tennguoidung.Text = selectedRow.Cells["ten_nguoi_dung"].Value.ToString();
                txt_matkhau.Text = selectedRow.Cells["mat_khau"].Value.ToString();
                string trangThai = selectedRow.Cells["trang_thai"].Value.ToString();
                if(trangThai=="True")
                {
                    cbm_trangthai.Text = "Đang hoạt động";
                }   
                else
                {
                    cbm_trangthai.Text = "Ngưng hoạt động";
                }    
                int mavaitro = int.Parse(selectedRow.Cells["vai_tro_id"].Value.ToString());
                cbm_vaitro.SelectedItem = nd.laytenvaitro(mavaitro);
            }
        }

        private void data_nguoidung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_nguoidung.Columns[e.ColumnIndex].Name == "mat_khau" && e.Value != null)
            {
                // Thay thế giá trị bằng '*'
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
    }
}

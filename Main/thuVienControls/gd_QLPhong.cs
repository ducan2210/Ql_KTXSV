using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using thuVienControls;

namespace thuVienControls
{
    public partial class gd_QLPhong : UserControl
    {
        private Phong phong1 = new Phong();
        private QL_Phong qL_Phong = new QL_Phong();
        bool them = false;
        bool sua=false;

        public event EventHandler Gd_Controlsclick;

        public gd_QLPhong()
        {
            InitializeComponent();
            Load += Gd_QLPhong_Load;
           


        }

        private void Gd_QLPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_sophong.Enabled = false;
            cbm_loaiphong.Enabled =false;
            cbm_tang.Enabled = false;
            cbm_trangthai.Enabled = false;
        }
        public gd_QLPhong(Phong phong)
        {
            InitializeComponent();
            phong1 = phong;
            txt_sophong.Text += phong.so_phong.ToString();
            cbm_loaiphong.SelectedValue = phong.loai_phong_id;
            cbm_tang.SelectedValue = phong.tang;
            cbm_trangthai.SelectedValue = phong.trang_thai;
        }
        public void LoadData()
        {
            LoadPhong();
            cbm_loaiphong.Items.Clear();
            cbm_tang.Items.Clear();
            cbm_trangthai.Items.Clear();
            foreach (string s in qL_Phong.laytenloaiPhong_khongtrung())
            {
                cbm_loaiphong.Items.Add(s.ToString());
            }

            cbm_trangthai.Items.AddRange(new[] { "Trống", "Đang ở" });
            cbm_tang.Items.AddRange(Enumerable.Range(1, 10).Select(s => s.ToString()).ToArray());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_sophong.Enabled = true;
            cbm_loaiphong.Enabled= true;
            cbm_tang.Enabled= true;
            cbm_trangthai.SelectedItem = "Trống";
            them = true;

        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrEmpty(txt_sophong.Text) &&
                   cbm_loaiphong.SelectedItem != null &&
                   cbm_tang.SelectedItem != null &&
                   cbm_loaiphong.SelectedItem != null;
        }

        public void ResetInputs()
        {
            txt_sophong.Text = "";
            cbm_loaiphong.SelectedItem = null;
            cbm_tang.SelectedItem = null;
            cbm_trangthai.SelectedItem = null;
        }
        public void Enabled(bool b)
        {
            txt_sophong.Enabled = b;
            cbm_loaiphong.Enabled = b; ;
            cbm_tang.Enabled = b;
            cbm_trangthai .Enabled = b;
        }
        public void LoadPhong()
        {
            ResetInputs();
            flowLayoutPanel1.Controls.Clear();
            cbm_loaiphong.Controls.Clear();

            foreach (Phong p in qL_Phong.loadDSPhong())
            {
                gd_Phong gd = new gd_Phong
                {
                    BackColor = Color.Aqua,
                    SoPhong = p.so_phong
                };

                gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, qL_Phong.DemSoSinhVienTrongPhong(p.so_phong));
                gd.Controlsclick += Gd_Controlsclick;
               // gd.Controlsclick_sua += Gd_Controlsclick_sua;
                gd.Controlsclick_xoa += Gd_Controlsclick_xoa;
                flowLayoutPanel1.Controls.Add(gd);
            }

            flowLayoutPanel1.AutoScroll = true;
        }
        public void load_sua(Phong phong)
        {
            txt_sophong.Text = phong.so_phong.ToString();
            cbm_loaiphong.SelectedValue = phong.loai_phong_id;
            cbm_tang.SelectedValue = phong.tang;
            cbm_trangthai.SelectedValue = phong.trang_thai;

        }
        public void load_theoboloc(List<Phong> list)
        {
            ResetInputs();
            flowLayoutPanel1.Controls.Clear();

            foreach (Phong p in list)
            {
                gd_Phong gd = new gd_Phong
                {
               
                    SoPhong = p.so_phong
                };

                gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, qL_Phong.DemSoSinhVienTrongPhong(p.so_phong));
                gd.Controlsclick += Gd_Controlsclick;
               // gd.Controlsclick_sua += Gd_Controlsclick_sua;
                sua = true;
                txt_sophong.Enabled = true;
                cbm_loaiphong.Enabled = true;
                cbm_tang.Enabled = true;
                gd.Controlsclick_xoa += Gd_Controlsclick_xoa;
                flowLayoutPanel1.Controls.Add(gd);
            }

        
          

        }

        private void Gd_Controlsclick_xoa(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Gd_Controlsclick_sua(object sender, EventArgs e)
        {
            //ResetInputs();
            //gd_Phong gd = sender as gd_Phong;
            //if (gd != null)
            //{
            //    sua = true;
            //    Phong a = qL_Phong.loadThongTinPhong(gd.SoPhong);
            //    txt_sophong.Text +=a.so_phong.ToString();
            //    cbm_loaiphong.SelectedItem = qL_Phong.layLoaiPhong(int.Parse(a.loai_phong_id.ToString()));
            //    cbm_tang.SelectedItem = a.tang.ToString();
            //    cbm_trangthai.SelectedItem =a.trang_thai;
            //    txt_sophong.Enabled = true;
            //    cbm_loaiphong.Enabled = true;
            //    cbm_trangthai.Enabled = true;
            //}
           
        }
        private void OnGdControlsclick()
        {
            Gd_Controlsclick?.Invoke(this, EventArgs.Empty);
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            OnGdControlsclick();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (sua)
            {
                //DialogResult r = MessageBox.Show("Bạn có muốn sửa phòng" + txt_sophong.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (r == DialogResult.Yes)
                //{
                //    int maloaiphong = qL_Phong.lay_maloaiphong(cbm_loaiphong.SelectedItem.ToString());
                //  bool kq=   qL_Phong.update_Phong(txt_sophong.Text,maloaiphong);
          
                //    if(kq)
                //    {
                //        MessageBox.Show("Đã sửa thành công !", "Thông báo", MessageBoxButtons.OK);
                //    }    
                //    else
                //    {
                //        MessageBox.Show("Cập nhật khong thành công !", "Thông Báo", MessageBoxButtons.OK);
                //    }
                //    ResetInputs();
                //}
                //else
                //{

                //  MessageBox.Show("Cập nhật khong thành công !", "Thông Báo", MessageBoxButtons.OK);
                //}    
                //LoadData();
                //sua = false;
                //ResetInputs();

            }
            else if(them)
            {
                if (ValidateInputs())
                {
                    int maloaiphong = qL_Phong.lay_maloaiphong(cbm_loaiphong.SelectedItem.ToString());
                   bool kt=qL_Phong.them_Phong(txt_sophong.Text, int.Parse(cbm_tang.SelectedItem.ToString()),
                        "Trống",maloaiphong );
                    if(kt)
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        LoadPhong();

                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Số phòng đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập đủ dữ liệu !", "Lưu Ý", MessageBoxButtons.OK);
                }
                them = false;
                txt_sophong.Enabled = false;
                cbm_loaiphong.Enabled = false;
                cbm_tang.Enabled = false;
                cbm_trangthai.Enabled = false;
                ResetInputs();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == null)
            {
                LoadData();
            }
            if (radio_sophong.Checked)
            {
                List<Phong> phongsFiltered = qL_Phong.LocTheo_SoPhong(txt_tim.Text);
                load_theoboloc(phongsFiltered);
            }
            else if (radio_tang.Checked)
            {
                List<Phong> phongsFiltered = qL_Phong.LocTheo_Tang(int.Parse(txt_tim.Text));
                load_theoboloc(phongsFiltered);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            radio_sophong.Checked = false;
            radio_tang.Checked = false;
            txt_sophong.Text = "";
            txt_tim.Text = "";
            them = false;
            txt_sophong.Enabled = false;
            cbm_loaiphong.Enabled = false;
            cbm_tang.Enabled = false;
            cbm_trangthai.Enabled = false;
            ResetInputs();

        }

        private void txt_sophong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_tim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }
    }
}

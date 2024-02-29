using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuVienControls;
namespace Main
{
    public partial class Form_QLHopDongThuePhong : Form
    {
        gd_QLHopDongThuePhong gd = new gd_QLHopDongThuePhong();
        public Form_QLHopDongThuePhong()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(gd);
            gd.clickDataGrid += Gd_clickDataGrid;
            gd.lapHDClick += Gd_lapHDClick;
        }

        private void Gd_lapHDClick(object sender, EventArgs e)
        {
            Form_LapHopDongThuePhong form = new Form_LapHopDongThuePhong();
            form.Show();
        }

        private void Gd_clickDataGrid(object sender, EventArgs e)
        {
            HopDongThuePhong hd = gd.layThongTinHopDong();
            Form_ThongTinHopDong tthd = new Form_ThongTinHopDong(hd.hop_dong_id);
            tthd.Show();
        }
    }
}

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
    public partial class Form_ThongTinHopDong : Form
    {
        gd_ThongTinHopDong gd = new gd_ThongTinHopDong();
        int maHD;
        public Form_ThongTinHopDong()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(gd); 
            gd.huyBoClick += Gd_huyBoClick;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public Form_ThongTinHopDong(int maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(gd);
            gd.huyBoClick += Gd_huyBoClick;
            gd.loadThongTinHopDong(maHD);
        }

        

        private void Gd_huyBoClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

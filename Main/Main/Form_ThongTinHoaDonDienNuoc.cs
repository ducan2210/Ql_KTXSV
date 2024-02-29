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
    public partial class Form_ThongTinHoaDonDienNuoc : Form
    {
 
        gd_ThongTinHoaDonDienNuoc gd = new gd_ThongTinHoaDonDienNuoc();
        public Form_ThongTinHoaDonDienNuoc()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public Form_ThongTinHoaDonDienNuoc(int maHD)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gd.loadThongTinHoaDon(maHD);
            gd.clickHuy += Gd_clickHuy;
            flowLayoutPanel1.Controls.Add(gd);
        }

        private void Gd_clickHuy(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

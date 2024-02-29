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
    public partial class Form_ThongTinSuCo : Form
    {
        gd_ThongTinSuCo gd = new gd_ThongTinSuCo();
        QL_SuCo qlsc = new QL_SuCo();
        public Form_ThongTinSuCo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(gd);
        }

        public Form_ThongTinSuCo(int maSC)
        {
            InitializeComponent();
            gd.loadThongTinSuCo(maSC);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gd.huyBoClick += Gd_huyBoClick;
            flowLayoutPanel1.Controls.Add(gd);
        }

        private void Gd_huyBoClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

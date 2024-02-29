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
    public partial class Form_QLBaoCaoSuCo : Form
    {
        gd_QLBaoCaoSuCo gd = new gd_QLBaoCaoSuCo();
        public Form_QLBaoCaoSuCo()
        {
            InitializeComponent();
            gd.clickDatagrid += Gd_clickDatagrid;

            flowLayoutPanel1.Controls.Add(gd);
        }

        private void Gd_clickDatagrid(object sender, EventArgs e)
        {
            int maSC = gd.layMaSuCo();
            Form_ThongTinSuCo ttsc = new Form_ThongTinSuCo(maSC);
            ttsc.Show();
        }
    }
}

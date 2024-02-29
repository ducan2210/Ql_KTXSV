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
    public partial class Form_QLBangGiaDienNuoc : Form
    {
        Form_QLDienNuoc qldn = new Form_QLDienNuoc();
        gd_QLBangGiaDienNuoc gd = new gd_QLBangGiaDienNuoc();
        public Form_QLBangGiaDienNuoc()
        {
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            flowLayoutPanel1.Controls.Add(gd);
            gd.huyClick += Gd_huyClick;
        }



        private void Gd_huyClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form_ThemSinhVien : Form
    {
        public Form_ThemSinhVien()
        {
            InitializeComponent();
            Load += Form_ThemSinhVien_Load;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_ThemSinhVien_Load(object sender, EventArgs e)
        {
            gd_Them_sinhvien t_sv=new gd_Them_sinhvien();
            panel1.Controls.Add(t_sv);
            t_sv.ThoatClick += T_sv_ThoatClick;

        }

        private void T_sv_ThoatClick(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

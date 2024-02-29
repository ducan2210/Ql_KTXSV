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
    public partial class Form_DSPhong : Form
    {
        QL_Phong qlp = new QL_Phong();
        
        public Form_DSPhong()
        {
            InitializeComponent();
            loadPhong();
            WindowState = FormWindowState.Maximized;

        }

        public void loadPhong()
        {
            gd_QLPhong ql=new gd_QLPhong();
            panel1.Controls.Add(ql);
            ql.Gd_Controlsclick += Ql_Gd_Controlsclick;
        }

        private void Ql_Gd_Controlsclick(object sender, EventArgs e)
        {
            gd_Phong gd = sender as gd_Phong;
            if (gd != null)
            {
                string soPhong = gd.SoPhong;
                Form_ThongTinPhong form = new Form_ThongTinPhong(soPhong);
                form.Show();
            }
        }

 

        private void Form_DSPhong_Load(object sender, EventArgs e)
        {

        }


    }
}

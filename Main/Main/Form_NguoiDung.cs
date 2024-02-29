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
    public partial class Form_NguoiDung : Form
    {
        public Form_NguoiDung()
        {
            InitializeComponent();
            Load += Form_NguoiDung_Load;
        }

        private void Form_NguoiDung_Load(object sender, EventArgs e)
        {
            gd_nguoidung nd=new gd_nguoidung();
            panel1.Controls.Add(nd);
        }
    }
}

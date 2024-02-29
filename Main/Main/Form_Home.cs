using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form_Home : Form
    {
        private Form activeForm;
        public Form_Home()
        {
            InitializeComponent();
            Load += Form_Home_Load;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;


            // Đặt Location để panel giữ ở giữa
            panel_trangchu.Location = new Point((this.Width - panel_trangchu.Width) / 2, (this.Height - panel_trangchu.Height) / 2);

        }

        private void pn_form_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_trangchu.Controls.Add(childForm);
            this.panel_trangchu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_DSPhong(), sender);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
         OpenChildForm(new Form_QLSinhVien(), sender);  
        }

        private void quảnLýĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QLDienNuoc(), sender);
        }

        private void quảnLýHợpĐồngThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLHopDongThuePhong form = new Form_QLHopDongThuePhong();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void báoCáoSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLBaoCaoSuCo form = new Form_QLBaoCaoSuCo();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            testKM form = new testKM();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_NguoiDung form =new Form_NguoiDung();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }
    }
}

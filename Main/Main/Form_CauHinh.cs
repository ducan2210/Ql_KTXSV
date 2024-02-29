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
    public partial class Form_CauHinh : Form
    {
        public Form_CauHinh()
        {
            InitializeComponent();
            cbx_severname.DropDown += Cbx_severname_DropDown;
            cbx_database.DropDown += Cbx_database_DropDown;
        }

        private void Cbx_database_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_database.DataSource =
            CauHinh.GetDBName(cbx_severname.Text, txt_username.Text, txt_pass.Text);
            cbx_database.DisplayMember = "name";
        }

        private void Cbx_severname_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_severname.DataSource = CauHinh.GetServerName();
            cbx_severname.DisplayMember = "ServerName";
        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_severname.DataSource = CauHinh.GetServerName();
            cbx_severname.DisplayMember = "ServerName";
        }

        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_database.DataSource =
            CauHinh.GetDBName(cbx_severname.Text, txt_username.Text, txt_pass.Text);
            cbx_database.DisplayMember = "name";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            CauHinh.SaveConfig(cbx_severname.Text, txt_username.Text, txt_pass.Text, cbx_database.Text);
            this.Close();
        }
    }
}

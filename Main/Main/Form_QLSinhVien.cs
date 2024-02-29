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
    public partial class Form_QLSinhVien : Form
    {
        Ql_SinhVien qlsv = new Ql_SinhVien();
        gd_QLSinhVien gd = new gd_QLSinhVien();
        gd_LapHopDongThuePhong gd_lhd=new gd_LapHopDongThuePhong();
        DataGridView dgv = new DataGridView();
        public Form_QLSinhVien()
        {
            InitializeComponent();
            loadDSSinhVien();
           
        }



        public void loadDSSinhVien()
        {

            dgv.DataSource = qlsv.loadDanhSachSinhVien();
            gd.loadGridSinhVien(dgv);
            gd.loadCbxTrangThai();
            
            flowLayoutPanel1.Controls.Add(gd);
            gd.themSVClick += Gd_themSVClick;
            gd.DataGridViewCellClick += Gd_DataGridViewCellClick;
            gd.laphopdong_Click += Gd_laphopdong_Click;
            


        }

        private void Gd_laphopdong_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gd.GetDataGrid().CurrentRow;
            if (selectedRow != null)
            {
                string masv = selectedRow.Cells[0].Value.ToString();
                Form_LapHopDongThuePhong lap = new Form_LapHopDongThuePhong(masv);
                lap.Massv = masv;
                lap.Show();
            }
        }

        private void Gd_DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
          
        }

        private void Gd_themSVClick(object sender, EventArgs e)
        {
           Form_ThemSinhVien frm=new Form_ThemSinhVien();
            frm.Show();
        }
    }
}

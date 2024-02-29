using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace thuVienControls
{
    public partial class gd_QLSinhVien : UserControl
    {
        QL_KTXDataContext QL_KTX = new QL_KTXDataContext();
        Ql_SinhVien qlsv = new Ql_SinhVien();
        string massv;
        DataGridView dgv=new DataGridView();
        public string Massv { get => massv; set => massv = value; }

        public gd_QLSinhVien()
        {
            InitializeComponent();
            Load += Gd_QLSinhVien_Load;
        }

        private void Gd_QLSinhVien_Load(object sender, EventArgs e)
        {
            
        }

        public void loadGridSinhVien(DataGridView dgv)
        {
            grid_dssv.DataSource = dgv.DataSource;
        }

        public void loadCbxTrangThai()
        {
            cbx_trangThai.Items.Add("Tất cả");
            cbx_trangThai.Items.Add("Đang ở");
            cbx_trangThai.Items.Add("Ngưng ở");
            cbx_trangThai.Items.Add("Chờ duyệt");
        }

        private void cbx_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string trangThai = cbx_trangThai.SelectedItem.ToString();
            if(trangThai=="Tất cả")
            {

                grid_dssv.DataSource = qlsv.loadDanhSachSinhVien();
            }
            else if (trangThai == "Chờ duyệt")
            {
                grid_dssv.DataSource = qlsv.loadDanhSachSinhVienTheoTrangThai("Chờ duyệt");
            }
            else if (trangThai == "Ngưng ở")
            {
                grid_dssv.DataSource = qlsv.loadDanhSachSinhVienTheoTrangThai("Ngưng ở");
            }
            else
            {
                grid_dssv.DataSource = qlsv.loadDanhSachSinhVienTheoTrangThai("Đang ở");
            }
        }

        private void grid_dssv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow selectedRow = grid_dssv.CurrentRow;
            if (selectedRow != null)
            {
                string masv = selectedRow.Cells[0].Value.ToString();
                Form_ThongTinSinhVien frm=new Form_ThongTinSinhVien(masv);
                frm.Show();
            }
        }
        public event EventHandler themSVClick;
        private void btn_them_Click(object sender, EventArgs e)
        {
          themSVClick?.Invoke(this, e);
        }

      
        public DataGridView GetDataGrid()
        {
            return grid_dssv;
        }

        public event EventHandler<DataGridViewCellEventArgs> DataGridViewCellClick;
        private void grid_dssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        
        private void btn_tailai_Click(object sender, EventArgs e)
        {
            grid_dssv.DataSource = qlsv.loadDanhSachSinhVien();
            cbx_trangThai.SelectedIndex = 0;
        }
        public event EventHandler laphopdong_Click;
        private void btn_laphopdong_Click(object sender, EventArgs e)
        {
            laphopdong_Click?.Invoke(this, e);
        }

        private void grid_dssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        //--------------------------------------------------------------------



    }
}

namespace thuVienControls
{
    partial class gd_ThongTinPhong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new Guna.UI.WinForms.GunaGradientButton();
            this.lb_soNguoi = new System.Windows.Forms.Label();
            this.lb_tang = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grid_sinhVien = new Guna.UI.WinForms.GunaDataGridView();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sinh_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lb_soNguoi);
            this.panel1.Controls.Add(this.lb_tang);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Controls.Add(this.lb_tenPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 217);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BaseColor1 = System.Drawing.Color.Indigo;
            this.button1.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = null;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(421, 159);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.button1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_soNguoi
            // 
            this.lb_soNguoi.AutoSize = true;
            this.lb_soNguoi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_soNguoi.Location = new System.Drawing.Point(418, 101);
            this.lb_soNguoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soNguoi.Name = "lb_soNguoi";
            this.lb_soNguoi.Size = new System.Drawing.Size(159, 21);
            this.lb_soNguoi.TabIndex = 9;
            this.lb_soNguoi.Text = "Số người ở hiện tại: ";
            // 
            // lb_tang
            // 
            this.lb_tang.AutoSize = true;
            this.lb_tang.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_tang.Location = new System.Drawing.Point(418, 55);
            this.lb_tang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tang.Name = "lb_tang";
            this.lb_tang.Size = new System.Drawing.Size(104, 21);
            this.lb_tang.TabIndex = 8;
            this.lb_tang.Text = "Thuộc tầng: ";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_loaiPhong.Location = new System.Drawing.Point(41, 159);
            this.lb_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(101, 21);
            this.lb_loaiPhong.TabIndex = 7;
            this.lb_loaiPhong.Text = "Loại phòng: ";
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_tenPhong.Location = new System.Drawing.Point(39, 101);
            this.lb_tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(99, 21);
            this.lb_tenPhong.TabIndex = 6;
            this.lb_tenPhong.Text = "Tên phòng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin chung:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 440);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grid_sinhVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 430);
            this.panel4.TabIndex = 2;
            // 
            // grid_sinhVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_sinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_sinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sinhVien.BackgroundColor = System.Drawing.Color.White;
            this.grid_sinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_sinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_sinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_sinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_sinhVien.ColumnHeadersHeight = 27;
            this.grid_sinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ho_ten,
            this.ma_sinh_vien,
            this.gioi_tinh,
            this.email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_sinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_sinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_sinhVien.EnableHeadersVisualStyles = false;
            this.grid_sinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_sinhVien.Location = new System.Drawing.Point(0, 0);
            this.grid_sinhVien.Name = "grid_sinhVien";
            this.grid_sinhVien.RowHeadersVisible = false;
            this.grid_sinhVien.RowHeadersWidth = 51;
            this.grid_sinhVien.RowTemplate.Height = 24;
            this.grid_sinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sinhVien.Size = new System.Drawing.Size(995, 430);
            this.grid_sinhVien.TabIndex = 0;
            this.grid_sinhVien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grid_sinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_sinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_sinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_sinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_sinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_sinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_sinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_sinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.BlueViolet;
            this.grid_sinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_sinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grid_sinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_sinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grid_sinhVien.ThemeStyle.HeaderStyle.Height = 27;
            this.grid_sinhVien.ThemeStyle.ReadOnly = false;
            this.grid_sinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_sinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_sinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grid_sinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_sinhVien.ThemeStyle.RowsStyle.Height = 24;
            this.grid_sinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_sinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_sinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_sinhVien_CellContentClick);
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ Tên";
            this.ho_ten.MinimumWidth = 6;
            this.ho_ten.Name = "ho_ten";
            // 
            // ma_sinh_vien
            // 
            this.ma_sinh_vien.DataPropertyName = "ma_sinh_vien";
            this.ma_sinh_vien.HeaderText = "Mã sinh viên";
            this.ma_sinh_vien.MinimumWidth = 6;
            this.ma_sinh_vien.Name = "ma_sinh_vien";
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.MinimumWidth = 6;
            this.gioi_tinh.Name = "gioi_tinh";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 10);
            this.panel3.TabIndex = 1;
            // 
            // gd_ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gd_ThongTinPhong";
            this.Size = new System.Drawing.Size(995, 657);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soNguoi;
        private System.Windows.Forms.Label lb_tang;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDataGridView grid_sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sinh_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private Guna.UI.WinForms.GunaGradientButton button1;
    }
}

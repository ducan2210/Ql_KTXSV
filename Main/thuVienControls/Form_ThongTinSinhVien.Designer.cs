namespace Main
{
    partial class Form_ThongTinSinhVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongTinSinhVien));
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_gioiTinh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_duyet = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_luu = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_khongDuyet = new Guna.UI.WinForms.GunaGradientButton();
            this.txt_email = new thietKeControls.txtEmail();
            this.btn_thoat = new Guna.UI.WinForms.GunaGradientButton();
            this.cbx_phong = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbx_gioiTinh
            // 
            resources.ApplyResources(this.cbx_gioiTinh, "cbx_gioiTinh");
            this.cbx_gioiTinh.FormattingEnabled = true;
            this.cbx_gioiTinh.Name = "cbx_gioiTinh";
            // 
            // dtp_ngaySinh
            // 
            resources.ApplyResources(this.dtp_ngaySinh, "dtp_ngaySinh");
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaySinh.MaxDate = new System.DateTime(2555, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.CloseUp += new System.EventHandler(this.dtp_ngaySinh_CloseUp);
            // 
            // txt_diaChi
            // 
            resources.ApplyResources(this.txt_diaChi, "txt_diaChi");
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diaChi_KeyPress);
            // 
            // txt_sdt
            // 
            resources.ApplyResources(this.txt_sdt, "txt_sdt");
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_hoTen
            // 
            resources.ApplyResources(this.txt_hoTen, "txt_hoTen");
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoTen_KeyPress);
            // 
            // txt_maSV
            // 
            resources.ApplyResources(this.txt_maSV, "txt_maSV");
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maSV_KeyPress);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_duyet
            // 
            this.btn_duyet.AnimationHoverSpeed = 0.07F;
            this.btn_duyet.AnimationSpeed = 0.03F;
            this.btn_duyet.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_duyet.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_duyet.BorderColor = System.Drawing.Color.Black;
            this.btn_duyet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_duyet.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_duyet, "btn_duyet");
            this.btn_duyet.ForeColor = System.Drawing.Color.White;
            this.btn_duyet.Image = null;
            this.btn_duyet.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_duyet.Name = "btn_duyet";
            this.btn_duyet.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_duyet.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_duyet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_duyet.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_duyet.OnHoverImage = null;
            this.btn_duyet.OnPressedColor = System.Drawing.Color.Black;
            this.btn_duyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_duyet.Click += new System.EventHandler(this.btn_duyet_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AnimationHoverSpeed = 0.07F;
            this.btn_luu.AnimationSpeed = 0.03F;
            this.btn_luu.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_luu.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_luu.BorderColor = System.Drawing.Color.Black;
            this.btn_luu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_luu.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_luu, "btn_luu");
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Image = null;
            this.btn_luu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_luu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu.OnHoverImage = null;
            this.btn_luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_khongDuyet
            // 
            this.btn_khongDuyet.AnimationHoverSpeed = 0.07F;
            this.btn_khongDuyet.AnimationSpeed = 0.03F;
            this.btn_khongDuyet.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_khongDuyet.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_khongDuyet.BorderColor = System.Drawing.Color.Black;
            this.btn_khongDuyet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_khongDuyet.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_khongDuyet, "btn_khongDuyet");
            this.btn_khongDuyet.ForeColor = System.Drawing.Color.White;
            this.btn_khongDuyet.Image = null;
            this.btn_khongDuyet.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_khongDuyet.Name = "btn_khongDuyet";
            this.btn_khongDuyet.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_khongDuyet.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_khongDuyet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_khongDuyet.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_khongDuyet.OnHoverImage = null;
            this.btn_khongDuyet.OnPressedColor = System.Drawing.Color.Black;
            this.btn_khongDuyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_khongDuyet.Click += new System.EventHandler(this.btn_khongDuyet_Click);
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.Name = "txt_email";
            // 
            // btn_thoat
            // 
            this.btn_thoat.AnimationHoverSpeed = 0.07F;
            this.btn_thoat.AnimationSpeed = 0.03F;
            this.btn_thoat.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_thoat.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_thoat.BorderColor = System.Drawing.Color.Black;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_thoat.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_thoat, "btn_thoat");
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = null;
            this.btn_thoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_thoat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_thoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thoat.OnHoverImage = null;
            this.btn_thoat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbx_phong
            // 
            this.cbx_phong.BackColor = System.Drawing.Color.Transparent;
            this.cbx_phong.BaseColor = System.Drawing.Color.White;
            this.cbx_phong.BorderColor = System.Drawing.Color.Silver;
            this.cbx_phong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_phong.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.cbx_phong, "cbx_phong");
            this.cbx_phong.ForeColor = System.Drawing.Color.Black;
            this.cbx_phong.FormattingEnabled = true;
            this.cbx_phong.Name = "cbx_phong";
            this.cbx_phong.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_phong.OnHoverItemForeColor = System.Drawing.Color.White;
            // 
            // Form_ThongTinSinhVien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.cbx_phong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_khongDuyet);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_duyet);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_gioiTinh);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_maSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ThongTinSinhVien";
            this.Load += new System.EventHandler(this.Form_ThongTinSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_gioiTinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private thietKeControls.txtEmail txt_email;
        private Guna.UI.WinForms.GunaGradientButton btn_duyet;
        private Guna.UI.WinForms.GunaGradientButton btn_luu;
        private Guna.UI.WinForms.GunaGradientButton btn_khongDuyet;
        private Guna.UI.WinForms.GunaGradientButton btn_thoat;
        private Guna.UI.WinForms.GunaComboBox cbx_phong;
    }
}
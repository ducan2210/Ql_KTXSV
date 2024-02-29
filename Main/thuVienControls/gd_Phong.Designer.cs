
namespace thuVienControls
{
    partial class gd_Phong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ghiDienNuoc = new Guna.UI.WinForms.GunaGradientButton();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.lb_soThanhVien = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_ghiDienNuoc);
            this.panel1.Controls.Add(this.lb_tenPhong);
            this.panel1.Controls.Add(this.lb_soThanhVien);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 172);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btn_ghiDienNuoc
            // 
            this.btn_ghiDienNuoc.AnimationHoverSpeed = 0.07F;
            this.btn_ghiDienNuoc.AnimationSpeed = 0.03F;
            this.btn_ghiDienNuoc.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_ghiDienNuoc.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_ghiDienNuoc.BorderColor = System.Drawing.Color.Black;
            this.btn_ghiDienNuoc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ghiDienNuoc.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ghiDienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ghiDienNuoc.ForeColor = System.Drawing.Color.White;
            this.btn_ghiDienNuoc.Image = null;
            this.btn_ghiDienNuoc.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ghiDienNuoc.Location = new System.Drawing.Point(244, 3);
            this.btn_ghiDienNuoc.Name = "btn_ghiDienNuoc";
            this.btn_ghiDienNuoc.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_ghiDienNuoc.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_ghiDienNuoc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ghiDienNuoc.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ghiDienNuoc.OnHoverImage = null;
            this.btn_ghiDienNuoc.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ghiDienNuoc.Size = new System.Drawing.Size(151, 41);
            this.btn_ghiDienNuoc.TabIndex = 17;
            this.btn_ghiDienNuoc.Text = "Số điện nước mới";
            this.btn_ghiDienNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ghiDienNuoc.Click += new System.EventHandler(this.btn_ghiDienNuoc_Click_1);
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_tenPhong.ForeColor = System.Drawing.Color.Black;
            this.lb_tenPhong.Location = new System.Drawing.Point(11, 14);
            this.lb_tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(112, 24);
            this.lb_tenPhong.TabIndex = 3;
            this.lb_tenPhong.Text = "Tên phòng:";
            // 
            // lb_soThanhVien
            // 
            this.lb_soThanhVien.AutoSize = true;
            this.lb_soThanhVien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_soThanhVien.ForeColor = System.Drawing.Color.Black;
            this.lb_soThanhVien.Location = new System.Drawing.Point(11, 117);
            this.lb_soThanhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soThanhVien.Name = "lb_soThanhVien";
            this.lb_soThanhVien.Size = new System.Drawing.Size(139, 24);
            this.lb_soThanhVien.TabIndex = 2;
            this.lb_soThanhVien.Text = "Số thành viên:";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_loaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lb_loaiPhong.Location = new System.Drawing.Point(11, 64);
            this.lb_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(115, 24);
            this.lb_loaiPhong.TabIndex = 1;
            this.lb_loaiPhong.Text = "Loại phòng:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa.AnimationSpeed = 0.03F;
            this.btn_Xoa.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_Xoa.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_Xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::thuVienControls.Properties.Resources.icons8_delete_64;
            this.btn_Xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Xoa.Location = new System.Drawing.Point(345, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_Xoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Size = new System.Drawing.Size(47, 38);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // gd_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gd_Phong";
            this.Size = new System.Drawing.Size(395, 172);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soThanhVien;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenPhong;
        private Guna.UI.WinForms.GunaGradientButton btn_Xoa;
        private Guna.UI.WinForms.GunaGradientButton btn_ghiDienNuoc;
    }
}

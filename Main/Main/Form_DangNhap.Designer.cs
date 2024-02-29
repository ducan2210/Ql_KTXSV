
namespace Main
{
    partial class Form_DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.lbform = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtChiNhapSo1 = new Guna.UI.WinForms.GunaTextBox();
            this.txt_matKhau = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_huy = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbform
            // 
            this.lbform.AutoSize = true;
            this.lbform.BackColor = System.Drawing.Color.Transparent;
            this.lbform.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbform.ForeColor = System.Drawing.Color.Indigo;
            this.lbform.Location = new System.Drawing.Point(689, 27);
            this.lbform.Name = "lbform";
            this.lbform.Size = new System.Drawing.Size(154, 34);
            this.lbform.TabIndex = 44;
            this.lbform.Text = "ĐĂNG NHẬP";
            this.lbform.UseCompatibleTextRendering = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtChiNhapSo1
            // 
            this.txtChiNhapSo1.BaseColor = System.Drawing.Color.White;
            this.txtChiNhapSo1.BorderColor = System.Drawing.Color.Silver;
            this.txtChiNhapSo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiNhapSo1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChiNhapSo1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChiNhapSo1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChiNhapSo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChiNhapSo1.Location = new System.Drawing.Point(701, 114);
            this.txtChiNhapSo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChiNhapSo1.Name = "txtChiNhapSo1";
            this.txtChiNhapSo1.PasswordChar = '\0';
            this.txtChiNhapSo1.SelectedText = "";
            this.txtChiNhapSo1.Size = new System.Drawing.Size(228, 37);
            this.txtChiNhapSo1.TabIndex = 45;
            this.txtChiNhapSo1.Text = "admin01";
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BaseColor = System.Drawing.Color.White;
            this.txt_matKhau.BorderColor = System.Drawing.Color.Silver;
            this.txt_matKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_matKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_matKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_matKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matKhau.Location = new System.Drawing.Point(701, 185);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.SelectedText = "";
            this.txt_matKhau.Size = new System.Drawing.Size(228, 37);
            this.txt_matKhau.TabIndex = 46;
            this.txt_matKhau.Text = "123";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Main.Properties.Resources.icons8_password;
            this.pictureBox3.Location = new System.Drawing.Point(579, 167);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Main.Properties.Resources.icons8_user;
            this.pictureBox2.Location = new System.Drawing.Point(579, 103);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Main.Properties.Resources._5155dac03c64c13a9875_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AnimationHoverSpeed = 0.07F;
            this.btn_thoat.AnimationSpeed = 1F;
            this.btn_thoat.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_thoat.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_thoat.BorderColor = System.Drawing.Color.Transparent;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_thoat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = global::Main.Properties.Resources.icons8_exit_50;
            this.btn_thoat.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_thoat.Location = new System.Drawing.Point(795, 263);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.OnHoverBaseColor1 = System.Drawing.Color.CadetBlue;
            this.btn_thoat.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.btn_thoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thoat.OnHoverImage = null;
            this.btn_thoat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thoat.Size = new System.Drawing.Size(148, 41);
            this.btn_thoat.TabIndex = 38;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.AnimationHoverSpeed = 0.07F;
            this.btn_huy.AnimationSpeed = 1F;
            this.btn_huy.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_huy.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_huy.BorderColor = System.Drawing.Color.Transparent;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = global::Main.Properties.Resources.icons8_login_501;
            this.btn_huy.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_huy.Location = new System.Drawing.Point(593, 263);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor1 = System.Drawing.Color.CadetBlue;
            this.btn_huy.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Size = new System.Drawing.Size(148, 41);
            this.btn_huy.TabIndex = 36;
            this.btn_huy.Text = "Đăng Nhập";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_huy.Click += new System.EventHandler(this.btn_dangNhap_Click_1);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 352);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txtChiNhapSo1);
            this.Controls.Add(this.lbform);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_huy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaLabel lbform;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI.WinForms.GunaGradientButton btn_huy;
        private Guna.UI.WinForms.GunaGradientButton btn_thoat;
        private Guna.UI.WinForms.GunaTextBox txtChiNhapSo1;
        private Guna.UI.WinForms.GunaTextBox txt_matKhau;
    }
}
namespace thuVienControls
{
    partial class gd_QLPhong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_tang = new System.Windows.Forms.RadioButton();
            this.radio_sophong = new System.Windows.Forms.RadioButton();
            this.txt_sophong = new System.Windows.Forms.TextBox();
            this.cbm_trangthai = new System.Windows.Forms.ComboBox();
            this.cbm_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbm_tang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2AnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Luu = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_Them = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_lammoi = new Guna.UI.WinForms.GunaGradientButton();
            this.button1 = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tim);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_sophong);
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.cbm_trangthai);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbm_loaiphong);
            this.panel1.Controls.Add(this.cbm_tang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 187);
            this.panel1.TabIndex = 0;
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_tim.Location = new System.Drawing.Point(768, 134);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(201, 28);
            this.txt_tim.TabIndex = 19;
            this.txt_tim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tim_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_tang);
            this.groupBox1.Controls.Add(this.radio_sophong);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(768, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 96);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bộ lọc";
            // 
            // radio_tang
            // 
            this.radio_tang.AutoSize = true;
            this.radio_tang.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radio_tang.Location = new System.Drawing.Point(174, 38);
            this.radio_tang.Name = "radio_tang";
            this.radio_tang.Size = new System.Drawing.Size(68, 25);
            this.radio_tang.TabIndex = 1;
            this.radio_tang.TabStop = true;
            this.radio_tang.Text = "Tầng";
            this.radio_tang.UseVisualStyleBackColor = true;
            // 
            // radio_sophong
            // 
            this.radio_sophong.AutoSize = true;
            this.radio_sophong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radio_sophong.Location = new System.Drawing.Point(28, 38);
            this.radio_sophong.Name = "radio_sophong";
            this.radio_sophong.Size = new System.Drawing.Size(99, 25);
            this.radio_sophong.TabIndex = 0;
            this.radio_sophong.TabStop = true;
            this.radio_sophong.Text = "Số Phòng";
            this.radio_sophong.UseVisualStyleBackColor = true;
            // 
            // txt_sophong
            // 
            this.txt_sophong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_sophong.Location = new System.Drawing.Point(198, 19);
            this.txt_sophong.Name = "txt_sophong";
            this.txt_sophong.Size = new System.Drawing.Size(187, 28);
            this.txt_sophong.TabIndex = 16;
            this.txt_sophong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sophong_KeyPress);
            // 
            // cbm_trangthai
            // 
            this.cbm_trangthai.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbm_trangthai.FormattingEnabled = true;
            this.cbm_trangthai.Location = new System.Drawing.Point(545, 17);
            this.cbm_trangthai.Name = "cbm_trangthai";
            this.cbm_trangthai.Size = new System.Drawing.Size(163, 29);
            this.cbm_trangthai.TabIndex = 15;
            // 
            // cbm_loaiphong
            // 
            this.cbm_loaiphong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbm_loaiphong.FormattingEnabled = true;
            this.cbm_loaiphong.Location = new System.Drawing.Point(545, 84);
            this.cbm_loaiphong.Name = "cbm_loaiphong";
            this.cbm_loaiphong.Size = new System.Drawing.Size(163, 29);
            this.cbm_loaiphong.TabIndex = 14;
            // 
            // cbm_tang
            // 
            this.cbm_tang.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbm_tang.FormattingEnabled = true;
            this.cbm_tang.Location = new System.Drawing.Point(198, 84);
            this.cbm_tang.Name = "cbm_tang";
            this.cbm_tang.Size = new System.Drawing.Size(187, 29);
            this.cbm_tang.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tầng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phòng";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.guna2AnimateWindow1.Interval = 100;
            this.guna2AnimateWindow1.TargetControl = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vScrollBar1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1690, 547);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 350);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(3, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1709, 570);
            this.panel2.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.AnimationHoverSpeed = 0.07F;
            this.btn_Luu.AnimationSpeed = 0.03F;
            this.btn_Luu.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_Luu.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_Luu.BorderColor = System.Drawing.Color.Black;
            this.btn_Luu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Luu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Image = global::thuVienControls.Properties.Resources.icons8_save_321;
            this.btn_Luu.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Luu.Location = new System.Drawing.Point(387, 134);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_Luu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Luu.OnHoverImage = null;
            this.btn_Luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Luu.Size = new System.Drawing.Size(114, 41);
            this.btn_Luu.TabIndex = 38;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AnimationHoverSpeed = 0.07F;
            this.btn_Them.AnimationSpeed = 0.03F;
            this.btn_Them.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_Them.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_Them.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::thuVienControls.Properties.Resources.icons8_add_50;
            this.btn_Them.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Them.Location = new System.Drawing.Point(213, 134);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_Them.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Size = new System.Drawing.Size(114, 41);
            this.btn_Them.TabIndex = 37;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AnimationHoverSpeed = 0.07F;
            this.btn_lammoi.AnimationSpeed = 0.03F;
            this.btn_lammoi.BaseColor1 = System.Drawing.Color.Indigo;
            this.btn_lammoi.BaseColor2 = System.Drawing.Color.BlueViolet;
            this.btn_lammoi.BorderColor = System.Drawing.Color.Black;
            this.btn_lammoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_lammoi.FocusedColor = System.Drawing.Color.Empty;
            this.btn_lammoi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_lammoi.ForeColor = System.Drawing.Color.White;
            this.btn_lammoi.Image = global::thuVienControls.Properties.Resources.icons8_reset_50;
            this.btn_lammoi.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_lammoi.Location = new System.Drawing.Point(568, 134);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_lammoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_lammoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_lammoi.OnHoverImage = null;
            this.btn_lammoi.OnPressedColor = System.Drawing.Color.Black;
            this.btn_lammoi.Size = new System.Drawing.Size(140, 41);
            this.btn_lammoi.TabIndex = 39;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BaseColor1 = System.Drawing.Color.White;
            this.button1.BaseColor2 = System.Drawing.Color.White;
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::thuVienControls.Properties.Resources.icons8_find_64;
            this.button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.ImageSize = new System.Drawing.Size(40, 40);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button1.Location = new System.Drawing.Point(979, 121);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.button1.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 40;
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gd_QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gd_QLPhong";
            this.Size = new System.Drawing.Size(1715, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sophong;
        private System.Windows.Forms.ComboBox cbm_trangthai;
        private System.Windows.Forms.ComboBox cbm_loaiphong;
        private System.Windows.Forms.ComboBox cbm_tang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.RadioButton radio_tang;
        private System.Windows.Forms.RadioButton radio_sophong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaAnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaGradientButton btn_Luu;
        private Guna.UI.WinForms.GunaGradientButton btn_Them;
        private Guna.UI.WinForms.GunaGradientButton btn_lammoi;
        private Guna.UI.WinForms.GunaGradientButton button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
    }
}

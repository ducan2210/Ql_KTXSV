
namespace thuVienControls
{
    partial class gd_GiaDien
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
            this.button1 = new Guna.UI.WinForms.GunaGradientButton();
            this.lb_stt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoBatDau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lb_stt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_DonGia);
            this.panel1.Controls.Add(this.txt_SoBatDau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 58);
            this.panel1.TabIndex = 0;
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
            this.button1.Image = global::thuVienControls.Properties.Resources.icons8_delete_64;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(553, 15);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.button1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(45, 28);
            this.button1.TabIndex = 30;
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lb_stt
            // 
            this.lb_stt.AutoSize = true;
            this.lb_stt.Location = new System.Drawing.Point(5, 18);
            this.lb_stt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(14, 16);
            this.lb_stt.TabIndex = 29;
            this.lb_stt.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(290, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đơn giá(VNĐ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số bắt đầu";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(414, 15);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(132, 22);
            this.txt_DonGia.TabIndex = 25;
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // txt_SoBatDau
            // 
            this.txt_SoBatDau.Location = new System.Drawing.Point(132, 14);
            this.txt_SoBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoBatDau.Name = "txt_SoBatDau";
            this.txt_SoBatDau.Size = new System.Drawing.Size(132, 22);
            this.txt_SoBatDau.TabIndex = 24;
            this.txt_SoBatDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoBatDau_KeyPress);
            // 
            // gd_GiaDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gd_GiaDien";
            this.Size = new System.Drawing.Size(620, 58);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoBatDau;
        private System.Windows.Forms.Label lb_stt;
        private Guna.UI.WinForms.GunaGradientButton button1;
    }
}

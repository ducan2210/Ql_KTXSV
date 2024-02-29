
namespace Main
{
    partial class Form_CauHinh
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cbx_database = new System.Windows.Forms.ComboBox();
            this.cbx_severname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(272, 265);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(200, 54);
            this.btn_huy.TabIndex = 39;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(33, 265);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(200, 54);
            this.btn_luu.TabIndex = 38;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "user name";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(128, 144);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(343, 22);
            this.txt_pass.TabIndex = 33;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(128, 82);
            this.txt_username.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(343, 22);
            this.txt_username.TabIndex = 32;
            // 
            // cbx_database
            // 
            this.cbx_database.FormattingEnabled = true;
            this.cbx_database.Location = new System.Drawing.Point(128, 206);
            this.cbx_database.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbx_database.Name = "cbx_database";
            this.cbx_database.Size = new System.Drawing.Size(343, 24);
            this.cbx_database.TabIndex = 34;
            // 
            // cbx_severname
            // 
            this.cbx_severname.FormattingEnabled = true;
            this.cbx_severname.Location = new System.Drawing.Point(128, 18);
            this.cbx_severname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbx_severname.Name = "cbx_severname";
            this.cbx_severname.Size = new System.Drawing.Size(343, 24);
            this.cbx_severname.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "sever name";
            // 
            // guna2AnimateWindow1
            // 
            // 
            // Form_CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 358);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.cbx_database);
            this.Controls.Add(this.cbx_severname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_CauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ComboBox cbx_database;
        private System.Windows.Forms.ComboBox cbx_severname;
        private System.Windows.Forms.Label label1;
    }
}
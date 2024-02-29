namespace thuVienControls
{
    partial class user_Xoa_Sua_HD
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 171);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn Muốn Xóa Hay Sửa ?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(118, 73);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 62);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(207, 73);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 62);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // user_Xoa_Sua_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "user_Xoa_Sua_HD";
            this.Size = new System.Drawing.Size(303, 171);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

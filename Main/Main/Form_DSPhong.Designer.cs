namespace Main
{
    partial class Form_DSPhong
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
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1697, 719);
            this.panel1.TabIndex = 0;
            // 
            // Form_DSPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 719);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DSPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_DSPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}
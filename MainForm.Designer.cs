namespace StoreFront
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cr = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_storage = new System.Windows.Forms.Button();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.btn_setting = new System.Windows.Forms.Button();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ir
            // 
            this.btn_ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ir.FlatAppearance.BorderSize = 0;
            this.btn_ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ir.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_ir.Image = ((System.Drawing.Image)(resources.GetObject("btn_ir.Image")));
            this.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ir.Location = new System.Drawing.Point(213, 0);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ir.Size = new System.Drawing.Size(188, 52);
            this.btn_ir.TabIndex = 0;
            this.btn_ir.Text = "Incident Report";
            this.btn_ir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_ir_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1062, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_exit.Size = new System.Drawing.Size(38, 32);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cr
            // 
            this.btn_cr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cr.FlatAppearance.BorderSize = 0;
            this.btn_cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cr.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cr.Image = ((System.Drawing.Image)(resources.GetObject("btn_cr.Image")));
            this.btn_cr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cr.Location = new System.Drawing.Point(0, 0);
            this.btn_cr.Name = "btn_cr";
            this.btn_cr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cr.Size = new System.Drawing.Size(94, 52);
            this.btn_cr.TabIndex = 4;
            this.btn_cr.Text = "Cart";
            this.btn_cr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cr.UseVisualStyleBackColor = true;
            this.btn_cr.Click += new System.EventHandler(this.btn_cr_Click);
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(1024, -1);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(32, 32);
            this.btn_home.TabIndex = 5;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_storage
            // 
            this.btn_storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_storage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_storage.FlatAppearance.BorderSize = 0;
            this.btn_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storage.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_storage.Image = ((System.Drawing.Image)(resources.GetObject("btn_storage.Image")));
            this.btn_storage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_storage.Location = new System.Drawing.Point(94, 0);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_storage.Size = new System.Drawing.Size(119, 52);
            this.btn_storage.TabIndex = 3;
            this.btn_storage.Text = "Storage";
            this.btn_storage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_storage.UseVisualStyleBackColor = true;
            this.btn_storage.Click += new System.EventHandler(this.btn_storage_Click);
            // 
            // panel_desktop
            // 
            this.panel_desktop.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(0, 0);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1100, 620);
            this.panel_desktop.TabIndex = 17;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.SystemColors.Info;
            this.Panel_Menu.Controls.Add(this.btn_setting);
            this.Panel_Menu.Controls.Add(this.btn_exit);
            this.Panel_Menu.Controls.Add(this.btn_ir);
            this.Panel_Menu.Controls.Add(this.btn_storage);
            this.Panel_Menu.Controls.Add(this.btn_cr);
            this.Panel_Menu.Controls.Add(this.btn_home);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(1100, 52);
            this.Panel_Menu.TabIndex = 18;
            // 
            // btn_setting
            // 
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(401, 0);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_setting.Size = new System.Drawing.Size(118, 52);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "Setting";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.panel_desktop);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.Button btn_cr;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel_desktop;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button btn_setting;
    }
}
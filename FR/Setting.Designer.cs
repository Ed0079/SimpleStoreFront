namespace StoreFront.FR
{
    partial class Setting
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
            this.panel_minimenu = new System.Windows.Forms.Panel();
            this.cbox_table = new System.Windows.Forms.ComboBox();
            this.btn_st2 = new System.Windows.Forms.Button();
            this.btn_st1 = new System.Windows.Forms.Button();
            this.panel_blocker = new System.Windows.Forms.Panel();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_minimenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_minimenu
            // 
            this.panel_minimenu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_minimenu.Controls.Add(this.cbox_table);
            this.panel_minimenu.Controls.Add(this.btn_st2);
            this.panel_minimenu.Controls.Add(this.btn_st1);
            this.panel_minimenu.Controls.Add(this.panel_blocker);
            this.panel_minimenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_minimenu.Location = new System.Drawing.Point(0, 0);
            this.panel_minimenu.Name = "panel_minimenu";
            this.panel_minimenu.Size = new System.Drawing.Size(200, 581);
            this.panel_minimenu.TabIndex = 2;
            // 
            // cbox_table
            // 
            this.cbox_table.BackColor = System.Drawing.SystemColors.Control;
            this.cbox_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbox_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_table.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_table.FormattingEnabled = true;
            this.cbox_table.Location = new System.Drawing.Point(0, 156);
            this.cbox_table.Name = "cbox_table";
            this.cbox_table.Size = new System.Drawing.Size(200, 31);
            this.cbox_table.TabIndex = 14;
            this.cbox_table.SelectedIndexChanged += new System.EventHandler(this.cbox_table_SelectedIndexChanged);
            // 
            // btn_st2
            // 
            this.btn_st2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_st2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_st2.FlatAppearance.BorderSize = 0;
            this.btn_st2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_st2.Location = new System.Drawing.Point(0, 104);
            this.btn_st2.Name = "btn_st2";
            this.btn_st2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_st2.Size = new System.Drawing.Size(200, 52);
            this.btn_st2.TabIndex = 8;
            this.btn_st2.Text = "Help";
            this.btn_st2.UseVisualStyleBackColor = true;
            this.btn_st2.Click += new System.EventHandler(this.btn_st2_Click);
            // 
            // btn_st1
            // 
            this.btn_st1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_st1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_st1.FlatAppearance.BorderSize = 0;
            this.btn_st1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_st1.Location = new System.Drawing.Point(0, 52);
            this.btn_st1.Name = "btn_st1";
            this.btn_st1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_st1.Size = new System.Drawing.Size(200, 52);
            this.btn_st1.TabIndex = 7;
            this.btn_st1.Text = "Profile";
            this.btn_st1.UseVisualStyleBackColor = true;
            this.btn_st1.Click += new System.EventHandler(this.btn_st1_Click);
            // 
            // panel_blocker
            // 
            this.panel_blocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_blocker.Location = new System.Drawing.Point(0, 0);
            this.panel_blocker.Name = "panel_blocker";
            this.panel_blocker.Size = new System.Drawing.Size(200, 52);
            this.panel_blocker.TabIndex = 6;
            // 
            // panel_desktop
            // 
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(200, 0);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(884, 581);
            this.panel_desktop.TabIndex = 3;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.panel_minimenu);
            this.Name = "Setting";
            this.Text = "Setting";
            this.panel_minimenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_minimenu;
        private System.Windows.Forms.Panel panel_blocker;
        private System.Windows.Forms.Button btn_st2;
        private System.Windows.Forms.Button btn_st1;
        private System.Windows.Forms.Panel panel_desktop;
        private System.Windows.Forms.ComboBox cbox_table;
    }
}
namespace StoreFront.FR
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_clocked = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_icon = new System.Windows.Forms.Label();
            this.p_1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_name.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_name.Location = new System.Drawing.Point(119, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(61, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_clocked
            // 
            this.lbl_clocked.AutoSize = true;
            this.lbl_clocked.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_clocked.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_clocked.Location = new System.Drawing.Point(0, 0);
            this.lbl_clocked.Name = "lbl_clocked";
            this.lbl_clocked.Size = new System.Drawing.Size(113, 23);
            this.lbl_clocked.TabIndex = 2;
            this.lbl_clocked.Text = "PlaceHolder";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_welcome.Location = new System.Drawing.Point(0, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(119, 23);
            this.lbl_welcome.TabIndex = 5;
            this.lbl_welcome.Text = "PlaceHolder:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_time.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_time.Location = new System.Drawing.Point(969, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(115, 23);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "1234567890";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_date.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_date.Location = new System.Drawing.Point(667, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(302, 23);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "1234567890123456789012345678";
            // 
            // lbl_icon
            // 
            this.lbl_icon.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_icon.Image = ((System.Drawing.Image)(resources.GetObject("lbl_icon.Image")));
            this.lbl_icon.Location = new System.Drawing.Point(385, 145);
            this.lbl_icon.Name = "lbl_icon";
            this.lbl_icon.Size = new System.Drawing.Size(272, 262);
            this.lbl_icon.TabIndex = 9;
            // 
            // p_1
            // 
            this.p_1.Controls.Add(this.lbl_name);
            this.p_1.Controls.Add(this.lbl_welcome);
            this.p_1.Location = new System.Drawing.Point(348, 410);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(393, 29);
            this.p_1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_clocked);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 29);
            this.panel1.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.lbl_icon);
            this.Name = "Home";
            this.Text = "Home";
            this.p_1.ResumeLayout(false);
            this.p_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_clocked;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_icon;
        private System.Windows.Forms.Panel p_1;
        private System.Windows.Forms.Panel panel1;
    }
}
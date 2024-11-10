namespace StoreFront.FR
{
    partial class Incident_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incident_Report));
            this.rbtn_lv1 = new System.Windows.Forms.RadioButton();
            this.btn_send = new System.Windows.Forms.Button();
            this.rtbox_report = new System.Windows.Forms.RichTextBox();
            this.rbtn_lv2 = new System.Windows.Forms.RadioButton();
            this.rbtn_lv3 = new System.Windows.Forms.RadioButton();
            this.lbl_d1 = new System.Windows.Forms.Label();
            this.lbl_signed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_lv1
            // 
            this.rbtn_lv1.AutoSize = true;
            this.rbtn_lv1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rbtn_lv1.Location = new System.Drawing.Point(45, 156);
            this.rbtn_lv1.Name = "rbtn_lv1";
            this.rbtn_lv1.Size = new System.Drawing.Size(68, 27);
            this.rbtn_lv1.TabIndex = 1;
            this.rbtn_lv1.TabStop = true;
            this.rbtn_lv1.Text = "Item";
            this.rbtn_lv1.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(979, 511);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(104, 58);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // rtbox_report
            // 
            this.rtbox_report.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rtbox_report.Location = new System.Drawing.Point(217, 119);
            this.rtbox_report.Name = "rtbox_report";
            this.rtbox_report.Size = new System.Drawing.Size(736, 450);
            this.rtbox_report.TabIndex = 5;
            this.rtbox_report.Text = "";
            // 
            // rbtn_lv2
            // 
            this.rbtn_lv2.AutoSize = true;
            this.rbtn_lv2.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rbtn_lv2.Location = new System.Drawing.Point(45, 201);
            this.rbtn_lv2.Name = "rbtn_lv2";
            this.rbtn_lv2.Size = new System.Drawing.Size(103, 27);
            this.rbtn_lv2.TabIndex = 8;
            this.rbtn_lv2.TabStop = true;
            this.rbtn_lv2.Text = "Software";
            this.rbtn_lv2.UseVisualStyleBackColor = true;
            // 
            // rbtn_lv3
            // 
            this.rbtn_lv3.AutoSize = true;
            this.rbtn_lv3.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rbtn_lv3.Location = new System.Drawing.Point(45, 244);
            this.rbtn_lv3.Name = "rbtn_lv3";
            this.rbtn_lv3.Size = new System.Drawing.Size(77, 27);
            this.rbtn_lv3.TabIndex = 9;
            this.rbtn_lv3.TabStop = true;
            this.rbtn_lv3.Text = "Other";
            this.rbtn_lv3.UseVisualStyleBackColor = true;
            // 
            // lbl_d1
            // 
            this.lbl_d1.AutoSize = true;
            this.lbl_d1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_d1.Location = new System.Drawing.Point(19, 59);
            this.lbl_d1.Name = "lbl_d1";
            this.lbl_d1.Size = new System.Drawing.Size(167, 23);
            this.lbl_d1.TabIndex = 11;
            this.lbl_d1.Text = "Report Signed by :";
            // 
            // lbl_signed
            // 
            this.lbl_signed.AutoSize = true;
            this.lbl_signed.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_signed.Location = new System.Drawing.Point(192, 59);
            this.lbl_signed.Name = "lbl_signed";
            this.lbl_signed.Size = new System.Drawing.Size(28, 23);
            this.lbl_signed.TabIndex = 18;
            this.lbl_signed.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label1.Location = new System.Drawing.Point(19, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Problem with :";
            // 
            // Incident_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_signed);
            this.Controls.Add(this.lbl_d1);
            this.Controls.Add(this.rbtn_lv3);
            this.Controls.Add(this.rbtn_lv2);
            this.Controls.Add(this.rtbox_report);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.rbtn_lv1);
            this.Name = "Incident_Report";
            this.Text = "Incident_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtn_lv1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox rtbox_report;
        private System.Windows.Forms.RadioButton rbtn_lv2;
        private System.Windows.Forms.RadioButton rbtn_lv3;
        private System.Windows.Forms.Label lbl_d1;
        private System.Windows.Forms.Label lbl_signed;
        private System.Windows.Forms.Label label1;
    }
}
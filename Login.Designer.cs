namespace StoreFront
{
    partial class Login
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_enter.Location = new System.Drawing.Point(307, 39);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(94, 51);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txt_name.Location = new System.Drawing.Point(12, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(275, 29);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_pw
            // 
            this.txt_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pw.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txt_pw.Location = new System.Drawing.Point(12, 72);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(275, 29);
            this.txt_pw.TabIndex = 2;
            this.txt_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pw_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 113);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pw;
    }
}


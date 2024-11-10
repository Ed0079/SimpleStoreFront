namespace StoreFront.FR
{
    partial class Confirm
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl2.Location = new System.Drawing.Point(18, 66);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 23);
            this.lbl2.TabIndex = 41;
            this.lbl2.Text = "Total :";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_total.Location = new System.Drawing.Point(120, 66);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 23);
            this.lbl_total.TabIndex = 40;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_confirm.Location = new System.Drawing.Point(12, 145);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(206, 35);
            this.btn_confirm.TabIndex = 42;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl3.Location = new System.Drawing.Point(18, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 23);
            this.lbl3.TabIndex = 45;
            this.lbl3.Text = "Payment :";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_payment.Location = new System.Drawing.Point(120, 100);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(0, 23);
            this.lbl_payment.TabIndex = 44;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl1.Location = new System.Drawing.Point(18, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 23);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Id :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_id.Location = new System.Drawing.Point(120, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 23);
            this.lbl_id.TabIndex = 46;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 192);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl_total);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_id;
    }
}
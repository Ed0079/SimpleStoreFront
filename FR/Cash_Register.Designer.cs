namespace StoreFront.FR
{
    partial class Cash_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash_Register));
            this.lv_cart = new System.Windows.Forms.ListView();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Q = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.P = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_taxes = new System.Windows.Forms.Button();
            this.cbox_name = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.cbox_qty = new System.Windows.Forms.ComboBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cbox_discount = new System.Windows.Forms.CheckBox();
            this.panel_discount = new System.Windows.Forms.Panel();
            this.btn_discount = new System.Windows.Forms.Button();
            this.cbox_txtdiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_s = new System.Windows.Forms.Label();
            this.lbl_t = new System.Windows.Forms.Label();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_other = new System.Windows.Forms.RadioButton();
            this.gbox_other = new System.Windows.Forms.GroupBox();
            this.rbt_other_three = new System.Windows.Forms.RadioButton();
            this.rbt_other_two = new System.Windows.Forms.RadioButton();
            this.rbt_other_one = new System.Windows.Forms.RadioButton();
            this.lbl_taxes = new System.Windows.Forms.Label();
            this.lbl_titleofsub = new System.Windows.Forms.Label();
            this.lbl_titleoftotal = new System.Windows.Forms.Label();
            this.PPD = new System.Windows.Forms.PrintPreviewDialog();
            this.PD = new System.Drawing.Printing.PrintDocument();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.panel_discount.SuspendLayout();
            this.gbox_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_cart
            // 
            this.lv_cart.BackColor = System.Drawing.SystemColors.Window;
            this.lv_cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.Q,
            this.P});
            this.lv_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_cart.FullRowSelect = true;
            this.lv_cart.GridLines = true;
            this.lv_cart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_cart.HideSelection = false;
            this.lv_cart.Location = new System.Drawing.Point(136, 85);
            this.lv_cart.MultiSelect = false;
            this.lv_cart.Name = "lv_cart";
            this.lv_cart.Size = new System.Drawing.Size(422, 474);
            this.lv_cart.TabIndex = 39;
            this.lv_cart.UseCompatibleStateImageBehavior = false;
            this.lv_cart.View = System.Windows.Forms.View.Details;
            this.lv_cart.Click += new System.EventHandler(this.lv_cart_Click);
            // 
            // N
            // 
            this.N.Text = "Name";
            this.N.Width = 127;
            // 
            // Q
            // 
            this.Q.Text = "Qty";
            this.Q.Width = 147;
            // 
            // P
            // 
            this.P.Text = "Price";
            this.P.Width = 137;
            // 
            // btn_taxes
            // 
            this.btn_taxes.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_taxes.Location = new System.Drawing.Point(650, 278);
            this.btn_taxes.Name = "btn_taxes";
            this.btn_taxes.Size = new System.Drawing.Size(91, 35);
            this.btn_taxes.TabIndex = 36;
            this.btn_taxes.Text = "More Info";
            this.btn_taxes.UseVisualStyleBackColor = true;
            this.btn_taxes.Click += new System.EventHandler(this.btn_taxes_Click);
            // 
            // cbox_name
            // 
            this.cbox_name.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_name.FormattingEnabled = true;
            this.cbox_name.Location = new System.Drawing.Point(580, 85);
            this.cbox_name.Name = "cbox_name";
            this.cbox_name.Size = new System.Drawing.Size(138, 31);
            this.cbox_name.TabIndex = 35;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.Add.Location = new System.Drawing.Point(792, 83);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 32);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cbox_qty
            // 
            this.cbox_qty.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_qty.FormattingEnabled = true;
            this.cbox_qty.Items.AddRange(new object[] {
            "0",
            "1",
            "5",
            "10",
            "20"});
            this.cbox_qty.Location = new System.Drawing.Point(724, 85);
            this.cbox_qty.Name = "cbox_qty";
            this.cbox_qty.Size = new System.Drawing.Size(51, 31);
            this.cbox_qty.TabIndex = 40;
            this.cbox_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_qty_KeyPress);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_checkout.Location = new System.Drawing.Point(583, 428);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(206, 35);
            this.btn_checkout.TabIndex = 41;
            this.btn_checkout.Text = "Check-out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_delete.Location = new System.Drawing.Point(883, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 32);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cbox_discount
            // 
            this.cbox_discount.AutoSize = true;
            this.cbox_discount.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_discount.Location = new System.Drawing.Point(583, 156);
            this.cbox_discount.Name = "cbox_discount";
            this.cbox_discount.Size = new System.Drawing.Size(105, 27);
            this.cbox_discount.TabIndex = 43;
            this.cbox_discount.Text = "Discount";
            this.cbox_discount.UseVisualStyleBackColor = true;
            this.cbox_discount.CheckedChanged += new System.EventHandler(this.cbox_discount_CheckedChanged);
            this.cbox_discount.Click += new System.EventHandler(this.cbox_discount_Click);
            // 
            // panel_discount
            // 
            this.panel_discount.Controls.Add(this.btn_discount);
            this.panel_discount.Controls.Add(this.cbox_txtdiscount);
            this.panel_discount.Location = new System.Drawing.Point(694, 144);
            this.panel_discount.Name = "panel_discount";
            this.panel_discount.Size = new System.Drawing.Size(220, 51);
            this.panel_discount.TabIndex = 44;
            this.panel_discount.Visible = false;
            // 
            // btn_discount
            // 
            this.btn_discount.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_discount.Image = ((System.Drawing.Image)(resources.GetObject("btn_discount.Image")));
            this.btn_discount.Location = new System.Drawing.Point(175, 10);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(31, 31);
            this.btn_discount.TabIndex = 45;
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // cbox_txtdiscount
            // 
            this.cbox_txtdiscount.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_txtdiscount.FormattingEnabled = true;
            this.cbox_txtdiscount.Location = new System.Drawing.Point(31, 10);
            this.cbox_txtdiscount.Name = "cbox_txtdiscount";
            this.cbox_txtdiscount.Size = new System.Drawing.Size(138, 31);
            this.cbox_txtdiscount.TabIndex = 36;
            this.cbox_txtdiscount.TextChanged += new System.EventHandler(this.cbox_txtdiscount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label1.Location = new System.Drawing.Point(661, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "or";
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_s.Location = new System.Drawing.Point(707, 229);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(51, 23);
            this.lbl_s.TabIndex = 46;
            this.lbl_s.Text = "0.00";
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_t.Location = new System.Drawing.Point(678, 330);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(51, 23);
            this.lbl_t.TabIndex = 47;
            this.lbl_t.Text = "0.00";
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rbtn_cash.Location = new System.Drawing.Point(586, 380);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(69, 27);
            this.rbtn_cash.TabIndex = 48;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            this.rbtn_cash.Click += new System.EventHandler(this.rbtn_cash_Click);
            // 
            // rbtn_other
            // 
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rbtn_other.Location = new System.Drawing.Point(698, 380);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(77, 27);
            this.rbtn_other.TabIndex = 49;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "Other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            this.rbtn_other.Click += new System.EventHandler(this.rbtn_other_Click);
            // 
            // gbox_other
            // 
            this.gbox_other.Controls.Add(this.rbt_other_three);
            this.gbox_other.Controls.Add(this.rbt_other_two);
            this.gbox_other.Controls.Add(this.rbt_other_one);
            this.gbox_other.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_other.Location = new System.Drawing.Point(781, 351);
            this.gbox_other.Name = "gbox_other";
            this.gbox_other.Size = new System.Drawing.Size(274, 71);
            this.gbox_other.TabIndex = 50;
            this.gbox_other.TabStop = false;
            this.gbox_other.Visible = false;
            // 
            // rbt_other_three
            // 
            this.rbt_other_three.AutoSize = true;
            this.rbt_other_three.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_other_three.Location = new System.Drawing.Point(189, 33);
            this.rbt_other_three.Name = "rbt_other_three";
            this.rbt_other_three.Size = new System.Drawing.Size(64, 22);
            this.rbt_other_three.TabIndex = 51;
            this.rbt_other_three.TabStop = true;
            this.rbt_other_three.Text = "Debit";
            this.rbt_other_three.UseVisualStyleBackColor = true;
            // 
            // rbt_other_two
            // 
            this.rbt_other_two.AutoSize = true;
            this.rbt_other_two.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_other_two.Location = new System.Drawing.Point(102, 33);
            this.rbt_other_two.Name = "rbt_other_two";
            this.rbt_other_two.Size = new System.Drawing.Size(70, 22);
            this.rbt_other_two.TabIndex = 50;
            this.rbt_other_two.TabStop = true;
            this.rbt_other_two.Text = "Credit";
            this.rbt_other_two.UseVisualStyleBackColor = true;
            // 
            // rbt_other_one
            // 
            this.rbt_other_one.AutoSize = true;
            this.rbt_other_one.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_other_one.Location = new System.Drawing.Point(7, 33);
            this.rbt_other_one.Name = "rbt_other_one";
            this.rbt_other_one.Size = new System.Drawing.Size(75, 22);
            this.rbt_other_one.TabIndex = 49;
            this.rbt_other_one.TabStop = true;
            this.rbt_other_one.Text = "PayPal";
            this.rbt_other_one.UseVisualStyleBackColor = true;
            // 
            // lbl_taxes
            // 
            this.lbl_taxes.AutoSize = true;
            this.lbl_taxes.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_taxes.Location = new System.Drawing.Point(579, 284);
            this.lbl_taxes.Name = "lbl_taxes";
            this.lbl_taxes.Size = new System.Drawing.Size(65, 23);
            this.lbl_taxes.TabIndex = 30;
            this.lbl_taxes.Text = "Taxes:";
            // 
            // lbl_titleofsub
            // 
            this.lbl_titleofsub.AutoSize = true;
            this.lbl_titleofsub.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_titleofsub.Location = new System.Drawing.Point(579, 229);
            this.lbl_titleofsub.Name = "lbl_titleofsub";
            this.lbl_titleofsub.Size = new System.Drawing.Size(98, 23);
            this.lbl_titleofsub.TabIndex = 37;
            this.lbl_titleofsub.Text = "SubTotal :";
            // 
            // lbl_titleoftotal
            // 
            this.lbl_titleoftotal.AutoSize = true;
            this.lbl_titleoftotal.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_titleoftotal.Location = new System.Drawing.Point(579, 330);
            this.lbl_titleoftotal.Name = "lbl_titleoftotal";
            this.lbl_titleoftotal.Size = new System.Drawing.Size(65, 23);
            this.lbl_titleoftotal.TabIndex = 38;
            this.lbl_titleoftotal.Text = "Total :";
            // 
            // PPD
            // 
            this.PPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD.Enabled = true;
            this.PPD.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD.Icon")));
            this.PPD.Name = "printPreviewDialog1";
            this.PPD.Visible = false;
            // 
            // PD
            // 
            this.PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD_PrintPage);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_1.Location = new System.Drawing.Point(650, 330);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(22, 23);
            this.lbl_1.TabIndex = 51;
            this.lbl_1.Text = "$";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_2.Location = new System.Drawing.Point(679, 229);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(22, 23);
            this.lbl_2.TabIndex = 52;
            this.lbl_2.Text = "$";
            // 
            // Cash_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.gbox_other);
            this.Controls.Add(this.rbtn_other);
            this.Controls.Add(this.rbtn_cash);
            this.Controls.Add(this.lbl_t);
            this.Controls.Add(this.lbl_s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_discount);
            this.Controls.Add(this.cbox_discount);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.cbox_qty);
            this.Controls.Add(this.lv_cart);
            this.Controls.Add(this.lbl_titleoftotal);
            this.Controls.Add(this.lbl_titleofsub);
            this.Controls.Add(this.btn_taxes);
            this.Controls.Add(this.cbox_name);
            this.Controls.Add(this.lbl_taxes);
            this.Controls.Add(this.Add);
            this.Name = "Cash_Register";
            this.Text = "CashRegister";
            this.Load += new System.EventHandler(this.Cash_Register_Load);
            this.panel_discount.ResumeLayout(false);
            this.gbox_other.ResumeLayout(false);
            this.gbox_other.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_cart;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader Q;
        private System.Windows.Forms.ColumnHeader P;
        private System.Windows.Forms.Button btn_taxes;
        private System.Windows.Forms.ComboBox cbox_name;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox cbox_qty;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox cbox_discount;
        private System.Windows.Forms.Panel panel_discount;
        private System.Windows.Forms.ComboBox cbox_txtdiscount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.RadioButton rbtn_other;
        private System.Windows.Forms.GroupBox gbox_other;
        private System.Windows.Forms.RadioButton rbt_other_three;
        private System.Windows.Forms.RadioButton rbt_other_two;
        private System.Windows.Forms.RadioButton rbt_other_one;
        private System.Windows.Forms.Label lbl_taxes;
        private System.Windows.Forms.Label lbl_titleofsub;
        private System.Windows.Forms.Label lbl_titleoftotal;
        private System.Windows.Forms.PrintPreviewDialog PPD;
        private System.Drawing.Printing.PrintDocument PD;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}
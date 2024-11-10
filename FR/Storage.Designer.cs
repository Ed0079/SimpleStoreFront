namespace StoreFront.FR
{
    partial class Storage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage));
            this.dv_storage = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbox_description = new System.Windows.Forms.RichTextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.cbox_name = new System.Windows.Forms.ComboBox();
            this.cbox_qty = new System.Windows.Forms.ComboBox();
            this.cbox_price = new System.Windows.Forms.ComboBox();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_d1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv_storage)).BeginInit();
            this.panel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dv_storage
            // 
            this.dv_storage.AllowUserToAddRows = false;
            this.dv_storage.AllowUserToDeleteRows = false;
            this.dv_storage.AllowUserToResizeColumns = false;
            this.dv_storage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dv_storage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dv_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_storage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dv_storage.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dv_storage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dv_storage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dv_storage.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dv_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dv_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_storage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.Price,
            this.Qty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv_storage.DefaultCellStyle = dataGridViewCellStyle6;
            this.dv_storage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dv_storage.EnableHeadersVisualStyles = false;
            this.dv_storage.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dv_storage.Location = new System.Drawing.Point(12, 62);
            this.dv_storage.MultiSelect = false;
            this.dv_storage.Name = "dv_storage";
            this.dv_storage.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dv_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dv_storage.RowHeadersVisible = false;
            this.dv_storage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dv_storage.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dv_storage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dv_storage.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dv_storage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv_storage.RowTemplate.ReadOnly = true;
            this.dv_storage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dv_storage.ShowCellToolTips = false;
            this.dv_storage.ShowEditingIcon = false;
            this.dv_storage.ShowRowErrors = false;
            this.dv_storage.Size = new System.Drawing.Size(740, 534);
            this.dv_storage.TabIndex = 53;
            this.dv_storage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_storage_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle5;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // rtbox_description
            // 
            this.rtbox_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbox_description.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_description.Location = new System.Drawing.Point(758, 249);
            this.rtbox_description.Name = "rtbox_description";
            this.rtbox_description.ReadOnly = true;
            this.rtbox_description.Size = new System.Drawing.Size(323, 320);
            this.rtbox_description.TabIndex = 46;
            this.rtbox_description.Text = "";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(70, 111);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(195, 50);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cbox_name
            // 
            this.cbox_name.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_name.FormattingEnabled = true;
            this.cbox_name.Location = new System.Drawing.Point(10, 74);
            this.cbox_name.Name = "cbox_name";
            this.cbox_name.Size = new System.Drawing.Size(138, 31);
            this.cbox_name.TabIndex = 42;
            // 
            // cbox_qty
            // 
            this.cbox_qty.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_qty.FormattingEnabled = true;
            this.cbox_qty.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50"});
            this.cbox_qty.Location = new System.Drawing.Point(269, 74);
            this.cbox_qty.Name = "cbox_qty";
            this.cbox_qty.Size = new System.Drawing.Size(51, 31);
            this.cbox_qty.TabIndex = 43;
            // 
            // cbox_price
            // 
            this.cbox_price.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.cbox_price.FormattingEnabled = true;
            this.cbox_price.Items.AddRange(new object[] {
            "0.99",
            "4.99",
            "9.99",
            "19.99"});
            this.cbox_price.Location = new System.Drawing.Point(154, 74);
            this.cbox_price.Name = "cbox_price";
            this.cbox_price.Size = new System.Drawing.Size(109, 31);
            this.cbox_price.TabIndex = 45;
            // 
            // panel_admin
            // 
            this.panel_admin.Controls.Add(this.lbl_Id);
            this.panel_admin.Controls.Add(this.lbl_d1);
            this.panel_admin.Controls.Add(this.btn_add);
            this.panel_admin.Controls.Add(this.btn_delet);
            this.panel_admin.Controls.Add(this.cbox_price);
            this.panel_admin.Controls.Add(this.cbox_qty);
            this.panel_admin.Controls.Add(this.cbox_name);
            this.panel_admin.Controls.Add(this.btn_update);
            this.panel_admin.Location = new System.Drawing.Point(758, 36);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(326, 182);
            this.panel_admin.TabIndex = 52;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_Id.Location = new System.Drawing.Point(60, 33);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(15, 23);
            this.lbl_Id.TabIndex = 49;
            this.lbl_Id.Text = " ";
            // 
            // lbl_d1
            // 
            this.lbl_d1.AutoSize = true;
            this.lbl_d1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_d1.Location = new System.Drawing.Point(20, 33);
            this.lbl_d1.Name = "lbl_d1";
            this.lbl_d1.Size = new System.Drawing.Size(34, 23);
            this.lbl_d1.TabIndex = 48;
            this.lbl_d1.Text = "Id:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(10, 111);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 50);
            this.btn_add.TabIndex = 47;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_delet.Image = ((System.Drawing.Image)(resources.GetObject("btn_delet.Image")));
            this.btn_delet.Location = new System.Drawing.Point(269, 111);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(54, 50);
            this.btn_delet.TabIndex = 46;
            this.btn_delet.UseVisualStyleBackColor = true;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.rtbox_description);
            this.Controls.Add(this.dv_storage);
            this.Controls.Add(this.panel_admin);
            this.Name = "Storage";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_storage)).EndInit();
            this.panel_admin.ResumeLayout(false);
            this.panel_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dv_storage;
        private System.Windows.Forms.RichTextBox rtbox_description;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cbox_name;
        private System.Windows.Forms.ComboBox cbox_qty;
        private System.Windows.Forms.ComboBox cbox_price;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label lbl_d1;
        private System.Windows.Forms.Label lbl_Id;
    }
}
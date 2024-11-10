namespace StoreFront.FR.subforms
{
    partial class S2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.dv_user = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 52);
            this.panel1.TabIndex = 34;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(648, 138);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(149, 29);
            this.txt_name.TabIndex = 36;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txt_password.Location = new System.Drawing.Point(648, 180);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(149, 29);
            this.txt_password.TabIndex = 37;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(549, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(59, 49);
            this.btn_add.TabIndex = 39;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(746, 281);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(51, 49);
            this.btn_delete.TabIndex = 40;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(614, 281);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 49);
            this.btn_update.TabIndex = 41;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_2.Location = new System.Drawing.Point(545, 138);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(61, 23);
            this.lbl_2.TabIndex = 42;
            this.lbl_2.Text = "Name";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_3.Location = new System.Drawing.Point(545, 180);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(91, 23);
            this.lbl_3.TabIndex = 43;
            this.lbl_3.Text = "Password";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_4.Location = new System.Drawing.Point(545, 224);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(80, 23);
            this.lbl_4.TabIndex = 44;
            this.lbl_4.Text = "Position";
            // 
            // dv_user
            // 
            this.dv_user.AllowUserToAddRows = false;
            this.dv_user.AllowUserToDeleteRows = false;
            this.dv_user.AllowUserToResizeColumns = false;
            this.dv_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dv_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dv_user.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dv_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dv_user.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Password,
            this.Position});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv_user.DefaultCellStyle = dataGridViewCellStyle6;
            this.dv_user.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dv_user.EnableHeadersVisualStyles = false;
            this.dv_user.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dv_user.Location = new System.Drawing.Point(0, 70);
            this.dv_user.MultiSelect = false;
            this.dv_user.Name = "dv_user";
            this.dv_user.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dv_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dv_user.RowHeadersVisible = false;
            this.dv_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dv_user.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dv_user.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dv_user.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dv_user.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv_user.RowTemplate.ReadOnly = true;
            this.dv_user.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dv_user.ShowCellToolTips = false;
            this.dv_user.ShowEditingIcon = false;
            this.dv_user.ShowRowErrors = false;
            this.dv_user.Size = new System.Drawing.Size(539, 444);
            this.dv_user.TabIndex = 54;
            this.dv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_user_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.Password.DefaultCellStyle = dataGridViewCellStyle4;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            this.Position.DefaultCellStyle = dataGridViewCellStyle5;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_id.Location = new System.Drawing.Point(579, 86);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(113, 23);
            this.lbl_id.TabIndex = 56;
            this.lbl_id.Text = "PlaceHolder";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lbl_1.Location = new System.Drawing.Point(545, 86);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(28, 23);
            this.lbl_1.TabIndex = 55;
            this.lbl_1.Text = "Id";
            // 
            // txt_position
            // 
            this.txt_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_position.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txt_position.FormattingEnabled = true;
            this.txt_position.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "TeamLeader",
            "Trainer",
            "Employee"});
            this.txt_position.Location = new System.Drawing.Point(648, 224);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(149, 31);
            this.txt_position.TabIndex = 57;
            // 
            // S2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 542);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.dv_user);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel1);
            this.Name = "S2";
            this.Text = "S2";
            ((System.ComponentModel.ISupportInitialize)(this.dv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.DataGridView dv_user;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.ComboBox txt_position;
    }
}
namespace Presentation
{
    partial class FrmThietLap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbNvID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpdateLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtLoginPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtLoginUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThietLap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvLoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoginuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoginPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietLap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLoginID);
            this.panel1.Controls.Add(this.cbbNvID);
            this.panel1.Controls.Add(this.btnUpdateLogin);
            this.panel1.Controls.Add(this.btnDeleteLogin);
            this.panel1.Controls.Add(this.txtLoginPass);
            this.panel1.Controls.Add(this.btnAddLogin);
            this.panel1.Controls.Add(this.txtLoginUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 732);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtLoginID
            // 
            this.txtLoginID.BorderRadius = 20;
            this.txtLoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginID.DefaultText = "";
            this.txtLoginID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginID.Location = new System.Drawing.Point(154, 66);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.PasswordChar = '\0';
            this.txtLoginID.PlaceholderText = "";
            this.txtLoginID.SelectedText = "";
            this.txtLoginID.Size = new System.Drawing.Size(246, 53);
            this.txtLoginID.TabIndex = 7;
            // 
            // cbbNvID
            // 
            this.cbbNvID.BackColor = System.Drawing.Color.Transparent;
            this.cbbNvID.BorderRadius = 16;
            this.cbbNvID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNvID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNvID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNvID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNvID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNvID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNvID.ItemHeight = 40;
            this.cbbNvID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbNvID.Location = new System.Drawing.Point(154, 303);
            this.cbbNvID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNvID.Name = "cbbNvID";
            this.cbbNvID.Size = new System.Drawing.Size(247, 46);
            this.cbbNvID.TabIndex = 6;
            this.cbbNvID.SelectedIndexChanged += new System.EventHandler(this.cbbNvID_SelectedIndexChanged_1);
            // 
            // btnUpdateLogin
            // 
            this.btnUpdateLogin.BorderRadius = 16;
            this.btnUpdateLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnUpdateLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnUpdateLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateLogin.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateLogin.Location = new System.Drawing.Point(217, 435);
            this.btnUpdateLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateLogin.Name = "btnUpdateLogin";
            this.btnUpdateLogin.Size = new System.Drawing.Size(148, 54);
            this.btnUpdateLogin.TabIndex = 5;
            this.btnUpdateLogin.Text = "sửa thông tin";
            this.btnUpdateLogin.Click += new System.EventHandler(this.btnUpdateLogin_Click);
            // 
            // btnDeleteLogin
            // 
            this.btnDeleteLogin.BorderRadius = 16;
            this.btnDeleteLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnDeleteLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnDeleteLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteLogin.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteLogin.Location = new System.Drawing.Point(122, 507);
            this.btnDeleteLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteLogin.Name = "btnDeleteLogin";
            this.btnDeleteLogin.Size = new System.Drawing.Size(148, 54);
            this.btnDeleteLogin.TabIndex = 4;
            this.btnDeleteLogin.Text = "xóa thông tin";
            this.btnDeleteLogin.Click += new System.EventHandler(this.btnDeleteLogin_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BorderRadius = 20;
            this.txtLoginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPass.DefaultText = "";
            this.txtLoginPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPass.Location = new System.Drawing.Point(154, 222);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '\0';
            this.txtLoginPass.PlaceholderText = "";
            this.txtLoginPass.SelectedText = "";
            this.txtLoginPass.Size = new System.Drawing.Size(246, 53);
            this.txtLoginPass.TabIndex = 3;
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.BorderRadius = 16;
            this.btnAddLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnAddLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnAddLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAddLogin.Location = new System.Drawing.Point(40, 435);
            this.btnAddLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(148, 54);
            this.btnAddLogin.TabIndex = 2;
            this.btnAddLogin.Text = "lưu thông tin";
            this.btnAddLogin.Click += new System.EventHandler(this.btnAddLogin_Click);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.BorderRadius = 20;
            this.txtLoginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUser.DefaultText = "";
            this.txtLoginUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginUser.Location = new System.Drawing.Point(154, 141);
            this.txtLoginUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.PasswordChar = '\0';
            this.txtLoginUser.PlaceholderText = "";
            this.txtLoginUser.SelectedText = "";
            this.txtLoginUser.Size = new System.Drawing.Size(246, 53);
            this.txtLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã đăng nhập";
            // 
            // dgvThietLap
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThietLap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietLap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThietLap.ColumnHeadersHeight = 40;
            this.dgvThietLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThietLap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLoginID,
            this.clLoginuse,
            this.clLoginPass,
            this.clNvID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietLap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThietLap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietLap.Location = new System.Drawing.Point(471, 180);
            this.dgvThietLap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThietLap.Name = "dgvThietLap";
            this.dgvThietLap.ReadOnly = true;
            this.dgvThietLap.RowHeadersVisible = false;
            this.dgvThietLap.RowHeadersWidth = 51;
            this.dgvThietLap.RowTemplate.Height = 24;
            this.dgvThietLap.Size = new System.Drawing.Size(592, 525);
            this.dgvThietLap.TabIndex = 1;
            this.dgvThietLap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietLap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThietLap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThietLap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThietLap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThietLap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietLap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietLap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThietLap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThietLap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThietLap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThietLap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThietLap.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvThietLap.ThemeStyle.ReadOnly = true;
            this.dgvThietLap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietLap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThietLap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThietLap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThietLap.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThietLap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietLap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThietLap.Click += new System.EventHandler(this.dgvThietLap_Click);
            // 
            // dgvLoginID
            // 
            this.dgvLoginID.DataPropertyName = "idLogin";
            this.dgvLoginID.HeaderText = "mã đăng nhập";
            this.dgvLoginID.MinimumWidth = 6;
            this.dgvLoginID.Name = "dgvLoginID";
            this.dgvLoginID.ReadOnly = true;
            // 
            // clLoginuse
            // 
            this.clLoginuse.DataPropertyName = "userName";
            this.clLoginuse.HeaderText = "Tên đăng nhập";
            this.clLoginuse.MinimumWidth = 6;
            this.clLoginuse.Name = "clLoginuse";
            this.clLoginuse.ReadOnly = true;
            // 
            // clLoginPass
            // 
            this.clLoginPass.DataPropertyName = "passWords";
            this.clLoginPass.HeaderText = "mật khẩu";
            this.clLoginPass.MinimumWidth = 6;
            this.clLoginPass.Name = "clLoginPass";
            this.clLoginPass.ReadOnly = true;
            // 
            // clNvID
            // 
            this.clNvID.DataPropertyName = "Ho_ten";
            this.clNvID.HeaderText = "tên nhân viên";
            this.clNvID.MinimumWidth = 6;
            this.clNvID.Name = "clNvID";
            this.clNvID.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thông tin đăng nhập";
            // 
            // FrmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1086, 732);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvThietLap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThietLap";
            this.Text = "FrmThietLap";
            this.Load += new System.EventHandler(this.FrmThietLap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietLap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginUser;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginID;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNvID;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThietLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoginuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoginPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNvID;
    }
}
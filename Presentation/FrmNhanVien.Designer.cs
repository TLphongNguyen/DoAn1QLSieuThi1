namespace Presentation
{
    partial class FrmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEMID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbEmSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEmUppdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEmDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEmAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmploiee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvNvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNvSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbChucVu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEMID);
            this.panel1.Controls.Add(this.cbbEmSex);
            this.panel1.Controls.Add(this.btnEmUppdate);
            this.panel1.Controls.Add(this.btnEmDelete);
            this.panel1.Controls.Add(this.btnEmAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmAddress);
            this.panel1.Controls.Add(this.txtEmPhone);
            this.panel1.Controls.Add(this.txtEmName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 732);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "chức vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbbChucVu.BorderRadius = 20;
            this.cbbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbChucVu.ItemHeight = 36;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbChucVu.Location = new System.Drawing.Point(142, 157);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(206, 42);
            this.cbbChucVu.TabIndex = 14;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtEMID
            // 
            this.txtEMID.BorderRadius = 20;
            this.txtEMID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMID.DefaultText = "";
            this.txtEMID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEMID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEMID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEMID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEMID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEMID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEMID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEMID.Location = new System.Drawing.Point(142, 34);
            this.txtEMID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEMID.Name = "txtEMID";
            this.txtEMID.PasswordChar = '\0';
            this.txtEMID.PlaceholderText = "";
            this.txtEMID.SelectedText = "";
            this.txtEMID.Size = new System.Drawing.Size(205, 39);
            this.txtEMID.TabIndex = 12;
            // 
            // cbbEmSex
            // 
            this.cbbEmSex.BackColor = System.Drawing.Color.Transparent;
            this.cbbEmSex.BorderRadius = 20;
            this.cbbEmSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbEmSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmSex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbEmSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbEmSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbEmSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbEmSex.ItemHeight = 36;
            this.cbbEmSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbEmSex.Location = new System.Drawing.Point(142, 216);
            this.cbbEmSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbEmSex.Name = "cbbEmSex";
            this.cbbEmSex.Size = new System.Drawing.Size(206, 42);
            this.cbbEmSex.TabIndex = 11;
            // 
            // btnEmUppdate
            // 
            this.btnEmUppdate.BorderRadius = 10;
            this.btnEmUppdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmUppdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmUppdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmUppdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmUppdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmUppdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnEmUppdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(206)))));
            this.btnEmUppdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmUppdate.ForeColor = System.Drawing.Color.Black;
            this.btnEmUppdate.Location = new System.Drawing.Point(183, 446);
            this.btnEmUppdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmUppdate.Name = "btnEmUppdate";
            this.btnEmUppdate.Size = new System.Drawing.Size(164, 45);
            this.btnEmUppdate.TabIndex = 10;
            this.btnEmUppdate.Text = "Sửa thông tin";
            this.btnEmUppdate.Click += new System.EventHandler(this.btnEmUppdate_Click);
            // 
            // btnEmDelete
            // 
            this.btnEmDelete.BorderRadius = 10;
            this.btnEmDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnEmDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(206)))));
            this.btnEmDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmDelete.ForeColor = System.Drawing.Color.Black;
            this.btnEmDelete.Location = new System.Drawing.Point(89, 532);
            this.btnEmDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmDelete.Name = "btnEmDelete";
            this.btnEmDelete.Size = new System.Drawing.Size(164, 45);
            this.btnEmDelete.TabIndex = 9;
            this.btnEmDelete.Text = "Xóa Nhân viên";
            this.btnEmDelete.Click += new System.EventHandler(this.btnEmDelete_Click);
            // 
            // btnEmAdd
            // 
            this.btnEmAdd.BorderRadius = 10;
            this.btnEmAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnEmAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(206)))));
            this.btnEmAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmAdd.Location = new System.Drawing.Point(15, 446);
            this.btnEmAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmAdd.Name = "btnEmAdd";
            this.btnEmAdd.Size = new System.Drawing.Size(164, 45);
            this.btnEmAdd.TabIndex = 8;
            this.btnEmAdd.Text = "Lưu thông tin";
            this.btnEmAdd.Click += new System.EventHandler(this.btnEmAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // txtEmAddress
            // 
            this.txtEmAddress.BorderRadius = 20;
            this.txtEmAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmAddress.DefaultText = "";
            this.txtEmAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmAddress.Location = new System.Drawing.Point(142, 280);
            this.txtEmAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmAddress.Name = "txtEmAddress";
            this.txtEmAddress.PasswordChar = '\0';
            this.txtEmAddress.PlaceholderText = "";
            this.txtEmAddress.SelectedText = "";
            this.txtEmAddress.Size = new System.Drawing.Size(205, 39);
            this.txtEmAddress.TabIndex = 2;
            // 
            // txtEmPhone
            // 
            this.txtEmPhone.BorderRadius = 20;
            this.txtEmPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmPhone.DefaultText = "";
            this.txtEmPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmPhone.Location = new System.Drawing.Point(142, 345);
            this.txtEmPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmPhone.Name = "txtEmPhone";
            this.txtEmPhone.PasswordChar = '\0';
            this.txtEmPhone.PlaceholderText = "";
            this.txtEmPhone.SelectedText = "";
            this.txtEmPhone.Size = new System.Drawing.Size(205, 39);
            this.txtEmPhone.TabIndex = 1;
            // 
            // txtEmName
            // 
            this.txtEmName.BorderRadius = 20;
            this.txtEmName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmName.DefaultText = "";
            this.txtEmName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmName.Location = new System.Drawing.Point(142, 89);
            this.txtEmName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.PasswordChar = '\0';
            this.txtEmName.PlaceholderText = "";
            this.txtEmName.SelectedText = "";
            this.txtEmName.Size = new System.Drawing.Size(205, 39);
            this.txtEmName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quản lí nhân viên";
            // 
            // dgvEmploiee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmploiee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmploiee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmploiee.ColumnHeadersHeight = 40;
            this.dgvEmploiee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmploiee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNvID,
            this.dgvNvName,
            this.dgvNvSex,
            this.dgvNvAddress,
            this.dgvNvPhone,
            this.clTenLoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmploiee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmploiee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmploiee.Location = new System.Drawing.Point(400, 115);
            this.dgvEmploiee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmploiee.Name = "dgvEmploiee";
            this.dgvEmploiee.ReadOnly = true;
            this.dgvEmploiee.RowHeadersVisible = false;
            this.dgvEmploiee.RowHeadersWidth = 51;
            this.dgvEmploiee.RowTemplate.Height = 24;
            this.dgvEmploiee.Size = new System.Drawing.Size(663, 535);
            this.dgvEmploiee.TabIndex = 6;
            this.dgvEmploiee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmploiee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmploiee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmploiee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmploiee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmploiee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmploiee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmploiee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmploiee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmploiee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmploiee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmploiee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmploiee.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvEmploiee.ThemeStyle.ReadOnly = true;
            this.dgvEmploiee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmploiee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmploiee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmploiee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmploiee.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmploiee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmploiee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmploiee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmploiee_CellClick);
            // 
            // dgvNvID
            // 
            this.dgvNvID.DataPropertyName = "ma_nhan_vien";
            this.dgvNvID.HeaderText = "mã nhân viên";
            this.dgvNvID.MinimumWidth = 6;
            this.dgvNvID.Name = "dgvNvID";
            this.dgvNvID.ReadOnly = true;
            // 
            // dgvNvName
            // 
            this.dgvNvName.DataPropertyName = "ho_ten";
            this.dgvNvName.HeaderText = "Tên nhân viên";
            this.dgvNvName.MinimumWidth = 6;
            this.dgvNvName.Name = "dgvNvName";
            this.dgvNvName.ReadOnly = true;
            // 
            // dgvNvSex
            // 
            this.dgvNvSex.DataPropertyName = "gioi_tinh";
            this.dgvNvSex.HeaderText = "Giới tính";
            this.dgvNvSex.MinimumWidth = 6;
            this.dgvNvSex.Name = "dgvNvSex";
            this.dgvNvSex.ReadOnly = true;
            // 
            // dgvNvAddress
            // 
            this.dgvNvAddress.DataPropertyName = "dia_chi";
            this.dgvNvAddress.HeaderText = "Địa chỉ";
            this.dgvNvAddress.MinimumWidth = 6;
            this.dgvNvAddress.Name = "dgvNvAddress";
            this.dgvNvAddress.ReadOnly = true;
            // 
            // dgvNvPhone
            // 
            this.dgvNvPhone.DataPropertyName = "so_dien_thoai";
            this.dgvNvPhone.HeaderText = "Số điện thoại";
            this.dgvNvPhone.MinimumWidth = 6;
            this.dgvNvPhone.Name = "dgvNvPhone";
            this.dgvNvPhone.ReadOnly = true;
            // 
            // clTenLoai
            // 
            this.clTenLoai.DataPropertyName = "tenLoai";
            this.clTenLoai.HeaderText = "Chức vụ";
            this.clTenLoai.MinimumWidth = 6;
            this.clTenLoai.Name = "clTenLoai";
            this.clTenLoai.ReadOnly = true;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1086, 732);
            this.Controls.Add(this.dgvEmploiee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtEmPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmName;
        private Guna.UI2.WinForms.Guna2ComboBox cbbEmSex;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmUppdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmDelete;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmploiee;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtEMID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbbChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNvSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoai;
    }
}
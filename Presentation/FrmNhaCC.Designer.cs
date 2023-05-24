namespace Presentation
{
    partial class FrmNhaCC
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearchNhacc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchNhacc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhaCCName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhaCCAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhaCCPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateNhaCC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteNhaCC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddNhaCC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaCCId = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvNhaCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clNhaCCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhaCCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhaCCAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhaCCPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtNhaCCName);
            this.guna2Panel1.Controls.Add(this.txtNhaCCAddress);
            this.guna2Panel1.Controls.Add(this.txtNhaCCPhone);
            this.guna2Panel1.Controls.Add(this.btnUpdateNhaCC);
            this.guna2Panel1.Controls.Add(this.btnDeleteNhaCC);
            this.guna2Panel1.Controls.Add(this.btnAddNhaCC);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtNhaCCId);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(410, 735);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnSearchNhacc
            // 
            this.btnSearchNhacc.BorderRadius = 20;
            this.btnSearchNhacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchNhacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchNhacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchNhacc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchNhacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchNhacc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.btnSearchNhacc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnSearchNhacc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchNhacc.ForeColor = System.Drawing.Color.Black;
            this.btnSearchNhacc.Location = new System.Drawing.Point(933, 51);
            this.btnSearchNhacc.Name = "btnSearchNhacc";
            this.btnSearchNhacc.Size = new System.Drawing.Size(154, 45);
            this.btnSearchNhacc.TabIndex = 12;
            this.btnSearchNhacc.Text = "Tìm Kiếm";
            this.btnSearchNhacc.Click += new System.EventHandler(this.btnSearchNhacc_Click);
            // 
            // txtSearchNhacc
            // 
            this.txtSearchNhacc.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchNhacc.BorderRadius = 20;
            this.txtSearchNhacc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNhacc.DefaultText = "";
            this.txtSearchNhacc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNhacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNhacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNhacc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNhacc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNhacc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchNhacc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNhacc.Location = new System.Drawing.Point(445, 48);
            this.txtSearchNhacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchNhacc.Name = "txtSearchNhacc";
            this.txtSearchNhacc.PasswordChar = '\0';
            this.txtSearchNhacc.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtSearchNhacc.SelectedText = "";
            this.txtSearchNhacc.Size = new System.Drawing.Size(326, 48);
            this.txtSearchNhacc.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhà CC";
            // 
            // txtNhaCCName
            // 
            this.txtNhaCCName.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaCCName.BorderRadius = 20;
            this.txtNhaCCName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCCName.DefaultText = "";
            this.txtNhaCCName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaCCName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaCCName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaCCName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCName.Location = new System.Drawing.Point(148, 165);
            this.txtNhaCCName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaCCName.Name = "txtNhaCCName";
            this.txtNhaCCName.PasswordChar = '\0';
            this.txtNhaCCName.PlaceholderText = "";
            this.txtNhaCCName.SelectedText = "";
            this.txtNhaCCName.Size = new System.Drawing.Size(229, 48);
            this.txtNhaCCName.TabIndex = 7;
            // 
            // txtNhaCCAddress
            // 
            this.txtNhaCCAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaCCAddress.BorderRadius = 20;
            this.txtNhaCCAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCCAddress.DefaultText = "";
            this.txtNhaCCAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaCCAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaCCAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaCCAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCAddress.Location = new System.Drawing.Point(148, 237);
            this.txtNhaCCAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaCCAddress.Name = "txtNhaCCAddress";
            this.txtNhaCCAddress.PasswordChar = '\0';
            this.txtNhaCCAddress.PlaceholderText = "";
            this.txtNhaCCAddress.SelectedText = "";
            this.txtNhaCCAddress.Size = new System.Drawing.Size(229, 48);
            this.txtNhaCCAddress.TabIndex = 6;
            // 
            // txtNhaCCPhone
            // 
            this.txtNhaCCPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaCCPhone.BorderRadius = 20;
            this.txtNhaCCPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCCPhone.DefaultText = "";
            this.txtNhaCCPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaCCPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaCCPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaCCPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCPhone.Location = new System.Drawing.Point(148, 305);
            this.txtNhaCCPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaCCPhone.Name = "txtNhaCCPhone";
            this.txtNhaCCPhone.PasswordChar = '\0';
            this.txtNhaCCPhone.PlaceholderText = "";
            this.txtNhaCCPhone.SelectedText = "";
            this.txtNhaCCPhone.Size = new System.Drawing.Size(229, 48);
            this.txtNhaCCPhone.TabIndex = 5;
            // 
            // btnUpdateNhaCC
            // 
            this.btnUpdateNhaCC.BorderRadius = 20;
            this.btnUpdateNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateNhaCC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateNhaCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.btnUpdateNhaCC.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnUpdateNhaCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateNhaCC.Location = new System.Drawing.Point(223, 412);
            this.btnUpdateNhaCC.Name = "btnUpdateNhaCC";
            this.btnUpdateNhaCC.Size = new System.Drawing.Size(154, 45);
            this.btnUpdateNhaCC.TabIndex = 4;
            this.btnUpdateNhaCC.Text = "Sửa thông tin";
            this.btnUpdateNhaCC.Click += new System.EventHandler(this.btnUpdateNhaCC_Click);
            // 
            // btnDeleteNhaCC
            // 
            this.btnDeleteNhaCC.BorderRadius = 20;
            this.btnDeleteNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteNhaCC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteNhaCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.btnDeleteNhaCC.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnDeleteNhaCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteNhaCC.Location = new System.Drawing.Point(127, 496);
            this.btnDeleteNhaCC.Name = "btnDeleteNhaCC";
            this.btnDeleteNhaCC.Size = new System.Drawing.Size(154, 45);
            this.btnDeleteNhaCC.TabIndex = 3;
            this.btnDeleteNhaCC.Text = "Xóa thông tin";
            this.btnDeleteNhaCC.Click += new System.EventHandler(this.btnDeleteNhaCC_Click);
            // 
            // btnAddNhaCC
            // 
            this.btnAddNhaCC.BorderRadius = 20;
            this.btnAddNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNhaCC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNhaCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.btnAddNhaCC.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnAddNhaCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnAddNhaCC.Location = new System.Drawing.Point(16, 412);
            this.btnAddNhaCC.Name = "btnAddNhaCC";
            this.btnAddNhaCC.Size = new System.Drawing.Size(154, 45);
            this.btnAddNhaCC.TabIndex = 2;
            this.btnAddNhaCC.Text = "Lưu thông tin";
            this.btnAddNhaCC.Click += new System.EventHandler(this.btnAddNhaCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà CC";
            // 
            // txtNhaCCId
            // 
            this.txtNhaCCId.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaCCId.BorderRadius = 20;
            this.txtNhaCCId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCCId.DefaultText = "";
            this.txtNhaCCId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaCCId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaCCId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCCId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaCCId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCCId.Location = new System.Drawing.Point(148, 96);
            this.txtNhaCCId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaCCId.Name = "txtNhaCCId";
            this.txtNhaCCId.PasswordChar = '\0';
            this.txtNhaCCId.PlaceholderText = "";
            this.txtNhaCCId.SelectedText = "";
            this.txtNhaCCId.Size = new System.Drawing.Size(229, 48);
            this.txtNhaCCId.TabIndex = 0;
            // 
            // dgvNhaCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNhaCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaCC.ColumnHeadersHeight = 40;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNhaCCID,
            this.clNhaCCName,
            this.clNhaCCAddress,
            this.clNhaCCPhone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhaCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCC.Location = new System.Drawing.Point(445, 180);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.ReadOnly = true;
            this.dgvNhaCC.RowHeadersVisible = false;
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.Size = new System.Drawing.Size(670, 529);
            this.dgvNhaCC.TabIndex = 1;
            this.dgvNhaCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhaCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhaCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhaCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhaCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhaCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhaCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhaCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhaCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhaCC.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNhaCC.ThemeStyle.ReadOnly = true;
            this.dgvNhaCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhaCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhaCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhaCC.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhaCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhaCC.Click += new System.EventHandler(this.dgvNhaCC_Click);
            // 
            // clNhaCCID
            // 
            this.clNhaCCID.DataPropertyName = "ma_nha_cung_cap";
            this.clNhaCCID.HeaderText = "mã nhà cung cấp";
            this.clNhaCCID.MinimumWidth = 6;
            this.clNhaCCID.Name = "clNhaCCID";
            this.clNhaCCID.ReadOnly = true;
            // 
            // clNhaCCName
            // 
            this.clNhaCCName.DataPropertyName = "ten_nha_cung_cap";
            this.clNhaCCName.HeaderText = "tên nhà cung cấp";
            this.clNhaCCName.MinimumWidth = 6;
            this.clNhaCCName.Name = "clNhaCCName";
            this.clNhaCCName.ReadOnly = true;
            // 
            // clNhaCCAddress
            // 
            this.clNhaCCAddress.DataPropertyName = "dia_chi";
            this.clNhaCCAddress.HeaderText = "địa chỉ";
            this.clNhaCCAddress.MinimumWidth = 6;
            this.clNhaCCAddress.Name = "clNhaCCAddress";
            this.clNhaCCAddress.ReadOnly = true;
            // 
            // clNhaCCPhone
            // 
            this.clNhaCCPhone.DataPropertyName = "so_dien_thoai";
            this.clNhaCCPhone.HeaderText = "số điện thoại";
            this.clNhaCCPhone.MinimumWidth = 6;
            this.clNhaCCPhone.Name = "clNhaCCPhone";
            this.clNhaCCPhone.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin nhà cung cấp";
            // 
            // FrmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1152, 735);
            this.Controls.Add(this.btnSearchNhacc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchNhacc);
            this.Controls.Add(this.dgvNhaCC);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhaCC";
            this.Text = "FrmNhaCC";
            this.Load += new System.EventHandler(this.FrmNhaCC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNhaCC;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaCCId;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhaCC;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearchNhacc;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNhacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaCCName;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaCCAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaCCPhone;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateNhaCC;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteNhaCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCCAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCCPhone;
    }
}
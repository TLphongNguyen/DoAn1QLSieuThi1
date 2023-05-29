namespace Presentation
{
    partial class FrmProduct
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
            this.cbbCategoryID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnProductUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnProductAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductQuanty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProcductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnProductDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductQuanty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbCategoryID);
            this.panel1.Controls.Add(this.btnProductUpdate);
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductQuanty);
            this.panel1.Controls.Add(this.txtProcductPrice);
            this.panel1.Controls.Add(this.btnProductDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 901);
            this.panel1.TabIndex = 0;
            // 
            // cbbCategoryID
            // 
            this.cbbCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.cbbCategoryID.BorderRadius = 20;
            this.cbbCategoryID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCategoryID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbCategoryID.ItemHeight = 40;
            this.cbbCategoryID.Location = new System.Drawing.Point(236, 226);
            this.cbbCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategoryID.Name = "cbbCategoryID";
            this.cbbCategoryID.Size = new System.Drawing.Size(293, 46);
            this.cbbCategoryID.TabIndex = 14;
            this.cbbCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryID_SelectedIndexChanged);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BorderRadius = 20;
            this.btnProductUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnProductUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnProductUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnProductUpdate.Location = new System.Drawing.Point(299, 562);
            this.btnProductUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(229, 63);
            this.btnProductUpdate.TabIndex = 13;
            this.btnProductUpdate.Text = "Sửa sản phẩm";
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BorderRadius = 20;
            this.btnProductAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnProductAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnProductAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductAdd.ForeColor = System.Drawing.Color.Black;
            this.btnProductAdd.Location = new System.Drawing.Point(25, 562);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(229, 63);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Thêm sản phẩm";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã loại hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderRadius = 20;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(236, 135);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(293, 62);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductQuanty
            // 
            this.txtProductQuanty.BorderRadius = 20;
            this.txtProductQuanty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuanty.DefaultText = "";
            this.txtProductQuanty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductQuanty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductQuanty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuanty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuanty.FillColor = System.Drawing.Color.Silver;
            this.txtProductQuanty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuanty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductQuanty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuanty.Location = new System.Drawing.Point(237, 399);
            this.txtProductQuanty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductQuanty.Name = "txtProductQuanty";
            this.txtProductQuanty.PasswordChar = '\0';
            this.txtProductQuanty.PlaceholderText = "";
            this.txtProductQuanty.ReadOnly = true;
            this.txtProductQuanty.SelectedText = "";
            this.txtProductQuanty.Size = new System.Drawing.Size(293, 62);
            this.txtProductQuanty.TabIndex = 4;
            // 
            // txtProcductPrice
            // 
            this.txtProcductPrice.BorderRadius = 20;
            this.txtProcductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcductPrice.DefaultText = "";
            this.txtProcductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProcductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcductPrice.Location = new System.Drawing.Point(236, 308);
            this.txtProcductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcductPrice.Name = "txtProcductPrice";
            this.txtProcductPrice.PasswordChar = '\0';
            this.txtProcductPrice.PlaceholderText = "";
            this.txtProcductPrice.SelectedText = "";
            this.txtProcductPrice.Size = new System.Drawing.Size(293, 62);
            this.txtProcductPrice.TabIndex = 3;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BorderRadius = 20;
            this.btnProductDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnProductDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductDelete.ForeColor = System.Drawing.Color.Black;
            this.btnProductDelete.Location = new System.Drawing.Point(153, 668);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(229, 63);
            this.btnProductDelete.TabIndex = 2;
            this.btnProductDelete.Text = "Xóa sản phẩm";
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtProductID
            // 
            this.txtProductID.BorderRadius = 20;
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.DefaultText = "";
            this.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Location = new System.Drawing.Point(237, 50);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PlaceholderText = "";
            this.txtProductID.SelectedText = "";
            this.txtProductID.Size = new System.Drawing.Size(293, 62);
            this.txtProductID.TabIndex = 0;
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 40;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProductID,
            this.clProductName,
            this.clcategoryID,
            this.ClProductPrice,
            this.clProductQuanty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(583, 226);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(751, 624);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProduct.ThemeStyle.ReadOnly = false;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            // 
            // clProductID
            // 
            this.clProductID.DataPropertyName = "MaSanPham";
            this.clProductID.HeaderText = "mã sản phẩm";
            this.clProductID.MinimumWidth = 6;
            this.clProductID.Name = "clProductID";
            // 
            // clProductName
            // 
            this.clProductName.DataPropertyName = "TenSanPham";
            this.clProductName.HeaderText = "tên sản phẩm";
            this.clProductName.MinimumWidth = 6;
            this.clProductName.Name = "clProductName";
            // 
            // clcategoryID
            // 
            this.clcategoryID.DataPropertyName = "TenLoaiHang";
            this.clcategoryID.HeaderText = "tên loại hàng";
            this.clcategoryID.MinimumWidth = 6;
            this.clcategoryID.Name = "clcategoryID";
            // 
            // ClProductPrice
            // 
            this.ClProductPrice.DataPropertyName = "GiaBan";
            this.ClProductPrice.HeaderText = "giá tiền";
            this.ClProductPrice.MinimumWidth = 6;
            this.ClProductPrice.Name = "ClProductPrice";
            // 
            // clProductQuanty
            // 
            this.clProductQuanty.DataPropertyName = "SoLuong";
            this.clProductQuanty.HeaderText = "số lượng";
            this.clProductQuanty.MinimumWidth = 6;
            this.clProductQuanty.Name = "clProductQuanty";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.BorderRadius = 20;
            this.txtProductSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSearch.DefaultText = "";
            this.txtProductSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.Location = new System.Drawing.Point(613, 94);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.PasswordChar = '\0';
            this.txtProductSearch.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtProductSearch.SelectedText = "";
            this.txtProductSearch.Size = new System.Drawing.Size(311, 63);
            this.txtProductSearch.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm sản phẩm";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BorderRadius = 20;
            this.btnProductSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(203)))), ((int)(((byte)(230)))));
            this.btnProductSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.btnProductSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductSearch.ForeColor = System.Drawing.Color.Black;
            this.btnProductSearch.Image = global::Presentation.Properties.Resources._2303114_explore_lense_magnifier_search_searching_icon;
            this.btnProductSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProductSearch.Location = new System.Drawing.Point(1028, 94);
            this.btnProductSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(272, 60);
            this.btnProductSearch.TabIndex = 14;
            this.btnProductSearch.Text = "Tìm kiếm";
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 901);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductDelete;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtProductQuanty;
        private Guna.UI2.WinForms.Guna2TextBox txtProcductPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtProductSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCategoryID;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductQuanty;
    }
}
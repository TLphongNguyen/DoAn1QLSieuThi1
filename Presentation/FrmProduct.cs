using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmProduct : Form
    {
        IProductBUL Prd = new ProductBUL();
        ICategoryBUL Ctg = new CategoryBUL();
        public FrmProduct()
        {
            InitializeComponent();
        }
        public void LoadCategory()
        {
            IList<ETTCategory> list = Ctg.getAll();
            cbbCategoryID.ValueMember = "ma_loai_hang";
            cbbCategoryID.DisplayMember = "ten_loai_hang";
            cbbCategoryID.DataSource = list;
        }
        public void LoadData()
        {
            dgvProduct.DataSource = Prd.getAllJoin();
            txtProductName.Focus();
        }
        private void ResetForm()
        {
            txtProductID.Text = "Mã sản phẩm tự động tăng!";
            txtProductName.Text = "";
            cbbCategoryID.Text = "";
            txtProcductPrice.Text = "";
            txtProductQuanty.Text = "";

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || cbbCategoryID.Text == "" || txtProcductPrice.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = Prd.Insert(new ETTProduct(txtProductName.Text, (int)cbbCategoryID.SelectedValue, float.Parse(txtProcductPrice.Text), 0));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnProductAdd.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            ETTProduct Pr = new ETTProduct();
            Pr.MSP = int.Parse(txtProductID.Text);
            Pr.TSP = txtProductName.Text;
            Pr.MLH = (int)cbbCategoryID.SelectedValue;
            Pr.GT = int.Parse(txtProcductPrice.Text);
            Pr.SL = int.Parse(txtProductQuanty.Text);

            try
            {
                int val = Prd.Update(Pr);
                LoadData();
                if (val == -1)
                    MessageBox.Show("Sửa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã sửa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
            LoadCategory();
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Text = dgvProduct[0, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtProductName.Text = dgvProduct[1, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            cbbCategoryID.Text = dgvProduct[2, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtProcductPrice.Text = dgvProduct[3, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtProductQuanty.Text = dgvProduct[4, dgvProduct.CurrentCell.RowIndex].Value.ToString();

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Prd.Delete(int.Parse(txtProductID.Text));
                LoadData();
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {

            ETTProduct ETTC = new ETTProduct();
            ETTC.TSP = txtProductSearch.Text;
            dgvProduct.DataSource = Prd.SearchLinq(ETTC);
        }

        private void cbbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadProd(int.Parse(cbbCategoryID.ToString()));
        }
    }
}

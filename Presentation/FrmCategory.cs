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
    public partial class FrmCategory : Form
    {
        ICategoryBUL CTG  = new CategoryBUL();
        public FrmCategory()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvCategory.DataSource = CTG.getAll();
            txtNameCategory.Focus();
        }

        private void btbAddCategory_Click(object sender, EventArgs e)
        {
            if (txtNameCategory.Text == "" )
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = CTG.Insert(new ETTCategory(txtNameCategory.Text));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btbAddCategory.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }
        private void ResetForm()
        {
            txtIDCategory.Text = "Mã lớp tự động tăng!";
            txtNameCategory.Text = "";
            txtSearchID.Text = "";
            
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            ETTCategory ECTG = new ETTCategory();
            ECTG.Ma_loai_hang = int.Parse(txtIDCategory.Text);
            ECTG.Ten_loai_hang = txtNameCategory.Text;
            
            try
            {
                int val = CTG.Update(ECTG);
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

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            txtIDCategory.Text = dgvCategory[0, dgvCategory.CurrentCell.RowIndex].Value.ToString();
            txtNameCategory.Text = dgvCategory[1, dgvCategory.CurrentCell.RowIndex].Value.ToString();
            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int val = CTG.Delete(int.Parse(txtIDCategory.Text));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ETTCategory ETTC = new ETTCategory();
            ETTC.Ten_loai_hang = txtSearchID.Text;
            dgvCategory.DataSource = CTG.SearchLinq(ETTC);
        }
    }
}

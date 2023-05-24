using BusinessLogicLayer;
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
    public partial class FrmNhaCC : Form
    {
        NhaCCBUL NCC = new NhaCCBUL();
        public FrmNhaCC()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvNhaCC.DataSource = NCC.getAll();
            txtNhaCCName.Focus();
        }
        private void ResetForm()
        {
            txtNhaCCId.Text = "Mã tự động tăng!";
            txtNhaCCName.Text = "";
            txtNhaCCAddress.Text = "";
            txtNhaCCPhone.Text = "";
        }
        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void btnAddNhaCC_Click(object sender, EventArgs e)
        {
            if (txtNhaCCName.Text == "" || txtNhaCCAddress.Text == "" || txtNhaCCPhone.Text == "" )
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = NCC.Insert(new ETTNhaCC(txtNhaCCName.Text, txtNhaCCAddress.Text, txtNhaCCPhone.Text));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAddNhaCC.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateNhaCC_Click(object sender, EventArgs e)
        {
            ETTNhaCC ENCC = new ETTNhaCC();
            ENCC.Ma_nha_cung_cap = int.Parse(txtNhaCCId.Text);
            ENCC.Ten_nha_cung_cap = txtNhaCCName.Text;
            ENCC.Dia_chi = txtNhaCCAddress.Text;
            ENCC.So_dien_thoai = txtNhaCCPhone.Text;
            try
            {
                int val = NCC.Update(ENCC);
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

        private void dgvNhaCC_Click(object sender, EventArgs e)
        {
            txtNhaCCId.Text = dgvNhaCC[0, dgvNhaCC.CurrentCell.RowIndex].Value.ToString();
            txtNhaCCName.Text = dgvNhaCC[1, dgvNhaCC.CurrentCell.RowIndex].Value.ToString();
            txtNhaCCAddress.Text = dgvNhaCC[2, dgvNhaCC.CurrentCell.RowIndex].Value.ToString();
            txtNhaCCPhone.Text = dgvNhaCC[3, dgvNhaCC.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnDeleteNhaCC_Click(object sender, EventArgs e)
        {
            try
            {
                int val = NCC.Delete(int.Parse(txtNhaCCId.Text));
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

        private void btnSearchNhacc_Click(object sender, EventArgs e)
        {
            ETTNhaCC ENCC = new ETTNhaCC();
            //ETTC.Ma_loai_hang = int.Parse(txtSearchID.Text);
            ENCC.Ten_nha_cung_cap = txtSearchNhacc.Text;
            ENCC.Dia_chi = txtSearchNhacc.Text;
            ENCC.So_dien_thoai = txtSearchNhacc.Text;
            //dgvClass.DataSource = cls.Search(cl);
            dgvNhaCC.DataSource = NCC.SearchLinq(ENCC);
        }
    }
}

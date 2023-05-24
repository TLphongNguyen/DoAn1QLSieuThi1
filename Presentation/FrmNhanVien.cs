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
    public partial class FrmNhanVien : Form
    {
        INhanVienBUL nhanVienBUL = new NhanVienBUL();
        ILoaiNhanVienBUL lnv = new LoaiNhanVienBUL();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvEmploiee.AutoGenerateColumns = false;
            dgvEmploiee.DataSource = nhanVienBUL.getAll();
            txtEmName.Focus();
            dgvEmploiee.DataSource = nhanVienBUL.tl_nv();

        }
        public void LoadNhanVien()
        {
            IList<ETTLoaiNhanVien> list = lnv.getAll();
            cbbChucVu.DataSource = lnv.getAll();
            cbbChucVu.ValueMember = "MaLoai";
            cbbChucVu.DisplayMember = "TenLoai";
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
            LoadNhanVien();
        }
        private void ResetForm()
        {
            txtEMID.Text = "Mã lớp tự động tăng!";
            txtEmName.Text = "";
            cbbEmSex.Text = "";
            txtEmAddress.Text = "";
            txtEmPhone.Text = "";
            cbbChucVu.Text = "";
        }

        private void btnEmAdd_Click(object sender, EventArgs e)
        {
            if (txtEmName.Text == "" || cbbEmSex.Text == "" || cbbEmSex.Text == ""|| txtEmAddress.Text =="" || txtEmPhone.Text == ""||cbbChucVu.Text=="")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = nhanVienBUL.Insert(new ETTNhanVien(txtEmName.Text, cbbEmSex.Text, txtEmAddress.Text, txtEmPhone.Text, (int)cbbChucVu.SelectedValue));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEmAdd.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEmUppdate_Click(object sender, EventArgs e)
        {

            ETTNhanVien NV = new ETTNhanVien();
            NV.Ma_nhan_vien = int.Parse(txtEMID.Text);
            NV.Ho_ten = txtEmName.Text;
            NV.Gioi_tinh = cbbEmSex.Text;
            NV.Dia_chi = txtEmAddress.Text;
            NV.So_dien_thoai = txtEmPhone.Text;
            NV.Maloai = (int)cbbChucVu.SelectedValue;
            try
            {
                int val = nhanVienBUL.Update(NV);
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

        private void dgvEmploiee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEMID.Text = dgvEmploiee[0, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();
            txtEmName.Text = dgvEmploiee[1, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();
            cbbEmSex.Text = dgvEmploiee[2, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();
            txtEmAddress.Text = dgvEmploiee[3, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();
            txtEmPhone.Text = dgvEmploiee[4, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();
            cbbChucVu.Text = dgvEmploiee[5, dgvEmploiee.CurrentCell.RowIndex].Value.ToString();


        }

        private void btnEmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = nhanVienBUL.Delete(int.Parse(txtEMID.Text));
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

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadNhanVien(int.Parse(cbbChucVu.SelectedValue.ToString()));
        }
    }
}

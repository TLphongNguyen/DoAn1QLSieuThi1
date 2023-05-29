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
    public partial class FrmImportProduct : Form
    {
        INhaCCBUL bllncc = new NhaCCBUL();
        IPhieuNhapBUL bllpn = new PhieuNhapBUL();
        ICTPNBUL bllctpn = new CTPNBUL();
        IProductBUL bllpdt = new ProductBUL();
        public FrmImportProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            dgvncc.AutoGenerateColumns = false;
            dgvncc.DataSource = bllncc.getAll();
            dgvSanpham.AutoGenerateColumns = false;
            dgvSanpham.DataSource = bllpdt.getAll();
        }

        private void ResetForm()
        {
            txtmasp.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
        }

        private void FrmImportProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = dgvncc[0, dgvncc.CurrentCell.RowIndex].Value.ToString();
            txttencc.Text = dgvncc[1, dgvncc.CurrentCell.RowIndex].Value.ToString();
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvSanpham[0, dgvSanpham.CurrentCell.RowIndex].Value.ToString();
            txttensp.Text = dgvSanpham[1, dgvSanpham.CurrentCell.RowIndex].Value.ToString();
        }

        private void tinhTien()
        {
            float sum = 0;

            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    string value = row.Cells[5].Value.ToString();
                    float number;
                    if (float.TryParse(value, out number))
                    {
                        sum += number;
                    }
                }
            }
            lblTongtien.Text = sum.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dgvphieunhap.Rows.Add(row);
            int rowIndex = dgvphieunhap.Rows.Count - 1;
            dgvphieunhap.Rows[rowIndex].Cells[0].Value = txtmasp.Text;
            dgvphieunhap.Rows[rowIndex].Cells[1].Value = txttensp.Text;
            dgvphieunhap.Rows[rowIndex].Cells[2].Value = txtmancc.Text;
            dgvphieunhap.Rows[rowIndex].Cells[3].Value = txtdongia.Text;
            dgvphieunhap.Rows[rowIndex].Cells[4].Value = txtsoluong.Text;
            float tongtien = float.Parse(txtsoluong.Text) * float.Parse(txtdongia.Text);
            dgvphieunhap.Rows[rowIndex].Cells[5].Value = tongtien.ToString();
            tinhTien();
            ResetForm();
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvphieunhap[0, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txttensp.Text = dgvphieunhap[1, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtmancc.Text = dgvphieunhap[2, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtdongia.Text = dgvphieunhap[3, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtsoluong.Text = dgvphieunhap[4, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                string code = row.Cells[0].Value?.ToString();
                if (code == txtmasp.Text)
                {
                    dgvphieunhap.Rows.Remove(row);
                }
            }
            ResetForm();
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtmancc.Text = "";
            txttencc.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                string code = row.Cells[0].Value?.ToString();
                if (code == txtmasp.Text)
                {
                    row.Cells[1].Value = txttensp.Text;
                    row.Cells[2].Value = txtmancc.Text;
                    row.Cells[3].Value = txtdongia.Text;
                    row.Cells[4].Value = txtsoluong.Text;
                    float tongtien = float.Parse(txtsoluong.Text) * float.Parse(txtdongia.Text);
                    row.Cells[5].Value = tongtien.ToString();
                    tinhTien();
                    ResetForm();
                }
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (dgvphieunhap.Rows.Count > 0)
            {
                try
                {
                    int val = bllpn.Insert(new ETTPhieuNhap(today,int.Parse(txtmancc.Text)));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int mapn = (int)bllpn.GetLastPN().MaPhieuNhap;
                foreach(DataGridViewRow row in dgvphieunhap.Rows)
                {
                    int val = bllctpn.Insert(new ETTCTPN(mapn, int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[4].Value.ToString()), float.Parse(row.Cells[3].Value.ToString())));
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm để nhập!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtmancc.Text = "";
            txttencc.Text = "";
            dgvphieunhap.Rows.Clear();
            lblTongtien.Text = "0 VND";
        }
    }
}

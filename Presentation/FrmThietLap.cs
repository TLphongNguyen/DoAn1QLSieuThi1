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
    public partial class FrmThietLap : Form
    {
        INhanVienBUL ctg = new NhanVienBUL();
        IThietLapBUL TLBUL = new ThietLapBUL();
        public FrmThietLap()
        {
            InitializeComponent();
        }
        public void LoadNhanVien()
        {
            IList<ETTNhanVien> list = ctg.getAll();
            cbbNvID.DataSource = ctg.getAll();
            cbbNvID.ValueMember = "ma_nhan_vien";
            cbbNvID.DisplayMember = "ho_ten";
        }
        public void LoadThietLap(int Ma_nhan_vien)
        {
            //dgvThietLap.DataSource = TLBUL.getAll(Ma_nhan_vien);

        }
        public void LoadData()
        {
            dgvThietLap.AutoGenerateColumns = false;
            dgvThietLap.DataSource = TLBUL.tl_nv();
            txtLoginUser.Focus();
        }
        private void ResetForm()
        {
            txtLoginID.Text = "Mã đăng nhập tự động tăng!";
            txtLoginUser.Text = "";
            txtLoginPass.Text = "";
            cbbNvID.Text = "";
            
        }
        private void btnAddLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "" || txtLoginPass.Text == "" || cbbNvID.Text == "" )
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = TLBUL.Insert(new ETTThietLap(/*int.Parse(txtLoginID.Text),*/txtLoginUser.Text, txtLoginPass.Text,(int)cbbNvID.SelectedValue));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAddLogin.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmThietLap_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
            LoadNhanVien();
        }

        private void btnUpdateLogin_Click(object sender, EventArgs e)
        {
            ETTThietLap TL = new ETTThietLap();
            TL.idLogin = int.Parse(txtLoginID.Text);
            TL.userName = txtLoginUser.Text;
            TL.passWords = txtLoginPass.Text;
            TL.Ma_nhan_vien = (int)cbbNvID.SelectedValue;
            try
            {
                int val = TLBUL.Update(TL);
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

        private void dgvThietLap_Click(object sender, EventArgs e)
        {
            txtLoginID.Text = dgvThietLap[0, dgvThietLap.CurrentCell.RowIndex].Value.ToString();
            txtLoginUser.Text = dgvThietLap[1, dgvThietLap.CurrentCell.RowIndex].Value.ToString();
            txtLoginPass.Text = dgvThietLap[2, dgvThietLap.CurrentCell.RowIndex].Value.ToString();
            cbbNvID.Text = dgvThietLap[3, dgvThietLap.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnDeleteLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int val = TLBUL.Delete(int.Parse(txtLoginID.Text));
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

        private void cbbNvID_SelectedIndexChanged(object sender, EventArgs e)
        {
                

        }

        private void cbbNvID_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

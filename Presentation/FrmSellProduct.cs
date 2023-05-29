using BusinessLogicLayer.Interface;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System.Drawing.Drawing2D;
using System.IO;


namespace Presentation
{
    public partial class FrmSellProduct : Form
    {
        public FrmSellProduct()
        {
            InitializeComponent();
        }
        IProductBUL product = new ProductBUL();
        IChiTietHoaDonBUL chitiethd = new ChiTietHoaDonBUL();
        IHoaDonBUL hoadon = new HoaDonBUL();
        ICategoryBUL ctg = new CategoryBUL();
        public void InsertChiTietHoaDon()
        {
            foreach (DataGridViewRow row in dgvSell.Rows)
            {
                //kh.SearchLinq(value)[0].Hoten;
                //string nameProduct = row.Cells[1].Value.ToString();
                int soluong = int.Parse(row.Cells[3].Value.ToString());
                int MaSanPham = int.Parse(row.Cells[0].Value.ToString());
                //int MaSanPham = product.getAll().Where(t => t.TSP == nameProduct)
                //         .Select(t => t.MSP)
                //         .FirstOrDefault();
                decimal GiaBan = decimal.Parse(row.Cells[4].Value.ToString());
                int mahoadon = (int)hoadon.getAll().OrderByDescending(hd => hd.Ma_hoa_don).FirstOrDefault()?.Ma_hoa_don;
                chitiethd.Insert(new ETTChiTietHoaDon(mahoadon, MaSanPham, soluong, GiaBan));
                MessageBox.Show(MaSanPham.ToString());

            }
        }
        public void LoadData()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = product.getAllJoin();
            
        }
        public void CleardgvHoaDon()
        {
            dgvSell.Rows.Clear();
        }
        public void ResetDgv()
        {
            dgvSell.Rows.Clear();
            dgvSell.DataSource = null;
            lbPrice.Text = "0";
        }
        public void setCTHD()
        {
            int mahd = (int)hoadon.lastHD()[0].Ma_hoa_don;
            foreach (DataGridViewRow x in dgvSell.Rows)
            {
                try
                {
                    int val = chitiethd.Insert(new ETTChiTietHoaDon(mahd, (int)x.Cells[0].Value, (int)x.Cells[3].Value, (decimal)x.Cells[2].Value));
                    if (val == -1)
                    {
                        MessageBox.Show("Không thể thêm CTHD, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            int valsp = product.UpdateSL(new ETTProduct((int)x.Cells[0].Value, (int)x.Cells[1].Value * -1));
                        }
                        catch
                        {
                            MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL654321!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL123456!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmSellProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = product.getAll();
            btnPay.Enabled = false;
            btnDestroy.Enabled = false;
            lbPrice.Text = "0 VND";
            LoadData();
            ResetDgv();


        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedRowIndex = e.RowIndex;
            // Lấy dữ liệu của hàng được chọn
            DataGridViewRow selectedRow = dgvProducts.Rows[selectedRowIndex];

            // Tạo một hàng mới
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvSell, new object[dgvSell.ColumnCount]);
            // Gán kiểu dữ liệu cho từng ô dữ liệu của hàng mới
            for (int i = 0; i < dgvProducts.ColumnCount; i++)
            {
                newRow.Cells[i].ValueType = dgvSell.Columns[i].ValueType;
            }
            newRow.Cells[0].Value = selectedRow.Cells[0].Value;
            newRow.Cells[1].Value = selectedRow.Cells[1].Value;
            newRow.Cells[2].Value = selectedRow.Cells[4].Value;
            newRow.Cells[4].Value = selectedRow.Cells[4].Value;
            DataGridViewButtonCell quantityCell = new DataGridViewButtonCell();
            quantityCell.Value = "+";
            DataGridViewButtonCell quantityCell2 = new DataGridViewButtonCell();
            quantityCell2.Value = "-";
            newRow.Cells[6] = quantityCell;
            newRow.Cells[5] = quantityCell2;
            newRow.Cells[3].Value = 1;
            Boolean check = true;
            foreach (DataGridViewRow x in dgvSell.Rows)
            {
                if (x.Cells[0].Value.ToString() == selectedRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Sản phẩm đã có trong hóa đơn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                

            }
            if (dgvSell.Rows.Count == 0 || check)
            {
                dgvSell.Rows.Add(newRow);
            }
        }
        private void AddRowIfNotExist(DataGridView dataGridView, DataGridViewRow newRow)
        {
            if (!IsRowExist(dataGridView, newRow))
            {
                dataGridView.Rows.Add(newRow);

            }
        }
        public void CheckSateBtn()
        {
            if (dgvSell.RowCount > 0)
            {
                btnPay.Enabled = true;
                btnDestroy.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
                btnDestroy.Enabled = false;
            }
        }
        public void CaculatorPrice()
        {
            float sumPrice = 0;
            foreach (DataGridViewRow row in dgvSell.Rows)
            {
                string soluong = row.Cells["clSoLuong"].Value?.ToString();
                string gia = row.Cells["clPrice"].Value?.ToString();
                sumPrice += float.Parse(soluong) * float.Parse(gia);
            }
            lbPrice.Text = sumPrice.ToString("#,##0 VND");
            Function.tonghoadon = sumPrice;
        }
        private bool IsRowExist(DataGridView dataGridView, DataGridViewRow newRow)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool isExist = true;

                for (int i = 0; i < 2; i++)
                {
                    // So sánh giá trị của ô trong hai dòng
                    if (row.Cells[i].Value != null && !row.Cells[i].Value.Equals(newRow.Cells[i].Value))
                    {
                        isExist = false;
                        break;
                    }
                }
                if (isExist)
                {
                    // Dòng đã tồn tại trong DataGridView
                    return true;
                }
            }
            // Dòng chưa tồn tại trong DataGridView
            return false;
        }

        private void dgvSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int SL = 0;
            foreach (DataGridViewRow x in dgvProducts.Rows)
            {
                if (dgvSell.Rows[e.RowIndex].Cells["clPrdID"].Value.ToString() == x.Cells[0].Value.ToString())
                {
                    SL = int.Parse(x.Cells[3].Value.ToString());
                }
            }
            if (e.ColumnIndex == dgvSell.Columns["clTang"].Index)
            {
                // Nút tăng số lượng được nhấp vào
                int currentQuantity = Convert.ToInt32(dgvSell.Rows[e.RowIndex].Cells["clSoLuong"].Value);
                int newQuantity = currentQuantity + 1;
                //dgvSell.Rows[e.RowIndex].Cells["clSoLuong"].Value = newQuantity;
                //dgvSell.Rows[e.RowIndex].Cells["clSum"].Value = Convert.ToDecimal(dgvSell.Rows[e.RowIndex].Cells["clPrice"].Value) * newQuantity;
                if (newQuantity <= SL)
                {
                    dgvSell.Rows[e.RowIndex].Cells["clSoLuong"].Value = newQuantity;
                    dgvSell.Rows[e.RowIndex].Cells["clSum"].Value = Convert.ToDecimal(dgvSell.Rows[e.RowIndex].Cells["clPrice"].Value) * newQuantity;
                }
                else
                {
                    MessageBox.Show("Đã hết sản phẩm!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if (e.ColumnIndex == dgvSell.Columns["clGiam"].Index)
            {
                // Nút giảm số lượng được nhấp vào
                int currentQuantity = Convert.ToInt32(dgvSell.Rows[e.RowIndex].Cells["clSoLuong"].Value);
                int newQuantity = currentQuantity - 1;
                if (newQuantity > 0)
                {
                    dgvSell.Rows[e.RowIndex].Cells["clSoLuong"].Value = newQuantity;
                    dgvSell.Rows[e.RowIndex].Cells["clSum"].Value = Convert.ToDecimal(dgvSell.Rows[e.RowIndex].Cells["clPrice"].Value) * newQuantity;

                }
                else
                {
                    dgvSell.Rows.RemoveAt(e.RowIndex);
                }
            }
            CaculatorPrice();

        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            dgvSell.Rows.Clear();
            dgvSell.DataSource = null;
            lbPrice.Text = "0";
        }
        public void CheckSaleBtn()
        {
            if (dgvSell.RowCount > 0)
            {
                btnPay.Enabled = true;
                btnDestroy.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
                btnDestroy.Enabled = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgvSell.Rows)
            {
                Function.tongTien += float.Parse(x.Cells["clSum"].Value.ToString());
            }
            if (dgvSell.Rows.Count != 0)
            {

                FrmHoaDon hd = new FrmHoaDon(this);
                hd.Show();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm trong hóa đơn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //MessageBox.Show("" + Function.tongTien);


        }
        

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            ETTProduct ETTC = new ETTProduct();
            ETTC.TSP = txtSellSearch.Text;
            dgvProducts.DataSource = product.SearchLinq(ETTC);

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //dgvProducts.AutoGenerateColumns = false;
            //dgvProducts.DataSource = product.getAll();
            FrmSellProduct_Load(sender, e);


        }

        private void dgvSell_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvSell.Rows.Count > 0)
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }
        }
    }
}

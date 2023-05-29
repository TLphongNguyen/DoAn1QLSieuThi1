using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using Entities;

namespace Presentation
{
    public partial class FrmHoaDon : Form
    {
        IHoaDonBUL bll = new HoaDonBUL();
        IChiTietHoaDonBUL chitiet = new ChiTietHoaDonBUL();

        FrmSellProduct FrmSellProduct;
        public FrmHoaDon(FrmSellProduct FrmSellProduct1)
        {
            InitializeComponent();
            FrmSellProduct = FrmSellProduct1;
        }
        public void LoadDaTa()
        {
            lblTongHoaDon.Text = Tools.VND(int.Parse(Function.tongTien.ToString()));
            if (txtTienkhachtra.Text != "")
            {
                lbTienThua.Text = (float.Parse(txtTienkhachtra.Text) - Function.tongTien).ToString();
            }
            else
            {
                lbTienThua.Text = Tools.VND(0);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Today;
            float tongtien =Function.tongTien;
            int manv = Function.BgetClass_ID;
            string namenv = Function.username;

            bll.Insert(new ETTHoaDon(today, manv));
            List<ETTHoaDon> danhSachSapXep = bll.getAll().OrderByDescending(hd => hd.Ma_hoa_don).ToList();
            // Lấy mã hóa đơn mới nhất
            int maHoaDonMoiNhat = danhSachSapXep.First().Ma_hoa_don;
            FrmSellProduct.InsertChiTietHoaDon();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    chitiet.KetXuatWord(txtName.Text, maHoaDonMoiNhat, tongtien,namenv, @"Template\Chitiethoadon_Template.docx", saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                    

                }

            }
            FrmSellProduct.ResetDgv();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            lblTongHoaDon.Text = Function.tongTien.ToString("#,##0 VND");
            btnPay.Enabled = false;
        }

        private void txtTienkhachtra_TextChanged(object sender, EventArgs e)
        {
            if (txtTienkhachtra.Text != "" && Function.tongTien <= float.Parse(txtTienkhachtra.Text))
            {
                btnPay.Enabled = true;
                float priceBack = float.Parse(txtTienkhachtra.Text) - Function.tongTien;
                lbTienThua.Text = priceBack.ToString("#,##0 VND");
            }
            else
            {
                btnPay.Enabled = false;
                lbTienThua.Text = "";
            }
        }
    }
}

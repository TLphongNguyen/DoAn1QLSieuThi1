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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation
{
    public partial class FrmThongKe : Form
    {
        IThongKeBUL tk = new ThongKeBUL();
        public FrmThongKe()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            
            
        }
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            int[] data = { 10, 20, 30, 40, 50 };

            // Đổ dữ liệu từ mảng vào chuỗi
            for (int i = 0; i < data.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i + 1, data[i]);
            }

            // Đặt loại biểu đồ là Column
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;


            lbProduct.Text = tk.Tongsp().ToString();
            lbDoanhThu.Text = tk.TongLh().ToString();
            lbNhanVien.Text = tk.Tongkhdk().ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

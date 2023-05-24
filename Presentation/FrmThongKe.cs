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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            chartThongKe.Series["january"].Points.AddXY("1", 1000);
            chartThongKe.Series["january"].Points.AddXY("2", 500);
            chartThongKe.Series["january"].Points.AddXY("3", 700);
            chartThongKe.Series["january"].Points.AddXY("4", 1000);
            chartThongKe.Series["january"].Points.AddXY("5", 700);
            chartThongKe.Series["january"].Points.AddXY("6", 1000);
        }
    }
}

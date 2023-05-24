using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;

namespace Presentation
{
    public partial class Main : Form
    {
        INhanVienBUL BLL = new NhanVienBUL();
        public Main()
        {
            InitializeComponent();
        }
        private Form currentformchild;
        private void OpenchildForm(Form childForm)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmThongKe());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmCategory());
        }

        private void btnEmploiee_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmNhanVien());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmThietLap());
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmNhaCC());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenchildForm(new FrmThongKe());
            LbTime.Text = DateTime.Now.ToString();
            var item = BLL.getAll();
            //Console.WriteLine(bnv);
            
                //lbName.Text = (string)item.GetType().GetProperty("Ho_ten").GetValue(item, null);
                
                




        }
    }
}

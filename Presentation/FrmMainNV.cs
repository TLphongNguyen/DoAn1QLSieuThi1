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
    public partial class FrmMainNV : Form
    {
        public FrmMainNV()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmProduct());
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
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmSellProduct());
        }
    }
}

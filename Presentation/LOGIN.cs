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
using BusinessLogicLayer;
using Entities;
using BusinessLogicLayer.Interface;

namespace Presentation
{
    public partial class LOGIN : Form
    {
        //User taikhoan = new User();
        //TaiKhoanBLL tkDLL = new TaiKhoanBLL();
        IThietLapBUL bul = new ThietLapBUL();
        INhanVienBUL nv = new NhanVienBUL();
        //ILoaiNhanVienBUL lnv = new LoaiNhanVienBUL();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Trim() != "" && txtPassWord.Text.Trim() != "")
            {
                // Kiểm tra mật khẩu
                bool isAccountExist = bul.checkTaiKhoan_IsExist(txtUsername.Text, txtPassWord.Text);
                if (isAccountExist)
                {
                    int manvLogin = bul.TaiKhoanLogin(txtUsername.Text, txtPassWord.Text).Ma_nhan_vien;
                    int lnvLogin = nv.getMaLoai(manvLogin).Maloai;
                    ETTNhanVien mlnvLogin = nv.getMaLoai(lnvLogin);
                    ETTNhanVien nvLogin = bul.GetNhanVien(manvLogin);
                    //MessageBox.Show(lnvLogin.ToString());
                    
                    Function.BgetClass_ID = manvLogin;
                    Function.username = nvLogin.Ho_ten;
                    Function.MaLoainv = lnvLogin;
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
        }

        private void txtPassWord_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassWord.UseSystemPasswordChar)
            {
                txtPassWord.UseSystemPasswordChar = false;
                txtPassWord.IconRight = (Image)Properties.Resources.close_eye_slash_icon;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
                txtPassWord.IconRight = (Image)Properties.Resources.open_eye_view_icon;
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

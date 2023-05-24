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
        public LOGIN()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //taikhoan.userName = txtUsername.Text;
            //taikhoan.passWords = txtPassWord.Text;
            //string getuser = tkDLL.CheckLogin(taikhoan);
            //switch (getuser)
            //{
            //    case "requeid_TaiKhoan":
            //        MessageBox.Show("không được để trống tài khoản");
            //        return;
            //    case "requeid_PassWord":
            //        MessageBox.Show("không được để trống mật khẩu");
            //        return;
            //    case "tài khoản hoặc mật khẩu không chính xác":
            //        MessageBox.Show("tài khoản mật khẩu không chính xác");
            //        return;

            //}
            //if (txtUsername.Text != "admin"||txtPassWord.Text != "123")
            //{
            //    FrmMainNV mNv = new FrmMainNV();
            //    mNv.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    Main main = new Main();
            //    main.Show();
            //    this.Hide();
            //}
            if (txtUsername.Text.Trim() != "" && txtPassWord.Text.Trim() != "")
            {
                // Kiểm tra mật khẩu
                bool isAccountExist = bul.checkTaiKhoan_IsExist(txtUsername.Text, txtPassWord.Text);
                if (isAccountExist)
                {
                    int manvLogin = bul.TaiKhoanLogin(txtUsername.Text, txtPassWord.Text).Ma_nhan_vien;
                    ETTNhanVien nvLogin = bul.GetNhanVien(manvLogin);
                    Function.BgetClass_ID = manvLogin;
                    Function.username = nvLogin.Ho_ten;
                    if (txtUsername.Text != "admin" || txtPassWord.Text != "123")
                    {
                        FrmMainNV mNv = new FrmMainNV();
                        mNv.Show();
                        this.Hide();

                    }
                    else
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
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
    }
}

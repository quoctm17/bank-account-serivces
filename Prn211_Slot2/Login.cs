using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prn211_Slot2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ẩn nút Login
            btnLogin.Enabled = false;
            btnLogin.Text = "Processing...";

            UserServices _userService = new UserServices();
            var ListUser = _userService.GetAll();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var user = ListUser.FirstOrDefault(User => User.UserName == username && User.Password == password);
            if (user != null && user.UserName == "Administrator")
            {
                    //Đăng nhập thành công
                    //MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK);
                    this.Hide();
                    Form frManagement = new Management();
                    frManagement.ShowDialog();
            }
            else
            {
                //Đăng nhập thất bại
                MessageBox.Show("You are not allowed to access this function!", "Alert", MessageBoxButtons.OK);

                // Hiển thị lại nút Login
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }

        }
    }
}

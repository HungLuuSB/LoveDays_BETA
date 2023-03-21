using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveDays
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User u0 = new User
            {
                Id = 0,
                name = "Nguyen Duc Trung",
                username = "trung",
                password = "123456",
                date_of_birth = "Not now",
                lover = null
            };

            User u1 = new User
            {
                Id = 1,
                name = "Luu Thai Hung",
                username = "hungluu12",
                password = "123456",
                date_of_birth = "Not now",
                lover = null
            };
            
            userDAO.userlist.Add(u0);
            userDAO.userlist.Add(u1);

            
            string username = tb_username.Text;
            string password = tb_password.Text;
            foreach (User user in userDAO.userlist)
            {
                Console.WriteLine(user.username);
            }
            foreach (User user in userDAO.userlist)
            {
                if (username == user.username)
                {
                    Console.WriteLine("Username found");
                    if (password == user.password)
                    {
                        MessageBox.Show("Success");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }

            }
        }
    }
}

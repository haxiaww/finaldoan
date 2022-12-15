using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dictionary_winform
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnesc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> users = new Dictionary<string, string>()
            {
                {"haiau","123" },
                {"tuyetnhu", "123" },
                {"minhtrieu", "123" },
                {"nagito","hope" },
                {"admin" ,"1"}
            }
            ;
            string user = txtuser.Text.Trim();
            string pass = txtpassword.Text.Trim();
            if (users.ContainsKey(user) == false)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!");
            }
            else
            {
                if (users[user] == pass)
                {
                    (this.Owner as main).btnql.Enabled = true;
                    Close();
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu vừa nhập không chính xác. Vui lòng nhập lại!");
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

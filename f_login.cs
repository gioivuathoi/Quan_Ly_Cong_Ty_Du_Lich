using Quản_lý_công_ty_du_lịch.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_công_ty_du_lịch
{
    public partial class f_login : Form
    {
        public static f_login instance;
        public f_login()
        {
            InitializeComponent();
            instance = this;
        }
        
        public string ID;
        public string role;
        string check_user(string username, string pass)
        {
            string query = "exec KiemTraUser @username , @password";
            DataSet data = DataProvider.Instance.ExecuteQuery(query, new object[] {username, pass});
            if (data.Tables[0].Rows.Count >0)

            {
                ID = data.Tables[0].Rows[0][0].ToString();
                if (data.Tables[0].Rows[0][1].ToString() == "custormer")
                {
                    return "cus";
                }
                else if (data.Tables[0].Rows[0][1].ToString() == "staff")
                {
                    return "staff";
                }    
                else
                {
                    return "admin";
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo");
                return "";
            }
        }
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sử muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }
        
        private void sign_in_click_Click(object sender, EventArgs e)
        {
            string userName = login_name.Text;
            string passWord = login_pass.Text;
            string mode = check_user(userName, passWord);
            if (mode != "")
            {
                
                f_account_customer c = new f_account_customer();
                f_account_manager m = new f_account_manager();
                this.Hide();
                if (mode == "cus")
                {
                    c.ShowDialog();
                }
                else
                {
                    role = mode;
                    m.ShowDialog();
                }
                this.Show();

            }
            
        }

        private void register_click_Click(object sender, EventArgs e)
        {
            
        }

        private void login_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_click_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
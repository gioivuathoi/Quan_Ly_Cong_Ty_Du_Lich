using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_công_ty_du_lịch
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
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
            if (MessageBox.Show("Bạn có thật sử muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void sign_in_click_Click(object sender, EventArgs e)
        {
            f_account_customer c = new f_account_customer();
            f_account_manager m = new f_account_manager();
            this.Hide();
            if (2== 1)
            { 
                c.ShowDialog();
            }    
            else
            {
                m.ShowDialog();
            }
            
            this.Show();
        }
    }
}

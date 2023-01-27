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
    public partial class f_account_customer : Form
    {
        public f_account_customer()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hồSơCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_account_infor f = new f_account_infor();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_book_ticket f = new f_book_ticket();
            this.Hide();
            f.ShowDialog(); 
            this.Show();
        }

        private void hủyVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_book_ticket f = new f_book_ticket();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

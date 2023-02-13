using Quản_lý_công_ty_du_lịch.DAO;
using Quản_lý_công_ty_du_lịch.DTO;
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
            LoadTour();
        }
        List<Tour> SearchTour(string name)
        {
            List<Tour> ListTour = TourDAO.Instance.SearchTour(name);
            return ListTour;
        }
        void SearchTour(DateTime startdate)
        {
            string query = "exec timkiemtourchoban @startdate ";
            DataSet data1 = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { startdate.ToString()});
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.DataSource = data1.Tables[0];
        }
        void LoadTour()
        {
            List<Tour> Tour = TourDAO.Instance.GetListTour;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = TourDAO.Instance.GetListTour();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void f_account_customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Khách hàng vui lòng liên hệ số điện thoại 0123456789 để được hỗ trợ !", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
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

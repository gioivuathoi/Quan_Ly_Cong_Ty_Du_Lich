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
            load_tour();
        }
        #region methods
        void load_tour()
        {
            string query = "exec ListTour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = data.Tables[0];
        }
        void search_tour_by_name(string name_tour)
        {
            string query = "exec TimTourBangTen @ten_tour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] {name_tour});
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.DataSource = data.Tables[0];
        }

        #endregion
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void f_account_customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Khách hàng vui lòng liên hệ số điện thoại 0123456789 để được hỗ trợ !", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }
        #region events
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name_tour = TB_search_tour.Text;
            search_tour_by_name(name_tour);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_get_mess_infor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy nhắn tin với chúng tôi vào hotline: 0991122 rằng bạn cần tư vấn \n" +
                "Và chúng tôi sẽ gọi điện lại cho ban trong thời gian sớm nhất", "Thông báo");

        }

        private void button_get_phone_num_infor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu bạn cần gọi điện trực tiếp, hãy gọi vào hotline: 0991122\nXin cảm ơn!", "Thông báo");
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

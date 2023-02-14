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
    public partial class f_account_manager : Form
    {
        public f_account_manager()
        {
            InitializeComponent();
            load_not_payment();
        }
        #region methods
        private void load_not_payment()
        {
            string query = "exec TimKiemVeChuaThanhToan";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query);
            if (data.Tables[0].Rows.Count == 0)
            {

                dataGridView2.Rows.Add("Thông báo", "Không có trường hợp nào chưa thanh toán!");

            }
            else
            {
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.DataSource = data.Tables[0];
            }
        }
        private void update_advice(string id_ticket)
        {
            string query = "exec UpdateTuVan @ma_ve";
            int data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] {id_ticket});
            if (data > 0)
            {
                MessageBox.Show("Nhận tư vấn thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi nhận tư vấn!", "Thông báo");
            }    
        }
        private void update_payment(string id_ticket)
        {
            string query = "exec UpdateThanhToan @ma_ve";
            int data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] { id_ticket });
            if (data>0)
            {
                MessageBox.Show("Đã update trạng thái thanh toán thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update trạng thái thanh toán thất bại!", "Thông báo!");
            }    
        }
        void LoadAccountCustormer(string id_cus)
        {
            string query = "exec TimKiemTaiKhoanKhachHang @id , @sdt";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_cus,id_cus });
            if (data.Tables[0].Rows.Count == 0 || data.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ID!", "Thông Báo!");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DataSource = data.Tables[1];
            }

        }
        void LoadTourInfor(string id_tour)
        {
            string query = "exec TimKiemTour @ma_tour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_tour });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mã tour!", "Thông báo");

            }
            else
            {
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView4.DataSource = data.Tables[0];
            }
        }
        void LoadTicketInfor (string id_ticket)
        {
            string query = "exec TimKiemVe @ma_ve";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_ticket });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mã tour!", "Thông báo");

            }
            else
            {
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView3.DataSource = data.Tables[0];
            }
        }
        #endregion
        private void f_account_manager_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_account_infor f = new f_account_infor();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string role = f_login.instance.role;
            if (role == "admin")
            { 
            f_admin f = new f_admin();
            this.Hide();
            f.ShowDialog();
            this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin!", "Thông báo");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            f_account_infor f = new f_account_infor();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id_ticket = TB_ID_Ticket_Advice.Text;
            update_advice(id_ticket);
            load_not_payment();
        }

        private void button_paid_Click(object sender, EventArgs e)
        {
            string id_ticket = TB_ID_Ticket_pay.Text;
            update_payment(id_ticket);
            load_not_payment();
        }

        private void button_search_cus_Click(object sender, EventArgs e)
        {
            string id_cus = TB_search_id_cus.Text;
            LoadAccountCustormer(id_cus);
            load_not_payment();
        }

        private void button_search_tour_Click(object sender, EventArgs e)
        {
            string id_tour = TB_search_id_tour.Text;
            LoadTourInfor(id_tour);
            load_not_payment();
        }

        private void button_search_ticket_Click(object sender, EventArgs e)
        {
            string id_ticket = TB_search_id_tic.Text;
            LoadTicketInfor(id_ticket);
            load_not_payment();
        }
    }
}

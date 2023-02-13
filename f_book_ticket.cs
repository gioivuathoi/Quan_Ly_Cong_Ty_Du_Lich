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
    public partial class f_book_ticket : Form
    {
        public f_book_ticket()
        {
            InitializeComponent();
        }

        private void f_book_ticket_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region methods
        void LoadTicket(string id_tour)
        {
            string query = "exec TimKiemCongTyVanTai @ma_tour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_tour });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Tour không tồn tại!", "Thông báo");
            }
            else
            {
                DTGV_TICKET.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DTGV_TICKET.DataSource = data.Tables[0];
            }
        }
        #endregion
        #region events
        private void button_find_ticket_Click(object sender, EventArgs e)
        {
            string id_tour = TB_ID_TOUR_SEARCH.Text;
            LoadTicket(id_tour);
        }
        #endregion
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

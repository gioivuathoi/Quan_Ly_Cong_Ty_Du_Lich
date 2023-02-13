using Quản_lý_công_ty_du_lịch.DAO;
using Quản_lý_công_ty_du_lịch.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region methods
        void LoadTour(string id_tour)
        {
            string query = "exec TimKiemTour @ma_tour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_tour });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Tour không tồn tại!", "Thông báo");
            }
            else
            {
                DTGV_TOUR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DTGV_TOUR.DataSource = data.Tables[0];
            }
        }

        #endregion
        #region events
        private void button_load_tour_Click(object sender, EventArgs e)
        {
            string id_tour = TB_ID_TOUR_LOAD.ToString();
            LoadTour(id_tour);
        }
        //Đặt vé buttton
        private void BT_BOOK_TICKET_Click(object sender, EventArgs e)
        {
            //kiểm tra chưa chọn vé
            if (DAO.DAO_BookTicket.Instance.KTRong(int.Parse(numericUpDownOver16.Text), int.Parse(numericUpDownUnder16.Text)) == false)//nhập sluong
            {
                return;
            }
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn đặt vé này không", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //tạo DTO

                int gia = int.Parse(numericUpDownOver16.Text) * int.Parse(DTGV_TOUR.Rows[1].Cells[2].ToString());
                DTO_BookTicket tk = new DTO_BookTicket(DAO.DAO_BookTicket.Instance.taomavetudong().ToString(), int.Parse(numericUpDownOver16.Text), int.Parse(numericUpDownUnder16.Text), gia, DateTime.Parse(DTP_ngaydi.Text), DateTime.Now, listBox_paytype.Text);
                //đặt tour
                if (DAO.DAO_BookTicket.Instance.BookTicket(tk))//thành  công
                {
                    //hiển thị mã ve của hóa đơn
                    int k = DAO.DAO_BookTicket.Instance.taomavetudong() - 1;//do khi thêm vào stt sẽ tăng 1
                    string mave = k.ToString();
                    MessageBox.Show("Đặt vé thành công. Mã vé của bạn là nội dung chuyển khoản. Vui lòng chuyển khoản đến STK 123 của ngân hàng ABC theo đúng nội dung.", "Thông Báo");
                    TB_PAYTEXT.Text = mave;
                    return;
                }
                else//thất bại
                {
                    MessageBox.Show("Đặt vé thất Bại", "Thông Báo");
                    return;
                }

            }
        }
        #endregion
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}

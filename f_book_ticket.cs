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
        //kiểm tra rỗng
        public bool KTRong(int a, int b)
        {
            if (a==0 && b == 0)//rỗng
            {
                MessageBox.Show("Chưa chọn số lượng vé để đặt", "Thông Báo");
                return false;
            }
            return true;//đã nhập tất cả
        }
        //kiểm mã hóa đơn tránh bị trùng
        public bool KTmavetrung(int sl)
        {
            try
            {
                string query = "select count(*) from Ve where ma_ve='" + sl + "'";
                DataProvider provider = new DataProvider();
                int k = (int)provider.ExecuteScalar(query);//thực thi câu lệnh trả về 1 số
                if (k > 0)//có tồn tại mã hóa đơn
                {
                    return true;
                }
                else//chưa có mã hóa đơn
                {
                    return false;
                }

            }
            catch
            {
                return false;//thất bại
            }
        }
        //tao ma hoa don tu dung
        public int taomavetudong()
        {
            try
            {
                string query = "select count(*) from Ve";
                DataProvider provider = new DataProvider();
                int k = (int)provider.ExecuteScalar(query);//thực thi câu lệnh trả về 1 số
                if (KTmavetrung(k))//trùng mã hóa đơn
                {
                    return k + 1;
                }
                else//không trùng mã hóa đơn
                {
                    return k;
                }

            }
            catch
            {
                return 0;
            }
        }

        //Đặt tour
        public bool BookTicket(BookTicket tk)
        {
            try
            {
                string query = "exec BookTicket '" + tk.Mave + "'" + "','" + tk.So_nguoi_lon + "','" +tk.So_tre_em + "','" + tk.Gia_ve + "','" + tk.Ngay_di + "','" + tk.Ngay_dat + "','" + tk.Payment + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;//thất bại
            }
        }
        #endregion
        #region events
        private void button_load_tour_Click(object sender, EventArgs e)
        {
            string id_tour = TB_ID_TOUR_SEARCH.Text;
            LoadTour(id_tour);
        }
        //Đặt vé buttton
        private void BT_BOOK_TICKET_Click(object sender, EventArgs e)
        {
            //kiểm tra chưa chọn vé
            if (KTRong(int.Parse(numericUpDownOver16.Text), int.Parse(numericUpDownUnder16.Text)) == false)//nhập sluong
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
                BookTicket tk = new BookTicket(taomavetudong().ToString(), int.Parse(numericUpDownOver16.Text), int.Parse(numericUpDownUnder16.Text), gia, DateTime.Parse(DTP_ngaydi.Text), DateTime.Now, listBox_paytype.Text);
                //đặt tour
                if (BookTicket(tk))//thành  công
                {
                    //hiển thị mã ve của hóa đơn
                    int k = taomavetudong() - 1;//do khi thêm vào stt sẽ tăng 1
                    string mave = k.ToString();
                    MessageBox.Show("Đặt vé thành công. Mã vé của bạn là:", "Thông Báo");
                    MessageBox.Show(mave, "Thông Báo");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

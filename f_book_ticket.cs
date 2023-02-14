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
            string query = "exec TimKiemTourChoKhachHang @ma_tour";
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
        void BookTicket(string id_ticket, int adults, int children, int price, DateTime start_date, DateTime end_date, string id_tour,
            string id_cus, DateTime book_date)
        {
           
             string query = "exec BookTicket @ma_ve , @so_nguoi_lon , @so_tre_em , @gia_ve , @ngay_di , @ngay_ve , @ma_tour , @id , @ngay_dat_ve";
            int result = UpdateData.Instance.ExecuteUpdate(query, new object[] { id_ticket, adults, children, price, start_date, end_date, id_tour, id_cus, book_date });
             if (result > 0)
            {
                MessageBox.Show("Đặt vé thành công!", "Thông báo");
            }    
             else
            {
                MessageBox.Show("Đặt vé thất bại!", "Thông báo");
            }    
        }
        public bool CancelTicket(string mave)
        {
            string query = string.Format("Delete Ve where ma_ve = N'{0}'", mave);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        bool KTRong(int a, int b)
        {
            if (a == 0 && b == 0)//rỗng
            {
                MessageBox.Show("Chưa chọn số lượng vé để đặt", "Thông Báo");
                return false;
            }
            return true;//đã nhập tất cả
        }
        public bool KTmavetrung(string sl)
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
        int taomavetudong()
        {
            try
            {
                string query = "select count(*) from Ve";

                DataSet data = DataProvider.Instance.ExecuteQuery(query);
                string k = data.Tables[0].Rows[0][0].ToString();    
                if (KTmavetrung( k))//trùng mã hóa đơn
                {
                    return int.Parse(k) + 1;
                }
                else//không trùng mã hóa đơn
                {
                    return int.Parse(k);
                }

            }
            catch
            {
                return 0;
            }
        }

        #endregion
        #region events
        private void button_load_tour_Click(object sender, EventArgs e)
        {
            string id_tour = TB_ID_TOUR_LOAD.Text;
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
                string query = "exec TimKiemTourChoKhachHang @ma_tour";
                string id_tour = TB_ID_TOUR_LOAD.Text;
                DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_tour });
                
                DTGV_TOUR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DTGV_TOUR.DataSource = data.Tables[0];
                int price = int.Parse(numericUpDownOver16.Text) * int.Parse(data.Tables[0].Rows[0][2].ToString()) + int.Parse(numericUpDownUnder16.Text) * int.Parse(data.Tables[0].Rows[0][2].ToString()) * 80/100;
                string id_tic = taomavetudong().ToString();
                int adults = int.Parse(numericUpDownOver16.Text);
                int children = int.Parse(numericUpDownUnder16.Text);
                DateTime start_date = DateTime.Parse(DTP_ngaydi.Text);
                System.TimeSpan tSpan = new System.TimeSpan(10, 0, 0, 0);
                DateTime end_date = start_date + tSpan;
                DateTime book_date = DateTime.Now.Date;
                string id_cus = f_login.instance.ID;
                BookTicket(id_tic,adults,children,price,start_date,end_date,id_tour,id_cus,book_date);

            }
        }
        private void BT_CANCEL_TICKET_Click(object sender, EventArgs e)
        {
            CancelTicket(TB_CancelID.Text);
            MessageBox.Show("Vé đã được xoá thành công.", "Thông Báo");
            return;
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

        private void TB_ID_TOUR_LOAD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

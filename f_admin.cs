using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_công_ty_du_lịch
{
    public partial class f_admin : Form
    {
        public f_admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        #region methods
        void LoadListStatisTicket(DateTime startdate, DateTime enddate)
        {
            //string query = "exec ThongKeVe @startdate=" + startdate.ToString() + ",@enddate=" + enddate.ToString();
            string query1 = "exec ThongKeVeDaThanhToan @startdate , @enddate";
            string query2 = "exec ThongKeVeChuaThanhToan @startdate , @enddate";
            DataSet data1 = DAO.DataProvider.Instance.ExecuteQuery(query1, new object[] { startdate.ToString(), enddate.ToString() });
            DataSet data2 = DAO.DataProvider.Instance.ExecuteQuery(query2, new object[] { startdate.ToString(), enddate.ToString() });
            view_thongkevechuathanhtoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            view_thongkevedathanhtoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            view_thongkevedathanhtoan.DataSource = data1.Tables[0];
            view_thongkevechuathanhtoan.DataSource = data2.Tables[0];
        }
        void LoadAccountStaff(string id_staff)
        {
            string query = "exec TimKiemTaiKhoanNhanVien @id";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_staff });
            if (data.Tables[0].Rows.Count == 0 || data.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ID!", "Thông Báo!");
            }
            else
            {
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView4.DataSource = data.Tables[0];
                dataGridView2.DataSource = data.Tables[1];  
            }    
            
        }
        void LoadAccountCustormer(string id_cus)
        {
            string query = "exec TimKiemTaiKhoanKhachHang @id";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_cus });
            if (data.Tables[0].Rows.Count == 0 || data.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ID!", "Thông Báo!");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DataSource = data.Tables[0];
                dataGridView5.DataSource = data.Tables[1];
            }
            
        }
        void LockAccount(string id)
        {
            string query = "exec KhoaTaiKhoan @id";
            int data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] { id });
            if (data == 1) { MessageBox.Show("Khóa tài khoản thành công!", "Thông Báo"); }
            else
            {
                MessageBox.Show("Khóa tài khoàn thất bại", "Thông Báo");
            }
        }
        void CreateAccount(string username,string password, string name, string phone_number,
                           string role,string citizen_id,DateTime dob, string bank_number = null, string email = null, int staff = 1)
        {
            string query;
            if (staff == 1) { query = "exec TaoTaiKhoanNhanVien @tendangnhap , @mat_khau , @id , @hovaten , @sdt , @ma_quyen , @stk , @scc , @ntns , @email"; }
            else { query = "exec TaoTaiKhoanKhachHang @tendangnhap , @mat_khau , @id , @hovaten , @sdt , @ma_quyen , @scc , @ntns , @email"; }
            if (username.Count() <= 2) { MessageBox.Show("Tên đăng nhập quá ngắn!", "Thông báo"); }
            else
            {
                string id = username[0] + username[2] + username[3] + citizen_id;
                int data;
                if (staff == 1)
                {
                    data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] { username, password, id, name, phone_number, role, bank_number, citizen_id, dob, email });
                }
                else
                {
                    data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] { username, password, id, name, phone_number, role, citizen_id, dob, email });
                }
                if (data == 2) { MessageBox.Show("Tạo tài khoản thành công!", "Thông báo"); }
                else { MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo"); }
            }
        }
        void LoadTourInfor(string id_tour)
        {
            string query = "exec TimKiemTour @ma_tour";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query,new object[]{id_tour});
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
        void DeleteTour(string id_tour)
        {
            //DataRow row = data.Tables[0].Rows[0];
            int data = 0;
            string query_delete = "exec XoaTour @ma_tour";
            string query_check_ticket = "exec DemVeDatTour @matour";
            DataSet data1 = DAO.DataProvider.Instance.ExecuteQuery(query_check_ticket, new object[] {id_tour});
            DataRow row = data1.Tables[0].Rows[0];
            
            if (row != null && row[0].ToString() == "0")
            {
                if (MessageBox.Show("Tour này chưa có vé đăng ký.\nBạn có muốn tiếp tục xóa tour này?", "Thông báo!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    data = DTO.UpdateData.Instance.ExecuteUpdate(query_delete, new object[] { id_tour });
                    if (data != 0)
                    {
                        MessageBox.Show("Xóa thành công Tour!", "Thông báo");
                    }
                }
            }
            else
            {
                if (row[0].ToString() != "0")
                {
                    if (MessageBox.Show("Tour đã có vé đăng ký.\nXóa tour sẽ đồng thời xóa thông tin các vé đã được đăng ký." +
                        "\nKhuyến nghị chỉ chỉnh sửa thông tin của tour.\nBạn có muốn tiếp tục xóa tour?","Thông báo!",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        data = DTO.UpdateData.Instance.ExecuteUpdate(query_delete, new object[] { id_tour });
                        if (data != 0)
                        {
                            MessageBox.Show("Xóa thành công Tour!", "Thông báo");
                        }
                    }    
                }
            }
        }
        void CreateTour(string tour_id, string tour_name, int tour_price, int tour_type, string id_trans,
            string id_hotel, string tour_process, int num_ticket=0)
        {
            int check = 0;
            string query1 = "exec TaoTourMoi @ma_tour , @ten_tour , @gia_tour , @loai_tour , @so_ve_da_dat , @ma_ctvt , @ma_ks , @lich_trinh";
            string query2 = "exec TimKiemTour @ma_tour";
            string query3 = "exec TimKiemCongTyVanTai @ma_ctvt";
            string query4 = "exec TimKiemKhachSan @ma_ks";
            DataSet data2 = DAO.DataProvider.Instance.ExecuteQuery(query2, new object[] { tour_id });
            DataSet data3 = DAO.DataProvider.Instance.ExecuteQuery(query3, new object[] { id_trans });
            DataSet data4 = DAO.DataProvider.Instance.ExecuteQuery(query4, new object[] { id_hotel });
            if (data2.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Mã Tour đã tồn tại!", "Thông báo");
            }
            else if (data3.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Công ty vận tải không tồn tại!", "Thông báo");
            }
            else if (data4.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Khách sạn không tồn tại!", "Thông báo");
            }
            else
            {
                check = DTO.UpdateData.Instance.ExecuteUpdate(query1, new object[] { tour_id,tour_name,tour_price,tour_type,num_ticket, id_trans,id_hotel,tour_process });
                if (check == 1) { MessageBox.Show("Tạo tour thành công!","Thông báo"); }
                else
                {
                    MessageBox.Show("Tạo tour thất bại","Thông báo");
                }
            }    
        }
        void LoadTransport(string id_trans)
        {
            string query = "exec TimKiemCongTyVanTai @ma_ctvt";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_trans });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Công ty vận tải không tồn tại!", "Thông báo");
            }
            else
            {
                dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView6.DataSource = data.Tables[0];
            }
        }
        void LoadHotel(string id_hotel)
        {
            string query = "exec TimKiemKhachSan @ma_ks";
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id_hotel });
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã Khách sạn không tồn tại!", "Thông báo");
            }
            else
            {
                dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView7.DataSource = data.Tables[0];
            }
        }
        void CreateTrans(string id_trans, string name, string phone_num, string email)
        {
            string query = "exec TaoVanTai @id , @ten , @sdt , @email";
            int data = DTO.UpdateData.Instance.ExecuteUpdate(query,new object[] {id_trans, name, phone_num, email});
            if (data != 1)
            {
                MessageBox.Show("ID công ty vận tải đã tồn tại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản Công ty vận tải mới thành công!", "Thông báo");
            }    
        }
        void CreateHotel(string id_hotel, string name, string phone_num, string email, string address)
        {
            string query = "exec TaoKhachSan @id , @ten , @sdt , @email , @dia_chi";
            int data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] {id_hotel, name, phone_num, email, address});
            if (data != 1)
            {
                MessageBox.Show("ID khách sạn đã tồn tại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản Khách sạn thành công!", "Thông báo");
            }    
        }    
        #endregion
        #region events
        private void Button_thongkeve_Click(object sender, EventArgs e)
        {
            LoadListStatisTicket(DTP_thongkeve_start.Value, DTP_thongkeve_end.Value);
        }
        private void button_timkiemnhanvien_Click(object sender, EventArgs e)
        {
            string id_staff = textBox14.Text;
            LoadAccountStaff(id_staff);
        }
        private void button_timkiemkhachhang_Click(object sender, EventArgs e)
        {
            string id_cus = textBox21.Text;
            LoadAccountCustormer(id_cus);
        }
        private void button_khoataikhoan_nv_Click(object sender, EventArgs e)
        {
            string id = textBox14.Text;
            LockAccount(id);
        }

        private void button_khoataikhoan_kh_Click(object sender, EventArgs e)
        {
            string id = textBox21.Text;
            LockAccount(id);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string id = textBox14.Text;
            LockAccount(id);
        }
        private void button_cre_acc_staff_Click(object sender, EventArgs e)
        {
            string username = TB_login_name_staff.Text;
            string password = TB_pass_staff.Text;
            string name = TB_name_staff.Text;
            string phone_number = TB_phone_num_staff.Text;
            string role = TB_role_staff.Text;
            string bank_number = TB_bank_num_staff.Text;
            string citizen_id = TB_id_citizen_staff.Text;
            DateTime dob = DTP_dob_staff.Value;
            string email = TB_email_staff.Text;
            if (username == "" || password == "" || name == ""|| phone_number == "" || role == "" || bank_number == "" || citizen_id == "")
            {
                MessageBox.Show("Ngoài ngày sinh và email, các ô khác cần đủ thông tin!", "Thông báo");
            }
            else
            {
                CreateAccount(username, password, name, phone_number, role, citizen_id, dob, bank_number, email);
            }    
        }
        private void button_cre_acc_cus_Click(object sender, EventArgs e)
        {
            string username = TB_login_name_cus.Text;
            string password = TB_pass_cus.Text;
            string name = TB_name_cus.Text;
            string phone_number = TB_phone_num_cus.Text;
            string bank_number = TB_bank_num_staff.Text;
            string citizen_id = TB_id_citizen_staff.Text;
            string role = "Customer";
            
            DateTime dob = DTP_dob_staff.Value;
            string email = TB_email_staff.Text;
            if (username == "" || password == "" || name == "" || phone_number == "" || bank_number == "" || citizen_id == "")
            {
                MessageBox.Show("Các ô cần đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                CreateAccount(username, password, name, phone_number, role, citizen_id, dob, bank_number, email, 0);
            }    
            
        }
        private void button_timkiem_tour_Click(object sender, EventArgs e)
        {
            string ma_tour = TB_find_matour.Text;
            LoadTourInfor(ma_tour);
        }
        private void button_delete_tour_Click(object sender, EventArgs e)
        {
            string id_tour = TB_find_matour.Text;
            DeleteTour(id_tour);
        }
        private void button_cre_tour_Click(object sender, EventArgs e)
        {
            string tour_id = TB_cre_tour_id.Text;
            string tour_name = TB_cre_tour_name.Text;
            int tour_price = -1;
            tour_price = int.Parse(TB_cre_tour_price.Text);
            int tour_type = -1;
            tour_type = int.Parse(TB_cre_tour_type.Text);
            string id_trans = TB_cre_tour_trans_id.Text;
            string id_hotel = TB_cre_tour_hotel_id.Text;
            string tour_process = TB_cre_tour_process.Text;
            if (tour_id == "" || tour_name == "" || tour_price == -1|| tour_type == -1|| tour_process == "")
            {
                MessageBox.Show("Ngoài Mã công ti vận tải, Mã Khách sạn thì các ô khác cần đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                CreateTour(tour_id, tour_name, tour_price, tour_type, id_trans, id_hotel, tour_process);
            }    
            
        }
        private void button_find_trans_Click(object sender, EventArgs e)
        {
            string id_trans = TB_find_id_trans.Text;
            LoadTransport(id_trans);
        }
        private void button_find_hotel_Click(object sender, EventArgs e)
        {
            string id_hotel = TB_find_id_hotel.Text;
            LoadHotel(id_hotel);
        }
        private void Add_trans_Click(object sender, EventArgs e)
        {
            string id_trans = TB_cre_id_trans.Text;
            string name = TB_cre_name_trans.Text;
            string phone_num = TB_cre_phone_num_trans.Text;
            string email = TB_cre_email_trans.Text;
            if (id_trans == "" || name == "" || phone_num == "")
            {
                MessageBox.Show("Ngoài Email thì cần điền đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                CreateTrans(id_trans, name, phone_num, email);
            }    
            
        }
        private void Add_hotel_Click(object sender, EventArgs e)
        {
            string id_hotel = TB_cre_id_hotel.Text;
            string name = TB_cre_name_hotel.Text;
            string phone_num = TB_cre_phone_num_hotel.Text;
            string email = TB_cre_email_hotel.Text;
            string address = TB_cre_address_hotel.Text;
            if (id_hotel == "" || name == "" || phone_num == "" || address == "")
            {
                MessageBox.Show("Ngoài Email thì cần điền đầy đủ thông tin!", "Thông báo");
            }    
            else
            {
                CreateHotel(id_hotel,name, phone_num,email, address);
            }    
        }
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transport_tab_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        
    }
}

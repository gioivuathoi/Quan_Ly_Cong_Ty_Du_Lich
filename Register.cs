using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Quản_lý_công_ty_du_lịch.DAO;

namespace Quản_lý_công_ty_du_lịch
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac) // check mat khau va tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        bool check_user(string username)
        {
            string query = "exec KiemTraUserĐangKy @username";
            DataSet data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if (data.Tables[0].Rows.Count > 0)

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = TB_username.Text;
            if (check_user(tentk))
            {
                string matkhau = TB_new_pass.Text;
                string xnmatkhau = TB_verified_pass.Text;
                if (!checkAccount(tentk)) { MessageBox.Show("Vui long nhap ten tai khoan dai 6-24 ki tu, voi cac ki tu chu va so, chu hoa va chu thuong!"); return; }
                if (!checkAccount(matkhau)) { MessageBox.Show("Vui long nhap mat khau dai 6-24 ki tu, voi cac ki tu chu va so, chu hoa va chu thuong!"); return; }
                if (xnmatkhau != matkhau) { MessageBox.Show("Vui long xac nhan lai mat khau!"); return; }

                string query = "exec KhachHangTaoTaiKhoan @username , @password , @id";
                int data = DTO.UpdateData.Instance.ExecuteUpdate(query, new object[] { tentk, matkhau, tentk });

                if (data > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký, xin chọn tên khác!", "Thông báo");
            }


        }
    }
}


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
    public partial class f_account_infor : Form
    {
        public f_account_infor()
        {
            InitializeComponent();
            loadTTCaNhan_KH();
        }

        public void loadTTCaNhan_KH()
        {
            string query = "";
            if (f_login.instance.role == "staff" || f_login.instance.role == "admin")
            {
                query = "exec ThongTinNV @id ";
            }
            else
            {
                query = "exec ThongTinKH @id";
            }
            
            string id = f_login.instance.ID;
            
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query,new object[] {id});
            if (data.Tables[0].Rows.Count > 0)
            {
                login_name.Text = data.Tables[0].Rows[0].ItemArray[0].ToString();
                TB_TenKH.Text = data.Tables[0].Rows[0].ItemArray[1].ToString();
                TB_NgaySinh.Text = data.Tables[0].Rows[0].ItemArray[2].ToString();
                TB_CCCD.Text = data.Tables[0].Rows[0].ItemArray[3].ToString();
                TB_Email.Text = data.Tables[0].Rows[0].ItemArray[5].ToString();
                TB_SDT.Text = data.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

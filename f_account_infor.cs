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
            string query = "exec ThongTinKH @id";
            string id = f_login.instance.ID;
            DataSet data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            TB_TenKH.Text = data.Tables[0].Columns[1].ToString();
            TB_NgaySinh.Text = data.Tables[0].Columns[2].ToString();
            TB_CCCD.Text = data.Tables[0].Columns[3].ToString();
            TB_Email.Text = data.Tables[0].Columns[4].ToString();
            TB_SDT.Text = data.Tables[0].Columns[5].ToString();
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DAO
{
    public class DataProviderDo
    {
        private static DataProviderDo instance;
        public static DataProviderDo Instance
        {
            get { if (instance == null) { instance = new DataProviderDo(); } return instance; }
            private set => DataProviderDo.instance = value;
        }
        private DataProviderDo() { }
        private string connectionSTR = "Data Source=DESKTOP-SRVEET5\\XUANTHINH;Initial Catalog=CongTyDuLich;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();

            }
            return data;
        }
    }
}

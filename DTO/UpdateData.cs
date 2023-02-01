using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DTO
{
    public class UpdateData
    {
        private static UpdateData instance;
        public static UpdateData Instance
        {
            get { if (instance == null) instance = new UpdateData(); return instance; }
            private set { UpdateData.instance = value; }
        }
        private UpdateData() { }

        private string connectionSTR = "Data Source=DESKTOP-SRVEET5\\XUANTHINH;Initial Catalog=CongTyDuLich;Integrated Security=True";

        public int ExecuteUpdate(string query, object[] parameter = null)
        {
            int data = 0;
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
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}

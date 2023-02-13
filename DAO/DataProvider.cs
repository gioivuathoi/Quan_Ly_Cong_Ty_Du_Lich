using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() {}
        private string connectionSTR = "Data Source=HDzungx;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public DataSet ExecuteQuery(string query, object[] parameter = null)
        {
            DataSet dataset = new DataSet();
            using (SqlConnection connection= new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
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
                adapter.Fill(dataset);
                connection.Close();
                return dataset;
            }
        }
    }
}

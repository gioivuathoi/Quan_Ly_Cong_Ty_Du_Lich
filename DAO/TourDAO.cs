using Quản_lý_công_ty_du_lịch.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DAO
{
    public class TourDAO
    {
        private static TourDAO instance;
        public static TourDAO Instance
        {
            get { if (instance == null) instance = new TourDAO(); return TourDAO.instance; }
            private set { TourDAO.instance = value; }
        }
        private TourDAO() { }
        public List<Tour> GetListTour(int id)
        {
            List<Tour> listTour = new List<Tour>();
            string query = "select * form Tour";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                listTour.Add(Tour);
            }
            return listTour;
        }
        public List<Tour> SearchTour(string name)
        {
            List<Tour> list = new List<Tour>();
            string query = string.Format("select * from where name = N'{0}'", name);
            DataTable data = TourDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                list.Add(Tour);
            }
            return list;
        }
    }
}

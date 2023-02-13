using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DTO
{
    internal class Tour
    {
        public Tour(string tour )
        {
            this.tour = tour;
        }

        public Tour(DataRow row)
        {
            this.tour = row["tour"].ToString();
        }
        public string tour
        {
            get { return this.tour; }
            set { this.tour = value; }
        }
    }
}

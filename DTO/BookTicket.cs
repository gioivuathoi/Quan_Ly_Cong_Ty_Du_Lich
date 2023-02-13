using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DTO
{
    public class BookTicket
    {
        private string mave;
        private int so_nguoi_lon;
        private int so_tre_em;
        private int gia_ve;
        private DateTime ngay_di;
        private DateTime ngay_dat;
        private string payment;

        public string Mave { get => mave; set => mave = value; }
        public int So_nguoi_lon { get => so_nguoi_lon; set => so_nguoi_lon = value; }
        public int So_tre_em { get => so_tre_em; set => so_tre_em = value; }
        public int Gia_ve { get => gia_ve; set => gia_ve = value; }
        public DateTime Ngay_di { get => ngay_di; set => ngay_di = value; }
        public DateTime Ngay_dat { get => ngay_dat; set => ngay_dat = value; }
        public string Payment { get => payment; set => payment = value; }


        public BookTicket()
        { }

        public BookTicket(string mave, int so_nguoi_lon, int so_tre_em, int gia_ve, DateTime ngay_di, DateTime ngay_dat, string payment)
        {
            Mave = mave;
            So_nguoi_lon = so_nguoi_lon;
            So_tre_em = so_tre_em;
            Gia_ve = gia_ve;
            Ngay_di = ngay_di;
            Ngay_dat = ngay_dat;
            Payment = payment;
        }
    }
}

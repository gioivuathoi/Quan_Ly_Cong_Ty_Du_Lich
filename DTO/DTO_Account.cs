using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_công_ty_du_lịch.DTO
{
    public class Account
    {
        private string userName;
        private string tenKH;
        private DateTime ngaySinh;
        private string cccd;
        private string email;
        private string sDT;


        public string UserName { get => userName; set => userName = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }


        public Account()
        { }

        public Account(string userName, string tenKH, DateTime ngaySinh, string cccd, string email, string sDT)
        {
            UserName = userName;
            TenKH = tenKH;
            NgaySinh = ngaySinh;
            Cccd = cccd;
            Email = email;
            SDT = sDT;
        }
    }
}

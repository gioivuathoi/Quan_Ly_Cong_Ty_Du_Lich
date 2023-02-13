using Quản_lý_công_ty_du_lịch.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_công_ty_du_lịch.DAO
{
    public class DAO_BookTicket
    {
        private static DAO_BookTicket instance;

        public static DAO_BookTicket Instance
        {
            get { if (instance == null) instance = new DAO_BookTicket(); return instance; }
            private set { instance = value; }
        }

        private DAO_BookTicket() { }
        //kiểm tra rỗng
        public bool KTRong(int a, int b)
        {
            if (a == 0 && b == 0)//rỗng
            {
                MessageBox.Show("Chưa chọn số lượng vé để đặt", "Thông Báo");
                return false;
            }
            return true;//đã nhập tất cả
        }
        //kiểm mã hóa đơn tránh bị trùng
        public bool KTmavetrung(int sl)
        {
            try
            {
                string query = "select count(*) from Ve where ma_ve='" + sl + "'";
                DataProvider provider = new DataProvider();
                int k = (int)provider.ExecuteScalar(query);//thực thi câu lệnh trả về 1 số
                if (k > 0)//có tồn tại mã hóa đơn
                {
                    return true;
                }
                else//chưa có mã hóa đơn
                {
                    return false;
                }

            }
            catch
            {
                return false;//thất bại
            }
        }
        //tao ma hoa don tu dung
        public int taomavetudong()
        {
            try
            {
                string query = "select count(*) from Ve";
                DataProvider provider = new DataProvider();
                int k = (int)provider.ExecuteScalar(query);//thực thi câu lệnh trả về 1 số
                if (KTmavetrung(k))//trùng mã hóa đơn
                {
                    return k + 1;
                }
                else//không trùng mã hóa đơn
                {
                    return k;
                }

            }
            catch
            {
                return 0;
            }
        }

        //Đặt tour
        public bool BookTicket(DTO_BookTicket tk)
        {
            try
            {
                string query = "exec BookTicket '" + tk.Mave + "'" + "','" + tk.So_nguoi_lon + "','" + tk.So_tre_em + "','" + tk.Gia_ve + "','" + tk.Ngay_di + "','" + tk.Ngay_dat + "','" + tk.Payment + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;//thất bại
            }
        }
    }
}

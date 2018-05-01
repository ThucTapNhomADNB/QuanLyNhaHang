using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.ENTITY
{
    class Statis
    {
        private int maHoaDon;
        private DateTime ngay;
        private int tongTien;
        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }
        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }
        public int TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}

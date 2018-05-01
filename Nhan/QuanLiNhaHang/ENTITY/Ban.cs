using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.ENTITY
{
    class Ban
    {
        private int maBan;
        private string tenBan;
        private int trangThai;
        private string khuVuc;

        public int MaBan
        {
            get
            {
                return maBan;
            }

            set
            {
                maBan = value;
            }
        }

        public string TenBan
        {
            get
            {
                return tenBan;
            }

            set
            {
                tenBan = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string KhuVuc
        {
            get
            {
                return khuVuc;
            }

            set
            {
                khuVuc = value;
            }
        }
    }
}

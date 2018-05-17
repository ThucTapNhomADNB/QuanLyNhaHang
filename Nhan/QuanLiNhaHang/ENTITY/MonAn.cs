using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.ENTITY
{
    class MonAn
    {
        private int id;
        private string name;
        private int price;
        private int status;

    //       Id int IDENTITY(1,1) PRIMARY KEY,
    //   Name nvarchar(50),
	//  Price int,
	//  Status int, --1: còn, 0: hết
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}

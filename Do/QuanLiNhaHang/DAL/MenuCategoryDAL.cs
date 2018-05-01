using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class MenuCategoryDAL
    {
        // lấy danh sách category
        DatabaseConnect dbConnect = new DatabaseConnect();
        public DataTable getListCategory()
        {
            string query = "select * from MenuCategory";
            return dbConnect.GETdata(query);

        }

    }
}

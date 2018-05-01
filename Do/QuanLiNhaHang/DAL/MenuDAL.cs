using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class MenuDAL
    {
        DatabaseConnect dbConnect = new DatabaseConnect();
        // hiển thị menu theo category
        public DataTable getListMenuByIdCategory(int idCategory)
        {
            string query = String.Format("select * from Menu where IdCategory= {0}", idCategory);
            return dbConnect.GETdata(query);
        }
    }
}

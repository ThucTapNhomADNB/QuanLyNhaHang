using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiNhaHang.DAL
{
    class StatisDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS(DateTime date1, DateTime date2)
        {
            string query = string.Format("SELECT * FROM dbo.Bill WHERE DateCheckIn>={0} AND DateCheckIn<={1}", date1, date2);
            return dtConnect.GETdata(query);
        }
    }
}

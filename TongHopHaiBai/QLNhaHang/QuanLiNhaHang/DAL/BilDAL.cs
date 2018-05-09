using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class BilDAL
    {
        DatabaseConnect dbConnect = new DatabaseConnect();
        // them 1 bill vs ban
        public void insertBill(int idTable, DateTime d)
        {
            string query = String.Format("insert Bill(IdTable,DateCheckIn, Status) values ({0},'{1}',0)", idTable, d.ToShortDateString());
            dbConnect.ExecuteNonQuery(query);
        }
        // update total bill
        public void updateTotalBill(int id, int total)
        {
            string query = String.Format(" update Bill set Total ={1} where id ={0}", id, total);
            dbConnect.ExecuteNonQuery(query);
        }


        // binh

        public DataTable LoadDSByTime(DateTime date1, DateTime date2)
        {
            string query = string.Format("SELECT * FROM dbo.Bill WHERE DateCheckIn>='{0}' AND DateCheckIn<='{1}'", date1.ToShortDateString(), date2.ToShortDateString());
            return dbConnect.GETdata(query);
        }

    }
}

using QuanLiNhaHang.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class TableMenuDAL
    {
        DatabaseConnect dbConnect = new DatabaseConnect();
        public List<TableMenu> getDS(int TrangThai)
        {
            List<TableMenu> lsBan = new List<TableMenu>();
            return lsBan;
        }
        public DataTable getTableMenu ()
        {
            string query = "SELECT * FROM dbo.TableMenu";
            return dbConnect.GETdata(query);
        }
        public void insertTableMenu(TableMenu tb)
        {
            string query = string.Format("INSERT dbo.TableMenu(TableName, Status, Area) VALUES('{0}', {1}, '{2}')", tb.TableName, tb.Status, tb.Area);
            dbConnect.ExecuteNonQuery(query);
        }
    }
}

using QuanLiNhaHang.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class TableDAL
    {
        DatabaseConnect dbConnect = new DatabaseConnect();
       
        // lấy danh sách table từ csdl
        public List<Table> getListTable()
        {
            string query = "select * from TableMenu";
            DataTable data = dbConnect.GETdata(query);
            List<Table> lsTable = new List<Table>();
            // chọn từng dòng trong bảng dữ liệu
            foreach( DataRow item in data.Rows)
            {
                // bên class table đã khởi tạo contructor
                Table tb = new Table(item);
                lsTable.Add(tb);
            }
            return lsTable;
        }

        // hien thi danh sach ban trống

        public List<Table> getListTableEmpty()
        {
            string query = "select * from TableMenu";
            DataTable data = dbConnect.GETdata(query);
            List<Table> lsTable = new List<Table>();
            // chọn từng dòng trong bảng dữ liệu
            foreach (DataRow item in data.Rows)
            {
                
                // bên class table đã khởi tạo contructor
                Table tb = new Table(item);
                if(tb.Status==0) lsTable.Add(tb);
            }
            return lsTable;
        }
        // tra về một bảng với id cho  trước

        public Table getTableById(int id)
        {
           
            string query = "select * from TableMenu";
            DataTable data = dbConnect.GETdata(query);
            List<Table> lsTable = new List<Table>();
            // chọn từng dòng trong bảng dữ liệu
            foreach (DataRow item in data.Rows)
            {
                // bên class table đã khởi tạo contructor
                if( Convert.ToInt32(item.ItemArray[0].ToString() )== id)
                {
                    Table tb = new Table(item);
                    return tb;
                }  
            }
            return null;
        }

        // goi ham chuyen ban
        public void ChuyenBan(int idOldTable, int idNewTable)
        {
            string query = String.Format("chuyenban {0}, {1}", idOldTable, idNewTable);
            dbConnect.ExecuteNonQuery(query);
        }
        // goi proc thanh toan

        public void ThanhToan(int idTable , int idBill)
        {
            string query = string.Format("thanhToan {0},{1}", idTable, idBill);
            dbConnect.ExecuteNonQuery(query);
        }
             

    }
}

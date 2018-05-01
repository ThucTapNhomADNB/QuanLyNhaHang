using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhaHang.ENTITY;

namespace QuanLiNhaHang.DAL
{
    class MenuDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        

        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.Menu ";
            return dtConnect.GETdata(query);
        }
        
        public void insertMenu( Menu mn)
        {
            string query = string.Format("INSERT Menu ( Name, Price, Status) VALUES (N'{0}', N'{1}', N'{2}')", mn.Name, mn.Price, mn.Status);
            
            dtConnect.ExecuteNonQuery(query);
        }

        public void deleteMenu(int id)
        {
            string query = string.Format("DELETE dbo.Menu WHERE Id={0}", id);
            
            dtConnect.ExecuteNonQuery(query);
        }

        public void UpdateMenu(Menu mn)
        {
            string query = string.Format(" UPDATE  Menu SET Name = N'{0}', Price = '{1}', Status = N'{2}' WHERE Id = '{3}'", mn.Name, mn.Price, mn.Status, mn.Id);

            dtConnect.ExecuteNonQuery(query);
        }

        public DataTable searchMenu(string name)
        {
            string query = string.Format("SELECT * FROM Menu WHERE Name LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }
    }
}

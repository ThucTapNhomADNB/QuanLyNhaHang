using QuanLiNhaHang.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class MenuCateDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();


        public DataTable LoadDSCate()
        {
            string query = "SELECT * FROM  MenuCategory";
            return dtConnect.GETdata(query);
        }

        public void insertMenuCate(MenuCate mnc)
        {
            string query = string.Format("INSERT MenuCategory  VALUES (N'{0}')", mnc.Name);
            //DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnect.ExecuteNonQuery(query);
        }

        public void deleteMenuCate(int id)
        {
            string query = string.Format("DELETE MenuCategory WHERE Id={0}", id);
            //DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnect.ExecuteNonQuery(query);
        }

        public void UpdateMenuCate(MenuCate mnc)
        {
            string query = string.Format(" UPDATE MenuCategory SET Name = N'{1}' WHERE Id = '{0}'", mnc.Id, mnc.Name);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnect.ExecuteNonQuery(query);
        }

        public DataTable searchMenuCate(string name)
        {
            string query = string.Format("SELECT * FROM MenuCategory WHERE Name LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }
    }
}


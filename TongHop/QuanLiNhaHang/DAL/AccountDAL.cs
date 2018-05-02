using QuanLiNhaHang.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAL
{
    class AccountDAL
    {
        //************************an
        DatabaseConnect dtconnect = new DatabaseConnect();
        public DataTable GetAccount()
        {
            string query = "SELECT* FROM dbo.Account";
            return dtconnect.GETdata(query);
        }
        public void insertAcc(Account acc)
        {
            string query = string.Format("INSERT dbo.Account(Id, UserName, DisplayName, PassWords, type) value({0}, '{1}', '{2}', '{3}', {4})", acc.Id, acc.UserName, acc.DisplayName, acc.PassWord, acc.Type);
            dtconnect.ExecuteNonQuery(query);
        }
    }
}

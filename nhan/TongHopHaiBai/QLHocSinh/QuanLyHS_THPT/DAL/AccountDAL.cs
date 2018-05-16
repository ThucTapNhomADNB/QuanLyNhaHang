using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class AccountDAL
    {
        DatabaseConnect dtconnect = new DatabaseConnect();
        public DataTable getTableAcc()
        {
            string query = "SELECT*FROM dbo.ACCOUNT";
            return dtconnect.GETdata(query);
        }
        public void doiMatKhau(string username, string oldpassword, string newpassword)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET PASSWORD='{0}' WHERE USERNAME='{1}'AND PASSWORD='{2}'", newpassword, username, oldpassword);
            dtconnect.ExecuteNonQuery(query);
        }
        // them moi tai khoan

        public void InsertAcc(Account acc)
        {
            string query = string.Format("INSERT dbo.ACCOUNT( USERNAME,  PASSWORD,   PHANQUYEN ) VALUES( '{0}', '{1}', {2} )", acc.Usename,acc.Password,acc.PhanQuyen);
            dtconnect.ExecuteNonQuery(query);
        }


        // ma hoa password md5
        public string encodeMD5(string input)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            Console.WriteLine(sb.ToString());


            string output = sb.ToString();
            return output;
        }
    }
}

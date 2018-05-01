using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.ENTITY
{
    class Account
    {
        int id;
        string userName;
        string passWord;
        string displayName;
        int type;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return DisplayName1;
            }

            set
            {
                DisplayName1 = value;
            }
        }

        public string DisplayName1
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }
    }
}

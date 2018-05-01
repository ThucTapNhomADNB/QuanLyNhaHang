using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhaHang.ENTITY;
using QuanLiNhaHang.DAL;
namespace QuanLiNhaHang.GUI
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void btAddAccount_Click(object sender, EventArgs e)
        {
            int key=0;
            AccountDAL accDAL = new AccountDAL();
            DataTable dataacc = accDAL.GetAccount();
            Account acc = new Account();
            acc.DisplayName = tbdisplayname.Text;
            string filterExpression = string.Format("UserName='{0}'", tbUsername.Text);
            DataRow[] rows = dataacc.Select(filterExpression);
            if (rows.Length == 0)
            {
                acc.UserName = tbUsername.Text;
            }
            else
            {
                key++;
                lbloiusername.Text= "*Tên đăng nhập bị trùng";
            }
            if (tbPass.Text.Length >=8)
            {

            }
            else
            {
                key++;
                lbloipassword.Text = "*Mật khẩu it nhất 8 kí tự";
            }
            //check pass
            if(tbRepass.Text==tbPass.Text)
            {
                acc.PassWord = tbPass.Text;
            }
            else
            {
                key++;
                lbloirepassword.Text = "*Xác nhận mật khẩu không chính xác";
            }
            // kiem tra Phan quyen
            if (rbAdmin.Checked == true)
            {
                acc.Type = 1;
            }
            else
            {
                if (rbNhanVien.Checked == true)
                {
                    acc.Type = 0;
                }
                else
                {
                    lbloiphanquyen.Text = "Bạn chưa phân quyền tài khoản";
                }
            }
            if (key == 0)
            {
                accDAL.insertAcc(acc);
                lbnotice.Text = "Thêm tài khoản thành công";
            }
            else
            {
                lbnotice.Text = "Thêm tài khoản thất bại";
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int key = 0;
            TableMenuDAL tbmenuDAL = new TableMenuDAL();
            DataTable dtmenu = tbmenuDAL.getTableMenu();
            TableMenu tbmenu = new TableMenu();
            tbmenu.Area = cbxarea.SelectedItem.ToString();
            string filterExpression = string.Format("Area='{0}'", tbmenu.Area);
            DataRow[] rows = dtmenu.Select(filterExpression);
            if (rows.Length == 0)
            {
                tbmenu.TableName = tbtablename.Text;
            }
            else
            {
                key++;
                lbloitablename.Text = "*Tên bàn bị trùng";
            }
            tbmenu.Status = 0;
            if (key == 0)
            {
                tbmenuDAL.insertTableMenu(tbmenu);
                lbnotice1.Text = "Thêm bàn thành công";
            }
            else
            {
                lbnotice1.Text = "Thêm bàn thất bại";
            }
        }
    }
}

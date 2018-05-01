using QuanLiNhaHang.DAL;
using QuanLiNhaHang.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class FrmOrder : Form
    {
       
        Table table = new Table();
        int total = 0;
        public FrmOrder(int idtable)
        {

            InitializeComponent();

            TableDAL tbDAL = new TableDAL();
            this.table = tbDAL.getTableById(idtable);

            lbTableName.Text = this.table.TableName;
            loadTable();
            loadCategory();
            loadBill(this.table.Status);
        }

        //hiển thị danh sách bàn trống 
        public void loadTable()
        {
            TableDAL tableDAL = new TableDAL();
            cbTable.DataSource = tableDAL.getListTableEmpty();
            cbTable.DisplayMember = "TableName";
            cbTable.ValueMember = "id";

        }

        // hiển thị danh sách Category

        public void loadCategory()
        {
            MenuCategoryDAL cateDAL = new MenuCategoryDAL();
            cbMenuCategory.DataSource = cateDAL.getListCategory();
            cbMenuCategory.DisplayMember = "Name";
            cbMenuCategory.ValueMember = "Id";
            try
            {
                int idCategory = Convert.ToInt32(cbMenuCategory.SelectedValue.ToString());
                loadMenu(idCategory);
            }
            catch
            {

            }
        }

        // hien thi menu theo category

        public void loadMenu(int idCategory)
        {
            MenuDAL menuDAL = new MenuDAL();
            cbMenu.DataSource = menuDAL.getListMenuByIdCategory(idCategory);
            cbMenu.DisplayMember = "Name";
            cbMenu.ValueMember = "Id";
        }

        // hiển thị hóa đơn 
        public void loadBill(int id)
        {
            dgrBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillInfoDAL billInfoDAL = new BillInfoDAL();
            DataTable data= billInfoDAL.getBillInfoByIdBill(id);
            dgrBillInfo.DataSource = data;

            // hien thi tổng tiền hiện tại

            this.total = 0;
            foreach( DataRow row in data.Rows){
                this.total = total + Convert.ToInt32(row.ItemArray[4].ToString());
            }
            lbTotal.Text = total.ToString();
            // cap nhat lai tong tin hao don
            BilDAL billDAL = new BilDAL();
            billDAL.updateTotalBill(id, total);
        }


        // action button ChuyenBan
        private void btChuyenBan_Click(object sender, EventArgs e)
        {
            int idNewTable = Convert.ToInt32(cbTable.SelectedValue.ToString());
            TableDAL tableDAL = new TableDAL();
            tableDAL.ChuyenBan(this.table.Id, idNewTable);
            
           
            this.table = tableDAL.getTableById(idNewTable);
            lbTableName.Text = this.table.TableName;
        }


        // chon 1 mon trong ordel
        private void cbMenuCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCategory = Convert.ToInt32(cbMenuCategory.SelectedValue.ToString());

                loadMenu(idCategory);
            }
            catch
            {

            }
        }
        // check textbox so 
        public bool checkNumber(string str)
        {
            try
            {
                int d = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai", "Lỗi");
            }
            return false;
        }

        // action button them mon
        private void btThemMon_Click(object sender, EventArgs e)
        {
            int soLuong;
            int idMenu = Convert.ToInt32(cbMenu.SelectedValue.ToString());
            if (checkNumber(tbSoLuong.Text))
            {
                soLuong= Convert.ToInt32(tbSoLuong.Text);
                int idMenuSelect = Convert.ToInt32(cbMenu.SelectedValue.ToString());
                BillInfoDAL billInfoDAL = new BillInfoDAL();
                billInfoDAL.insertBillInfo(table.Status, idMenuSelect, soLuong);
                loadBill(this.table.Status);
            }
        }


        // select item in ordel
        private void dgrBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numberRow = e.RowIndex;
            

        }

        private void tbKhach_TextChanged(object sender, EventArgs e)
        {
            if (checkNumber(tbKhach.Text))
            {
                int money = Convert.ToInt32(tbKhach.Text);
                lbSoDu.Text = (money - this.total).ToString();
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

            MessageBox.Show( table.TableName+ " đã thanh toán số tiền là  : "+ total, "Thông báo");
            // gọi proc thanh toan 

            TableDAL tableDAL = new TableDAL();
            tableDAL.ThanhToan(this.table.Id, this.table.Status);
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrame frmMain = new MainFrame();
            frmMain.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }

}

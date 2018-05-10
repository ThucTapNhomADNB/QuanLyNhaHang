﻿using QuanLiNhaHang.DAL;
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
    public partial class FrmAdmin : Form
    {
        private int idCategory = 0;

        public FrmAdmin()
        {
            InitializeComponent();

            LoadMenuCate();     // load cb
            HienThiDSMenu();
            HienThiDSMenuCategory();
            HienthiDanhsachBan();
            HienThiDSNhanVien();
        }

        //Menu
        void HienThiDSMenu()
        {
            dgvmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                int idCate = Convert.ToInt16(cbMenuCate.SelectedValue.ToString());
                MenuDAL mnDAL = new MenuDAL();
                dgvmenu.DataSource = mnDAL.LoadDSMenuByCate(idCate);
                this.idCategory = idCate;
            }
            catch
            {

            }

        }



        private void btnxemmenu_Click(object sender, EventArgs e)
        {
            HienThiDSMenu();
        }

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

        private void LoadMenuCate()
        {
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();
            DataTable datacate = mncDAL.getListCategory();
            cbMenuCate.DataSource = datacate;
            cbMenuCate.DisplayMember = "Name";
            cbMenuCate.ValueMember = "Id";

        }

        private void cbMenuCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCate = Convert.ToInt16(cbMenuCate.SelectedValue.ToString());
                MenuDAL mnDAL = new MenuDAL();
                dgvmenu.DataSource = mnDAL.LoadDSMenuByCate(idCate);

                this.idCategory = idCate;
            }
            catch
            {

            }
        }

        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtMaMon.Text = dgvmenu.Rows[numRow].Cells[0].Value.ToString();
            txtTenMon.Text = dgvmenu.Rows[numRow].Cells[1].Value.ToString();
            txtGia.Text = dgvmenu.Rows[numRow].Cells[2].Value.ToString();
            string stt = dgvmenu.Rows[numRow].Cells[3].Value.ToString();
            if (stt == "Còn") rbCon.Checked = true;
            else if (stt == "Hết") rbHet.Checked = true;
        }



        private void btInsertThucDon_Click(object sender, EventArgs e)
        {
            int idCate = Convert.ToInt16(cbMenuCate.SelectedValue.ToString());
            ENTITY.Menu mn = new ENTITY.Menu();
            MenuDAL mnDAL = new MenuDAL();

            if (txtMaMon.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã món", " Lỗi ");
            }
            else
            {
                if (txtTenMon.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên món", " Lỗi ");
                }
                else
                {
                    mn.Name = txtTenMon.Text;

                    if (txtGia.TextLength == 0)
                    {
                        MessageBox.Show("Chưa nhập giá ", " Lỗi ");
                    }
                    else
                    {
                        mn.Price = Convert.ToInt32(txtGia.Text.ToString());
                        try
                        {
                            if (rbCon.Checked == false && rbHet.Checked == false)
                            {
                                MessageBox.Show("Chưa chọn tình trạng món ăn", " Lỗi ");
                            }
                            else
                            {
                                if (rbCon.Checked == true) mn.Status = "Còn";
                                else if (rbHet.Checked == true) mn.Status = "Hết";
                                mnDAL.insertMenu(mn);
                                dgvmenu.DataSource = mnDAL.LoadDSMenuByCate(idCate);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void btDeleteThucDon_Click(object sender, EventArgs e)
        {
            int idCate = Convert.ToInt16(cbMenuCate.SelectedValue.ToString());
            MenuDAL mnDAL = new MenuDAL();
            if (txtMaMon.TextLength == 0)
            {
                MessageBox.Show("Chưa có mã món", " Lỗi ");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt16(txtMaMon.Text);
                    if (MessageBox.Show("Bạn có chắc muốn xóa món?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        mnDAL.deleteMenu(id);
                        dgvmenu.DataSource = mnDAL.LoadDSMenuByCate(idCate);

                    }
                    else
                    {
                        MessageBox.Show(" Có lỗi khi xóa món", "Thông báo");
                    }

                }
                catch
                {
                    MessageBox.Show("Mã món không thỏa mãn", " Lỗi ");
                }

            }
        }

        private void btEditThucDon_Click(object sender, EventArgs e)
        {
            int idCate = Convert.ToInt16(cbMenuCate.SelectedValue.ToString());
            ENTITY.Menu mn = new ENTITY.Menu();
            mn.Id = Convert.ToInt16(txtMaMon.Text);
            MenuDAL mnDAL = new MenuDAL();

            if (txtMaMon.Text != mn.Id.ToString())
            {
                MessageBox.Show("Không được sửa mã món", " Lỗi ");
            }
            else
            {
                if (txtTenMon.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên món", " Lỗi ");
                }

                else
                {
                    mn.Name = txtTenMon.Text;
                    if (txtGia.TextLength == 0)
                    {
                        MessageBox.Show("Chưa nhập giá ", " Lỗi ");
                    }
                    else
                    {
                        mn.Price = Convert.ToInt32(txtGia.Text.ToString());

                        if (rbCon.Checked == false && rbHet.Checked == false)
                        {
                            MessageBox.Show("Chưa chọn tình trạng món ăn", " Lỗi ");
                        }
                        else
                        {
                            if (rbCon.Checked == true) mn.Status = "Còn";
                            else if (rbHet.Checked == true) mn.Status = "Hết";
                            mnDAL.UpdateMenu(mn);
                            dgvmenu.DataSource = mnDAL.LoadDSMenuByCate(idCate);
                        }
                    }
                }
            }
        }

        private void btSearchThucDon_Click(object sender, EventArgs e)
        {
            string searchtxt = txtSearchMenu.Text;
            MenuDAL mnDAL = new MenuDAL();
            dgvmenu.DataSource = mnDAL.searchMenu(searchtxt);
        }

        //MenuCategory
        private void HienThiDSMenuCategory()
        {
            dgvmenucate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();
            dgvmenucate.DataSource = mncDAL.getListCategory();
        }

        private void dgvmenucate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtmadm.Text = dgvmenucate.Rows[numRow].Cells[0].Value.ToString();
            txttendm.Text = dgvmenucate.Rows[numRow].Cells[1].Value.ToString();
        }

        // them danh muc
        private void btnthemdm_Click(object sender, EventArgs e)
        {
            ENTITY.MenuCategory mnc = new ENTITY.MenuCategory();
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();

            if (txtmadm.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã danh mục", " Lỗi ");
            }
            else
            {
                if (txttendm.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên danh mục", " lỗi ");
                }
                else
                {
                    mnc.Name = txttendm.Text;
                    mncDAL.insertMenuCate(mnc);
                    dgvmenucate.DataSource = mncDAL.getListCategory();

                }
            }
        }


        // xoa danh muc
        private void btnXoadm_Click(object sender, EventArgs e)
        {
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();
            if (txtmadm.TextLength == 0)
            {
                MessageBox.Show("Chưa có mã danh mục", " Lỗi ");
            }
            else
            {
                try

                {
                    int Id = Convert.ToInt16(txtmadm.Text);
                    if (MessageBox.Show("Bạn có chắc muốn xóa món?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        mncDAL.deleteMenuCate(Id);
                        dgvmenucate.DataSource = mncDAL.getListCategory();
                    }
                    else
                    {
                        MessageBox.Show(" Có lỗi khi xóa món", "Thông báo");
                    }

                }
                catch
                {
                    MessageBox.Show("Mã danh mục không thỏa mãn", " Lỗi ");
                }

            }
        }


        // sua danh muc
        private void btnSuadm_Click(object sender, EventArgs e)
        {
            ENTITY.MenuCategory mnc = new ENTITY.MenuCategory();
            mnc.Id = Convert.ToInt16(txtmadm.Text);
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();

            if (txtmadm.Text != mnc.Id.ToString())
            {
                MessageBox.Show("Không được sửa mã danh mục", " Lỗi ");
            }
            else
            {
                if (txttendm.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên danh mục", " lỗi ");
                }
                else
                {
                    mnc.Name = txttendm.Text;
                    mncDAL.UpdateMenuCate(mnc);
                    dgvmenucate.DataSource = mncDAL.getListCategory();
                }


            }

        }


        //  nut tim kiem
        private void btntimkiemdm_Click(object sender, EventArgs e)
        {
            string searchtxt = txtSearchMenu.Text;
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();
            dgvmenu.DataSource = mncDAL.searchMenuCate(searchtxt);
        }

        private void txtSearchMenu_TextChanged(object sender, EventArgs e)
        {
            string searchtxt = txtSearchMenu.Text;
            MenuCategoryDAL mncDAL = new MenuCategoryDAL();
            dgvmenu.DataSource = mncDAL.searchMenuCate(searchtxt);
        }

        //***********************************************************
        // an 

        private void tabBan_Click(object sender, EventArgs e)
        {
            HienthiDanhsachBan();
            tbid.Enabled = false;
        }
        public void HienthiDanhsachBan()
        {
            dgvtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableDAL tbmenuDAL = new TableDAL();
            dgvtable.DataSource = tbmenuDAL.getTableMenu();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int key = 0;
            TableDAL tbmenuDAL = new TableDAL();
            DataTable dtmenu = tbmenuDAL.getTableMenu();
            Table tbmenu = new Table();
            if (tbArea.TextLength != 0)
            {
                tbmenu.Area = tbArea.Text;
            }
            else
            {
                key++;
                lbloiArea.Text = "Chưa Nhập Khu Vực";
            }
            DataTable tbmenu_Area = tbmenuDAL.getTableMenu(tbmenu.Area);
            string filterExpression = string.Format("TableName='{0}'", tbtablename.Text);
            DataRow[] rows = tbmenu_Area.Select(filterExpression);
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
                dgvtable.DataSource = tbmenuDAL.getTableMenu();
            }
            else
            {
                lbnotice1.Text = "Thêm bàn thất bại";
            }
        }

        private void dgvtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Enabled = true;
            int numRow;
            numRow = e.RowIndex;
            tbid.Text = dgvtable.Rows[numRow].Cells[0].Value.ToString();
            tbArea.Text = dgvtable.Rows[numRow].Cells[3].Value.ToString();
            tbtablename.Text = dgvtable.Rows[numRow].Cells[1].Value.ToString();
            tbstatus.Text = dgvtable.Rows[numRow].Cells[2].Value.ToString();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            int key = 0;
            TableDAL tbmenuDAL = new TableDAL();
            DataTable dtmenu = tbmenuDAL.getTableMenu();
            Table tbmenu = new Table();
            if (tbArea.TextLength != 0)
            {
                tbmenu.Area = tbArea.Text;
            }
            else
            {
                key++;
                lbloiArea.Text = "Chưa Nhập Khu Vực";
            }
            DataTable tbmenu_Area = tbmenuDAL.getTableMenu(tbmenu.Area);
            string filterExpression = string.Format("TableName='{0}'", tbtablename.Text);
            DataRow[] rows = tbmenu_Area.Select(filterExpression);
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
                lbnotice1.Text = "sửa thành công";
                dgvtable.DataSource = tbmenuDAL.getTableMenu();
            }
            else
            {
                lbnotice1.Text = "sửa thất bại";
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TableDAL tbmenuDAL = new TableDAL();
            DataTable dtmenu = tbmenuDAL.getTableMenu();
            Table tbmenu = new Table();
            try
            {
                int id = Convert.ToInt16(tbid.Text);
                tbmenuDAL.deleteTableMenu(id);
                dgvtable.DataSource = tbmenuDAL.getTableMenu();
            }
            catch
            {
                MessageBox.Show("ma ban khong thoa man", " loi ");
            }
        }

        // ****************************************************************************

        // Binh

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dvwTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BilDAL billDAL = new BilDAL();
            DataTable data = billDAL.LoadDSByTime(Convert.ToDateTime(dtFrom.Value), Convert.ToDateTime(dtTo.Value));
            dvwTotal.DataSource = data;
            int total = 0;

            foreach (DataRow row in data.Rows)
            {
                total += Convert.ToInt32(row.ItemArray[4].ToString());
            }
            lblTotal.Text = total.ToString();

        }

        private void tabAccount_Click(object sender, EventArgs e)
        {

        }

        //*****************************************************************************


        // hien thi danh sach nhan vien
        public void HienThiDSNhanVien()
        {
            dgvtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeDAL empDAL = new EmployeeDAL();
            dgvEmployee.DataSource = empDAL.getListEmployee();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtIdEmployee.Text = dgvEmployee.Rows[numRow].Cells[0].Value.ToString();
            txtNamEmployee.Text = dgvEmployee.Rows[numRow].Cells[1].Value.ToString();
            txtAddressEmployee.Text = dgvEmployee.Rows[numRow].Cells[2].Value.ToString();
            txtAgeEmployee.Text = dgvEmployee.Rows[numRow].Cells[3].Value.ToString();
            txtPhoneNumberEmployee.Text = dgvEmployee.Rows[numRow].Cells[4].Value.ToString();
        }


        private void btInsertEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (txtIdEmployee.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã nhân viên", " Lỗi ");
            }
            else
            {
                if (txtNamEmployee.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên nhân viên", " Lỗi ");
                }
                else
                {
                    emp.Name = txtNamEmployee.Text;

                    if (txtAddressEmployee.TextLength == 0)
                    {
                        MessageBox.Show("Chưa nhập địa chỉ ", " Lỗi ");
                    }
                    else
                    {
                        emp.Address = txtAddressEmployee.Text;
                        if (!checkNumber(txtAgeEmployee.Text))
                        {
                            MessageBox.Show("Nhập sai  tuổi ", " Lỗi ");

                        }
                        else
                        {
                            emp.Age = Convert.ToInt32(txtAgeEmployee.Text);
                            if (txtPhoneNumberEmployee.TextLength == 0)
                            {
                                MessageBox.Show("Chưa nhập số điện thoại ", " Lỗi ");
                            }
                            else
                            {
                                emp.PhoneNumber = txtPhoneNumberEmployee.Text;
                                EmployeeDAL empDAL = new EmployeeDAL();
                                empDAL.insertEmployee(emp);
                                HienThiDSNhanVien();
                            }
                        }








                    }
                }

            }
        }

        private void btEditEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (!checkNumber(txtIdEmployee.Text))
            {
                MessageBox.Show("mã nhân viên bị lỗi", " Lỗi ");
            }
            else
            {
                emp.Id = Convert.ToInt32(txtIdEmployee.Text);
                if (txtNamEmployee.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên nhân viên", " Lỗi ");
                }
                else
                {
                    emp.Name = txtNamEmployee.Text;

                    if (txtAddressEmployee.TextLength == 0)
                    {
                        MessageBox.Show("Chưa nhập địa chỉ ", " Lỗi ");
                    }
                    else
                    {
                        emp.Address = txtAddressEmployee.Text;
                        if (!checkNumber(txtAgeEmployee.Text))
                        {
                            MessageBox.Show("Nhập sai  tuổi ", " Lỗi ");

                        }
                        else
                        {
                            emp.Age = Convert.ToInt32(txtAgeEmployee.Text);
                            if (txtPhoneNumberEmployee.TextLength == 0)
                            {
                                MessageBox.Show("Chưa nhập số điện thoại ", " Lỗi ");
                            }
                            else
                            {
                                emp.PhoneNumber = txtPhoneNumberEmployee.Text;
                                EmployeeDAL empDAL = new EmployeeDAL();
                                empDAL.editEmployee(emp);
                                HienThiDSNhanVien();
                            }
                        }

                    }
                }
            }
        }

        private void btDeleteEmployee_Click(object sender, EventArgs e)
        {
            int Id;
            if (!checkNumber(txtIdEmployee.Text))
            {
                MessageBox.Show("mã nhân viên bị lỗi", " Lỗi ");
            }
            else
            {
                Id = Convert.ToInt32(txtIdEmployee.Text);
                EmployeeDAL empDAL = new EmployeeDAL();
                empDAL.deleteEmployee(Id);
                HienThiDSNhanVien();
            }
        }

        private void btCapTaiKhoan_Click(object sender, EventArgs e)
        {
            int Id;
            EmployeeDAL empDAL = new EmployeeDAL();
            
            if (!checkNumber(txtIdEmployee.Text))
            {
                MessageBox.Show("mã nhân viên bị lỗi", " Lỗi ");
            }
            else
            {
                Id = Convert.ToInt32(txtIdEmployee.Text);
                if (empDAL.CheckHaveAccount(Id))
                {
                    FrmCapTaiKhoan frmCapTaiKhoan = new FrmCapTaiKhoan(Id);
                    frmCapTaiKhoan.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã có tài khoản", " Lỗi ");
                }
            }


            
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string nameEmployee = txtSearchEmployee.Text;
            EmployeeDAL empDAL = new EmployeeDAL();
            dgvEmployee.DataSource = empDAL.searchEmployee(nameEmployee);
        }
    }
}

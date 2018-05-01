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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            HienThiDSMenu();
            HienThiDSMenuCategory();
            //LoadCate();
        }

        //Menu
        void HienThiDSMenu()
        {
            dgvmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MenuDAL mnDAL = new MenuDAL();
            dgvmenu.DataSource = mnDAL.LoadDS();

        }


        private void btInsertThucDon_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void lbNameMonAn_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaMonAn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
        private void dgvmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtMaMon.Text = dgvmenu.Rows[numRow].Cells[0].Value.ToString();
            txtTenMon.Text = dgvmenu.Rows[numRow].Cells[1].Value.ToString();
            txtGia.Text = dgvmenu.Rows[numRow].Cells[2].Value.ToString();
            string stt = dgvmenu.Rows[numRow].Cells[3].Value.ToString();
            if (stt == "Còn") rbCon.Checked = true;
            else if (stt == "Hết") rbHet.Checked = true;
            HienThiDSMenu();
        }

        private void btInsertThucDon_Click_1(object sender, EventArgs e)
        {
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
                        mn.Price = Convert.ToInt16(txtGia.Text);
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
                                dgvmenu.DataSource = mnDAL.LoadDS();
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
                    mnDAL.deleteMenu(id);
                    dgvmenu.DataSource = mnDAL.LoadDS();
                }
                catch
                {
                    MessageBox.Show("Mã món không thỏa mãn", " Lỗi ");
                }

            }
        }

        private void btEditThucDon_Click(object sender, EventArgs e)
        {
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
                        mn.Price = Convert.ToInt16(txtGia.Text);
                        if (rbCon.Checked == false && rbHet.Checked == false)
                        {
                            MessageBox.Show("Chưa chọn tình trạng món ăn", " Lỗi ");
                        }
                        else
                        {
                            if (rbCon.Checked == true) mn.Status = "Còn";
                            else if (rbHet.Checked == true) mn.Status = "Hết";
                            mnDAL.UpdateMenu(mn);
                            dgvmenu.DataSource = mnDAL.LoadDS();
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
            MenuCateDAL mncDAL = new MenuCateDAL();
            dgvmenucate.DataSource = mncDAL.LoadDSCate();
        }

        //public void LoadCate()
        //{
        //    MenuCateDAL mncDAL = new MenuCateDAL();
        //    DataTable datacate = mncDAL.LoadDSCate();
        //    cbtendm.DataSource = datacate;
        //    cbtendm.DisplayMember = "Name";
        //    cbtendm.ValueMember = "Id";
        //}

        private void dgvmenucate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtmadm.Text = dgvmenucate.Rows[numRow].Cells[0].Value.ToString();
            txttendm.Text = dgvmenucate.Rows[numRow].Cells[1].Value.ToString();
            //if (dgvmenucate.Rows[numRow].Cells[1].Value.ToString() != "")
            //{
            //    int Id = Convert.ToInt32(dgvmenucate.Rows[numRow].Cells[1].Value.ToString());
            //    cbtendm.SelectedValue = Id;
            //}
            //HienThiDSMenuCategory();

        }

        private void btnthemdm_Click(object sender, EventArgs e)
        {
            ENTITY.MenuCate mnc = new ENTITY.MenuCate();
            MenuCateDAL mncDAL = new MenuCateDAL();

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
                    dgvmenucate.DataSource = mncDAL.LoadDSCate();

                }
                //try
                //{
                //    int Id = Convert.ToInt16(cbtendm.SelectedValue.ToString());
                //    mnc.Id = Id;
                //    mncDAL.insertMenuCate(mnc);
                //    dgvmenucate.DataSource = mncDAL.LoadDSCate();
                //}
                //catch
                //{

                //}
            }
        }

        private void btnXoadm_Click(object sender, EventArgs e)
        {
            MenuCateDAL mncDAL = new MenuCateDAL();
            if (txtmadm.TextLength == 0)
            {
                MessageBox.Show("Chưa có mã danh mục", " Lỗi ");
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt16(txtmadm.Text);
                    mncDAL.deleteMenuCate(Id);
                    dgvmenucate.DataSource = mncDAL.LoadDSCate();
                }
                catch
                {
                    MessageBox.Show("Mã danh mục không thỏa mãn", " Lỗi ");
                }

            }
        }

        private void btnSuadm_Click(object sender, EventArgs e)
        {
            ENTITY.MenuCate mnc = new ENTITY.MenuCate();
            mnc.Id = Convert.ToInt16(txtmadm.Text);
            MenuCateDAL mncDAL = new MenuCateDAL();

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
                    dgvmenucate.DataSource = mncDAL.LoadDSCate();
                }
                //try
                //{
                //    int Id = Convert.ToInt16(cbtendm.SelectedValue.ToString());
                //    mnc.Id = Id;
                //    mncDAL.UpdateMenuCate(mnc);
                //    dgvmenucate.DataSource = mncDAL.LoadDSCate();
                //}
                //catch
                //{

                //}

            }
           
        }

        private void btntimkiemdm_Click(object sender, EventArgs e)
        {
            string searchtxt = txtSearchMenu.Text;
            MenuCateDAL mncDAL = new MenuCateDAL();
            dgvmenu.DataSource = mncDAL.searchMenuCate(searchtxt);
        }
    }
}


     
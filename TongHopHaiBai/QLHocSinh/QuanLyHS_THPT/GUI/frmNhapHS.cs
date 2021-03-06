﻿using QuanLyHS_THPT.DAL;
using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHS_THPT.GUI
{
    public partial class frmNhapHS : Form
    {
        public frmNhapHS()
        {
            InitializeComponent();
            HienThiDSHocSinh();
            LoadLop();
        }
        private void LoadLop()
        {
            LopDAL LOPdal = new LopDAL();
            DataTable dataLop = LOPdal.LoadDS();
            cbLop.DataSource = dataLop;
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";

        }

        private void frmNhapHS_Load(object sender, EventArgs e)
        {

        }
        private void HienThiDSHocSinh()
        {
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HocSinhDAL hsDAL = new HocSinhDAL();
            dgvHocSinh.DataSource = hsDAL.LoadDS();
        }
        private void HienThiDSLop()
        {
            try
            {
                int maHS= Convert.ToInt32(tbMaHs.Text); 
                dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                HocSinhDAL hsDAL = new HocSinhDAL();
                dgvLop.DataSource = hsDAL.getDSLop(maHS);
            }
            catch
            {

            }

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            tbMaHs.Text = dgvHocSinh.Rows[numRow].Cells[0].Value.ToString();
            tbHoTen.Text = dgvHocSinh.Rows[numRow].Cells[1].Value.ToString();
            string gt= dgvHocSinh.Rows[numRow].Cells[2].Value.ToString();
            if (gt == "Nam") rbNam.Checked = true;
            else if (gt == "Nữ") rbNu.Checked = true;
            dtpNgaySinh.Value = Convert.ToDateTime(dgvHocSinh.Rows[numRow].Cells[3].Value);
            tbNoiSinh.Text = dgvHocSinh.Rows[numRow].Cells[4].Value.ToString();
            tbDanToc.Text = dgvHocSinh.Rows[numRow].Cells[5].Value.ToString();
            tbTonGiao.Text = dgvHocSinh.Rows[numRow].Cells[6].Value.ToString();
            HienThiDSLop();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            HocSinhDAL hsDAL = new HocSinhDAL();
            
            if(tbMaHs.TextLength != 0)
            {
                MessageBox.Show("Khong can nhap ma hoc sinh", " Lỗi ");
            }
            else
            {
                if (tbHoTen.TextLength ==0)
                {
                    MessageBox.Show("Chua nhap ho ten hoc sinh", " Lỗi ");
                }
                else
                {
                    hs.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " Lỗi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) hs.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) hs.GioiTinh = "Nữ";
                        hs.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Value);

                        if (tbNoiSinh.TextLength == 0)
                        {
                            MessageBox.Show("Chua nhap noi sinh ", " Lỗi ");
                        }
                        else
                        {
                            hs.NoiSinh = tbNoiSinh.Text;
                            if (tbDanToc.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap dan toc", " Lỗi ");
                            }
                            else
                            {
                                hs.DanToc = tbDanToc.Text;
                                if (tbTonGiao.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap ton giao", " Lỗi ");
                                }
                                else
                                {
                                    hs.TonGiao = tbTonGiao.Text;
                                    hsDAL.insertHocSinh(hs);
                                    dgvHocSinh.DataSource = hsDAL.LoadDS();
                                }
                            }
                        }
                    } //                            
                 }
              }
            

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            HocSinhDAL hsDAL = new HocSinhDAL();
            if (tbMaHs.TextLength == 0)
            {
                MessageBox.Show("Chua co ma hoc sinh", " Lỗi ");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt16(tbMaHs.Text);
                    hsDAL.deleteHocSinh(id);
                    dgvHocSinh.DataSource = hsDAL.LoadDS();
                }
                catch
                {
                    MessageBox.Show("ma hoc sinh khong thoa man", " Lỗi ");
                }

            }
         }

        private void btSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.MaHocSinh = Convert.ToInt32(tbMaHs.Text);
            HocSinhDAL hsDAL = new HocSinhDAL();

            if (tbMaHs.Text != hs.MaHocSinh.ToString())
            {
                MessageBox.Show("Khong duoc sua ma hoc sinh", " Lỗi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chua nhap ho ten hoc sinh", " Lỗi ");
                }
                else
                {
                    hs.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " Lỗi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) hs.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) hs.GioiTinh = "Nữ";
                        hs.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Value);

                        if (tbNoiSinh.TextLength == 0)
                        {
                            MessageBox.Show("Chua nhap noi sinh ", " Lỗi ");
                        }
                        else
                        {
                            hs.NoiSinh = tbNoiSinh.Text;
                            if (tbDanToc.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap dan toc", " Lỗi ");
                            }
                            else
                            {
                                hs.DanToc = tbDanToc.Text;
                                if (tbTonGiao.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap ton giao", " Lỗi ");
                                }
                                else
                                {
                                    hs.TonGiao = tbTonGiao.Text;
                                    hsDAL.SuaHocSinh(hs);
                                    dgvHocSinh.DataSource = hsDAL.LoadDS();
                                }
                            }
                        }
                    }
                }
            }

        }

        



        private void tbTimKIem_TextChanged(object sender, EventArgs e)
        {
            string searchtxt = tbTimKIem.Text;
            HocSinhDAL hsDAL = new HocSinhDAL();
            dgvHocSinh.DataSource = hsDAL.searchHS(searchtxt);
        }

        private void btThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                int maHS= Convert.ToInt32(tbMaHs.Text);
                int maLop = Convert.ToInt16(cbLop.SelectedValue.ToString());
                HocSinhDAL hsDAL = new HocSinhDAL();
                hsDAL.ThemHSLop(maHS, maLop);
                HienThiDSLop();
            }
            catch
            {

            }
        }
        int idLop;
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            idLop = Convert.ToInt32(dgvLop.Rows[numRow].Cells[0].Value.ToString());
        }
        private void btXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                int maHS = Convert.ToInt32(tbMaHs.Text);
                HocSinhDAL hsDAL = new HocSinhDAL();
                hsDAL.XoaHSLop(maHS, idLop);
                HienThiDSLop();
            }
            catch
            {

            }

        }
        
    }
}

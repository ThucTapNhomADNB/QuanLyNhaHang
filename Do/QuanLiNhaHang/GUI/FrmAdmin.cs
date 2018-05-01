using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhaHang.DAL;
using QuanLiNhaHang.ENTITY;

namespace QuanLiNhaHang.GUI
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dvwTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StatisDAL stDAL = new StatisDAL();
            dvwTotal.DataSource = stDAL.LoadDS(dtFrom.Value, dtTo.Value);
            int total = 0;
            foreach (DataRow row in dvwTotal.Rows)
            {
                total += Convert.ToInt32(row.ItemArray[4].ToString());
            }
            lblTotal.Text = total.ToString();
        }
    }
}

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
    public partial class FrmStatis : Form
    {
        public FrmStatis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ThongKe()
        {
            dvwTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StatisDAL stDAL = new StatisDAL();
            dvwTotal.DataSource = stDAL.LoadDS(DtFrom.Value, DtTo.Value);
            int total = 0;
            foreach(DataRow row in dvwTotal.Rows)
            {
                total += Convert.ToInt32(row.ItemArray[4].ToString());
            }
            txtTotal.Text = total.ToString();
        }
    }
}

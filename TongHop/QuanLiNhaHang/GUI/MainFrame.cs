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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            LoadTable();
        }

        public void LoadTable()
        {
            TableDAL tbDAL = new TableDAL();
            List<Table> lsTable = tbDAL.getListTable();
            foreach (Table table in lsTable)
            {
                Button bt = new Button() { Width = 100, Height = 100 };
                bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;   // tu zoom image
                bt.Text = table.TableName;
                bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          

                if (table.Status == 0)
                {
                    bt.BackgroundImage = Image.FromFile(Application.StartupPath + "\\IMAGE\\table0.png");
                }
                else
                {
                    bt.BackgroundImage = Image.FromFile(Application.StartupPath + "\\IMAGE\\table1.png");
                }

                bt.Tag = table;
                bt.Click += btTable_Click;
               
                flpTable.Controls.Add(bt);
            }
        }
        private void btTable_Click(object sender, EventArgs e)
        {
            Table tb = (sender as Button).Tag as Table;
            if(tb.Status == 0)
            {
                BilDAL billDAL = new BilDAL();
                string dt = DateTime.Today.ToString().Trim();
                DateTime d = Convert.ToDateTime(dt);
               
                
                billDAL.insertBill(tb.Id, d);
                TableDAL tableDAL = new TableDAL();
                tb = tableDAL.getTableById(tb.Id);
            }

            this.Hide();
            FrmOrder frOrder = new FrmOrder(tb.Id);
            
            frOrder.ShowDialog();
        }

        private void trangADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.ShowDialog();
        }
    }
}

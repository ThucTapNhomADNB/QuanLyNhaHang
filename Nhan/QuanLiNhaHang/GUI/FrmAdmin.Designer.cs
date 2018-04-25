namespace QuanLiNhaHang.GUI
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabThucDon = new System.Windows.Forms.TabPage();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btSearchThucDon = new System.Windows.Forms.Button();
            this.txtSearchMenu = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btDeleteThucDon = new System.Windows.Forms.Button();
            this.btEditThucDon = new System.Windows.Forms.Button();
            this.btInsertThucDon = new System.Windows.Forms.Button();
            this.pannelViewThucDon = new System.Windows.Forms.Panel();
            this.ViewThucDon = new System.Windows.Forms.DataGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.cbTinhTrangMonAn = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lbGiaMonAn = new System.Windows.Forms.Label();
            this.lbTinhTrangMonAn = new System.Windows.Forms.Label();
            this.lbNameMonAn = new System.Windows.Forms.Label();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.pnThongKeView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnThongKeChucNang = new System.Windows.Forms.Panel();
            this.btThongKe = new System.Windows.Forms.Button();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbThongKe3 = new System.Windows.Forms.Label();
            this.lbThongKe2 = new System.Windows.Forms.Label();
            this.lbThongke1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btAddAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.tbRepass = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbTaikhoan4 = new System.Windows.Forms.Label();
            this.lbTaikhoan3 = new System.Windows.Forms.Label();
            this.lbTaikhoan8 = new System.Windows.Forms.Label();
            this.lbTaikhoan7 = new System.Windows.Forms.Label();
            this.lbTaikhoan6 = new System.Windows.Forms.Label();
            this.lbTaikhoan5 = new System.Windows.Forms.Label();
            this.lbTaikhoan2 = new System.Windows.Forms.Label();
            this.lbTaiKhoan1 = new System.Windows.Forms.Label();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.tabAdmin.SuspendLayout();
            this.tabThucDon.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.pannelViewThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewThucDon)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.pnThongKeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnThongKeChucNang.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabThucDon);
            this.tabAdmin.Controls.Add(this.tabDanhMuc);
            this.tabAdmin.Controls.Add(this.tabBan);
            this.tabAdmin.Controls.Add(this.tabDoanhThu);
            this.tabAdmin.Controls.Add(this.tabAccount);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1179, 567);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabThucDon
            // 
            this.tabThucDon.Controls.Add(this.panelSearch);
            this.tabThucDon.Controls.Add(this.panelButton);
            this.tabThucDon.Controls.Add(this.pannelViewThucDon);
            this.tabThucDon.Controls.Add(this.panelEdit);
            this.tabThucDon.Location = new System.Drawing.Point(4, 25);
            this.tabThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabThucDon.Name = "tabThucDon";
            this.tabThucDon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabThucDon.Size = new System.Drawing.Size(1171, 538);
            this.tabThucDon.TabIndex = 0;
            this.tabThucDon.Text = "Thực đơn";
            this.tabThucDon.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.btSearchThucDon);
            this.panelSearch.Controls.Add(this.txtSearchMenu);
            this.panelSearch.Location = new System.Drawing.Point(403, 9);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(764, 70);
            this.panelSearch.TabIndex = 3;
            // 
            // btSearchThucDon
            // 
            this.btSearchThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btSearchThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchThucDon.Location = new System.Drawing.Point(523, 17);
            this.btSearchThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearchThucDon.Name = "btSearchThucDon";
            this.btSearchThucDon.Size = new System.Drawing.Size(113, 42);
            this.btSearchThucDon.TabIndex = 1;
            this.btSearchThucDon.Text = "Tìm kiếm";
            this.btSearchThucDon.UseVisualStyleBackColor = false;
            // 
            // txtSearchMenu
            // 
            this.txtSearchMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMenu.Location = new System.Drawing.Point(132, 23);
            this.txtSearchMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(355, 30);
            this.txtSearchMenu.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.Controls.Add(this.btDeleteThucDon);
            this.panelButton.Controls.Add(this.btEditThucDon);
            this.panelButton.Controls.Add(this.btInsertThucDon);
            this.panelButton.Location = new System.Drawing.Point(9, 6);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(385, 74);
            this.panelButton.TabIndex = 2;
            // 
            // btDeleteThucDon
            // 
            this.btDeleteThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btDeleteThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteThucDon.Location = new System.Drawing.Point(296, 6);
            this.btDeleteThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeleteThucDon.Name = "btDeleteThucDon";
            this.btDeleteThucDon.Size = new System.Drawing.Size(67, 62);
            this.btDeleteThucDon.TabIndex = 2;
            this.btDeleteThucDon.Text = "Xóa";
            this.btDeleteThucDon.UseVisualStyleBackColor = false;
            // 
            // btEditThucDon
            // 
            this.btEditThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btEditThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditThucDon.Location = new System.Drawing.Point(159, 6);
            this.btEditThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEditThucDon.Name = "btEditThucDon";
            this.btEditThucDon.Size = new System.Drawing.Size(67, 62);
            this.btEditThucDon.TabIndex = 1;
            this.btEditThucDon.Text = "Sửa";
            this.btEditThucDon.UseVisualStyleBackColor = false;
            // 
            // btInsertThucDon
            // 
            this.btInsertThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btInsertThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertThucDon.Location = new System.Drawing.Point(17, 6);
            this.btInsertThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInsertThucDon.Name = "btInsertThucDon";
            this.btInsertThucDon.Size = new System.Drawing.Size(67, 62);
            this.btInsertThucDon.TabIndex = 0;
            this.btInsertThucDon.Text = "Thêm";
            this.btInsertThucDon.UseVisualStyleBackColor = false;
            this.btInsertThucDon.Click += new System.EventHandler(this.btInsertThucDon_Click);
            // 
            // pannelViewThucDon
            // 
            this.pannelViewThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelViewThucDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pannelViewThucDon.BackColor = System.Drawing.Color.DimGray;
            this.pannelViewThucDon.Controls.Add(this.ViewThucDon);
            this.pannelViewThucDon.Location = new System.Drawing.Point(404, 92);
            this.pannelViewThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelViewThucDon.Name = "pannelViewThucDon";
            this.pannelViewThucDon.Size = new System.Drawing.Size(780, 439);
            this.pannelViewThucDon.TabIndex = 1;
            // 
            // ViewThucDon
            // 
            this.ViewThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewThucDon.Location = new System.Drawing.Point(4, 0);
            this.ViewThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewThucDon.Name = "ViewThucDon";
            this.ViewThucDon.Size = new System.Drawing.Size(748, 428);
            this.ViewThucDon.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelEdit.Controls.Add(this.txtMaMon);
            this.panelEdit.Controls.Add(this.lblMaMon);
            this.panelEdit.Controls.Add(this.cbTinhTrangMonAn);
            this.panelEdit.Controls.Add(this.txtGia);
            this.panelEdit.Controls.Add(this.txtTenMon);
            this.panelEdit.Controls.Add(this.lbGiaMonAn);
            this.panelEdit.Controls.Add(this.lbTinhTrangMonAn);
            this.panelEdit.Controls.Add(this.lbNameMonAn);
            this.panelEdit.Location = new System.Drawing.Point(11, 92);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(385, 443);
            this.panelEdit.TabIndex = 0;
            // 
            // cbTinhTrangMonAn
            // 
            this.cbTinhTrangMonAn.FormattingEnabled = true;
            this.cbTinhTrangMonAn.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbTinhTrangMonAn.Location = new System.Drawing.Point(56, 395);
            this.cbTinhTrangMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTinhTrangMonAn.Name = "cbTinhTrangMonAn";
            this.cbTinhTrangMonAn.Size = new System.Drawing.Size(253, 24);
            this.cbTinhTrangMonAn.TabIndex = 5;
            this.cbTinhTrangMonAn.Text = "Còn hàng";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(59, 273);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(253, 30);
            this.txtGia.TabIndex = 4;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(56, 174);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(253, 30);
            this.txtTenMon.TabIndex = 3;
            // 
            // lbGiaMonAn
            // 
            this.lbGiaMonAn.AutoSize = true;
            this.lbGiaMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaMonAn.Location = new System.Drawing.Point(55, 228);
            this.lbGiaMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaMonAn.Name = "lbGiaMonAn";
            this.lbGiaMonAn.Size = new System.Drawing.Size(102, 23);
            this.lbGiaMonAn.TabIndex = 2;
            this.lbGiaMonAn.Text = "Giá( VND)";
            this.lbGiaMonAn.Click += new System.EventHandler(this.lbGiaMonAn_Click);
            // 
            // lbTinhTrangMonAn
            // 
            this.lbTinhTrangMonAn.AutoSize = true;
            this.lbTinhTrangMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangMonAn.Location = new System.Drawing.Point(55, 351);
            this.lbTinhTrangMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTinhTrangMonAn.Name = "lbTinhTrangMonAn";
            this.lbTinhTrangMonAn.Size = new System.Drawing.Size(99, 23);
            this.lbTinhTrangMonAn.TabIndex = 1;
            this.lbTinhTrangMonAn.Text = "Tình trạng";
            // 
            // lbNameMonAn
            // 
            this.lbNameMonAn.AutoSize = true;
            this.lbNameMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMonAn.Location = new System.Drawing.Point(52, 116);
            this.lbNameMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameMonAn.Name = "lbNameMonAn";
            this.lbNameMonAn.Size = new System.Drawing.Size(82, 23);
            this.lbNameMonAn.TabIndex = 0;
            this.lbNameMonAn.Text = "Tên món";
            this.lbNameMonAn.Click += new System.EventHandler(this.lbNameMonAn_Click);
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.pnThongKeView);
            this.tabDoanhThu.Controls.Add(this.pnThongKeChucNang);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tabDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoanhThu.Size = new System.Drawing.Size(1171, 538);
            this.tabDoanhThu.TabIndex = 1;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // pnThongKeView
            // 
            this.pnThongKeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongKeView.Controls.Add(this.dataGridView1);
            this.pnThongKeView.Location = new System.Drawing.Point(11, 114);
            this.pnThongKeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnThongKeView.Name = "pnThongKeView";
            this.pnThongKeView.Size = new System.Drawing.Size(1149, 411);
            this.pnThongKeView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1136, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnThongKeChucNang
            // 
            this.pnThongKeChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongKeChucNang.Controls.Add(this.btThongKe);
            this.pnThongKeChucNang.Controls.Add(this.dateTimeEnd);
            this.pnThongKeChucNang.Controls.Add(this.dateTimeBegin);
            this.pnThongKeChucNang.Controls.Add(this.lbTotal);
            this.pnThongKeChucNang.Controls.Add(this.lbThongKe3);
            this.pnThongKeChucNang.Controls.Add(this.lbThongKe2);
            this.pnThongKeChucNang.Controls.Add(this.lbThongke1);
            this.pnThongKeChucNang.Location = new System.Drawing.Point(11, 17);
            this.pnThongKeChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnThongKeChucNang.Name = "pnThongKeChucNang";
            this.pnThongKeChucNang.Size = new System.Drawing.Size(1149, 90);
            this.pnThongKeChucNang.TabIndex = 0;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(532, 27);
            this.btThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(121, 43);
            this.btThongKe.TabIndex = 6;
            this.btThongKe.Text = "Thống kê ";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(177, 55);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(265, 22);
            this.dateTimeEnd.TabIndex = 5;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(177, 12);
            this.dateTimeBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(265, 22);
            this.dateTimeBegin.TabIndex = 4;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(1020, 37);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(80, 23);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "1000000";
            // 
            // lbThongKe3
            // 
            this.lbThongKe3.AutoSize = true;
            this.lbThongKe3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe3.Location = new System.Drawing.Point(732, 37);
            this.lbThongKe3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongKe3.Name = "lbThongKe3";
            this.lbThongKe3.Size = new System.Drawing.Size(208, 23);
            this.lbThongKe3.TabIndex = 2;
            this.lbThongKe3.Text = "Tổng doanh thu(VND): ";
            // 
            // lbThongKe2
            // 
            this.lbThongKe2.AutoSize = true;
            this.lbThongKe2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe2.Location = new System.Drawing.Point(4, 58);
            this.lbThongKe2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongKe2.Name = "lbThongKe2";
            this.lbThongKe2.Size = new System.Drawing.Size(56, 23);
            this.lbThongKe2.TabIndex = 1;
            this.lbThongKe2.Text = "Đến :";
            // 
            // lbThongke1
            // 
            this.lbThongke1.AutoSize = true;
            this.lbThongke1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongke1.Location = new System.Drawing.Point(4, 12);
            this.lbThongke1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongke1.Name = "lbThongke1";
            this.lbThongke1.Size = new System.Drawing.Size(124, 23);
            this.lbThongke1.TabIndex = 0;
            this.lbThongke1.Text = "Thống kê từ: ";
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.Aqua;
            this.tabAccount.Controls.Add(this.btAddAccount);
            this.tabAccount.Controls.Add(this.panel2);
            this.tabAccount.Controls.Add(this.panel1);
            this.tabAccount.Controls.Add(this.tbRepass);
            this.tabAccount.Controls.Add(this.tbPass);
            this.tabAccount.Controls.Add(this.tbUsername);
            this.tabAccount.Controls.Add(this.tbAddress);
            this.tabAccount.Controls.Add(this.tbName);
            this.tabAccount.Controls.Add(this.lbTaikhoan4);
            this.tabAccount.Controls.Add(this.lbTaikhoan3);
            this.tabAccount.Controls.Add(this.lbTaikhoan8);
            this.tabAccount.Controls.Add(this.lbTaikhoan7);
            this.tabAccount.Controls.Add(this.lbTaikhoan6);
            this.tabAccount.Controls.Add(this.lbTaikhoan5);
            this.tabAccount.Controls.Add(this.lbTaikhoan2);
            this.tabAccount.Controls.Add(this.lbTaiKhoan1);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAccount.Size = new System.Drawing.Size(1171, 538);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Tài khoản";
            // 
            // btAddAccount
            // 
            this.btAddAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAccount.Location = new System.Drawing.Point(448, 391);
            this.btAddAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(180, 55);
            this.btAddAccount.TabIndex = 16;
            this.btAddAccount.Text = "Thêm Tài Khoản";
            this.btAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNhanVien);
            this.panel2.Controls.Add(this.rbAdmin);
            this.panel2.Location = new System.Drawing.Point(753, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 75);
            this.panel2.TabIndex = 15;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhanVien.Location = new System.Drawing.Point(101, 31);
            this.rbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(111, 26);
            this.rbNhanVien.TabIndex = 14;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(4, 31);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(84, 26);
            this.rbAdmin.TabIndex = 13;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNu);
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Location = new System.Drawing.Point(283, 292);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 75);
            this.panel1.TabIndex = 14;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.Location = new System.Drawing.Point(133, 31);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(54, 26);
            this.rbNu.TabIndex = 14;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(24, 33);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(68, 26);
            this.rbNam.TabIndex = 13;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // tbRepass
            // 
            this.tbRepass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepass.Location = new System.Drawing.Point(753, 250);
            this.tbRepass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRepass.Name = "tbRepass";
            this.tbRepass.Size = new System.Drawing.Size(199, 30);
            this.tbRepass.TabIndex = 12;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(753, 178);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(199, 30);
            this.tbPass.TabIndex = 11;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(753, 117);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(199, 30);
            this.tbUsername.TabIndex = 10;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(283, 219);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(199, 30);
            this.tbAddress.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(283, 117);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(199, 30);
            this.tbName.TabIndex = 8;
            // 
            // lbTaikhoan4
            // 
            this.lbTaikhoan4.AutoSize = true;
            this.lbTaikhoan4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan4.Location = new System.Drawing.Point(167, 322);
            this.lbTaikhoan4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan4.Name = "lbTaikhoan4";
            this.lbTaikhoan4.Size = new System.Drawing.Size(85, 23);
            this.lbTaikhoan4.TabIndex = 7;
            this.lbTaikhoan4.Text = "Giới tính";
            // 
            // lbTaikhoan3
            // 
            this.lbTaikhoan3.AutoSize = true;
            this.lbTaikhoan3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan3.Location = new System.Drawing.Point(167, 228);
            this.lbTaikhoan3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan3.Name = "lbTaikhoan3";
            this.lbTaikhoan3.Size = new System.Drawing.Size(73, 23);
            this.lbTaikhoan3.TabIndex = 6;
            this.lbTaikhoan3.Text = "Địa chỉ ";
            // 
            // lbTaikhoan8
            // 
            this.lbTaikhoan8.AutoSize = true;
            this.lbTaikhoan8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan8.Location = new System.Drawing.Point(611, 322);
            this.lbTaikhoan8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan8.Name = "lbTaikhoan8";
            this.lbTaikhoan8.Size = new System.Drawing.Size(107, 23);
            this.lbTaikhoan8.TabIndex = 5;
            this.lbTaikhoan8.Text = "Phân quyền";
            // 
            // lbTaikhoan7
            // 
            this.lbTaikhoan7.AutoSize = true;
            this.lbTaikhoan7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan7.Location = new System.Drawing.Point(611, 254);
            this.lbTaikhoan7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan7.Name = "lbTaikhoan7";
            this.lbTaikhoan7.Size = new System.Drawing.Size(124, 23);
            this.lbTaikhoan7.TabIndex = 4;
            this.lbTaikhoan7.Text = "Repassword :";
            // 
            // lbTaikhoan6
            // 
            this.lbTaikhoan6.AutoSize = true;
            this.lbTaikhoan6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan6.Location = new System.Drawing.Point(611, 182);
            this.lbTaikhoan6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan6.Name = "lbTaikhoan6";
            this.lbTaikhoan6.Size = new System.Drawing.Size(102, 23);
            this.lbTaikhoan6.TabIndex = 3;
            this.lbTaikhoan6.Text = "Password :";
            // 
            // lbTaikhoan5
            // 
            this.lbTaikhoan5.AutoSize = true;
            this.lbTaikhoan5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan5.Location = new System.Drawing.Point(611, 121);
            this.lbTaikhoan5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan5.Name = "lbTaikhoan5";
            this.lbTaikhoan5.Size = new System.Drawing.Size(107, 23);
            this.lbTaikhoan5.TabIndex = 2;
            this.lbTaikhoan5.Text = "Username :";
            // 
            // lbTaikhoan2
            // 
            this.lbTaikhoan2.AutoSize = true;
            this.lbTaikhoan2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan2.Location = new System.Drawing.Point(164, 121);
            this.lbTaikhoan2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan2.Name = "lbTaikhoan2";
            this.lbTaikhoan2.Size = new System.Drawing.Size(76, 23);
            this.lbTaikhoan2.TabIndex = 1;
            this.lbTaikhoan2.Text = "Name : ";
            // 
            // lbTaiKhoan1
            // 
            this.lbTaiKhoan1.AutoSize = true;
            this.lbTaiKhoan1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan1.Location = new System.Drawing.Point(347, 16);
            this.lbTaiKhoan1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaiKhoan1.Name = "lbTaiKhoan1";
            this.lbTaiKhoan1.Size = new System.Drawing.Size(461, 45);
            this.lbTaiKhoan1.TabIndex = 0;
            this.lbTaiKhoan1.Text = "Thêm tài khoản nhân viên";
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 25);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Size = new System.Drawing.Size(1171, 538);
            this.tabDanhMuc.TabIndex = 3;
            this.tabDanhMuc.Text = "Danh mục";
            this.tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // tabBan
            // 
            this.tabBan.Location = new System.Drawing.Point(4, 25);
            this.tabBan.Name = "tabBan";
            this.tabBan.Size = new System.Drawing.Size(1171, 538);
            this.tabBan.TabIndex = 4;
            this.tabBan.Text = "Bàn ăn";
            this.tabBan.UseVisualStyleBackColor = true;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(51, 14);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(78, 23);
            this.lblMaMon.TabIndex = 6;
            this.lblMaMon.Text = "Mã món";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(55, 62);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(253, 30);
            this.txtMaMon.TabIndex = 7;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.tabAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.tabAdmin.ResumeLayout(false);
            this.tabThucDon.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.pannelViewThucDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewThucDon)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.tabDoanhThu.ResumeLayout(false);
            this.pnThongKeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnThongKeChucNang.ResumeLayout(false);
            this.pnThongKeChucNang.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabThucDon;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.Panel pannelViewThucDon;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btSearchThucDon;
        private System.Windows.Forms.TextBox txtSearchMenu;
        private System.Windows.Forms.Button btDeleteThucDon;
        private System.Windows.Forms.Button btEditThucDon;
        private System.Windows.Forms.Button btInsertThucDon;
        private System.Windows.Forms.DataGridView ViewThucDon;
        private System.Windows.Forms.ComboBox cbTinhTrangMonAn;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lbGiaMonAn;
        private System.Windows.Forms.Label lbTinhTrangMonAn;
        private System.Windows.Forms.Label lbNameMonAn;
        private System.Windows.Forms.Panel pnThongKeView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnThongKeChucNang;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbThongKe3;
        private System.Windows.Forms.Label lbThongKe2;
        private System.Windows.Forms.Label lbThongke1;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Label lbTaikhoan3;
        private System.Windows.Forms.Label lbTaikhoan8;
        private System.Windows.Forms.Label lbTaikhoan7;
        private System.Windows.Forms.Label lbTaikhoan6;
        private System.Windows.Forms.Label lbTaikhoan5;
        private System.Windows.Forms.Label lbTaikhoan2;
        private System.Windows.Forms.Label lbTaiKhoan1;
        private System.Windows.Forms.Label lbTaikhoan4;
        private System.Windows.Forms.TextBox tbRepass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
    }
}
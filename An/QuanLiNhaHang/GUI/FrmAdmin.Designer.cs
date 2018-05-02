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
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.cbTinhTrangMonAn = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lbGiaMonAn = new System.Windows.Forms.Label();
            this.lbTinhTrangMonAn = new System.Windows.Forms.Label();
            this.lbNameMonAn = new System.Windows.Forms.Label();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnotice1 = new System.Windows.Forms.Label();
            this.lbloitablename = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtablename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxarea = new System.Windows.Forms.ComboBox();
            this.lbarea = new System.Windows.Forms.Label();
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
            this.lbloiphanquyen = new System.Windows.Forms.Label();
            this.lbnotice = new System.Windows.Forms.Label();
            this.lbloirepassword = new System.Windows.Forms.Label();
            this.lbloipassword = new System.Windows.Forms.Label();
            this.lbloiusername = new System.Windows.Forms.Label();
            this.tbdisplayname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.tbRepass = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbTaikhoan8 = new System.Windows.Forms.Label();
            this.lbTaikhoan7 = new System.Windows.Forms.Label();
            this.lbTaikhoan6 = new System.Windows.Forms.Label();
            this.lbTaikhoan5 = new System.Windows.Forms.Label();
            this.lbTaiKhoan1 = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabThucDon.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.pannelViewThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewThucDon)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.tabBan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.pnThongKeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnThongKeChucNang.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(884, 461);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabThucDon
            // 
            this.tabThucDon.Controls.Add(this.panelSearch);
            this.tabThucDon.Controls.Add(this.panelButton);
            this.tabThucDon.Controls.Add(this.pannelViewThucDon);
            this.tabThucDon.Controls.Add(this.panelEdit);
            this.tabThucDon.Location = new System.Drawing.Point(4, 22);
            this.tabThucDon.Name = "tabThucDon";
            this.tabThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabThucDon.Size = new System.Drawing.Size(876, 435);
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
            this.panelSearch.Location = new System.Drawing.Point(302, 7);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(573, 57);
            this.panelSearch.TabIndex = 3;
            // 
            // btSearchThucDon
            // 
            this.btSearchThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btSearchThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchThucDon.Location = new System.Drawing.Point(392, 14);
            this.btSearchThucDon.Name = "btSearchThucDon";
            this.btSearchThucDon.Size = new System.Drawing.Size(85, 34);
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
            this.txtSearchMenu.Location = new System.Drawing.Point(99, 19);
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(267, 26);
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
            this.panelButton.Location = new System.Drawing.Point(7, 5);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(289, 60);
            this.panelButton.TabIndex = 2;
            // 
            // btDeleteThucDon
            // 
            this.btDeleteThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btDeleteThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteThucDon.Location = new System.Drawing.Point(222, 5);
            this.btDeleteThucDon.Name = "btDeleteThucDon";
            this.btDeleteThucDon.Size = new System.Drawing.Size(50, 50);
            this.btDeleteThucDon.TabIndex = 2;
            this.btDeleteThucDon.Text = "Xóa";
            this.btDeleteThucDon.UseVisualStyleBackColor = false;
            // 
            // btEditThucDon
            // 
            this.btEditThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btEditThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditThucDon.Location = new System.Drawing.Point(119, 5);
            this.btEditThucDon.Name = "btEditThucDon";
            this.btEditThucDon.Size = new System.Drawing.Size(50, 50);
            this.btEditThucDon.TabIndex = 1;
            this.btEditThucDon.Text = "Sửa";
            this.btEditThucDon.UseVisualStyleBackColor = false;
            // 
            // btInsertThucDon
            // 
            this.btInsertThucDon.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btInsertThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertThucDon.Location = new System.Drawing.Point(13, 5);
            this.btInsertThucDon.Name = "btInsertThucDon";
            this.btInsertThucDon.Size = new System.Drawing.Size(50, 50);
            this.btInsertThucDon.TabIndex = 0;
            this.btInsertThucDon.Text = "Thêm";
            this.btInsertThucDon.UseVisualStyleBackColor = false;
            // 
            // pannelViewThucDon
            // 
            this.pannelViewThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelViewThucDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pannelViewThucDon.BackColor = System.Drawing.Color.DimGray;
            this.pannelViewThucDon.Controls.Add(this.ViewThucDon);
            this.pannelViewThucDon.Location = new System.Drawing.Point(303, 75);
            this.pannelViewThucDon.Name = "pannelViewThucDon";
            this.pannelViewThucDon.Size = new System.Drawing.Size(585, 357);
            this.pannelViewThucDon.TabIndex = 1;
            // 
            // ViewThucDon
            // 
            this.ViewThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewThucDon.Location = new System.Drawing.Point(3, 0);
            this.ViewThucDon.Name = "ViewThucDon";
            this.ViewThucDon.Size = new System.Drawing.Size(561, 348);
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
            this.panelEdit.Location = new System.Drawing.Point(8, 75);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(289, 360);
            this.panelEdit.TabIndex = 0;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(41, 50);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(191, 26);
            this.txtMaMon.TabIndex = 7;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(38, 11);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(65, 19);
            this.lblMaMon.TabIndex = 6;
            this.lblMaMon.Text = "Mã món";
            // 
            // cbTinhTrangMonAn
            // 
            this.cbTinhTrangMonAn.FormattingEnabled = true;
            this.cbTinhTrangMonAn.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbTinhTrangMonAn.Location = new System.Drawing.Point(42, 321);
            this.cbTinhTrangMonAn.Name = "cbTinhTrangMonAn";
            this.cbTinhTrangMonAn.Size = new System.Drawing.Size(191, 21);
            this.cbTinhTrangMonAn.TabIndex = 5;
            this.cbTinhTrangMonAn.Text = "Còn hàng";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(44, 222);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(191, 26);
            this.txtGia.TabIndex = 4;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(42, 141);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(191, 26);
            this.txtTenMon.TabIndex = 3;
            // 
            // lbGiaMonAn
            // 
            this.lbGiaMonAn.AutoSize = true;
            this.lbGiaMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaMonAn.Location = new System.Drawing.Point(41, 185);
            this.lbGiaMonAn.Name = "lbGiaMonAn";
            this.lbGiaMonAn.Size = new System.Drawing.Size(82, 19);
            this.lbGiaMonAn.TabIndex = 2;
            this.lbGiaMonAn.Text = "Giá( VND)";
            // 
            // lbTinhTrangMonAn
            // 
            this.lbTinhTrangMonAn.AutoSize = true;
            this.lbTinhTrangMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangMonAn.Location = new System.Drawing.Point(41, 285);
            this.lbTinhTrangMonAn.Name = "lbTinhTrangMonAn";
            this.lbTinhTrangMonAn.Size = new System.Drawing.Size(78, 19);
            this.lbTinhTrangMonAn.TabIndex = 1;
            this.lbTinhTrangMonAn.Text = "Tình trạng";
            // 
            // lbNameMonAn
            // 
            this.lbNameMonAn.AutoSize = true;
            this.lbNameMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMonAn.Location = new System.Drawing.Point(39, 94);
            this.lbNameMonAn.Name = "lbNameMonAn";
            this.lbNameMonAn.Size = new System.Drawing.Size(67, 19);
            this.lbNameMonAn.TabIndex = 0;
            this.lbNameMonAn.Text = "Tên món";
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 22);
            this.tabDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Size = new System.Drawing.Size(876, 435);
            this.tabDanhMuc.TabIndex = 3;
            this.tabDanhMuc.Text = "Danh mục";
            this.tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // tabBan
            // 
            this.tabBan.Controls.Add(this.panel1);
            this.tabBan.Location = new System.Drawing.Point(4, 22);
            this.tabBan.Margin = new System.Windows.Forms.Padding(2);
            this.tabBan.Name = "tabBan";
            this.tabBan.Size = new System.Drawing.Size(876, 435);
            this.tabBan.TabIndex = 4;
            this.tabBan.Text = "Bàn ăn";
            this.tabBan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbnotice1);
            this.panel1.Controls.Add(this.lbloitablename);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.tbstatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbtablename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxarea);
            this.panel1.Controls.Add(this.lbarea);
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 424);
            this.panel1.TabIndex = 0;
            // 
            // lbnotice1
            // 
            this.lbnotice1.AutoSize = true;
            this.lbnotice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnotice1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbnotice1.Location = new System.Drawing.Point(404, 375);
            this.lbnotice1.Name = "lbnotice1";
            this.lbnotice1.Size = new System.Drawing.Size(37, 16);
            this.lbnotice1.TabIndex = 25;
            this.lbnotice1.Text = "fgnm";
            // 
            // lbloitablename
            // 
            this.lbloitablename.AutoSize = true;
            this.lbloitablename.Location = new System.Drawing.Point(468, 130);
            this.lbloitablename.Name = "lbloitablename";
            this.lbloitablename.Size = new System.Drawing.Size(68, 13);
            this.lbloitablename.TabIndex = 24;
            this.lbloitablename.Text = "dfghjkcvbnm";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(439, 329);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 23;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // tbstatus
            // 
            this.tbstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstatus.Location = new System.Drawing.Point(458, 252);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(150, 26);
            this.tbstatus.TabIndex = 22;
            this.tbstatus.TextChanged += new System.EventHandler(this.tbstatus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbtablename
            // 
            this.tbtablename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtablename.Location = new System.Drawing.Point(458, 165);
            this.tbtablename.Name = "tbtablename";
            this.tbtablename.Size = new System.Drawing.Size(150, 26);
            this.tbtablename.TabIndex = 20;
            this.tbtablename.TextChanged += new System.EventHandler(this.tbtablename_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "TableName :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thêm Bàn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxarea
            // 
            this.cbxarea.FormattingEnabled = true;
            this.cbxarea.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3"});
            this.cbxarea.Location = new System.Drawing.Point(458, 92);
            this.cbxarea.Name = "cbxarea";
            this.cbxarea.Size = new System.Drawing.Size(150, 21);
            this.cbxarea.TabIndex = 4;
            this.cbxarea.SelectedIndexChanged += new System.EventHandler(this.cbxarea_SelectedIndexChanged);
            // 
            // lbarea
            // 
            this.lbarea.AutoSize = true;
            this.lbarea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbarea.Location = new System.Drawing.Point(324, 91);
            this.lbarea.Name = "lbarea";
            this.lbarea.Size = new System.Drawing.Size(51, 19);
            this.lbarea.TabIndex = 3;
            this.lbarea.Text = "Area :";
            this.lbarea.Click += new System.EventHandler(this.lbarea_Click);
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.pnThongKeView);
            this.tabDoanhThu.Controls.Add(this.pnThongKeChucNang);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(876, 435);
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
            this.pnThongKeView.Location = new System.Drawing.Point(8, 93);
            this.pnThongKeView.Name = "pnThongKeView";
            this.pnThongKeView.Size = new System.Drawing.Size(862, 334);
            this.pnThongKeView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 318);
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
            this.pnThongKeChucNang.Location = new System.Drawing.Point(8, 14);
            this.pnThongKeChucNang.Name = "pnThongKeChucNang";
            this.pnThongKeChucNang.Size = new System.Drawing.Size(862, 73);
            this.pnThongKeChucNang.TabIndex = 0;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(399, 22);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(91, 35);
            this.btThongKe.TabIndex = 6;
            this.btThongKe.Text = "Thống kê ";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(133, 45);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 5;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(133, 10);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBegin.TabIndex = 4;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(765, 30);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(65, 19);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "1000000";
            // 
            // lbThongKe3
            // 
            this.lbThongKe3.AutoSize = true;
            this.lbThongKe3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe3.Location = new System.Drawing.Point(549, 30);
            this.lbThongKe3.Name = "lbThongKe3";
            this.lbThongKe3.Size = new System.Drawing.Size(166, 19);
            this.lbThongKe3.TabIndex = 2;
            this.lbThongKe3.Text = "Tổng doanh thu(VND): ";
            // 
            // lbThongKe2
            // 
            this.lbThongKe2.AutoSize = true;
            this.lbThongKe2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe2.Location = new System.Drawing.Point(3, 47);
            this.lbThongKe2.Name = "lbThongKe2";
            this.lbThongKe2.Size = new System.Drawing.Size(46, 19);
            this.lbThongKe2.TabIndex = 1;
            this.lbThongKe2.Text = "Đến :";
            // 
            // lbThongke1
            // 
            this.lbThongke1.AutoSize = true;
            this.lbThongke1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongke1.Location = new System.Drawing.Point(3, 10);
            this.lbThongke1.Name = "lbThongke1";
            this.lbThongke1.Size = new System.Drawing.Size(100, 19);
            this.lbThongke1.TabIndex = 0;
            this.lbThongke1.Text = "Thống kê từ: ";
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.Aqua;
            this.tabAccount.Controls.Add(this.lbloiphanquyen);
            this.tabAccount.Controls.Add(this.lbnotice);
            this.tabAccount.Controls.Add(this.lbloirepassword);
            this.tabAccount.Controls.Add(this.lbloipassword);
            this.tabAccount.Controls.Add(this.lbloiusername);
            this.tabAccount.Controls.Add(this.tbdisplayname);
            this.tabAccount.Controls.Add(this.label1);
            this.tabAccount.Controls.Add(this.btAddAccount);
            this.tabAccount.Controls.Add(this.panel2);
            this.tabAccount.Controls.Add(this.tbRepass);
            this.tabAccount.Controls.Add(this.tbPass);
            this.tabAccount.Controls.Add(this.tbUsername);
            this.tabAccount.Controls.Add(this.lbTaikhoan8);
            this.tabAccount.Controls.Add(this.lbTaikhoan7);
            this.tabAccount.Controls.Add(this.lbTaikhoan6);
            this.tabAccount.Controls.Add(this.lbTaikhoan5);
            this.tabAccount.Controls.Add(this.lbTaiKhoan1);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(876, 435);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Tài khoản";
            // 
            // lbloiphanquyen
            // 
            this.lbloiphanquyen.AutoSize = true;
            this.lbloiphanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloiphanquyen.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbloiphanquyen.Location = new System.Drawing.Point(320, 306);
            this.lbloiphanquyen.Name = "lbloiphanquyen";
            this.lbloiphanquyen.Size = new System.Drawing.Size(0, 16);
            this.lbloiphanquyen.TabIndex = 23;
            this.lbloiphanquyen.Text = "dfg";
            // 
            // lbnotice
            // 
            this.lbnotice.AutoSize = true;
            this.lbnotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnotice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbnotice.Location = new System.Drawing.Point(342, 396);
            this.lbnotice.Name = "lbnotice";
            this.lbnotice.Size = new System.Drawing.Size(0, 16);
            this.lbnotice.TabIndex = 22;
            this.lbnotice.Text = "dfghnmvb";
            // 
            // lbloirepassword
            // 
            this.lbloirepassword.AutoSize = true;
            this.lbloirepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloirepassword.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbloirepassword.Location = new System.Drawing.Point(659, 204);
            this.lbloirepassword.Name = "lbloirepassword";
            this.lbloirepassword.Size = new System.Drawing.Size(0, 16);
            this.lbloirepassword.TabIndex = 21;
            this.lbloirepassword.Text = "cvbn";
            // 
            // lbloipassword
            // 
            this.lbloipassword.AutoSize = true;
            this.lbloipassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloipassword.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbloipassword.Location = new System.Drawing.Point(659, 127);
            this.lbloipassword.Name = "lbloipassword";
            this.lbloipassword.Size = new System.Drawing.Size(0, 16);
            this.lbloipassword.TabIndex = 20;
            this.lbloipassword.Text = "bn";
            // 
            // lbloiusername
            // 
            this.lbloiusername.AutoSize = true;
            this.lbloiusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloiusername.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbloiusername.Location = new System.Drawing.Point(184, 127);
            this.lbloiusername.Name = "lbloiusername";
            this.lbloiusername.Size = new System.Drawing.Size(0, 16);
            this.lbloiusername.TabIndex = 19;
            this.lbloiusername.Text = "fghj";
            // 
            // tbdisplayname
            // 
            this.tbdisplayname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdisplayname.Location = new System.Drawing.Point(175, 161);
            this.tbdisplayname.Name = "tbdisplayname";
            this.tbdisplayname.Size = new System.Drawing.Size(150, 26);
            this.tbdisplayname.TabIndex = 18;
            this.tbdisplayname.TextChanged += new System.EventHandler(this.tbdisplayname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "DisplayName :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAddAccount
            // 
            this.btAddAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAccount.Location = new System.Drawing.Point(342, 332);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(135, 45);
            this.btAddAccount.TabIndex = 16;
            this.btAddAccount.Text = "Thêm Tài Khoản";
            this.btAddAccount.UseVisualStyleBackColor = true;
            this.btAddAccount.Click += new System.EventHandler(this.btAddAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNhanVien);
            this.panel2.Controls.Add(this.rbAdmin);
            this.panel2.Location = new System.Drawing.Point(320, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 61);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhanVien.Location = new System.Drawing.Point(87, 25);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(88, 23);
            this.rbNhanVien.TabIndex = 14;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            this.rbNhanVien.CheckedChanged += new System.EventHandler(this.rbNhanVien_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(3, 25);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(67, 23);
            this.rbAdmin.TabIndex = 13;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // tbRepass
            // 
            this.tbRepass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepass.Location = new System.Drawing.Point(647, 161);
            this.tbRepass.Name = "tbRepass";
            this.tbRepass.Size = new System.Drawing.Size(150, 26);
            this.tbRepass.TabIndex = 12;
            this.tbRepass.UseSystemPasswordChar = true;
            this.tbRepass.TextChanged += new System.EventHandler(this.tbRepass_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(647, 82);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(150, 26);
            this.tbPass.TabIndex = 11;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(175, 82);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 26);
            this.tbUsername.TabIndex = 10;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbTaikhoan8
            // 
            this.lbTaikhoan8.AutoSize = true;
            this.lbTaikhoan8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan8.Location = new System.Drawing.Point(171, 258);
            this.lbTaikhoan8.Name = "lbTaikhoan8";
            this.lbTaikhoan8.Size = new System.Drawing.Size(86, 19);
            this.lbTaikhoan8.TabIndex = 5;
            this.lbTaikhoan8.Text = "Phân quyền";
            this.lbTaikhoan8.Click += new System.EventHandler(this.lbTaikhoan8_Click);
            // 
            // lbTaikhoan7
            // 
            this.lbTaikhoan7.AutoSize = true;
            this.lbTaikhoan7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan7.Location = new System.Drawing.Point(470, 164);
            this.lbTaikhoan7.Name = "lbTaikhoan7";
            this.lbTaikhoan7.Size = new System.Drawing.Size(100, 19);
            this.lbTaikhoan7.TabIndex = 4;
            this.lbTaikhoan7.Text = "Repassword :";
            this.lbTaikhoan7.Click += new System.EventHandler(this.lbTaikhoan7_Click);
            // 
            // lbTaikhoan6
            // 
            this.lbTaikhoan6.AutoSize = true;
            this.lbTaikhoan6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan6.Location = new System.Drawing.Point(489, 85);
            this.lbTaikhoan6.Name = "lbTaikhoan6";
            this.lbTaikhoan6.Size = new System.Drawing.Size(81, 19);
            this.lbTaikhoan6.TabIndex = 3;
            this.lbTaikhoan6.Text = "Password :";
            this.lbTaikhoan6.Click += new System.EventHandler(this.lbTaikhoan6_Click);
            // 
            // lbTaikhoan5
            // 
            this.lbTaikhoan5.AutoSize = true;
            this.lbTaikhoan5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan5.Location = new System.Drawing.Point(36, 85);
            this.lbTaikhoan5.Name = "lbTaikhoan5";
            this.lbTaikhoan5.Size = new System.Drawing.Size(86, 19);
            this.lbTaikhoan5.TabIndex = 2;
            this.lbTaikhoan5.Text = "Username :";
            this.lbTaikhoan5.Click += new System.EventHandler(this.lbTaikhoan5_Click);
            // 
            // lbTaiKhoan1
            // 
            this.lbTaiKhoan1.AutoSize = true;
            this.lbTaiKhoan1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan1.Location = new System.Drawing.Point(260, 13);
            this.lbTaiKhoan1.Name = "lbTaiKhoan1";
            this.lbTaiKhoan1.Size = new System.Drawing.Size(375, 36);
            this.lbTaiKhoan1.TabIndex = 0;
            this.lbTaiKhoan1.Text = "Thêm tài khoản nhân viên";
            this.lbTaiKhoan1.Click += new System.EventHandler(this.lbTaiKhoan1_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabAdmin);
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
            this.tabBan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDoanhThu.ResumeLayout(false);
            this.pnThongKeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnThongKeChucNang.ResumeLayout(false);
            this.pnThongKeChucNang.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lbTaikhoan8;
        private System.Windows.Forms.Label lbTaikhoan7;
        private System.Windows.Forms.Label lbTaikhoan6;
        private System.Windows.Forms.Label lbTaikhoan5;
        private System.Windows.Forms.Label lbTaiKhoan1;
        private System.Windows.Forms.TextBox tbRepass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lbnotice;
        private System.Windows.Forms.Label lbloirepassword;
        private System.Windows.Forms.Label lbloipassword;
        private System.Windows.Forms.Label lbloiusername;
        private System.Windows.Forms.TextBox tbdisplayname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbloiphanquyen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxarea;
        private System.Windows.Forms.Label lbarea;
        private System.Windows.Forms.TextBox tbtablename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbloitablename;
        private System.Windows.Forms.Label lbnotice1;
    }
}
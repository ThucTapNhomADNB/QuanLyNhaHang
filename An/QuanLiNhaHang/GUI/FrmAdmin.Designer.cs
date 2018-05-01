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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btDeleteThucDon = new System.Windows.Forms.Button();
            this.btEditThucDon = new System.Windows.Forms.Button();
            this.btInsertThucDon = new System.Windows.Forms.Button();
            this.pannelViewThucDon = new System.Windows.Forms.Panel();
            this.ViewThucDon = new System.Windows.Forms.DataGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.cbTinhTrangMonAn = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.tabThucDon.Text = "Thuc Don";
            this.tabThucDon.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.btSearchThucDon);
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Location = new System.Drawing.Point(302, 7);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(573, 57);
            this.panelSearch.TabIndex = 3;
            // 
            // btSearchThucDon
            // 
            this.btSearchThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchThucDon.Location = new System.Drawing.Point(392, 14);
            this.btSearchThucDon.Name = "btSearchThucDon";
            this.btSearchThucDon.Size = new System.Drawing.Size(85, 34);
            this.btSearchThucDon.TabIndex = 1;
            this.btSearchThucDon.Text = "Search";
            this.btSearchThucDon.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panelButton
            // 
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
            this.btDeleteThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteThucDon.Location = new System.Drawing.Point(222, 5);
            this.btDeleteThucDon.Name = "btDeleteThucDon";
            this.btDeleteThucDon.Size = new System.Drawing.Size(50, 50);
            this.btDeleteThucDon.TabIndex = 2;
            this.btDeleteThucDon.Text = "Delete";
            this.btDeleteThucDon.UseVisualStyleBackColor = true;
            // 
            // btEditThucDon
            // 
            this.btEditThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditThucDon.Location = new System.Drawing.Point(119, 5);
            this.btEditThucDon.Name = "btEditThucDon";
            this.btEditThucDon.Size = new System.Drawing.Size(50, 50);
            this.btEditThucDon.TabIndex = 1;
            this.btEditThucDon.Text = "Edit";
            this.btEditThucDon.UseVisualStyleBackColor = true;
            // 
            // btInsertThucDon
            // 
            this.btInsertThucDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertThucDon.Location = new System.Drawing.Point(13, 5);
            this.btInsertThucDon.Name = "btInsertThucDon";
            this.btInsertThucDon.Size = new System.Drawing.Size(50, 50);
            this.btInsertThucDon.TabIndex = 0;
            this.btInsertThucDon.Text = "Insert";
            this.btInsertThucDon.UseVisualStyleBackColor = true;
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
            this.ViewThucDon.Location = new System.Drawing.Point(6, 4);
            this.ViewThucDon.Name = "ViewThucDon";
            this.ViewThucDon.Size = new System.Drawing.Size(561, 348);
            this.ViewThucDon.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEdit.BackColor = System.Drawing.Color.Silver;
            this.panelEdit.Controls.Add(this.cbTinhTrangMonAn);
            this.panelEdit.Controls.Add(this.textBox3);
            this.panelEdit.Controls.Add(this.textBox2);
            this.panelEdit.Controls.Add(this.lbGiaMonAn);
            this.panelEdit.Controls.Add(this.lbTinhTrangMonAn);
            this.panelEdit.Controls.Add(this.lbNameMonAn);
            this.panelEdit.Location = new System.Drawing.Point(8, 75);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(289, 360);
            this.panelEdit.TabIndex = 0;
            // 
            // cbTinhTrangMonAn
            // 
            this.cbTinhTrangMonAn.FormattingEnabled = true;
            this.cbTinhTrangMonAn.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbTinhTrangMonAn.Location = new System.Drawing.Point(42, 272);
            this.cbTinhTrangMonAn.Name = "cbTinhTrangMonAn";
            this.cbTinhTrangMonAn.Size = new System.Drawing.Size(191, 21);
            this.cbTinhTrangMonAn.TabIndex = 5;
            this.cbTinhTrangMonAn.Text = "Còn hàng";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(42, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 26);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(42, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 26);
            this.textBox2.TabIndex = 3;
            // 
            // lbGiaMonAn
            // 
            this.lbGiaMonAn.AutoSize = true;
            this.lbGiaMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaMonAn.Location = new System.Drawing.Point(39, 128);
            this.lbGiaMonAn.Name = "lbGiaMonAn";
            this.lbGiaMonAn.Size = new System.Drawing.Size(78, 19);
            this.lbGiaMonAn.TabIndex = 2;
            this.lbGiaMonAn.Text = "Gia(VND)";
            // 
            // lbTinhTrangMonAn
            // 
            this.lbTinhTrangMonAn.AutoSize = true;
            this.lbTinhTrangMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangMonAn.Location = new System.Drawing.Point(39, 232);
            this.lbTinhTrangMonAn.Name = "lbTinhTrangMonAn";
            this.lbTinhTrangMonAn.Size = new System.Drawing.Size(82, 19);
            this.lbTinhTrangMonAn.TabIndex = 1;
            this.lbTinhTrangMonAn.Text = "Tinh Trang";
            // 
            // lbNameMonAn
            // 
            this.lbNameMonAn.AutoSize = true;
            this.lbNameMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMonAn.Location = new System.Drawing.Point(38, 27);
            this.lbNameMonAn.Name = "lbNameMonAn";
            this.lbNameMonAn.Size = new System.Drawing.Size(53, 19);
            this.lbNameMonAn.TabIndex = 0;
            this.lbNameMonAn.Text = "Name ";
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
            this.pnThongKeView.Size = new System.Drawing.Size(862, 282);
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
            this.dataGridView1.Size = new System.Drawing.Size(852, 255);
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
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(876, 435);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Tai khoan";
            // 
            // btAddAccount
            // 
            this.btAddAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAccount.Location = new System.Drawing.Point(336, 318);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(135, 45);
            this.btAddAccount.TabIndex = 16;
            this.btAddAccount.Text = "Thêm Tài Khoản";
            this.btAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNhanVien);
            this.panel2.Controls.Add(this.rbAdmin);
            this.panel2.Location = new System.Drawing.Point(565, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 61);
            this.panel2.TabIndex = 15;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhanVien.Location = new System.Drawing.Point(91, 25);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(88, 23);
            this.rbNhanVien.TabIndex = 14;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(18, 27);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(67, 23);
            this.rbAdmin.TabIndex = 13;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNu);
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Location = new System.Drawing.Point(212, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 61);
            this.panel1.TabIndex = 14;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.Location = new System.Drawing.Point(100, 25);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(46, 23);
            this.rbNu.TabIndex = 14;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(18, 27);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 23);
            this.rbNam.TabIndex = 13;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // tbRepass
            // 
            this.tbRepass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepass.Location = new System.Drawing.Point(565, 203);
            this.tbRepass.Name = "tbRepass";
            this.tbRepass.Size = new System.Drawing.Size(150, 26);
            this.tbRepass.TabIndex = 12;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(565, 145);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(150, 26);
            this.tbPass.TabIndex = 11;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(565, 95);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 26);
            this.tbUsername.TabIndex = 10;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(212, 178);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(150, 26);
            this.tbAddress.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(212, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 26);
            this.tbName.TabIndex = 8;
            // 
            // lbTaikhoan4
            // 
            this.lbTaikhoan4.AutoSize = true;
            this.lbTaikhoan4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan4.Location = new System.Drawing.Point(125, 262);
            this.lbTaikhoan4.Name = "lbTaikhoan4";
            this.lbTaikhoan4.Size = new System.Drawing.Size(67, 19);
            this.lbTaikhoan4.TabIndex = 7;
            this.lbTaikhoan4.Text = "Giới tính";
            // 
            // lbTaikhoan3
            // 
            this.lbTaikhoan3.AutoSize = true;
            this.lbTaikhoan3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan3.Location = new System.Drawing.Point(125, 185);
            this.lbTaikhoan3.Name = "lbTaikhoan3";
            this.lbTaikhoan3.Size = new System.Drawing.Size(60, 19);
            this.lbTaikhoan3.TabIndex = 6;
            this.lbTaikhoan3.Text = "Địa chỉ ";
            // 
            // lbTaikhoan8
            // 
            this.lbTaikhoan8.AutoSize = true;
            this.lbTaikhoan8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan8.Location = new System.Drawing.Point(458, 262);
            this.lbTaikhoan8.Name = "lbTaikhoan8";
            this.lbTaikhoan8.Size = new System.Drawing.Size(86, 19);
            this.lbTaikhoan8.TabIndex = 5;
            this.lbTaikhoan8.Text = "Phân quyền";
            // 
            // lbTaikhoan7
            // 
            this.lbTaikhoan7.AutoSize = true;
            this.lbTaikhoan7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan7.Location = new System.Drawing.Point(458, 206);
            this.lbTaikhoan7.Name = "lbTaikhoan7";
            this.lbTaikhoan7.Size = new System.Drawing.Size(100, 19);
            this.lbTaikhoan7.TabIndex = 4;
            this.lbTaikhoan7.Text = "Repassword :";
            // 
            // lbTaikhoan6
            // 
            this.lbTaikhoan6.AutoSize = true;
            this.lbTaikhoan6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan6.Location = new System.Drawing.Point(458, 148);
            this.lbTaikhoan6.Name = "lbTaikhoan6";
            this.lbTaikhoan6.Size = new System.Drawing.Size(81, 19);
            this.lbTaikhoan6.TabIndex = 3;
            this.lbTaikhoan6.Text = "Password :";
            // 
            // lbTaikhoan5
            // 
            this.lbTaikhoan5.AutoSize = true;
            this.lbTaikhoan5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan5.Location = new System.Drawing.Point(458, 98);
            this.lbTaikhoan5.Name = "lbTaikhoan5";
            this.lbTaikhoan5.Size = new System.Drawing.Size(86, 19);
            this.lbTaikhoan5.TabIndex = 2;
            this.lbTaikhoan5.Text = "Username :";
            // 
            // lbTaikhoan2
            // 
            this.lbTaikhoan2.AutoSize = true;
            this.lbTaikhoan2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan2.Location = new System.Drawing.Point(123, 98);
            this.lbTaikhoan2.Name = "lbTaikhoan2";
            this.lbTaikhoan2.Size = new System.Drawing.Size(62, 19);
            this.lbTaikhoan2.TabIndex = 1;
            this.lbTaikhoan2.Text = "Name : ";
            // 
            // lbTaiKhoan1
            // 
            this.lbTaiKhoan1.AutoSize = true;
            this.lbTaiKhoan1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan1.Location = new System.Drawing.Point(206, 35);
            this.lbTaiKhoan1.Name = "lbTaiKhoan1";
            this.lbTaiKhoan1.Size = new System.Drawing.Size(375, 36);
            this.lbTaiKhoan1.TabIndex = 0;
            this.lbTaiKhoan1.Text = "Thêm tài khoản nhân viên";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btDeleteThucDon;
        private System.Windows.Forms.Button btEditThucDon;
        private System.Windows.Forms.Button btInsertThucDon;
        private System.Windows.Forms.DataGridView ViewThucDon;
        private System.Windows.Forms.ComboBox cbTinhTrangMonAn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}
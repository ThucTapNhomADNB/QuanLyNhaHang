namespace QuanLyHS_THPT.GUI
{
    partial class frmLop
    {  /// <summary>
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGiaoVien = new System.Windows.Forms.ComboBox();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblmagvcn = new System.Windows.Forms.Label();
            this.lblsiso = new System.Windows.Forms.Label();
            this.lbltenlop = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMonLop = new System.Windows.Forms.DataGridView();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbGVBM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btMon = new System.Windows.Forms.Button();
            this.btnXuatfileLH = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonLop)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1548, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnXuatfileLH);
            this.panel1.Controls.Add(this.cbGiaoVien);
            this.panel1.Controls.Add(this.txtsiso);
            this.panel1.Controls.Add(this.txttenlop);
            this.panel1.Controls.Add(this.txtmalop);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.lblmagvcn);
            this.panel1.Controls.Add(this.lblsiso);
            this.panel1.Controls.Add(this.lbltenlop);
            this.panel1.Controls.Add(this.lblmalop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 465);
            this.panel1.TabIndex = 2;
            // 
            // cbGiaoVien
            // 
            this.cbGiaoVien.FormattingEnabled = true;
            this.cbGiaoVien.Location = new System.Drawing.Point(133, 243);
            this.cbGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbGiaoVien.Name = "cbGiaoVien";
            this.cbGiaoVien.Size = new System.Drawing.Size(168, 28);
            this.cbGiaoVien.TabIndex = 4;
            // 
            // txtsiso
            // 
            this.txtsiso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsiso.Location = new System.Drawing.Point(133, 198);
            this.txtsiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(168, 27);
            this.txtsiso.TabIndex = 2;
            // 
            // txttenlop
            // 
            this.txttenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenlop.Location = new System.Drawing.Point(133, 148);
            this.txttenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(168, 27);
            this.txttenlop.TabIndex = 1;
            // 
            // txtmalop
            // 
            this.txtmalop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop.Location = new System.Drawing.Point(133, 93);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(168, 27);
            this.txtmalop.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::QuanLyHS_THPT.Properties.Resources.exit__1_;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnthoat.Location = new System.Drawing.Point(258, 310);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 71);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = global::QuanLyHS_THPT.Properties.Resources.edit_add;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsua.Location = new System.Drawing.Point(96, 310);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 72);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = global::QuanLyHS_THPT.Properties.Resources.note_add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnthem.Location = new System.Drawing.Point(12, 310);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 72);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblmagvcn
            // 
            this.lblmagvcn.AutoSize = true;
            this.lblmagvcn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmagvcn.Location = new System.Drawing.Point(35, 243);
            this.lblmagvcn.Name = "lblmagvcn";
            this.lblmagvcn.Size = new System.Drawing.Size(58, 19);
            this.lblmagvcn.TabIndex = 0;
            this.lblmagvcn.Text = "GVCN";
            // 
            // lblsiso
            // 
            this.lblsiso.AutoSize = true;
            this.lblsiso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsiso.Location = new System.Drawing.Point(35, 203);
            this.lblsiso.Name = "lblsiso";
            this.lblsiso.Size = new System.Drawing.Size(44, 19);
            this.lblsiso.TabIndex = 0;
            this.lblsiso.Text = "Sĩ số";
            // 
            // lbltenlop
            // 
            this.lbltenlop.AutoSize = true;
            this.lbltenlop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenlop.Location = new System.Drawing.Point(35, 152);
            this.lbltenlop.Name = "lbltenlop";
            this.lbltenlop.Size = new System.Drawing.Size(64, 19);
            this.lbltenlop.TabIndex = 0;
            this.lbltenlop.Text = "Tên lớp";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmalop.Location = new System.Drawing.Point(35, 96);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(61, 19);
            this.lblmalop.TabIndex = 0;
            this.lblmalop.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dữ liệu lớp";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(550, 63);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(149, 27);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search by name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Controls.Add(this.dgvLop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(345, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 465);
            this.panel2.TabIndex = 3;
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(3, 96);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(720, 367);
            this.dgvLop.TabIndex = 1;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            // 
            // dgvMonLop
            // 
            this.dgvMonLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonLop.Location = new System.Drawing.Point(4, 245);
            this.dgvMonLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonLop.Name = "dgvMonLop";
            this.dgvMonLop.Size = new System.Drawing.Size(448, 133);
            this.dgvMonLop.TabIndex = 5;
            this.dgvMonLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonLop_CellClick);
            // 
            // cbMon
            // 
            this.cbMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(160, 79);
            this.cbMon.Margin = new System.Windows.Forms.Padding(4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(241, 27);
            this.cbMon.TabIndex = 6;
            // 
            // btThemMon
            // 
            this.btThemMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.Image = global::QuanLyHS_THPT.Properties.Resources.edit_add;
            this.btThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMon.Location = new System.Drawing.Point(189, 168);
            this.btThemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(112, 54);
            this.btThemMon.TabIndex = 7;
            this.btThemMon.Text = "Thêm";
            this.btThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Môn";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.cbGVBM);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btMon);
            this.panel3.Controls.Add(this.dgvMonLop);
            this.panel3.Controls.Add(this.btThemMon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbMon);
            this.panel3.Location = new System.Drawing.Point(1077, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 462);
            this.panel3.TabIndex = 4;
            // 
            // cbGVBM
            // 
            this.cbGVBM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGVBM.FormattingEnabled = true;
            this.cbGVBM.Location = new System.Drawing.Point(160, 121);
            this.cbGVBM.Margin = new System.Windows.Forms.Padding(4);
            this.cbGVBM.Name = "cbGVBM";
            this.cbGVBM.Size = new System.Drawing.Size(241, 27);
            this.cbGVBM.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "GVBM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh Sách Các Môn Học Của Lớp";
            // 
            // btMon
            // 
            this.btMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMon.Image = global::QuanLyHS_THPT.Properties.Resources.delete__1_;
            this.btMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMon.Location = new System.Drawing.Point(189, 409);
            this.btMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMon.Name = "btMon";
            this.btMon.Size = new System.Drawing.Size(127, 51);
            this.btMon.TabIndex = 9;
            this.btMon.Text = "Xóa Môn";
            this.btMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMon.UseVisualStyleBackColor = true;
            this.btMon.Click += new System.EventHandler(this.btMon_Click);
            // 
            // btnXuatfileLH
            // 
            this.btnXuatfileLH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatfileLH.Image = global::QuanLyHS_THPT.Properties.Resources.document_down_alt;
            this.btnXuatfileLH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatfileLH.Location = new System.Drawing.Point(177, 309);
            this.btnXuatfileLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatfileLH.Name = "btnXuatfileLH";
            this.btnXuatfileLH.Size = new System.Drawing.Size(75, 72);
            this.btnXuatfileLH.TabIndex = 5;
            this.btnXuatfileLH.Text = "Xuất file";
            this.btnXuatfileLH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatfileLH.UseVisualStyleBackColor = true;
            this.btnXuatfileLH.Click += new System.EventHandler(this.btnXuatfileLH_Click);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLop";
            this.Text = "Danh sách lớp học";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonLop)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltenlop;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblmagvcn;
        private System.Windows.Forms.Label lblsiso;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGiaoVien;
        private System.Windows.Forms.Button btMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.DataGridView dgvMonLop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbGVBM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Button btnXuatfileLH;
    }
}
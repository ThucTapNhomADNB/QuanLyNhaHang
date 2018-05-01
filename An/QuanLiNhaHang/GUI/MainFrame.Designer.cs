namespace QuanLiNhaHang.GUI
{
    partial class MainFrame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.tbNameKhach = new System.Windows.Forms.TextBox();
            this.lbNameKhach = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.cbThucDon = new System.Windows.Forms.ComboBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridOrdel = new System.Windows.Forms.DataGridView();
            this.blBan = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelChinh.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // panelChinh
            // 
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.Controls.Add(this.panel3);
            this.panelChinh.Controls.Add(this.panel2);
            this.panelChinh.Controls.Add(this.panel1);
            this.panelChinh.Location = new System.Drawing.Point(12, 37);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(860, 375);
            this.panelChinh.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridOrdel);
            this.panel1.Location = new System.Drawing.Point(13, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 188);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(501, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 344);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.blBan);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbBan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbSoLuong);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btThemMon);
            this.panel3.Controls.Add(this.cbThucDon);
            this.panel3.Controls.Add(this.tbSDT);
            this.panel3.Controls.Add(this.lbSDT);
            this.panel3.Controls.Add(this.tbNameKhach);
            this.panel3.Controls.Add(this.lbNameKhach);
            this.panel3.Controls.Add(this.btThanhToan);
            this.panel3.Location = new System.Drawing.Point(16, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 150);
            this.panel3.TabIndex = 2;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Chỉnh sửa tài khoản";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.Location = new System.Drawing.Point(343, 113);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(132, 34);
            this.btThanhToan.TabIndex = 0;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // tbNameKhach
            // 
            this.tbNameKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameKhach.Location = new System.Drawing.Point(121, 3);
            this.tbNameKhach.Name = "tbNameKhach";
            this.tbNameKhach.Size = new System.Drawing.Size(176, 22);
            this.tbNameKhach.TabIndex = 5;
            // 
            // lbNameKhach
            // 
            this.lbNameKhach.AutoSize = true;
            this.lbNameKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameKhach.Location = new System.Drawing.Point(3, 6);
            this.lbNameKhach.Name = "lbNameKhach";
            this.lbNameKhach.Size = new System.Drawing.Size(112, 15);
            this.lbNameKhach.TabIndex = 4;
            this.lbNameKhach.Text = "Họ tên khách hàng ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(313, 10);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(35, 15);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "SDT:";
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(365, 7);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(110, 22);
            this.tbSDT.TabIndex = 7;
            // 
            // cbThucDon
            // 
            this.cbThucDon.FormattingEnabled = true;
            this.cbThucDon.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbThucDon.Location = new System.Drawing.Point(6, 56);
            this.cbThucDon.Name = "cbThucDon";
            this.cbThucDon.Size = new System.Drawing.Size(169, 21);
            this.cbThucDon.TabIndex = 8;
            this.cbThucDon.Text = "Thuc Don";
            // 
            // btThemMon
            // 
            this.btThemMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.Location = new System.Drawing.Point(343, 48);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(132, 34);
            this.btThemMon.TabIndex = 9;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 22);
            this.textBox1.TabIndex = 10;
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbSoLuong.Location = new System.Drawing.Point(267, 56);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(59, 21);
            this.cbSoLuong.TabIndex = 11;
            this.cbSoLuong.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "SL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chuyển bàn";
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbBan.Location = new System.Drawing.Point(6, 121);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(169, 21);
            this.cbBan.TabIndex = 14;
            this.cbBan.Text = "Bàn 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giảm giá";
            // 
            // dataGridOrdel
            // 
            this.dataGridOrdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdel.Location = new System.Drawing.Point(9, 3);
            this.dataGridOrdel.Name = "dataGridOrdel";
            this.dataGridOrdel.Size = new System.Drawing.Size(468, 184);
            this.dataGridOrdel.TabIndex = 0;
            // 
            // blBan
            // 
            this.blBan.AutoSize = true;
            this.blBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blBan.Location = new System.Drawing.Point(3, 38);
            this.blBan.Name = "blBan";
            this.blBan.Size = new System.Drawing.Size(39, 15);
            this.blBan.TabIndex = 16;
            this.blBan.Text = "Bàn 1";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelChinh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbNameKhach;
        private System.Windows.Forms.Label lbNameKhach;
        private System.Windows.Forms.Label blBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.ComboBox cbThucDon;
        private System.Windows.Forms.DataGridView dataGridOrdel;
    }
}
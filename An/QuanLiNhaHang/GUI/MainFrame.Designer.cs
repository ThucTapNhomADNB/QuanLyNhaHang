﻿namespace QuanLiNhaHang.GUI
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
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.tabChonBan = new System.Windows.Forms.TabControl();
            this.tabBanTrong = new System.Windows.Forms.TabPage();
            this.flpDSBanTrong = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.đổiMậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelChinh.SuspendLayout();
            this.tabChonBan.SuspendLayout();
            this.tabBanTrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.thêmTàiKhoảnToolStripMenuItem,
            this.toolStripMenuItem2,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Chỉnh sửa tài khoản";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panelChinh
            // 
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.Controls.Add(this.tabChonBan);
            this.panelChinh.Location = new System.Drawing.Point(16, 46);
            this.panelChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1147, 462);
            this.panelChinh.TabIndex = 1;
            // 
            // tabChonBan
            // 
            this.tabChonBan.Controls.Add(this.tabBanTrong);
            this.tabChonBan.Controls.Add(this.tabBan);
            this.tabChonBan.Location = new System.Drawing.Point(1, 5);
            this.tabChonBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabChonBan.Name = "tabChonBan";
            this.tabChonBan.SelectedIndex = 0;
            this.tabChonBan.Size = new System.Drawing.Size(1144, 455);
            this.tabChonBan.TabIndex = 0;
            // 
            // tabBanTrong
            // 
            this.tabBanTrong.Controls.Add(this.flpDSBanTrong);
            this.tabBanTrong.Location = new System.Drawing.Point(4, 25);
            this.tabBanTrong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBanTrong.Name = "tabBanTrong";
            this.tabBanTrong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBanTrong.Size = new System.Drawing.Size(1136, 426);
            this.tabBanTrong.TabIndex = 0;
            this.tabBanTrong.Text = "Danh Sách Bàn Trống";
            this.tabBanTrong.UseVisualStyleBackColor = true;
            // 
            // flpDSBanTrong
            // 
            this.flpDSBanTrong.AutoScroll = true;
            this.flpDSBanTrong.Location = new System.Drawing.Point(9, 58);
            this.flpDSBanTrong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpDSBanTrong.Name = "flpDSBanTrong";
            this.flpDSBanTrong.Size = new System.Drawing.Size(1109, 325);
            this.flpDSBanTrong.TabIndex = 0;
            // 
            // tabBan
            // 
            this.tabBan.Location = new System.Drawing.Point(4, 25);
            this.tabBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBan.Name = "tabBan";
            this.tabBan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBan.Size = new System.Drawing.Size(1136, 426);
            this.tabBan.TabIndex = 1;
            this.tabBan.Text = "Danh Sách Bàn Đã Đặt";
            this.tabBan.UseVisualStyleBackColor = true;
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            this.đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            this.đổiMậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi mật khẩu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm tài khoản";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 506);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelChinh.ResumeLayout(false);
            this.tabChonBan.ResumeLayout(false);
            this.tabBanTrong.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabChonBan;
        private System.Windows.Forms.TabPage tabBanTrong;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.FlowLayoutPanel flpDSBanTrong;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
    }
}
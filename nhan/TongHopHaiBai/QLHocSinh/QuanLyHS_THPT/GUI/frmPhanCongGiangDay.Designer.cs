namespace QuanLyHS_THPT.GUI
{
    partial class frmPhanCongGiangDay
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbChuyenMon = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.cbGiaoVien = new System.Windows.Forms.ComboBox();
            this.btPhanCong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopMon = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.label8);
            this.pnlMenu.Controls.Add(this.lbChuyenMon);
            this.pnlMenu.Controls.Add(this.lbName);
            this.pnlMenu.Controls.Add(this.lbMaGV);
            this.pnlMenu.Controls.Add(this.cbGiaoVien);
            this.pnlMenu.Controls.Add(this.btPhanCong);
            this.pnlMenu.Controls.Add(this.label6);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(16, 14);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(309, 448);
            this.pnlMenu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chọn giáo viên";
            // 
            // lbChuyenMon
            // 
            this.lbChuyenMon.AutoSize = true;
            this.lbChuyenMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenMon.Location = new System.Drawing.Point(188, 284);
            this.lbChuyenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChuyenMon.Name = "lbChuyenMon";
            this.lbChuyenMon.Size = new System.Drawing.Size(100, 19);
            this.lbChuyenMon.TabIndex = 15;
            this.lbChuyenMon.Text = "Chuyên môn";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(188, 238);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 19);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Họ tên";
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaGV.Location = new System.Drawing.Point(188, 196);
            this.lbMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(62, 19);
            this.lbMaGV.TabIndex = 13;
            this.lbMaGV.Text = "Mã GV";
            // 
            // cbGiaoVien
            // 
            this.cbGiaoVien.FormattingEnabled = true;
            this.cbGiaoVien.Location = new System.Drawing.Point(52, 127);
            this.cbGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGiaoVien.Name = "cbGiaoVien";
            this.cbGiaoVien.Size = new System.Drawing.Size(195, 24);
            this.cbGiaoVien.TabIndex = 11;
            this.cbGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbGiaoVien_SelectedIndexChanged);
            // 
            // btPhanCong
            // 
            this.btPhanCong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhanCong.Location = new System.Drawing.Point(85, 342);
            this.btPhanCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPhanCong.Name = "btPhanCong";
            this.btPhanCong.Size = new System.Drawing.Size(117, 31);
            this.btPhanCong.TabIndex = 9;
            this.btPhanCong.Text = "Phân công";
            this.btPhanCong.UseVisualStyleBackColor = true;
            this.btPhanCong.Click += new System.EventHandler(this.btPhanCong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chuyên Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân công giảng dạy";
            // 
            // dgvLopMon
            // 
            this.dgvLopMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopMon.Location = new System.Drawing.Point(333, 108);
            this.dgvLopMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLopMon.Name = "dgvLopMon";
            this.dgvLopMon.Size = new System.Drawing.Size(939, 353);
            this.dgvLopMon.TabIndex = 13;
            this.dgvLopMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopMon_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "Danh sách Lớp-Môn";
            // 
            // frmPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 476);
            this.Controls.Add(this.dgvLopMon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhanCongGiangDay";
            this.Text = "frmNhapGiaoVien";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btPhanCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbChuyenMon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMaGV;
        private System.Windows.Forms.ComboBox cbGiaoVien;
    }
}
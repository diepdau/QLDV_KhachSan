namespace QuanLyDichVuKhachSan
{
	partial class frmDSDV
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
			System.Windows.Forms.GroupBox gbLocTim;
			System.Windows.Forms.GroupBox gbDSDV;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSDV));
			this.txtMaTenDV = new System.Windows.Forms.TextBox();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnDSBatDau = new System.Windows.Forms.Button();
			this.btnXoaBoLoc = new System.Windows.Forms.Button();
			this.lblTenMaDV = new System.Windows.Forms.Label();
			this.lvDSDV = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiHome = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDoiMK = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Phong = new System.Windows.Forms.ToolStripMenuItem();
			this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDichVu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTroGiupHD = new System.Windows.Forms.ToolStripMenuItem();
			this.tùyChọnKhácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCheDo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNgonNgu = new System.Windows.Forms.ToolStripMenuItem();
			gbLocTim = new System.Windows.Forms.GroupBox();
			gbDSDV = new System.Windows.Forms.GroupBox();
			gbLocTim.SuspendLayout();
			gbDSDV.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbLocTim
			// 
			gbLocTim.Controls.Add(this.txtMaTenDV);
			gbLocTim.Controls.Add(this.btnCapNhat);
			gbLocTim.Controls.Add(this.btnXoa);
			gbLocTim.Controls.Add(this.btnThem);
			gbLocTim.Controls.Add(this.btnDSBatDau);
			gbLocTim.Controls.Add(this.btnXoaBoLoc);
			gbLocTim.Controls.Add(this.lblTenMaDV);
			gbLocTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			gbLocTim.Location = new System.Drawing.Point(11, 50);
			gbLocTim.Margin = new System.Windows.Forms.Padding(2);
			gbLocTim.Name = "gbLocTim";
			gbLocTim.Padding = new System.Windows.Forms.Padding(2);
			gbLocTim.Size = new System.Drawing.Size(778, 161);
			gbLocTim.TabIndex = 42;
			gbLocTim.TabStop = false;
			gbLocTim.Text = "Lọc và Tìm kiếm";
			// 
			// txtMaTenDV
			// 
			this.txtMaTenDV.Location = new System.Drawing.Point(118, 28);
			this.txtMaTenDV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaTenDV.Name = "txtMaTenDV";
			this.txtMaTenDV.Size = new System.Drawing.Size(232, 23);
			this.txtMaTenDV.TabIndex = 45;
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(616, 64);
			this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(89, 31);
			this.btnCapNhat.TabIndex = 44;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(616, 107);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(89, 28);
			this.btnXoa.TabIndex = 43;
			this.btnXoa.Text = "Xoá ";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(616, 24);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(89, 27);
			this.btnThem.TabIndex = 42;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnDSBatDau
			// 
			this.btnDSBatDau.Location = new System.Drawing.Point(427, 82);
			this.btnDSBatDau.Margin = new System.Windows.Forms.Padding(2);
			this.btnDSBatDau.Name = "btnDSBatDau";
			this.btnDSBatDau.Size = new System.Drawing.Size(120, 40);
			this.btnDSBatDau.TabIndex = 41;
			this.btnDSBatDau.Text = "Danh sách bắt đầu";
			this.btnDSBatDau.UseVisualStyleBackColor = true;
			// 
			// btnXoaBoLoc
			// 
			this.btnXoaBoLoc.Location = new System.Drawing.Point(427, 24);
			this.btnXoaBoLoc.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoaBoLoc.Name = "btnXoaBoLoc";
			this.btnXoaBoLoc.Size = new System.Drawing.Size(120, 34);
			this.btnXoaBoLoc.TabIndex = 40;
			this.btnXoaBoLoc.Text = "Xóa bộ lọc";
			this.btnXoaBoLoc.UseVisualStyleBackColor = true;
			// 
			// lblTenMaDV
			// 
			this.lblTenMaDV.AutoSize = true;
			this.lblTenMaDV.Location = new System.Drawing.Point(10, 28);
			this.lblTenMaDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenMaDV.Name = "lblTenMaDV";
			this.lblTenMaDV.Size = new System.Drawing.Size(89, 15);
			this.lblTenMaDV.TabIndex = 38;
			this.lblTenMaDV.Text = "Tên/Mã dịch vụ";
			// 
			// gbDSDV
			// 
			gbDSDV.Controls.Add(this.lvDSDV);
			gbDSDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			gbDSDV.Location = new System.Drawing.Point(11, 232);
			gbDSDV.Margin = new System.Windows.Forms.Padding(2);
			gbDSDV.Name = "gbDSDV";
			gbDSDV.Padding = new System.Windows.Forms.Padding(2);
			gbDSDV.Size = new System.Drawing.Size(778, 318);
			gbDSDV.TabIndex = 43;
			gbDSDV.TabStop = false;
			gbDSDV.Text = "Danh sách dịch vụ";
			// 
			// lvDSDV
			// 
			this.lvDSDV.CheckBoxes = true;
			this.lvDSDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvDSDV.GridLines = true;
			this.lvDSDV.HideSelection = false;
			this.lvDSDV.Location = new System.Drawing.Point(13, 16);
			this.lvDSDV.Margin = new System.Windows.Forms.Padding(2);
			this.lvDSDV.Name = "lvDSDV";
			this.lvDSDV.Size = new System.Drawing.Size(749, 298);
			this.lvDSDV.TabIndex = 40;
			this.lvDSDV.UseCompatibleStateImageBehavior = false;
			this.lvDSDV.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Dịch Vụ";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 102;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Dịch Vụ";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 156;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đơn giá";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 156;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "ĐVT";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 118;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Lưu ý";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 150;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHome,
            this.tsmi_HoaDon,
            this.tsmiTroGiupHD,
            this.tùyChọnKhácToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(800, 38);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiHome
			// 
			this.tsmiHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsmiHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDangXuat,
            this.tsmiDoiMK});
			this.tsmiHome.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHome.Image")));
			this.tsmiHome.Name = "tsmiHome";
			this.tsmiHome.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
			this.tsmiHome.Size = new System.Drawing.Size(49, 34);
			this.tsmiHome.Text = "Home";
			// 
			// tsmiDangXuat
			// 
			this.tsmiDangXuat.Name = "tsmiDangXuat";
			this.tsmiDangXuat.Size = new System.Drawing.Size(145, 22);
			this.tsmiDangXuat.Text = "Đăng xuất";
			// 
			// tsmiDoiMK
			// 
			this.tsmiDoiMK.Name = "tsmiDoiMK";
			this.tsmiDoiMK.Size = new System.Drawing.Size(145, 22);
			this.tsmiDoiMK.Text = "Đổi mật khẩu";
			// 
			// tsmi_HoaDon
			// 
			this.tsmi_HoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Phong,
            this.hóaĐơnToolStripMenuItem,
            this.tsmiDichVu,
            this.tsmiDoanhThu,
            this.tsmiKhachHang});
			this.tsmi_HoaDon.Name = "tsmi_HoaDon";
			this.tsmi_HoaDon.Size = new System.Drawing.Size(60, 34);
			this.tsmi_HoaDon.Text = "Quản lý";
			// 
			// tsmi_Phong
			// 
			this.tsmi_Phong.Name = "tsmi_Phong";
			this.tsmi_Phong.Size = new System.Drawing.Size(137, 22);
			this.tsmi_Phong.Text = "Phòng";
			// 
			// hóaĐơnToolStripMenuItem
			// 
			this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
			this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
			// 
			// tsmiDichVu
			// 
			this.tsmiDichVu.Name = "tsmiDichVu";
			this.tsmiDichVu.Size = new System.Drawing.Size(137, 22);
			this.tsmiDichVu.Text = "Dịch vụ";
			// 
			// tsmiDoanhThu
			// 
			this.tsmiDoanhThu.Name = "tsmiDoanhThu";
			this.tsmiDoanhThu.Size = new System.Drawing.Size(137, 22);
			this.tsmiDoanhThu.Text = "Doanh thu";
			// 
			// tsmiKhachHang
			// 
			this.tsmiKhachHang.Name = "tsmiKhachHang";
			this.tsmiKhachHang.Size = new System.Drawing.Size(137, 22);
			this.tsmiKhachHang.Text = "Khách hàng";
			// 
			// tsmiTroGiupHD
			// 
			this.tsmiTroGiupHD.Name = "tsmiTroGiupHD";
			this.tsmiTroGiupHD.Size = new System.Drawing.Size(111, 34);
			this.tsmiTroGiupHD.Text = "Trợ giúp và HDSD";
			// 
			// tùyChọnKhácToolStripMenuItem
			// 
			this.tùyChọnKhácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheDo,
            this.tsmiNgonNgu});
			this.tùyChọnKhácToolStripMenuItem.Name = "tùyChọnKhácToolStripMenuItem";
			this.tùyChọnKhácToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
			this.tùyChọnKhácToolStripMenuItem.Text = "Tùy chọn khác";
			// 
			// tsmiCheDo
			// 
			this.tsmiCheDo.Name = "tsmiCheDo";
			this.tsmiCheDo.Size = new System.Drawing.Size(128, 22);
			this.tsmiCheDo.Text = "Chế độ";
			// 
			// tsmiNgonNgu
			// 
			this.tsmiNgonNgu.Name = "tsmiNgonNgu";
			this.tsmiNgonNgu.Size = new System.Drawing.Size(128, 22);
			this.tsmiNgonNgu.Text = "Ngôn ngữ";
			// 
			// frmDSDV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(gbDSDV);
			this.Controls.Add(gbLocTim);
			this.Controls.Add(this.menuStrip1);
			this.Name = "frmDSDV";
			this.Text = "DanhSachDV";
			gbLocTim.ResumeLayout(false);
			gbLocTim.PerformLayout();
			gbDSDV.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiHome;
		private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
		private System.Windows.Forms.ToolStripMenuItem tsmiDoiMK;
		private System.Windows.Forms.ToolStripMenuItem tsmi_HoaDon;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Phong;
		private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiDichVu;
		private System.Windows.Forms.ToolStripMenuItem tsmiDoanhThu;
		private System.Windows.Forms.ToolStripMenuItem tsmiKhachHang;
		private System.Windows.Forms.ToolStripMenuItem tsmiTroGiupHD;
		private System.Windows.Forms.ToolStripMenuItem tùyChọnKhácToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiCheDo;
		private System.Windows.Forms.ToolStripMenuItem tsmiNgonNgu;
		private System.Windows.Forms.TextBox txtMaTenDV;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnDSBatDau;
		private System.Windows.Forms.Button btnXoaBoLoc;
		private System.Windows.Forms.Label lblTenMaDV;
		private System.Windows.Forms.ListView lvDSDV;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}
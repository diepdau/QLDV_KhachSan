namespace QuanLyDichVuKhachSan
{
	partial class frmDoanhThu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
			this.gbThongKe = new System.Windows.Forms.GroupBox();
			this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
			this.txtTienGiam = new System.Windows.Forms.TextBox();
			this.txtTienDichVu = new System.Windows.Forms.TextBox();
			this.txtTongDichVu = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lvListDoanhThu = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gbChonTG = new System.Windows.Forms.GroupBox();
			this.dtpNgayKTDT = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayBDDT = new System.Windows.Forms.DateTimePicker();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnXem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			this.gbThongKe.SuspendLayout();
			this.gbChonTG.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbThongKe
			// 
			this.gbThongKe.Controls.Add(this.txtTongDoanhThu);
			this.gbThongKe.Controls.Add(this.txtTienGiam);
			this.gbThongKe.Controls.Add(this.txtTienDichVu);
			this.gbThongKe.Controls.Add(this.txtTongDichVu);
			this.gbThongKe.Controls.Add(this.label6);
			this.gbThongKe.Controls.Add(this.label5);
			this.gbThongKe.Controls.Add(this.label4);
			this.gbThongKe.Controls.Add(this.label3);
			this.gbThongKe.Location = new System.Drawing.Point(374, 53);
			this.gbThongKe.Name = "gbThongKe";
			this.gbThongKe.Size = new System.Drawing.Size(309, 170);
			this.gbThongKe.TabIndex = 1;
			this.gbThongKe.TabStop = false;
			this.gbThongKe.Text = "Thống kê";
			// 
			// txtTongDoanhThu
			// 
			this.txtTongDoanhThu.Location = new System.Drawing.Point(127, 123);
			this.txtTongDoanhThu.Name = "txtTongDoanhThu";
			this.txtTongDoanhThu.ReadOnly = true;
			this.txtTongDoanhThu.Size = new System.Drawing.Size(162, 20);
			this.txtTongDoanhThu.TabIndex = 7;
			this.txtTongDoanhThu.TextChanged += new System.EventHandler(this.txtTongDoanhThu_TextChanged);
			// 
			// txtTienGiam
			// 
			this.txtTienGiam.Location = new System.Drawing.Point(127, 95);
			this.txtTienGiam.Name = "txtTienGiam";
			this.txtTienGiam.ReadOnly = true;
			this.txtTienGiam.Size = new System.Drawing.Size(162, 20);
			this.txtTienGiam.TabIndex = 6;
			// 
			// txtTienDichVu
			// 
			this.txtTienDichVu.Location = new System.Drawing.Point(127, 67);
			this.txtTienDichVu.Name = "txtTienDichVu";
			this.txtTienDichVu.ReadOnly = true;
			this.txtTienDichVu.Size = new System.Drawing.Size(162, 20);
			this.txtTienDichVu.TabIndex = 5;
			// 
			// txtTongDichVu
			// 
			this.txtTongDichVu.Location = new System.Drawing.Point(127, 39);
			this.txtTongDichVu.Name = "txtTongDichVu";
			this.txtTongDichVu.ReadOnly = true;
			this.txtTongDichVu.Size = new System.Drawing.Size(162, 20);
			this.txtTongDichVu.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Tổng doanh thu:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Tiền giảm:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tổng tiền dịch vụ:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tổng dịch vụ:";
			// 
			// lvListDoanhThu
			// 
			this.lvListDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvListDoanhThu.GridLines = true;
			this.lvListDoanhThu.HideSelection = false;
			this.lvListDoanhThu.Location = new System.Drawing.Point(32, 246);
			this.lvListDoanhThu.Margin = new System.Windows.Forms.Padding(2);
			this.lvListDoanhThu.Name = "lvListDoanhThu";
			this.lvListDoanhThu.Size = new System.Drawing.Size(651, 288);
			this.lvListDoanhThu.TabIndex = 8;
			this.lvListDoanhThu.UseCompatibleStateImageBehavior = false;
			this.lvListDoanhThu.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã dịch vụ";
			this.columnHeader1.Width = 70;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên dịch vụ";
			this.columnHeader2.Width = 148;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số lượng";
			this.columnHeader3.Width = 70;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "DVT";
			this.columnHeader4.Width = 70;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Thành tiền";
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ghi Chú";
			this.columnHeader6.Width = 200;
			// 
			// gbChonTG
			// 
			this.gbChonTG.Controls.Add(this.dtpNgayKTDT);
			this.gbChonTG.Controls.Add(this.dtpNgayBDDT);
			this.gbChonTG.Controls.Add(this.btnIn);
			this.gbChonTG.Controls.Add(this.btnXem);
			this.gbChonTG.Controls.Add(this.label2);
			this.gbChonTG.Controls.Add(this.label1);
			this.gbChonTG.Location = new System.Drawing.Point(32, 53);
			this.gbChonTG.Name = "gbChonTG";
			this.gbChonTG.Size = new System.Drawing.Size(304, 170);
			this.gbChonTG.TabIndex = 2;
			this.gbChonTG.TabStop = false;
			this.gbChonTG.Text = "Chọn khoảng thời gian";
			// 
			// dtpNgayKTDT
			// 
			this.dtpNgayKTDT.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayKTDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayKTDT.Location = new System.Drawing.Point(86, 68);
			this.dtpNgayKTDT.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgayKTDT.Name = "dtpNgayKTDT";
			this.dtpNgayKTDT.Size = new System.Drawing.Size(184, 20);
			this.dtpNgayKTDT.TabIndex = 7;
			// 
			// dtpNgayBDDT
			// 
			this.dtpNgayBDDT.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayBDDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayBDDT.Location = new System.Drawing.Point(86, 34);
			this.dtpNgayBDDT.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgayBDDT.Name = "dtpNgayBDDT";
			this.dtpNgayBDDT.Size = new System.Drawing.Size(184, 20);
			this.dtpNgayBDDT.TabIndex = 6;
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(195, 121);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(75, 23);
			this.btnIn.TabIndex = 5;
			this.btnIn.Text = "In";
			this.btnIn.UseVisualStyleBackColor = true;
			// 
			// btnXem
			// 
			this.btnXem.Location = new System.Drawing.Point(86, 121);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(75, 23);
			this.btnXem.TabIndex = 2;
			this.btnXem.Text = "Xem";
			this.btnXem.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đến ngày:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày:";
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(800, 40);
			this.menuStrip1.TabIndex = 9;
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
			// frmDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.lvListDoanhThu);
			this.Controls.Add(this.gbChonTG);
			this.Controls.Add(this.gbThongKe);
			this.Name = "frmDoanhThu";
			this.Text = "Báo cáo doanh thu";
			this.gbThongKe.ResumeLayout(false);
			this.gbThongKe.PerformLayout();
			this.gbChonTG.ResumeLayout(false);
			this.gbChonTG.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbThongKe;
		private System.Windows.Forms.ListView lvListDoanhThu;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.TextBox txtTongDoanhThu;
		private System.Windows.Forms.TextBox txtTienGiam;
		private System.Windows.Forms.TextBox txtTienDichVu;
		private System.Windows.Forms.TextBox txtTongDichVu;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gbChonTG;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.DateTimePicker dtpNgayKTDT;
		private System.Windows.Forms.DateTimePicker dtpNgayBDDT;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}
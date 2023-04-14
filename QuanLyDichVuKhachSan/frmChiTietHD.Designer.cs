namespace QuanLyDichVuKhachSan
{
	partial class frmChiTietHD
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHD));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvChiThietDichVu = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
			this.txtTenChu = new System.Windows.Forms.TextBox();
			this.txtSoKhach = new System.Windows.Forms.TextBox();
			this.txtSoPhong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.cbTrangThai = new System.Windows.Forms.ComboBox();
			this.dtpNgayKetThucThuc = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayBatDauDichVu = new System.Windows.Forms.DateTimePicker();
			this.txtTongThanhTien = new System.Windows.Forms.TextBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvChiThietDichVu);
			this.groupBox1.Controls.Add(this.mtbSDT);
			this.groupBox1.Controls.Add(this.txtTenChu);
			this.groupBox1.Controls.Add(this.txtSoKhach);
			this.groupBox1.Controls.Add(this.txtSoPhong);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(11, 42);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(778, 304);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Phòng";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lvChiThietDichVu
			// 
			this.lvChiThietDichVu.CheckBoxes = true;
			this.lvChiThietDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lvChiThietDichVu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvChiThietDichVu.GridLines = true;
			this.lvChiThietDichVu.HideSelection = false;
			this.lvChiThietDichVu.Location = new System.Drawing.Point(2, 122);
			this.lvChiThietDichVu.Margin = new System.Windows.Forms.Padding(2);
			this.lvChiThietDichVu.Name = "lvChiThietDichVu";
			this.lvChiThietDichVu.Size = new System.Drawing.Size(774, 180);
			this.lvChiThietDichVu.TabIndex = 3;
			this.lvChiThietDichVu.UseCompatibleStateImageBehavior = false;
			this.lvChiThietDichVu.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Dịch Vụ";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên Dịch Vụ";
			this.columnHeader2.Width = 76;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Giá";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số Lượng";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "DVT";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Thành Tiền";
			this.columnHeader6.Width = 80;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ghi chú";
			// 
			// mtbSDT
			// 
			this.mtbSDT.Location = new System.Drawing.Point(446, 66);
			this.mtbSDT.Margin = new System.Windows.Forms.Padding(2);
			this.mtbSDT.Mask = "0000.000.000";
			this.mtbSDT.Name = "mtbSDT";
			this.mtbSDT.Size = new System.Drawing.Size(178, 20);
			this.mtbSDT.TabIndex = 2;
			// 
			// txtTenChu
			// 
			this.txtTenChu.Location = new System.Drawing.Point(446, 27);
			this.txtTenChu.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenChu.Name = "txtTenChu";
			this.txtTenChu.Size = new System.Drawing.Size(178, 20);
			this.txtTenChu.TabIndex = 1;
			this.txtTenChu.TextChanged += new System.EventHandler(this.txtTenChu_TextChanged);
			// 
			// txtSoKhach
			// 
			this.txtSoKhach.Location = new System.Drawing.Point(94, 66);
			this.txtSoKhach.Margin = new System.Windows.Forms.Padding(2);
			this.txtSoKhach.Name = "txtSoKhach";
			this.txtSoKhach.Size = new System.Drawing.Size(178, 20);
			this.txtSoKhach.TabIndex = 1;
			this.txtSoKhach.TextChanged += new System.EventHandler(this.txtSoKhach_TextChanged);
			// 
			// txtSoPhong
			// 
			this.txtSoPhong.Location = new System.Drawing.Point(94, 25);
			this.txtSoPhong.Margin = new System.Windows.Forms.Padding(2);
			this.txtSoPhong.Name = "txtSoPhong";
			this.txtSoPhong.Size = new System.Drawing.Size(178, 20);
			this.txtSoPhong.TabIndex = 1;
			this.txtSoPhong.TextChanged += new System.EventHandler(this.txtSoPhong_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(350, 73);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số Điện Thoại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(350, 30);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên Chủ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số Khách";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số Phòng";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "empty-room.png");
			this.imageList1.Images.SetKeyName(1, "fill-room.png");
			this.imageList1.Images.SetKeyName(2, "use-services-room.png");
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnIn);
			this.groupBox2.Controls.Add(this.cbTrangThai);
			this.groupBox2.Controls.Add(this.dtpNgayKetThucThuc);
			this.groupBox2.Controls.Add(this.dtpNgayBatDauDichVu);
			this.groupBox2.Controls.Add(this.txtTongThanhTien);
			this.groupBox2.Controls.Add(this.txtGhiChu);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(11, 364);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(778, 186);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin Dịch Vụ";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(596, 122);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(56, 19);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(507, 122);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(56, 19);
			this.btnHuy.TabIndex = 4;
			this.btnHuy.Text = "S";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(423, 122);
			this.btnIn.Margin = new System.Windows.Forms.Padding(2);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(56, 19);
			this.btnIn.TabIndex = 4;
			this.btnIn.Text = "In";
			this.btnIn.UseVisualStyleBackColor = true;
			// 
			// cbTrangThai
			// 
			this.cbTrangThai.FormattingEnabled = true;
			this.cbTrangThai.Items.AddRange(new object[] {
            "Còn DV",
            "Hết DV"});
			this.cbTrangThai.Location = new System.Drawing.Point(532, 20);
			this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2);
			this.cbTrangThai.Name = "cbTrangThai";
			this.cbTrangThai.Size = new System.Drawing.Size(120, 21);
			this.cbTrangThai.TabIndex = 3;
			// 
			// dtpNgayKetThucThuc
			// 
			this.dtpNgayKetThucThuc.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayKetThucThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayKetThucThuc.Location = new System.Drawing.Point(153, 62);
			this.dtpNgayKetThucThuc.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgayKetThucThuc.Name = "dtpNgayKetThucThuc";
			this.dtpNgayKetThucThuc.Size = new System.Drawing.Size(151, 20);
			this.dtpNgayKetThucThuc.TabIndex = 2;
			// 
			// dtpNgayBatDauDichVu
			// 
			this.dtpNgayBatDauDichVu.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayBatDauDichVu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayBatDauDichVu.Location = new System.Drawing.Point(153, 22);
			this.dtpNgayBatDauDichVu.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgayBatDauDichVu.Name = "dtpNgayBatDauDichVu";
			this.dtpNgayBatDauDichVu.Size = new System.Drawing.Size(151, 20);
			this.dtpNgayBatDauDichVu.TabIndex = 2;
			// 
			// txtTongThanhTien
			// 
			this.txtTongThanhTien.Location = new System.Drawing.Point(153, 119);
			this.txtTongThanhTien.Margin = new System.Windows.Forms.Padding(2);
			this.txtTongThanhTien.Name = "txtTongThanhTien";
			this.txtTongThanhTien.Size = new System.Drawing.Size(76, 20);
			this.txtTongThanhTien.TabIndex = 1;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(532, 62);
			this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(120, 20);
			this.txtGhiChu.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(420, 69);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Ghi chú";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(420, 27);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Trạng Thái";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 122);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tổng Thành Tiền";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 68);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày Kết Thúc Dịch Vụ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 27);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ngày Bắt Đầu Dịch Vụ";
			// 
			// frmChiTietHD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChiTietHD";
			this.Text = "Chi tiết hóa đơn";
			this.Load += new System.EventHandler(this.frmChiTietHD_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvChiThietDichVu;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.MaskedTextBox mtbSDT;
		private System.Windows.Forms.TextBox txtTenChu;
		private System.Windows.Forms.TextBox txtSoKhach;
		private System.Windows.Forms.TextBox txtSoPhong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.ComboBox cbTrangThai;
		private System.Windows.Forms.DateTimePicker dtpNgayKetThucThuc;
		private System.Windows.Forms.DateTimePicker dtpNgayBatDauDichVu;
		private System.Windows.Forms.TextBox txtTongThanhTien;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}
namespace QuanLyDichVuKhachSan
{
	partial class frmDoiMatKhau
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLuuMK = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.txtMKHienTai = new System.Windows.Forms.TextBox();
			this.txtMKMoi = new System.Windows.Forms.TextBox();
			this.txtMKMoi2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mật khẩu hiện tại:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu mới:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nhập lại mật khẩu mới:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(54, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(229, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Vui lòng nhập đầy đủ thông tin rồi nhấn nút lưu";
			// 
			// btnLuuMK
			// 
			this.btnLuuMK.Location = new System.Drawing.Point(126, 169);
			this.btnLuuMK.Name = "btnLuuMK";
			this.btnLuuMK.Size = new System.Drawing.Size(94, 27);
			this.btnLuuMK.TabIndex = 4;
			this.btnLuuMK.Text = "Lưu";
			this.btnLuuMK.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(285, 169);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(94, 27);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// txtMKHienTai
			// 
			this.txtMKHienTai.Location = new System.Drawing.Point(179, 32);
			this.txtMKHienTai.Name = "txtMKHienTai";
			this.txtMKHienTai.Size = new System.Drawing.Size(216, 20);
			this.txtMKHienTai.TabIndex = 6;
			// 
			// txtMKMoi
			// 
			this.txtMKMoi.Location = new System.Drawing.Point(179, 63);
			this.txtMKMoi.Name = "txtMKMoi";
			this.txtMKMoi.Size = new System.Drawing.Size(216, 20);
			this.txtMKMoi.TabIndex = 7;
			// 
			// txtMKMoi2
			// 
			this.txtMKMoi2.Location = new System.Drawing.Point(179, 94);
			this.txtMKMoi2.Name = "txtMKMoi2";
			this.txtMKMoi2.Size = new System.Drawing.Size(216, 20);
			this.txtMKMoi2.TabIndex = 8;
			// 
			// frmDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 217);
			this.Controls.Add(this.txtMKMoi2);
			this.Controls.Add(this.txtMKMoi);
			this.Controls.Add(this.txtMKHienTai);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLuuMK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmDoiMatKhau";
			this.Text = "Đổi mật khẩu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLuuMK;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.TextBox txtMKHienTai;
		private System.Windows.Forms.TextBox txtMKMoi;
		private System.Windows.Forms.TextBox txtMKMoi2;
	}
}
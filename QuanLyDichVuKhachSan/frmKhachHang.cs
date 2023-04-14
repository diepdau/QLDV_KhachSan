using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDichVuKhachSan
{
	public partial class frmKhachHang : Form
	{
		public frmKhachHang()
		{
			InitializeComponent();
		}

		private void btnChiTietKH_Click(object sender, EventArgs e)
		{
			
		}

		private void btnXoaKH_Click(object sender, EventArgs e)
		{
			txtChiTietKH.Text = "";
			txtDiaChiKH.Text = "";
		}
	}
}

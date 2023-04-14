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
	public partial class frmDSDV : Form
	{
		public frmDSDV()
		{
			InitializeComponent();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			frmCapNhatDV capnhatDV=new frmCapNhatDV();
			capnhatDV.ShowDialog();
		}
	}
}

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
	public partial class frmChinh : Form
	{
		public frmChinh()
		{
			InitializeComponent();
		}

		private void tsmiHome_Click(object sender, EventArgs e)
		{

		}

		//private void cbbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//    cbbDichVu.Items.Clear();

		//    // Lấy loại dịch vụ được chọn trong CbbLoaiDichVu
		//    string selectedService = cbbLoaiDichVu.SelectedItem.ToString();

		//    // Thêm các mục con của loại dịch vụ được chọn vào CbbDichVu
		//    switch (selectedService)
		//    {
		//        case "Ăn uống":
		//            cbbDichVu.Items.Add("Nhà hàng");
		//            cbbDichVu.Items.Add("Quầy bar");
		//            break;
		//        case "Spa":
		//            cbbDichVu.Items.Add("Massage - bấm huyệt");
		//            cbbDichVu.Items.Add("Chăm sóc da mặt");
		//            cbbDichVu.Items.Add("Tắm trắng- tắm dưỡng");
		//            cbbDichVu.Items.Add("Xông hơi");
		//            break;
		//        case "Đi lại":
		//            cbbDichVu.Items.Add("Đưa đón sân bay");
		//            cbbDichVu.Items.Add("Thuê xe tự lái");
		//            break;
		//        case "Giặt là":
		//            cbbDichVu.Items.Add("Giặt khô");
		//            cbbDichVu.Items.Add("Giặt ướt");
		//            break;
		//        case "Giải trí":
		//            cbbDichVu.Items.Add("Sân golf và tennis");
		//            cbbDichVu.Items.Add("Phòng thể hình");
		//            cbbDichVu.Items.Add("Khu vui chơi phức hợp");
		//            cbbDichVu.Items.Add("Phòng karaoke");
		//            break;
		//    }
		//}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gbLoaiDV_Enter(object sender, EventArgs e)
		{
			if (rdAnUong.Checked)
			{
				cbbDichVu.Items.Clear();
				cbbDichVu.Items.Add("Nhà hàng");
				cbbDichVu.Items.Add("Quầy bar");
			}
			else if (rdSpa.Checked)
			{
				cbbDichVu.Items.Clear();
				cbbDichVu.Items.Add("Massage - bấm huyệt");
				cbbDichVu.Items.Add("Chăm sóc da mặt");
				cbbDichVu.Items.Add("Tắm trắng- tắm dưỡng");
				cbbDichVu.Items.Add("Xông hơi");
			}
			else if (rdDiLai.Checked)
			{
				cbbDichVu.Items.Clear();
				cbbDichVu.Items.Add("Đưa đón sân bay");
				cbbDichVu.Items.Add("Thuê xe tự lái");
			}
			else if (rdGiatLa.Checked)
			{
				cbbDichVu.Items.Clear();
				cbbDichVu.Items.Add("Giặt khô");
				cbbDichVu.Items.Add("Giặt ướt");
			}
			else if (rdGiaiTri.Checked)
			{
				cbbDichVu.Items.Clear();
				cbbDichVu.Items.Add("Sân golf và tennis");
				cbbDichVu.Items.Add("Phòng thể hình");
				cbbDichVu.Items.Add("Khu vui chơi phức hợp");
				cbbDichVu.Items.Add("Phòng karaoke");
			}
		}

		private void tsmiDoanhThu_Click(object sender, EventArgs e)
		{
			frmDoanhThu doanhThu = new frmDoanhThu();
			doanhThu.ShowDialog();
		}

		private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHoaDon hoaDon = new frmHoaDon();
			hoaDon.ShowDialog();
		}

		private void tsmiKhachHang_Click(object sender, EventArgs e)
		{
			frmKhachHang khachHang = new frmKhachHang();
			khachHang.ShowDialog();
		}

		private void tsmiDoiMK_Click(object sender, EventArgs e)
		{
			frmDoiMatKhau doimk = new frmDoiMatKhau();
			doimk.ShowDialog();
		}

		private void tsmiDichVu_Click(object sender, EventArgs e)
		{
			frmDSDV dsdv = new frmDSDV();
			dsdv.ShowDialog();
		}

		private void tsmi_Phong_Click(object sender, EventArgs e)
		{
			frmPhong phong = new frmPhong();
			phong.ShowDialog();
		}
	}
}

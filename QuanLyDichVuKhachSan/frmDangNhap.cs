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
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			/*Nhận giá trị của người dùng vào hộp txtNhapmatkhau và txtNhaptentaikhoan.
			  kiểm tra xem một trong 2 textbox có rỗng hay chỉ chứa khoảng trắng 
			  thì hộp thoại thông báo sẽ hiện thị và quay lại chương trình quay lại.
			  Cả hai textbox đều chứa dữ liệu, chương trình sẽ tìm tài khoản người dùng .
			  Nếu tài khoản được tìm thấy, ctr tiến hành bấm mật khauae cho người dùng
			  và so sánh nó với mật khẩu băm được lưu trữ trong đối tượng tài khoản.
Nếu			  hai mật khẩu băm khớp nhau, thì người dùng được coi là đã xác thực và được cập nhật với thông tin của người dùng đã xác thực.
			  Nếu mật khẩu băm không khớp, thông báo lỗi sẽ hiển thị cho người dùng.
Nếu			  không tìm thấy tài khoản trong danh sách "WorkingContext.AccountList", một thông báo lỗi sẽ hiển thị cho người dùng cho biết tên người dùng đã nhập không tồn tại trong hệ thống.
			 */
			frmChinh main = new frmChinh();
			main.ShowDialog();
			
		}
	}
}

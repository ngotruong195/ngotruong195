using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lớp_Entites;
using System.Threading.Tasks;

namespace Lớp_DAL
{
	public class SQL_tblKhachHang
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblKhachHang et)
		{
			this.cn.thucthicaulenh("INSERT INTO DMKhachHang (makh, tenkh, sdtkh, emailkh, diachikh) VALUES  (N'" + et.Makh + "',N'" + et.Tenkh + "',N'" + et.Sdtkh + "',N'" + et.Emailkh + "',N'" + et.Diachikh + "')");
		}

		public void suadulieu(EC_tblKhachHang et)
		{
			this.cn.thucthicaulenh("UPDATE DMKhachHang SET  tenkh =N'" + et.Tenkh + "', emailkh =N'" + et.Emailkh + "', sdtkh =N'" + et.Sdtkh + "', diachikh =N'" + et.Diachikh + "'  Where makh=N'" + et.Makh + "'  ");
		}

		public void xoadulieu(EC_tblKhachHang et)
		{
			this.cn.thucthicaulenh("DELETE FROM DMKhachHang Where makh=N'" + et.Makh + "'  ");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From DMKhachHang " + DieuKien);
		}
	}
}

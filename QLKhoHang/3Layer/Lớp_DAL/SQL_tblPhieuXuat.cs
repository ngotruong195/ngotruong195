using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lớp_Entites;

namespace Lớp_DAL
{
	public class SQL_tblPhieuXuat
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblPhieuXuat et)
		{
			this.cn.thucthicaulenh("INSERT INTO PhieuXuat (MaPXK, NgayXuat, NguoiXuat, makh, mahh) VALUES ('" + et.MaPXK + "','" + et.NgayXuat + "','" + et.NguoiXuat + "','" + et.Makh + "','" + et.Mahh + "')");
		}

		public void suadulieu(EC_tblPhieuXuat et)
		{
			this.cn.thucthicaulenh("UPDATE PhieuXuat SET NgayXuat ='" + et.NgayXuat + "', NguoiXuat ='" + et.NguoiXuat + "', makh ='" + et.Makh + "', mahh ='" + et.Mahh + "' Where MaPXK=N'" + et.MaPXK + "' ");
		}

		public void xoadulieu(EC_tblPhieuXuat et)
		{
			this.cn.thucthicaulenh("DELETE FROM PhieuXuat Where MaPXK=N'" + et.MaPXK + "'");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From PhieuXuat " + DieuKien);
		}

		public DataTable laydulieuKH(string DieuKien)
		{
			return this.cn.GetDataTable("Select makh, tenkh From PhieuXuat " + DieuKien);
		}

		public DataTable laydulieuPXK(string DieuKien)
		{
			return this.cn.GetDataTable("Select MaPXK, NgayXuat From PhieuXuat " + DieuKien);
		}
	}
}

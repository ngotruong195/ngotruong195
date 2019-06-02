using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lớp_Entites;
using System.Data;

namespace Lớp_DAL
{
	public class SQL_tblChiTietPXK
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblChiTietPXK et)
		{
			this.cn.thucthicaulenh("INSERT INTO ChiTietPXK (MaPXK, TenHangXuat, SoLuongXuat, DonViTinh) VALUES ('" + et.MaPXK + "','" + et.TenHangXuat + "','" + et.SoLuongXuat + "','" + et.DonViTinh + "')");
		}

		public void suadulieu(EC_tblChiTietPXK et)
		{
			this.cn.thucthicaulenh("UPDATE ChiTietPXK SET TenHangXuat ='" + et.TenHangXuat + "', SoLuongXuat ='" + et.SoLuongXuat + "', DonViTinh ='" + et.DonViTinh + "' where MaPXK='" + et.MaPXK + "' ");
		}

		public void xoadulieu(EC_tblChiTietPXK et)
		{
			this.cn.thucthicaulenh("DELETE FROM ChiTietPXK where where MaPXK='" + et.MaPXK + "'");
		}

		public DataTable laydulieu(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From DMHangHoa " + DieuKien);
		}

		public DataTable laydulieuPXK(string DieuKien)
		{
			return this.cn.GetDataTable("Select MaPXK, NgayXuat From PhieuXuat " + DieuKien);
		}
	}
}

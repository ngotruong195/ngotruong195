using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lớp_Entites;

namespace Lớp_DAL
{
	public class SQL_tblChiTietPNK
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblChiTietPNK et)
		{
			this.cn.thucthicaulenh("INSERT INTO ChiTietPNK (MaPNK, TenHangNhap, SoLuongNhap, DonViTinh) VALUES ('" + et.MaPNK + "','" + et.TenHangNhap + "','" + et.SoLuongNhap + "','" + et.DonViTinh + "')");
		}

		public void suadulieu(EC_tblChiTietPNK et)
		{
			this.cn.thucthicaulenh("UPDATE ChiTietPNK SET TenHangNhap ='" + et.TenHangNhap + "', SoLuongNhap ='" + et.SoLuongNhap + "', DonViTinh ='" + et.DonViTinh + "' where MaPNK='" + et.MaPNK + "'");
		}

		public void xoadulieu(EC_tblChiTietPNK et)
		{
			this.cn.thucthicaulenh("DELETE FROM ChiTietPNK where MaPNK='" + et.MaPNK + "'");
		}

		public DataTable laydulieu(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From DMHangHoa " + DieuKien);
		}

		public DataTable laydulieuPNK(string DieuKien)
		{
			return this.cn.GetDataTable("Select MaPNK, NgayNhap From PhieuXuat " + DieuKien);
		}
	}
}

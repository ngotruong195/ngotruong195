using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lớp_Entites;

namespace Lớp_DAL
{
	public class SQL_tblTaiKhoanNV
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblQLTaiKhoan et)
		{
			this.cn.thucthicaulenh("INSERT INTO TaiKhoanNV (MaTK, TenTK, MKTK, NhanVienQL) VALUES ('" + et.MaTK + "','" + et.TenTK + "','" + et.MKTK + "','" + et.NhanVienQL + "')");
		}

		public void suadulieu(EC_tblQLTaiKhoan et)
		{
			this.cn.thucthicaulenh("UPDATE TaiKhoanNV SET TenTK ='" + et.TenTK + "', MKTK ='" + et.MKTK + "' where NhanVienQL='" + et.NhanVienQL + "'");
		}

		public void xoadulieu(EC_tblQLTaiKhoan et)
		{
			this.cn.thucthicaulenh("DELETE FROM TaiKhoanNV where NhanVienQL='" + et.NhanVienQL + "'");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From TaiKhoanNV " + DieuKien);
		}
	}
}

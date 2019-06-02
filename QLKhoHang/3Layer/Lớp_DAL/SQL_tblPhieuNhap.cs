using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lớp_Entites;

namespace Lớp_DAL
{
	public class SQL_tblPhieuNhap
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblPhieuNhap et)
		{
			this.cn.thucthicaulenh("INSERT INTO PhieuNhap (MaPNK, NgayNhap, NguoiNhap, mancc, mahh) VALUES ('" + et.MaPNK + "','" + et.NgayNhap + "','" + et.NguoiNhap + "','" + et.Mancc + "','" + et.Mahh + "')");
		}

		public void suadulieu(EC_tblPhieuNhap et)
		{
			this.cn.thucthicaulenh("UPDATE PhieuNhap SET NgayNhap ='" + et.NgayNhap + "', NguoiNhap ='" + et.NguoiNhap + "', mancc ='" + et.Mancc + "', mahh ='" + et.Mahh + "' where MaPNK='" + et.MaPNK + "' ");
		}

		public void xoadulieu(EC_tblPhieuNhap et)
		{
			this.cn.thucthicaulenh("DELETE FROM PhieuNhap where MaPNK='" + et.MaPNK + "'");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From PhieuNhap " + DieuKien);
		}

		public DataTable laydulieuNCC(string DieuKien)
		{
			return this.cn.GetDataTable("Select mancc, tenncc From PhieuXuat " + DieuKien);
		}

		public DataTable laydulieuHH(string DieuKien)
		{
			return this.cn.GetDataTable("Select mahh, tenhh From PhieuXuat " + DieuKien);
		}

		public DataTable laydulieuTK(string DieuKien)
		{
			return this.cn.GetDataTable("Select TenTK, NhanVienQL From PhieuXuat " + DieuKien);
		}
	}
}

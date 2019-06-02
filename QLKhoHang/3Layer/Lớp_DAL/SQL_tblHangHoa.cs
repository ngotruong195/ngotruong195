using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lớp_Entites;
using System.Data;

namespace Lớp_DAL
{
	public class SQL_tblHangHoa
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblHangHoa et)
		{
			this.cn.thucthicaulenh("INSERT INTO DMHangHoa  (mahh, tenhh, soluong, donvitinh, ngaynhap) VALUES ('" + et.Mahh + "',N'" + et.Tenhh + "','" + et.Soluong + "',N'" + et.Donvitinh + "','" + et.Ngaynhap + "')");
		}

		public void suadulieu(EC_tblHangHoa et)
		{
			this.cn.thucthicaulenh("UPDATE DMHangHoa SET tenhh =N'" + et.Tenhh + "', soluong ='" + et.Soluong + "', donvitinh =N'" + et.Donvitinh + "', ngaynhap ='" + et.Ngaynhap + "' where mahh='" + et.Mahh + "'");
		}

		public void xoadulieu(EC_tblHangHoa et)
		{
			this.cn.thucthicaulenh("DELETE FROM DMHangHoa where mahh='" + et.Mahh + "'");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From DMHangHoa " + DieuKien);
		}
	}
}

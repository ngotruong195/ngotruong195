using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lớp_DAL;
using System.Data;
using Lớp_Entites;

namespace Lớp_BUS
{
	public class BUS_tblKhachHang
	{
		private SQL_tblKhachHang sql = new SQL_tblKhachHang();

		public void themdulieu(EC_tblKhachHang et)
		{
			this.sql.themdulieu(et);
		}

		public void suadulieu(EC_tblKhachHang et)
		{
			this.sql.suadulieu(et);
		}

		public void xoadulieu(EC_tblKhachHang et)
		{
			this.sql.xoadulieu(et);
		}

		public DataTable taobang(string DieuKien)
		{
			return this.sql.taobang(DieuKien);
		}
	}
}

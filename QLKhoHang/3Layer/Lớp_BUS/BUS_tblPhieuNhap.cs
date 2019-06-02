using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lớp_DAL;
using Lớp_Entites;
using System.Data;
namespace Lớp_BUS
{
	public class BUS_tblPhieuNhap
	{
		private SQL_tblPhieuNhap sql = new SQL_tblPhieuNhap();

		public void themdulieu(EC_tblPhieuNhap et)
		{
			this.sql.themdulieu(et);
		}

		public void suadulieu(EC_tblPhieuNhap et)
		{
			this.sql.suadulieu(et);
		}

		public void xoadulieu(EC_tblPhieuNhap et)
		{
			this.sql.xoadulieu(et);
		}

		public DataTable taobang(string DieuKien)
		{
			return this.sql.taobang(DieuKien);
		}
	}
}

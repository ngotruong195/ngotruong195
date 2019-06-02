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
	public class BUS_tblNhaCungCap
	{
		private SQL_tblNhaCungCap sql = new SQL_tblNhaCungCap();

		public void themdulieu(EC_tblNhaCungCap et)
		{
			this.sql.themdulieu(et);
		}

		public void suadulieu(EC_tblNhaCungCap et)
		{
			this.sql.suadulieu(et);
		}

		public void xoadulieu(EC_tblNhaCungCap et)
		{
			this.sql.xoadulieu(et);
		}

		public DataTable taobang(string DieuKien)
		{
			return this.sql.taobang(DieuKien);
		}
	}
}

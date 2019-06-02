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
	public class BUS_tblChiTietPXK
	{
		private SQL_tblChiTietPXK sql = new SQL_tblChiTietPXK();

		public void themdulieu(EC_tblChiTietPXK et)
		{
			this.sql.themdulieu(et);
		}

		public void suadulieu(EC_tblChiTietPXK et)
		{
			this.sql.suadulieu(et);
		}

		public void xoadulieu(EC_tblChiTietPXK et)
		{
			this.sql.xoadulieu(et);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lớp_Entites;
using Lớp_DAL;

namespace Lớp_BUS
{
	public class BUS_tblChiTietPNK
	{
		private SQL_tblChiTietPNK sql = new SQL_tblChiTietPNK();

		public void themdulieu(EC_tblChiTietPNK et)
		{
			this.sql.themdulieu(et);
		}

		public void suadulieu(EC_tblChiTietPNK et)
		{
			this.sql.suadulieu(et);
		}

		public void xoadulieu(EC_tblChiTietPNK et)
		{
			this.sql.xoadulieu(et);
		}
	}
}

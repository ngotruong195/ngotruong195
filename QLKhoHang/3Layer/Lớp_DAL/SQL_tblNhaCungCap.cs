using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lớp_Entites;

namespace Lớp_DAL
{
	public class SQL_tblNhaCungCap
	{
		private Kết_Nối_CSDL cn = new Kết_Nối_CSDL();

		public void themdulieu(EC_tblNhaCungCap et)
		{
			this.cn.thucthicaulenh("INSERT INTO DMNhaCungCap (mancc, tenncc, emailncc, sdtncc, diachincc) VALUES ('" + et.Mancc + "','" + et.Tenncc + "','" + et.Sdtncc + "','" + et.Emailncc + "','" + et.Diachincc + "')");
		}

		public void suadulieu(EC_tblNhaCungCap et)
		{
			this.cn.thucthicaulenh("UPDATE  DMNhaCungCap SET tenncc =N'" + et.Tenncc + "', sdtncc =N'" + et.Sdtncc + "', emailncc =N'" + et.Emailncc + "', diachincc =N'" + et.Diachincc + "'  Where mancc=N'" + et.Mancc + "'  ");
		}

		public void xoadulieu(EC_tblNhaCungCap et)
		{
			this.cn.thucthicaulenh("DELETE FROM DMNhacCungCap Where mancc=N'" + et.Mancc + "'");
		}

		public DataTable taobang(string DieuKien)
		{
			return this.cn.GetDataTable("Select *From DMNhaCungCap " + DieuKien);
		}
	}
}

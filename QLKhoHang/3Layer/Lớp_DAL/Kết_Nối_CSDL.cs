using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lớp_DAL
{
	public class Kết_Nối_CSDL
	{
		public static SqlConnection connect;

		public static void moketnoi()
		{
			if (Kết_Nối_CSDL.connect == null)
				Kết_Nối_CSDL.connect = new SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=QLKhoHang;Integrated Security=SSPI;");
			if (Kết_Nối_CSDL.connect.State == ConnectionState.Open)
				return;
			Kết_Nối_CSDL.connect.Open();
		}

		public static void dongketnoi()
		{
			if (Kết_Nối_CSDL.connect == null || Kết_Nối_CSDL.connect.State != ConnectionState.Open)
				return;
			Kết_Nối_CSDL.connect.Close();
		}

		public void thucthicaulenh(string strSQL)
		{
			try
			{
				Kết_Nối_CSDL.moketnoi();
				new SqlCommand(strSQL, Kết_Nối_CSDL.connect).ExecuteNonQuery();
				Kết_Nối_CSDL.dongketnoi();
			}
			catch
			{
			}
		}

		public DataTable GetDataTable(string strSQL)
		{
			try
			{
				Kết_Nối_CSDL.moketnoi();
				DataTable dataTable = new DataTable();
				new SqlDataAdapter(strSQL, Kết_Nối_CSDL.connect).Fill(dataTable);
				Kết_Nối_CSDL.dongketnoi();
				return dataTable;
			}
			catch
			{
				return (DataTable)null;
			}
		}

		public string GetValue(string strSQL)
		{
			string str = (string)null;
			Kết_Nối_CSDL.moketnoi();
			SqlDataReader sqlDataReader = new SqlCommand(strSQL, Kết_Nối_CSDL.connect).ExecuteReader();
			while (sqlDataReader.Read())
				str = sqlDataReader[0].ToString();
			Kết_Nối_CSDL.dongketnoi();
			return str;
		}
	}
}

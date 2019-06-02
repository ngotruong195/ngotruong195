using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblQLTaiKhoan
	{
		private string _MaTK;
		private string _TenTK;
		private string _MKTK;
		private string _NhanVienQL;

		public string MaTK
		{
			get
			{
				return this._MaTK;
			}
			set
			{
				this._MaTK = value;
			}
		}

		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				this._TenTK = value;
			}
		}

		public string MKTK
		{
			get
			{
				return this._MKTK;
			}
			set
			{
				this._MKTK = value;
			}
		}

		public string NhanVienQL
		{
			get
			{
				return this._NhanVienQL;
			}
			set
			{
				this._NhanVienQL = value;
			}
		}
	}
}

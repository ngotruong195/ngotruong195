using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblKhachHang
	{
		private string _makh;
		private string _tenkh;
		private string _sdtkh;
		private string _emailkh;
		private string _diachikh;

		public string Makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				this._makh = value;
			}
		}

		public string Tenkh
		{
			get
			{
				return this._tenkh;
			}
			set
			{
				this._tenkh = value;
			}
		}

		public string Sdtkh
		{
			get
			{
				return this._sdtkh;
			}
			set
			{
				this._sdtkh = value;
			}
		}

		public string Emailkh
		{
			get
			{
				return this._emailkh;
			}
			set
			{
				this._emailkh = value;
			}
		}

		public string Diachikh
		{
			get
			{
				return this._diachikh;
			}
			set
			{
				this._diachikh = value;
			}
		}
	}
}

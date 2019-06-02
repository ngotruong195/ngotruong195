using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblPhieuXuat
	{
		private string _MaPXK;
		private string _NgayXuat;
		private string _NguoiXuat;
		private string _makh;
		private string _mahh;

		public string MaPXK
		{
			get
			{
				return this._MaPXK;
			}
			set
			{
				this._MaPXK = value;
			}
		}

		public string NgayXuat
		{
			get
			{
				return this._NgayXuat;
			}
			set
			{
				this._NgayXuat = value;
			}
		}

		public string NguoiXuat
		{
			get
			{
				return this._NguoiXuat;
			}
			set
			{
				this._NguoiXuat = value;
			}
		}

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

		public string Mahh
		{
			get
			{
				return this._mahh;
			}
			set
			{
				this._mahh = value;
			}
		}
	}
}

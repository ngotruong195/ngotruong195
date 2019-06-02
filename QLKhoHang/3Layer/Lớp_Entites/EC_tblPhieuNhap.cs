using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblPhieuNhap
	{
		private string _MaPNK;
		private string _NgayNhap;
		private string _NguoiNhap;
		private string _mancc;
		private string _mahh;

		public string MaPNK
		{
			get
			{
				return this._MaPNK;
			}
			set
			{
				this._MaPNK = value;
			}
		}

		public string NgayNhap
		{
			get
			{
				return this._NgayNhap;
			}
			set
			{
				this._NgayNhap = value;
			}
		}

		public string NguoiNhap
		{
			get
			{
				return this._NguoiNhap;
			}
			set
			{
				this._NguoiNhap = value;
			}
		}

		public string Mancc
		{
			get
			{
				return this._mancc;
			}
			set
			{
				this._mancc = value;
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

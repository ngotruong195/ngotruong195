using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblHangHoa
	{
		private string _mahh;
		private string _tenhh;
		private string _soluong;
		private string _donvitinh;
		private string _ngaynhap;

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

		public string Tenhh
		{
			get
			{
				return this._tenhh;
			}
			set
			{
				this._tenhh = value;
			}
		}

		public string Soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				this._soluong = value;
			}
		}

		public string Donvitinh
		{
			get
			{
				return this._donvitinh;
			}
			set
			{
				this._donvitinh = value;
			}
		}

		public string Ngaynhap
		{
			get
			{
				return this._ngaynhap;
			}
			set
			{
				this._ngaynhap = value;
			}
		}
	}
}

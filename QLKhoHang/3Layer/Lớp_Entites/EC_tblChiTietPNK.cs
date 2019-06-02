using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblChiTietPNK
	{
		private string _MaPNK;
		private string _TenHangNhap;
		private string _SoLuongNhap;
		private string _DonViTinh;

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

		public string TenHangNhap
		{
			get
			{
				return this._TenHangNhap;
			}
			set
			{
				this._TenHangNhap = value;
			}
		}

		public string SoLuongNhap
		{
			get
			{
				return this._SoLuongNhap;
			}
			set
			{
				this._SoLuongNhap = value;
			}
		}

		public string DonViTinh
		{
			get
			{
				return this._DonViTinh;
			}
			set
			{
				this._DonViTinh = value;
			}
		}
	}
}

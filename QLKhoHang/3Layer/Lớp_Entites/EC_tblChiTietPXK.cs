using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblChiTietPXK
	{

		private string _MaPXK;
		private string _TenHangXuat;
		private string _SoLuongXuat;
		private string _DonViTinh;

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

		public string TenHangXuat
		{
			get
			{
				return this._TenHangXuat;
			}
			set
			{
				this._TenHangXuat = value;
			}
		}

		public string SoLuongXuat
		{
			get
			{
				return this._SoLuongXuat;
			}
			set
			{
				this._SoLuongXuat = value;
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

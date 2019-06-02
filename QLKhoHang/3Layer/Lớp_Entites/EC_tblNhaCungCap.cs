using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lớp_Entites
{
	public class EC_tblNhaCungCap
	{
		private string _mancc;
		private string _tenncc;
		private string _sdtncc;
		private string _emailncc;
		private string _diachincc;

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

		public string Tenncc
		{
			get
			{
				return this._tenncc;
			}
			set
			{
				this._tenncc = value;
			}
		}

		public string Sdtncc
		{
			get
			{
				return this._sdtncc;
			}
			set
			{
				this._sdtncc = value;
			}
		}

		public string Emailncc
		{
			get
			{
				return this._emailncc;
			}
			set
			{
				this._emailncc = value;
			}
		}

		public string Diachincc
		{
			get
			{
				return this._diachincc;
			}
			set
			{
				this._diachincc = value;
			}
		}
	}
}

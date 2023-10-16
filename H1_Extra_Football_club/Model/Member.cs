using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Football_club.Model
{
	/// <summary>
	/// This is an object of a member in the football club.
	/// Members have a name and a phone number.
	/// </summary>
	internal class Member
	{
		private string _name;
		private string _phone;

		internal string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		internal string Phone 
		{ 
			get { return _phone; }
			set { _phone = value; }
		}
	}
}

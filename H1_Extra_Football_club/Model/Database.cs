using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Football_club.Model
{
	/// <summary>
	/// This class represents a database, which has a table of members
	/// </summary>
	internal class Database
	{
		internal List<Member> members = new List<Member>()
		{
			new Member()
			{
				Name = "Mads Mikkelsen",
				Phone = "32041265"
			},
			new Member()
			{
				Name = "Lars Mikkelsen",
				Phone = "53016435"
			}
		};
	}
}

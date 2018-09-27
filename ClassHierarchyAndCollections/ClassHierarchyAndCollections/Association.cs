using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHeirarchy
{
	public class Association : Organization
	{
		public string President { get; set; }
		public int NumberOfMembers { get; set; }

		private List<Member> members;

		private List<Member> GetMembers()
		{
			return members;
		}

		private void SetMembers(List<Member> value)
		{
			members = value;
		}
	}	
}

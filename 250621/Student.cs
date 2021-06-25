using System;
using System.Collections.Generic;
using System.Text;

namespace _250621
{
	class Student
	{
		public int Id { get; set; }
		public string Name{ get; set; }

		public override string ToString()
		{
			return $"{Id} {Name}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTestApp
{
	class Person
	{
		public string FirstName, LastName;
		public DateTime DateOfBirth;
		public Person( string first, string last, DateTime dob)
		{
			this.FirstName = first;
			this.LastName = last;
			this.DateOfBirth = dob;
		}

		public override string  ToString()
		{
			return this.FirstName + " " + this.LastName + " was born on " + this.DateOfBirth.ToShortDateString();
		}
	}
}

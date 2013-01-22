using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			Console.WriteLine("Program starting");
			Console.WriteLine("Enter i: ");
			int i = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter j: ");
			int j = int.Parse(Console.ReadLine());

			Console.WriteLine("i + j = " + (i+j).ToString());
			Console.ReadKey();
		}


		public int Add(int i, int j)
		{
			return i + j;
		}
	}
}

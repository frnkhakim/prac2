using System;

namespace Problems
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Prefix("Hello"));
		}

		public static string Prefix(String x)
		{
			int length = x.Length;
			string[] words = x.Split(' ');
			int wrd = words.Length;
			
			return(length + "," + wrd + ":" + x);
		}
	}
}
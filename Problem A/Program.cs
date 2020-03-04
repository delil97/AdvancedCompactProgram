using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_A
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter your name:");
			string input = Console.ReadLine().ToLower().Replace(" ", ""); //no white space and only lowercase letters

			char[] character = input.ToCharArray();
			string output = "";
			int minlen = 1;
			int maxlen = 250;
			char letter = '.';
			for (int i = 0; i < character.Length; i++)
			{
				if (input.Length < minlen) // minimum lenght = 1
				{
					Console.WriteLine("Minimum length of input is 1 character ");
				}
				if (input.Length > maxlen) // maximum lenght = 250
				{
					Console.WriteLine("Maximum length of input is 250 character ");
				}

				if (character[i] != letter)
				{
					output = output + character[i];
				}
				letter = character[i];
			}
			Console.WriteLine("The compact version of the name is:" + output);
		}
	}
}

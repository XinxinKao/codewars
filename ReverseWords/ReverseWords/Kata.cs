using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
	public class Kata
	{
		public static string ReverseWords(string input)
		{
			if(string.IsNullOrEmpty(input))
				return string.Empty;

			var result = string.Empty;
			var splitStrings = input.Split(' ');
			
			foreach (var splitString in splitStrings)
			{
				var array = splitString.ToCharArray();
				Array.Reverse(array);
				result += new string(array) + " ";
			}

			return result.Trim();
		}
	}
}

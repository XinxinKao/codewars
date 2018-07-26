using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_the_Middle_Character
{
	public class Kata
	{
		public static string GetMiddle(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}

			var startIndex = s.Length / 2;

			if (IsStringLengthEvenNumber(s))
			{
				return s.Substring(startIndex - 1, 2);
			}

			return s.Substring(startIndex, 1);
		}

		private static bool IsStringLengthEvenNumber(string s)
		{
			return s.Length % 2 == 0;
		}
	}
}

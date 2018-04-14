using System.Collections.Generic;
using System.Linq;

namespace SortTheOdd
{
	public class Kata
	{
		public static int[] SortArray(int[] array)
		{
			if(array.Length == 0)
				return array;

			var oddNumberIndex = new List<int>{};
			var oddNumbers = new List<int>{};
			
			for (var i = 0; i < array.Length; i++)
			{
				if (IsOdd(array[i]))
				{
					oddNumberIndex.Add(i);
					oddNumbers.Add(array[i]);
				}
			}

			var orderOddNumbers = oddNumbers.OrderBy(i => i).ToList();
			for (var j = 0; j < oddNumberIndex.Count; j++)
			{
				array[oddNumberIndex[j]] = orderOddNumbers[j];
			}

			return array;
		}

		private static bool IsOdd(int number)
		{
			return number % 2 != 0;
		}
	}
}

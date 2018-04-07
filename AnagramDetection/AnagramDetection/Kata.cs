using System.Linq;

namespace AnagramDetection
{
	public class Kata
	{
		public static bool IsAnagram(string test, string original)
		{
			if (test.Length != original.Length)
				return false;

			var testOrderBy = string.Concat(test.ToLower().OrderBy(c => c));
			var originalOrderBy = string.Concat(original.ToLower().OrderBy(c => c));

			return testOrderBy == originalOrderBy;
		}
	}
}

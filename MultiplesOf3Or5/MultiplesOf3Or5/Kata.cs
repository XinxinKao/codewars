namespace MultiplesOf3Or5
{
	public class Kata
	{
		public static int Solution(int value)
		{
			var result = 0;
			for (var i = 0; i < value; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					result += i;
			}
			return result;
		}
	}
}

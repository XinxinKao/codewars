namespace DigitalCypher
{
    public class Kata
    {
	    public static int[] Encode(string input, int number)
	    {
		    var result = new int[input.Length];
		    var inputChars = input.ToCharArray();
		    var numberChars = number.ToString().ToCharArray();
		    for (var i = 0; i < input.Length; i++)
		    {
			    var numberIndex = i % numberChars.Length;
			    result[i] = TransferCharToNumberByAscii(inputChars[i], '`') +TransferCharToNumberByAscii(numberChars[numberIndex], '0');
		    }
		    return result;
	    }

	    private static int TransferCharToNumberByAscii(char character1, char character2)
	    {
		    return character1 - character2;
	    }
    }
}

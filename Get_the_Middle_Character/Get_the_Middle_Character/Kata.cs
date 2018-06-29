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
		    if (s.Length == 0)
		    {
			    return string.Empty;
		    }

		    var charArray = s.ToCharArray();
			var index = s.Length / 2;
		    if (IsStringLengthEvenNumber(s))
		    {
			    return charArray[index-1] + charArray[index].ToString();
			}
		    else
		    {
			    return charArray[index].ToString();
		    }
	    }

	    private static bool IsStringLengthEvenNumber(string s)
	    {
		    return s.Length % 2 == 0;
	    }
    }
}

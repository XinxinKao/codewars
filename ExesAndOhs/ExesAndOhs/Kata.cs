using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExesAndOhs
{
    public class Kata
    {
	    public static bool XO (string input)
	    {
		    if (string.IsNullOrWhiteSpace(input))
			    return true;
		    
		    return CharCountInString(input,'x') == CharCountInString(input,'o');
	    }

	    private static int CharCountInString(string input,char specialChar)
	    {
			return input.ToLower().Where(c => c == specialChar).ToArray().Length;
	    }
    }
}

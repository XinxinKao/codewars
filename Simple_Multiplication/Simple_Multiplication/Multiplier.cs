using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multiplication
{
    public class Multiplier
    {
	    public static int Multiply(int x)
	    {
		    if (IsOddNumber(x))
		    {
			    return x * 8;
		    }
		    else
		    {
			    return x * 9;
		    }
	    }

	    private static bool IsOddNumber(int x)
	    {
		    return x % 2 == 0;
	    }
    }
}

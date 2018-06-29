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
		    return x * (IsOddNumber(x) ? 8 : 9);
	    }

	    private static bool IsOddNumber(int x)
	    {
		    return x % 2 == 0;
	    }
	}
}

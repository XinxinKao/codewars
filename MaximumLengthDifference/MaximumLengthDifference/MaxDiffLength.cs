using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthDifference
{
    public class MaxDiffLength
    {
	    public static int Mxdiflg(string[] a1, string[] a2)
	    {
		    if (a1.Length == 0 || a2.Length == 0)
			    return -1;

		    var firstResult = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));

		    var secondResult = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
			
		    return Math.Max(firstResult, secondResult);
	    }
    }
}

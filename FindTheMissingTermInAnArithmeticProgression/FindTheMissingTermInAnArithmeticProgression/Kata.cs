using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMissingTermInAnArithmeticProgression
{
    public class Kata
    {
	    public static int FindMissing(List<int> list)
	    {
		    var x = 0;
		    var y = 0;
		    for (int i = 0; i < list.Count - 1; i++)
		    {
			    x = list[i + 1] - list[i];
				
		    }

		    return list[0];
	    }
	}
}

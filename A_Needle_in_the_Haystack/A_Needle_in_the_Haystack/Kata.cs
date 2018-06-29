using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Needle_in_the_Haystack
{
    public class Kata
    {
	    public static string FindNeedle(object[] haystack)
	    {
		    var count = 0;
		    foreach (var item in haystack)
		    {
				if (item != null && item.ToString() == "needle")
			    {
				    return $"found the needle at position {count}";
			    }
			    count++;
		    }
			return string.Empty;
	    }
	}
}

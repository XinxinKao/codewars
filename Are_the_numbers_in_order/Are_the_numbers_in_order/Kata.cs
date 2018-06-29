using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_the_numbers_in_order
{
    public class Kata
    {
	    public static bool IsAscOrder(int[] arr)
	    {
		    var lastNumber = 0;
		    foreach (var item in arr)
		    {
			    if (item < lastNumber)
			    {
				    return false;
			    }
			    lastNumber = item;
		    }
		    return true;
	    }
	}
}

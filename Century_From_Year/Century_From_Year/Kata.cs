using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Century_From_Year
{
    public class Kata
    {
	    public static int СenturyFromYear(int year)
	    {
		    var century = 0;
		    if (year % 100 != 0)
		    {
			    century = 1;
		    }
		    return (year / 100) + century;
	    }
	}
}

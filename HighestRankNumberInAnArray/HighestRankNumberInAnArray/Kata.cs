using System;
using System.Collections.Generic;
using System.Linq;

namespace HighestRankNumberInAnArray
{
    public class Kata
    {
		public static int HighestRank(int[] arr)
		{
			if (arr.Length == 0)
				return 0;

			Array.Sort(arr);
			var dic = new Dictionary<int,int>();
			foreach (var item in arr)
			{
				if (dic.ContainsKey(item))
				{
					dic[item] += 1;
				}
				else
				{
					dic.Add(item, 1);
				}
			}
			return dic.LastOrDefault(x => x.Value == dic.Values.Max()).Key;

			//return arr.GroupBy(x => x).OrderBy(x => x.Count()).ThenBy(x => x.Key).Last().Key;
		}
	}
}

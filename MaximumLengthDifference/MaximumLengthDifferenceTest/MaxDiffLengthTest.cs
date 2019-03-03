using System;
using MaximumLengthDifference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumLengthDifferenceTest
{
	[TestClass]
	public class MaxDiffLengthTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
			string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
			Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
		}
	}
}

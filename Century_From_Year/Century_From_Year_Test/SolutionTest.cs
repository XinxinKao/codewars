using System;
using Century_From_Year;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Century_From_Year_Test
{
	[TestFixture]
	public class SolutionTest
	{
		[Test]
		public void SampleTest()
		{
			Assert.AreEqual(18, Kata.СenturyFromYear(1705));
			Assert.AreEqual(19, Kata.СenturyFromYear(1900));
			Assert.AreEqual(17, Kata.СenturyFromYear(1601));
			Assert.AreEqual(20, Kata.СenturyFromYear(2000));
		}
	}
}

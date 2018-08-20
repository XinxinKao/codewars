using ExesAndOhs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExesAndOhsTest
{
	[TestClass]
	public class SolutionTest
	{
		[TestMethod]
		public void ExampleTests()
		{
			Assert.AreEqual(true, Kata.XO("xo"));
			Assert.AreEqual(true, Kata.XO("xxOo"));
			Assert.AreEqual(false, Kata.XO("xxxm"));
			Assert.AreEqual(false, Kata.XO("Oo"));
			Assert.AreEqual(false, Kata.XO("ooom"));
		}
	}
}

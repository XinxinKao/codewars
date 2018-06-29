using NUnit.Framework;
using Opposite_Number;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Opposite_Number_Test
{
	[TestFixture]
	public class MyTest
	{
		[Test]
		public void Test_1()
		{
			Assert.AreEqual(-1, Kata.Opposite(1));
		}
	}
}

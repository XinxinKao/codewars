using MultiplesOf3Or5;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MultiplesOf3Or5Test
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test()
		{
			Assert.AreEqual(23, Kata.Solution(10));
		}
	}
}

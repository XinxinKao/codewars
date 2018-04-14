using NUnit.Framework;
using SortTheOdd;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SortTheOddTest
{
	[TestFixture]
	public class KataTests
	{
		[Test]
		public void BasicTests()
		{
			CollectionAssert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
			CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
			CollectionAssert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
		}
	}
}

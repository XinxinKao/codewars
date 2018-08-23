using DigitalCypher;
using NUnit.Framework;

namespace DigitalCypherTest
{
	[TestFixture]
	public class CypherTest
	{
		[Test]
		public void BasicTest()
		{
			CollectionAssert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, Kata.Encode("scout", 1939));
			CollectionAssert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, Kata.Encode("masterpiece", 1939));
		}

		[Test]
		public void RandomTest()
		{
			CollectionAssert.AreEqual(new int[] { 14, 24 }, Kata.Encode("mo", 1937146320));
			CollectionAssert.AreEqual(new int[] { 7, 19, 6, 22, 27, 27, 4}, Kata.Encode("fncvrsc", 1530981613));
			CollectionAssert.AreEqual(new int[] { 25, 22, 17, 18, 24, 22, 27, 13, 32, 15, 5, 23, 31, 28, 26, 5, 30, 21, 28, 23, 22, 12, 9, 31, 10, 17, 24, 3, 13, 16, 17, 21, 8, 22, 16 }, Kata.Encode("wthkuoyiymcnxyscznzumefxhmqakgjratl", 229737247));
		}
	}
}

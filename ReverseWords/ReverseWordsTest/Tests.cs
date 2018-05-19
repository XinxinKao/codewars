using NUnit.Framework;
using ReverseWords;

namespace ReverseWordsTest
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Example()
		{
			Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
		}
	}
}

using System;
using AllStarCodeChallenge;
using NUnit.Framework;

namespace AllStarCodeChallengeTest
{
	[TestFixture]
	public class Tests
	{
		[Test]
		[TestCase("Hello", 'o', ExpectedResult = 1)]
		[TestCase("Hello", 'l', ExpectedResult = 2)]
		[TestCase("", 'z', ExpectedResult = 0)]
		public static int TestStrCount(string test, char letter)
		{
			return Kata.strCount(test, letter);
		}
	}
}

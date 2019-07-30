using System;
using M;
using Xunit;

namespace MTest
{
	public class JNTMTest
	{
		[Fact]
		public void AddTest()
		{
			const int a = 15;
			const int b = 10;
			Assert.Equal(a + b, JNTM.Add(a, b));
		}
	}
}

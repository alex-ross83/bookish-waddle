using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Util.Tests
{
	[TestClass]
	public class MedianArrayTests
	{
		[TestMethod]
		public void MedianArray_Test_Success()
		{
			var input = new int[] { 1, 2, 3, 4, 5 };
			var expected = 3;
			var actual = MedianArray.FindMedian(input);
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void MedianArray_Test_Success_Even_NumberOfElements()
		{
			var input = new int[] { 1, 2, 3, 4, 5, 6 };
			var expected = 3.5m;
			var actual = MedianArray.FindMedian(input);
			Assert.AreEqual(expected, actual);
		}
	}
}

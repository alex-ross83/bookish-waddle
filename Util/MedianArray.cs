using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
	public class MedianArray
	{
		public static decimal FindMedian(int[] input)
		{
			if (((input.Length - 1) % 2 > 0)){
				int median1 = (input.Length - 1) / 2;
				Console.WriteLine(median1);
				int median2 = median1 + 1;
				return (Convert.ToDecimal(input[median1]) + Convert.ToDecimal(input[median2])) / 2;
			}
			return input[input.Length / 2];
		}
	}
}

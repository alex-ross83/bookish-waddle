using System;

namespace LeftRotation
{
	public class LeftRotate
	{
		public static void BruteForceRotateLeft(int[] input, int numberOfSpaces)
		{
			for (int i = 0; i <= numberOfSpaces -1; i++)
			{
				Rotate(input);
			}
		}
		private static void Rotate(int[] input)
		{
			var max = input.Length;
			var lastVal = input[0];
			int i = 0;
			while (i < max - 1)
			{
				input[i] = input[i + 1];
				i++;
			}
			input[max - 1] = lastVal;
		}
	}
}
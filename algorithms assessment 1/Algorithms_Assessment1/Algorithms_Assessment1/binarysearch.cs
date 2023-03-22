using System;
namespace Algorithms_Assessment1
{
	public class binarysearch
	{
		public static object Binarysearch(int[] list, int key)
		{
			int lower_half = 0;
			int higher_half = list.Length - 1;

			while (lower_half <= higher_half)
			{
				int middle = (higher_half + lower_half) / 2;

				if (list[middle] == key)
				{
					return ++middle;
				}
				else if (key < list[middle])
				{
					higher_half = middle - 1;
				}
				else
				{
					lower_half = middle + 1;
				}

			}

			return -1;
		}
	}
}


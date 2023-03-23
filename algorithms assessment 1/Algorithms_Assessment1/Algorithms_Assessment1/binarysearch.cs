using System;
namespace Algorithms_Assessment1
{
	public class binarysearch
	{
        public static int binarycount = 0;
        public static object Binarysearch(int[] list, int key)
		{
			int lower_half = 0; // left side
			int higher_half = list.Length - 1; //right side

			while (lower_half <= higher_half)
			{
				int middle = (higher_half + lower_half) / 2; // divide the list into two

				if (list[middle] == key)
				{
					return ++middle; // returns the key
				}
				else if (key < list[middle])
				{
					higher_half = middle - 1;
				}
				else
				{
					lower_half = middle + 1;
				}
				binarycount++; // binary search step tracker
			}
			return -1;
		}
	}
}


using System;
namespace Algorithms_Assessment1
{
	public class Quicksort
	{
		public static int quickcount = 0;
        public int[] quicksort(int[] list, int left, int right)
		{
			var i = left;
			var j = right;
			var middle = list[left];

			while (i <= j)
			{
				while (list[i] < middle)
				{
					i++;
				}

				while (list[j] > middle)
				{
					j--;
				}
                if (i <= j)
				{
					int temp = list[i];
					list[i] = list[j];
					list[j] = temp;
					i++;
					j--;
                }
			}
			if (left < j)
			{
                quickcount++;
                quicksort(list, left, j);
            }

			if (i < right)
			{
                quickcount++;
                quicksort(list, i, right);
            }
            return list;
        }

	}
}


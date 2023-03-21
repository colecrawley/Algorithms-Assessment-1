using System;
namespace Algorithms_Assessment1
{
	public class linearsearch
	{
		public static int Linearsearch(int[] list, int key)
		{
			bool found = false;
			int max = list.Length - 1;
			int current = 0;

			do
			{
				if (list[current] == key)
				{
					found = true;
				}
				else
				{
					current = current + 1;
				}
			} while (!(found == true || current > max));

			if (found == true)
			{
				return current + 1;
			}
			else
			{
				return -1;
			}
		}
	}
}


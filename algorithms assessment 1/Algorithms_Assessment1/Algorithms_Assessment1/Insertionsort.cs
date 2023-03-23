using System;
namespace Algorithms_Assessment1
{
	public class Insertionsort
	{
		public static int insertioncount = 0;
		public int[] insertionsort(int[] list, int length)
		{
			for (int i = 1; i < length; i++) //iterates through the list
			{
				var value = list[i]; //stores a key to use to compare
				var flag = 0;

				for (int j = i - 1; j >= 0 && flag != 1;)
				{
					if (value < list[j]) //if the value is greater than the key, it goes to the right, if it's less it goes to the left
					{
						list[j + 1] = list[j];
						j--;
						list[j + 1] = value;
					}
					else flag = 1;
				}
				insertioncount++; //insertion counter
			}
            Console.WriteLine("The amount of steps taken for selection sort is: " + insertioncount);
            return list;
		}
	}
}


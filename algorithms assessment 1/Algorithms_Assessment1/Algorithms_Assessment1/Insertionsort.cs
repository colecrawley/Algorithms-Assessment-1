﻿using System;
namespace Algorithms_Assessment1
{
	public class Insertionsort
	{
		public int[] insertionsort(int[] list, int length)
		{
			int insertioncount = 0;
			for (int i = 1; i < length; i++)
			{
				var value = list[i];
				var flag = 0;

				for (int j = i - 1; j >= 0 && flag != 1;)
				{
					if (value < list[j])
					{
						list[j + 1] = list[j];
						j--;
						list[j + 1] = value;
						insertioncount++;
					}
					else flag = 1;
				}
			}
            Console.WriteLine("The amount of steps taken for selection sort is: " + insertioncount);
            return list;
		}
	}
}


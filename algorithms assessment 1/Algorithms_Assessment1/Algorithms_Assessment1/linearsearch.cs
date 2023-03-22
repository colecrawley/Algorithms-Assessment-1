using System;
namespace Algorithms_Assessment1
{
	public class linearsearch
	{
		public static int Linearsearch(int[] list, int key)
		{
			
			for (int current = 0; current < list.Length; current++)
			{
				if (list[current] == key)
				{
					return current + 1;
				}
			}
			return -1;
		}

		public static void Findduplicates(int[] list, int key)
		{

			for (int i = 0; i < list.Length; i++)
			{
				if (key == list[i])
				{
					Console.WriteLine(key+" is found at position: "+i);
				}
				
			}
		}

	}
}


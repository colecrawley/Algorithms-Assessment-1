using System;
namespace Algorithms_Assessment1
{
	public class bubblesort
	{
		public int[]? Roadarray { get; set; }
		public static int bubblecount = 0;
		public int[] Bubblesort()
		{
			var n = Roadarray.Length;

			for (int i = 0; i < n - 1; i++)
				for (int j = 0; j < n - 1; j++) // iterates through the whole list
					if (Roadarray[j] > Roadarray[j + 1]) // checks if item 1 is greater than item 2, if so, swap positions
					{
						var temp = Roadarray[j];
						Roadarray[j] = Roadarray[j + 1];
						Roadarray[ j + 1] = temp;
						bubblecount++; //bubble counter
					}
			//bubblecount++;
            Console.WriteLine("\nThis is the steps for bubble sort: " + bubblecount);
			return Roadarray;		
		}

	}
}


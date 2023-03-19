using System;
namespace Algorithms_Assessment1
{
	public class algorithms
	{
		public int[]? Roadarray { get; set; }

		public int[] Bubblesort()
		{
			var n = Roadarray.Length;

			for (int i = 0; i < n - 1; i++)
				for (int j = 0; j < n - 1; j++)
					if (Roadarray[j] > Roadarray[j + 1])
					{
						var temp = Roadarray[j];
						Roadarray[j] = Roadarray[j + 1];
						Roadarray[ j + 1] = temp;
					}
			return Roadarray;

			
		}
	}
}


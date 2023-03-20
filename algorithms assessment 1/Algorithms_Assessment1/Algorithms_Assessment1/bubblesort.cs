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

		public int[] Selectionsort()
		{
			var n = Roadarray.Length;

			for (int i = 0; i < n - 1; i++)
			{
				var minimum = i;

				for (int j = i + 1; j < n; j++)
				{
					if (Roadarray[j] < Roadarray[minimum])
					{
						minimum = j;
					}
				}

				var temp = Roadarray[minimum];
				Roadarray[minimum] = Roadarray[i];
				Roadarray[i] = temp;
			}
			return Roadarray;
		}

	}
}


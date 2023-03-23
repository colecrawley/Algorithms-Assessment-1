using System;
namespace Algorithms_Assessment1
{
	public class Mergearrays
	{
		public static int[] Mergeroads(int[] list_a, int[] list_b) // merge two lists together
		{
			var mergeroads = new int[list_a.Length + list_b.Length];
			Array.Copy(list_a, mergeroads, list_a.Length);
			Array.Copy(list_b, 0, mergeroads, list_a.Length, list_b.Length);

			return mergeroads;
		}
	}
}


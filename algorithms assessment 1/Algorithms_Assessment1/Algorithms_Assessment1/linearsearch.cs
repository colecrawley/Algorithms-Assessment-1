using System;
namespace Algorithms_Assessment1
{
	public class linearsearch
	{
        public static int linearcount = 0;
        public static int Linearsearch(int[] list, int key)
		{
			for (int current = 0; current < list.Length; current++) // iterates through the whole list
			{
				if (list[current] == key) // if the key is found in the list, return in
				{
					return current + 1;
				}
                linearcount++; //linear search tracker
            }
			return -1;
		}

		public static void Findduplicates(int[] list, int key)
		{
			bool found_locations = false;
			for (int i = 0; i < list.Length; i++) //iterate through list
			{
				if (key == list[i])
				{
					Console.WriteLine(key + " is found at position: " + i); //returns the index for every instance of the key
					found_locations = true;
				}
				
			}
			if (found_locations == false)
			{
				Console.WriteLine("Value not in list, this is the closest value available in list:\n");

				int closest_number = list.Aggregate((x, y) => Math.Abs(x - key) < Math.Abs(y - key) ? x : y); // returns closest value to your key if not in list

				Console.WriteLine(closest_number);

                for (int j = 0; j < list.Length; j++)
                {
                    if (closest_number == list[j])
                    {
                        Console.WriteLine(closest_number + " is found at position: " + j); // shows all instances within the list
                        found_locations = true;
                    }

                }
            }
		}

	}
}


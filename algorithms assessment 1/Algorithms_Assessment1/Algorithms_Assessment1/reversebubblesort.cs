using System;
namespace Algorithms_Assessment1
{
	public class reversebubblesort
	{
            public int[]? Roadarray { get; set; }
            public static int reversebubblecount = 0;
            public int[] Reversebubblesort()
            {
                var n = Roadarray.Length;

                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - 1; j++)
                        if (Roadarray[j] < Roadarray[j + 1])
                        {
                            var temp = Roadarray[j];
                            Roadarray[j] = Roadarray[j + 1];
                            Roadarray[j + 1] = temp;
                            reversebubblecount++;
                        }
                //bubblecount++;
                Console.WriteLine("\nThis is the steps for reverse bubble sort: " + reversebubblecount);
                return Roadarray;
            }
    }
}


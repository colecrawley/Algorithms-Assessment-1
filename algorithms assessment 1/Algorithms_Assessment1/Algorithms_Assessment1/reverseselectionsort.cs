using System;
namespace Algorithms_Assessment1
{
    public class reverseselectionsort
    {
        public int[]? Roadarray { get; set; }
        public static int reverseselectioncount = 0;
        public int[] ReverseselectionSort()
        {
            var n = Roadarray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                var minimum = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (Roadarray[j] > Roadarray[minimum])
                    {
                        minimum = j;
                    }
                }

                var temp = Roadarray[minimum];
                Roadarray[minimum] = Roadarray[i];
                Roadarray[i] = temp;
                reverseselectioncount++;
            }
            Console.WriteLine("The amount of steps taken for selection sort is: " + reverseselectioncount);
            return Roadarray;
        }
    }
}


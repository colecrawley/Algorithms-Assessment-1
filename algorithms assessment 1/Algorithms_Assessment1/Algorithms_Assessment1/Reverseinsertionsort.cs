using System;
namespace Algorithms_Assessment1
{
    public class Reverseinsertionsort
    {
        public static int reverseinsertioncount = 0;
        public int[] reverseinsertionsort(int[] list, int length)
        {
            for (int i = 1; i < length; i++)
            {
                var value = list[i];
                var flag = 0;

                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value > list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = value;
                        //insertioncount++;
                    }
                    else flag = 1;
                }
                reverseinsertioncount++;
            }
            Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + reverseinsertioncount);
            return list;
        }
    }
}


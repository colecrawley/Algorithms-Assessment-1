using System;
namespace Algorithms_Assessment1
{
    public class Selectionsort
    {
        public int[]? Roadarray { get; set; }

        public int[] SelectionSort()
        {
            int selectioncount = 0;
            var n = Roadarray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                var minimum = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (Roadarray[j] < Roadarray[minimum])
                    {
                        minimum = j;
                        selectioncount++;
                    }
                }

                var temp = Roadarray[minimum];
                Roadarray[minimum] = Roadarray[i];
                Roadarray[i] = temp;
            }
            Console.WriteLine("The amount of steps taken for selection sort is: " + selectioncount);
            return Roadarray;

        }
        


    }
}


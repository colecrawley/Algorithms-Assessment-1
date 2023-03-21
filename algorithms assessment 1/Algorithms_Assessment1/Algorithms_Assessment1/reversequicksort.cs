using System;
namespace Algorithms_Assessment1
{
    public class reversequicksort
    {
        public static int reversequickcount = 0;
        public int[] Reversequicksort(int[] list, int left, int right)
        {
            var i = left;
            var j = right;
            var middle = list[left];

            while (i <= j)
            {
                while (list[i] > middle)
                {
                    i++;
                }

                while (list[j] < middle)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                reversequickcount++;
                Reversequicksort(list, left, j);
            }

            if (i < right)
            {
                reversequickcount++;
                Reversequicksort(list, i, right);
            }
            return list;

        }
    }
}


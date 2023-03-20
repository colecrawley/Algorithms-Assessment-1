namespace Algorithms_Assessment1;
class Program
{
    static void Main(string[] args)
    {
        string[] roads = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_1_256.txt");
        Console.WriteLine("These are all road codes\n");

        int[] roadnums = Array.ConvertAll(roads, int.Parse);

        /*foreach (int roadnum in roadnums)
        {
            Console.WriteLine("\n" + roadnum);
        }
        */

        Console.WriteLine("Enter the sorting algorithm you want to use:\n1.Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
        string user_input = Console.ReadLine();

        if (user_input == "1")
        {
            Console.WriteLine("You have chosen the Bubble sort method!");

            var bubblesortingmethod = new bubblesort();
            bubblesortingmethod.Roadarray = roadnums;

            var bubblesortedroads = bubblesortingmethod.Bubblesort();

            Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

            foreach (var road in bubblesortedroads)
            {
                Console.WriteLine(road + "\n");
            }

        }
        else if (user_input == "2")
        {
            Console.WriteLine("You have chosen the Selection sort method!");

            var selectionsortingmethod = new Selectionsort();
            selectionsortingmethod.Roadarray = roadnums;

            var selectionsortedroads = selectionsortingmethod.SelectionSort();
            Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

            foreach (var road in selectionsortedroads)
            {
                Console.WriteLine(road + "\n");
            }

        }
        else if (user_input == "3")
        {
            Console.WriteLine("You have chosen the Insertion sort method!");

            var insertionsortingmethod = new Insertionsort();
            var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums, roadnums.Length);
            Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

            foreach (var road in insertionsortedroads)
            {
                Console.WriteLine(road + "\n");
            }
        }
        else if (user_input == "4")
        {
            Console.WriteLine("You have chosen the Quicksort method!");

            var quicksortingmethod = new Quicksort();
            var quicksortedroads = quicksortingmethod.quicksort(roadnums, 0, roadnums.Length - 1);
            Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

            foreach (var road in quicksortedroads)
            {
                Console.WriteLine(road + "\n");
            }
            Console.WriteLine("The amount of steps taken for selection sort is: " + Quicksort.quickcount);
        }

    }
}


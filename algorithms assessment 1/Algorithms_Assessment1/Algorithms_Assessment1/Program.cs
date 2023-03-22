using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms_Assessment1;
class Program
{
    static void Main(string[] args)
    {
        string[] roads_1 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_1_256.txt");
        string[] roads_2 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_2_256.txt");
        string[] roads_3 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_3_256.txt");
        string[] roads_4 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_1_2048.txt");
        string[] roads_5 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_2_2048.txt");
        string[] roads_6 = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_3_2048.txt");
        //Console.WriteLine("These are all road codes\n");

        int[] roadnums_1 = Array.ConvertAll(roads_1, int.Parse);
        int[] roadnums_2 = Array.ConvertAll(roads_2, int.Parse);
        int[] roadnums_3 = Array.ConvertAll(roads_3, int.Parse);
        int[] roadnums_4 = Array.ConvertAll(roads_4, int.Parse);
        int[] roadnums_5 = Array.ConvertAll(roads_5, int.Parse);
        int[] roadnums_6 = Array.ConvertAll(roads_6, int.Parse);


        int flag = 1;

        while (flag == 1)
        {
            Console.Clear();
            Console.WriteLine("Welcome! Which road do you want to use?\n1. Road 1 256\n2. Road 2 256\n3. Road 3 256\n4. Road 1 2048\n5. Road 2 2048\n6. Road 3 2048\n7. Exit");
            string road_ans = Console.ReadLine();

            if (road_ans == "1")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_1;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 10)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_1;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 10)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_1, roadnums_1.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 10)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_1, 0, roadnums_1.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 10)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_1;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_1;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method\n--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_1, roadnums_1.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_1, 0, roadnums_1.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {

                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_1, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_1, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_1, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }
            }
            else if (road_ans == "2")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_2;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 10)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_2;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 10)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_2, roadnums_2.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 10)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_2, 0, roadnums_2.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 10)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_2;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }

                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_2;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method\n--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_2, roadnums_2.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_2, 0, roadnums_2.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {
                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_2, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_2, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_2, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }

            }
            else if (road_ans == "3")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_3;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method--------------------\n");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 10)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_3;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 10)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_3, roadnums_3.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 10)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_3, 0, roadnums_3.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 10)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_3;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_3;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method\n--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_3, roadnums_3.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_3, 0, roadnums_3.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(10);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 10th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 10)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(10);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {
                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_3, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_3, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_3, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }
            }
            else if (road_ans == "4")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_4;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 50)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_4;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 50)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_4, roadnums_4.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 50)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_4, 0, roadnums_4.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", "); //wrietline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 50)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_4;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_4;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method\n--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_4, roadnums_4.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_4, 0, roadnums_4.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", "); //writeline
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {
                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_4, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_4, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_4, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }
            }
            else if (road_ans == "5")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_5;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }

                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 50)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_5;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 50)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_5, roadnums_5.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 50)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_5, 0, roadnums_5.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }

                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 50)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_5;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_5;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method\n--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_5, roadnums_5.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_5, 0, roadnums_5.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {
                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_5, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_5, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_5, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }
            }
            else if (road_ans == "6")
            {
                Console.WriteLine("Welcome! Select what action you want to take:\n1. Sort\n2. Reverse sort\n3. Search\n4. Exit");
                string answer = Console.ReadLine();

                if (answer == "1") //Sorting algorithms
                {
                    Console.WriteLine("Enter the sorting algorithm you want to use:\n1. Bubble Sort\n2. Selection sort\n3. Insertion sort\n4. Quicksort\n5. Exit");
                    string user_input = Console.ReadLine();

                    if (user_input == "1")
                    {
                        Console.WriteLine("You have chosen the Bubble sort method!");

                        var bubblesortingmethod = new bubblesort();
                        bubblesortingmethod.Roadarray = roadnums_6;

                        var bubblesortedroads = bubblesortingmethod.Bubblesort();

                        Console.WriteLine("\n--------------------This is the bubble sort method\n--------------------");

                        foreach (var road in bubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Bubble sort is: " + bubblesort.bubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < bubblesortedroads.Length; i += 50)
                        {
                            Console.Write(bubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }


                    else if (user_input == "2")
                    {
                        Console.WriteLine("You have chosen the Selection sort method!");

                        var selectionsortingmethod = new Selectionsort();
                        selectionsortingmethod.Roadarray = roadnums_6;

                        var selectionsortedroads = selectionsortingmethod.SelectionSort();
                        Console.WriteLine("\n--------------------This is the Selection sort method\n--------------------");

                        foreach (var road in selectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for selection sort is: " + Selectionsort.selectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < selectionsortedroads.Length; i += 50)
                        {
                            Console.Write(selectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "3")
                    {
                        Console.WriteLine("You have chosen the Insertion sort method!");

                        var insertionsortingmethod = new Insertionsort();
                        var insertionsortedroads = insertionsortingmethod.insertionsort(roadnums_6, roadnums_6.Length);
                        Console.WriteLine("\n--------------------This is the Insertion sort method\n--------------------");

                        foreach (var road in insertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Insertion sort is: " + Insertionsort.insertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < insertionsortedroads.Length; i += 50)
                        {
                            Console.Write(insertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "4")
                    {
                        Console.WriteLine("You have chosen the Quicksort method!");

                        var quicksortingmethod = new Quicksort();
                        var quicksortedroads = quicksortingmethod.quicksort(roadnums_6, 0, roadnums_6.Length - 1);
                        Console.WriteLine("\n--------------------This is the Quicksort method\n--------------------");

                        foreach (var road in quicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Quicksort sort is: " + Quicksort.quickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < quicksortedroads.Length; i += 50)
                        {
                            Console.Write(quicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (user_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException("Your selection is not part of the available choices!");
                    }

                }
                else if (answer == "2") // Reverse sort algorithms
                {
                    Console.WriteLine("Enter the Reverse sorting algorithm you want to use:\n1. Reverse Bubble Sort\n2. Reverse Selection sort\n3. Reverse Insertion sort\n4. Reverse Quicksort\n5. Exit");
                    string reverseuser_input = Console.ReadLine();

                    if (reverseuser_input == "1")
                    {
                        Console.WriteLine("You have chosen the Reverse Bubble sort method!");

                        var reversebubblesortingmethod = new reversebubblesort();
                        reversebubblesortingmethod.Roadarray = roadnums_6;

                        var reversebubblesortedroads = reversebubblesortingmethod.Reversebubblesort();

                        Console.WriteLine("\n--------------------This is the Reverse bubble sort method\n--------------------");

                        foreach (var road in reversebubblesortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse bubble sort is: " + reversebubblesort.reversebubblecount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversebubblesortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversebubblesortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "2")
                    {
                        Console.WriteLine("You have chosen the Reverse Selection sort method!");

                        var reverseselectionsortingmethod = new reverseselectionsort();
                        reverseselectionsortingmethod.Roadarray = roadnums_6;

                        var reverseselectionsortedroads = reverseselectionsortingmethod.ReverseselectionSort();
                        Console.WriteLine("\n--------------------This is the Reverse Selection sort method--------------------");

                        foreach (var road in reverseselectionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for reverse selection sort is: " + reverseselectionsort.reverseselectioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseselectionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseselectionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "3")
                    {
                        Console.WriteLine("You have chosen the Reverse Insertion sort method!");

                        var reverseinsertionsortingmethod = new Reverseinsertionsort();
                        var reverseinsertionsortedroads = reverseinsertionsortingmethod.reverseinsertionsort(roadnums_6, roadnums_6.Length);
                        Console.WriteLine("\n--------------------This is the Reverse Insertion sort method\n--------------------");

                        foreach (var road in reverseinsertionsortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Insertion sort is: " + Reverseinsertionsort.reverseinsertioncount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reverseinsertionsortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reverseinsertionsortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "4")
                    {
                        Console.WriteLine("You have chosen the Reverse Quicksort method!");

                        var reversequicksortingmethod = new reversequicksort();
                        var reversequicksortedroads = reversequicksortingmethod.Reversequicksort(roadnums_6, 0, roadnums_6.Length - 1);
                        Console.WriteLine("\n--------------------This is the Reverse Quicksort method\n--------------------");

                        foreach (var road in reversequicksortedroads)
                        {
                            Console.Write(road + ", ");
                            Thread.Sleep(1);
                        }
                        Console.WriteLine("The amount of steps taken for Reverse Quicksort sort is: " + reversequicksort.reversequickcount);
                        Console.WriteLine("\nThese are every 50th value from the list:\n");

                        for (int i = 0; i < reversequicksortedroads.Length - 1; i += 50)
                        {
                            Console.Write(reversequicksortedroads[i] + ", ");
                            Thread.Sleep(1);
                        }
                    }
                    else if (reverseuser_input == "5")
                    {
                        Console.WriteLine("Thanks for playing!");
                        flag = 1;
                        break;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Entry is not one of the available choices!");
                    }


                }

                else if (answer == "3") // Search algorithms
                {
                    Console.WriteLine("What search algorithm do you want to use:\n1. Binary Search\n2. Linear Search\n");
                    string search_algo = Console.ReadLine();

                    if (search_algo == "1")
                    {
                        Console.WriteLine("You have chosen the Binary search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + binarysearch.Binarysearch(roadnums_6, num_input) + "\n");
                    }
                    else if (search_algo == "2")
                    {
                        Console.WriteLine("You have chosen the Linear Search!");

                        Console.WriteLine("What value do you want to look for: ");
                        string input = Console.ReadLine();
                        int num_input = Int32.Parse(input);

                        Console.WriteLine("\nThe indexed location of your number is: " + linearsearch.Linearsearch(roadnums_6, num_input) + "\n");

                        Console.WriteLine("\nThese are all the other locations in the list where " + num_input + " appears:\n");
                        linearsearch.Findduplicates(roadnums_6, num_input);
                    }
                }
                else if (answer == "4") // Exit
                {
                    Console.WriteLine("Thanks for playing!");
                    flag = 1;
                    break;
                }
                else // Catch all
                {
                    throw new ArgumentOutOfRangeException("\nSelection not part of the available selection\n");
                }
            }
            else if (road_ans == "7")
            {
                Console.WriteLine("Thanks for playing!");
                flag = 1;
                break;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Selection not part of the available selection\n");
            }
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }



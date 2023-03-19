namespace Algorithms_Assessment1;
class Program
{
    static void Main(string[] args)
    {
        string[] roads = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_1_256.txt");
        Console.WriteLine("These are all road codes\n");

        int[] roadnums = Array.ConvertAll(roads, int.Parse);
        //List<int>introads = roads.Select(int.Parse).ToList();

        foreach (int roadnum in roadnums)
        {
            Console.WriteLine("\n" + roadnum);
        }

        var sortingmethod = new algorithms();
        sortingmethod.Roadarray = roadnums;

        var sortedroads = sortingmethod.Bubblesort();

        Console.WriteLine("This is the bubble sort method\n");

        int count = 0;
        foreach (var road in sortedroads)
        {
            Console.WriteLine(road);
            count++;
        }
        Console.WriteLine("The amount of steps it took to sort this list is: " + count);


    }
}


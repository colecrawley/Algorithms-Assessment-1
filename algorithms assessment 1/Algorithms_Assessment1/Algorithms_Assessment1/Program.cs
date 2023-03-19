namespace Algorithms_Assessment1;
class Program
{
    static void Main(string[] args)
    {
        string[] roads = System.IO.File.ReadAllLines(@"/Users/colecrawley/Documents/algorithms assessment 1/roads/Road_1_256.txt");
        Console.WriteLine("These are all road codes\n");

        List<int> introads = roads.Select(int.Parse).ToList();

        foreach (int introad in introads)
        {
            Console.WriteLine("\n" + introad);



        }


    }
}


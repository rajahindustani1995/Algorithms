namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithms Program");
            while (true)
            {
                Console.WriteLine("\n 1. Program to return all permutations of a string");
                Console.WriteLine(" 2. Binary Search the word from word list ");
                Console.WriteLine(" 3. Insertion sort ");

                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PermutationOfString permute = new PermutationOfString();
                        permute.Driver();
                        break;
                    case 2:
                        List<string> wordArray = new List<string> { "Application", "Run", "Test", "Bugs", "Results", "Post", "Add", "Search" };
                        BinarySearchWord<string> binarySearchWord = new BinarySearchWord<string>();
                        binarySearchWord.DriverMethod(wordArray);
                        break;
                    case 3:
                        InsertionSort<int> insertionSort = new InsertionSort<int>();
                        insertionSort.Insertion();
                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }
        }
    }
}
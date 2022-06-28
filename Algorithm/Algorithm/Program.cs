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
                Console.WriteLine(" 4. Bubble sort ");
                Console.WriteLine(" 5. Merge sort ");
                Console.WriteLine(" 6. Anagram Detection");

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
                    case 4:
                        BubbleSort<int> bubbleSort = new BubbleSort<int>();
                        bubbleSort.Bubble();
                        break;
                    case 5:
                        Console.Write("Enter integers values separated by spaces to sort : ");
                        //Taking input from user and storing it to strings array of type string
                        string[] strings = Console.ReadLine().Split();

                        int[] sortArray = new int[strings.Length];
                        //Converting each string value in strings array to integer type and storing it to sortArray for further calculation
                        for (int i = 0; i < strings.Length; i++)
                        {
                            sortArray[i] = Convert.ToInt32(strings[i]);
                        }
                        MergeSort<int> mergeSort = new MergeSort<int>();
                        mergeSort.Driver(sortArray);
                        break;
                    case 6:
                        AnagramDetection anagramDetection = new AnagramDetection();
                        anagramDetection.Detection();
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
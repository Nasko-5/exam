namespace exam0100
{
    internal class Program
    {
        
        static void PrintDivider()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        static void EmphasisString(string text)
        {
            Console.WriteLine($"+ {text.ToUpper()}{new string(' ', Console.WindowWidth - (text.Length+4))} +");
        }

        static string FormatArray(int[] arr)
        {
            return $"[{string.Join(", ", arr)}]";
        }

        // FIRST CRITERION
        static int[] BubbleSort(int[] arr)
        {
            PrintDivider();
            EmphasisString("FIRST CRITERION: Sorting array with BubbleSort");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        // swap
                        int c = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = c;
                        Console.WriteLine($"Swapping {arr[j]} and {arr[j+1]}: {FormatArray(arr)}");
                    }
                }
            }

            return arr;
        }

        // SECOND CRITERION
        static int[] FindFollowingInts(int[] arr)
        {
            PrintDivider();
            EmphasisString("SECOND CRITERION: Find longest string of consequtive numbers");

            int endindex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i + 1] - arr[i]);
                if (arr[i + 1] - arr[i] != 1)
                {
                    endindex = i;
                    Console.WriteLine($" - test failed! jump at index {endindex}");
                    break;
                }
                Console.WriteLine(" - the numbers are increasing by one");
            }

            return arr[0..(endindex+1)];
        }

        // THIRD CRITERION
        static void PrintAll(int[] sorted_array, int[] longest_following)
        {
            PrintDivider();
            EmphasisString("THIRD CRITERION: Print it all out");
            Console.WriteLine($"Sorted Array: {FormatArray(sorted_array)}\n" +
                              $"Longest Following: {FormatArray(longest_following)}\n" +
                              $"Length: {longest_following.Length}");
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };

            PrintDivider();
            EmphasisString("program begin");

            int[] sorted_array = BubbleSort(arr);

            int[] longest_following = FindFollowingInts(sorted_array);

            PrintAll(sorted_array, longest_following);

            PrintDivider();
        }
    }
}

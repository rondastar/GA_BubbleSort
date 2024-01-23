namespace GA_BubbleSort
{
    // Ronda Rutherford
    // Bubble sort
    // 1-22-2024
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample array to test bubble sort
            int[] intArray = { 7, 3, 98, 72, 45, 12, 96, 4, 16, 86, 82, 63, 97, 76, 23 };
            PrintArray(intArray);
            BubbleSort(intArray);
            PrintArray(intArray);
            // Sample array to test bubble sort
            string[] stringArray = { "aardvark", "zebra", "moon", "run", "cat", "yak", "tortoise", "pig" };
            PrintArray(stringArray);
            BubbleSort(stringArray);
            PrintArray(stringArray);

        } // Main

        static void BubbleSort<T>(T[] array )
        {
            // Get the length of the input array
            int arrayLenth = array.Length;

            // Initialize a flag to track whether any swaps occurred in a pass
            bool swapOccurred = true;

            // Continue iterating until no swaps occur in a pass
            do
            {
                // Reset the swap flag at the start of each pass
                swapOccurred = false;

                // Iterate through the array elements from the first to the second-to-last
                // element for current Index from 0 to arrayLength - 1
                for (int i = 0; i < arrayLenth - 1; i++)
                {
                    // Compare the current element with the next element
                    if (Comparer<T>.Default.Compare(array[i], array[i + 1]) > 0)
                    {
                        // Swap the elements if they are out of order
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        // Set the swap flag to true to indicate a swap occurred
                        swapOccurred = true;
                    } // if 
                } // for loop
            } while (swapOccurred) ; // while loop
        }
        static void PrintArray<T>(T[] array)
        {
            Console.Write("Array: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    } // class
}

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
            int[] array = { 7, 3, 98, 72, 45, 12, 96, 4, 16, 86, 82, 63, 97, 76, 23 };
            PrintArray(array);
            BubbleSort(array);
            PrintArray(array);

        } // Main

        static void BubbleSort(int[] array )
        {
            // Get the length of the input array
            int arrayLenth = array.Length;

            // Initialize a flag to track whether any swaps occurred in a pass
            bool swapOccurred = true;

            // Continue iterating until no swaps occur in a pass
            while (swapOccurred)
            {
                // Reset the swap flag at the start of each pass
                swapOccurred = false;

                // Iterate through the array elements from the first to the second-to-last
                // element for currentIndex from 1 to arrayLength - 1
                // NOTE: I did it as instructed the first time, but the last element wasn't
                // sorted, so I changed the code to loop through the last element too
                for (int i = 1; i < arrayLenth; i++)
                {
                    // Compare the current element with the next element
                    if (array[i - 1] > array[i])
                    {
                        // Swap the elements if they are out of order
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;

                        // Set the swap flag to true to indicate a swap occurred
                        swapOccurred = true;
                    } // if 
                } // for loop
            } // while loop
        }
        static void PrintArray(int[] array)
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

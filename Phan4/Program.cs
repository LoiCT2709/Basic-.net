using System;

namespace Phan4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write 3 sorting algorithms for integer arrays: Bubble Sort, Insertion Sort, Selection Sort
            Console.WriteLine("Enter the number of elements of the array: ");

            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            int[] arr = new int[n];

            // Input array
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Invalid number. Please enter again:");
                }
            }

            // Show initial array
            Console.WriteLine("Initial Array:");
            ArrayShow(arr);

            string input = "";
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Insertion Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("Enter 'q' to quit");
                Console.Write("Please enter your choice: ");

                input = Console.ReadLine();

                if (input.Trim().ToLower() == "q")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                int[] array_sort;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You selected Bubble Sort");
                        array_sort = BubbleSort((int[])arr.Clone());
                        ArrayShow(array_sort);
                        break;
                    case "2":
                        Console.WriteLine("You selected Insertion Sort");
                        array_sort = InsertionSort((int[])arr.Clone());
                        ArrayShow(array_sort);
                        break;
                    case "3":
                        Console.WriteLine("You selected Selection Sort");
                        array_sort = SelectionSort((int[])arr.Clone());
                        ArrayShow(array_sort);
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Display array
        public static void ArrayShow(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Bubble Sort
        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        // Insertion Sort
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        // Selection Sort
        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
    }
}

using System.Globalization;

namespace Assignment3_2_5
{
    internal class Program
    {
        // Create a function that finds the index of a given item in the array
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strArr = { "bob", "jake", "dog", "kate" };
            double[] dubArr = { 2.3, 5.6, 7.8, 10, 2.3 };

            List<int> IndexList;

            IndexList = FindIndex(intArr, 6);
            PrintList(IndexList);
            IndexList = FindIndex(strArr, "kate");
            PrintList(IndexList);
            IndexList = FindIndex(dubArr, 2.3);
            PrintList(IndexList);
            IndexList = FindIndex(dubArr, 2.2);
            PrintList(IndexList);

            Console.WriteLine();
        }

        // Method finds the indices of all matching items in any type of array. If not found return a list with -1 in index 0
        static List<int> FindIndex<T>(T[] arr, T item)
        {
            List<int> indexList = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    indexList.Add(i);
                }
                    
            }

            if (indexList.Count == 0)
            {
                indexList.Add(-1);
            }

            return indexList;
        }

        // Prints the list out
        static void PrintList(List<int> list)
        {
            Console.Write($"Item Index: | ");
            foreach (int i in list)
            {
                Console.Write($" { i } |");
            }
            Console.WriteLine();
            
        }
    }
}

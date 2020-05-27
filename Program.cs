using System;
using System.Linq;

namespace LexicographicOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3};

            Console.WriteLine(string.Join(", ", array));
            LexicographicOrder(array);

            Console.ReadKey();
        }

        static void LexicographicOrder(int[] array)
        {
            while(true)
            {
                int xIndex = -1;
                for (int i = 0; i < array.Length -1; i++)
                {
                    if (array[i] < array[i + 1])
                        xIndex = i;
                }

                if (xIndex == -1) //If we can't find an "x" that means we are at the end of our ordering
                    break;

                int yIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[xIndex] < array[i])
                        yIndex = i;
                }

                int temp = array[xIndex];
                array[xIndex] = array[yIndex];
                array[yIndex] = temp;

                int[] tempArray = array[(xIndex+1)..];
                tempArray = tempArray.Reverse().ToArray();

                tempArray.CopyTo(array, xIndex + 1);
                

                Console.WriteLine(string.Join(", ", array));
            }
        }
    }
}

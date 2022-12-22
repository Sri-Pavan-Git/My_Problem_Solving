using System;

namespace HistogramArea
{
    class HistogramAreaCalculator
    {
        static void Main(string[] args)
        {
            String given = "";
            do 
            { 
                Console.WriteLine("This is program is about to calculte the highest rectangular area in Histogram.\n\n Enter an histogram, this will give you the highest area. \t\tOR\t\t Enter X to quit this");
                given = Console.ReadLine();
                if (given != "x" && given != "X")
                {
                    int[] a = Array.ConvertAll(given.Split(","), int.Parse);
                    int result = HistogramArea(a, a.Length);
                    Console.WriteLine("\n\n\t\t\t The largest Rectangle area in the given Histogram is {0}\n\n\n\n", result);
                }
            }
            while (given != "x" && given != "X") ;
            Console.WriteLine("\n\n\n\t\t\t\t \"Hope you enjoyed!!!,  Have a nice day\"...\n\n\n\n\n\n");
        }
       static int HistogramArea(int[] arr, int size)
        {
            int maxArea = 0;
            for (int current = 0; current < size; current++)
            {
                int width = 1;
                int moveRight = current + 1;
                int moveLeft = current - 1;

                while(moveRight < size && arr[moveRight] >=arr[current])
                {
                    width++;
                    moveRight++;
                }

                while(moveLeft>=0 && arr[moveLeft]>=arr[current])
                {
                    width++;
                    moveLeft--;
                }

                if(width* arr[current]>maxArea)
                {
                    maxArea = width * arr[current];
                }
            }
            return maxArea;
        }
        
    }
}

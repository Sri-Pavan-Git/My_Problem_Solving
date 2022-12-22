using System;

namespace TwoSumLeetCode
{
    class Program
    {
       public static void Main(string[] args)
        {
            String input;
            do
            {
                Console.WriteLine("\nEnter some collection of numbers separated with (,) \"No number should Repeat\" \t\t Enter X to quit the game..\n");
                input = Console.ReadLine();
                if (input != "x" && input != "X")
                {
                    Console.WriteLine("\n\n\nNow give me a number which should be sum of two numbers u given\n");
                    int goal = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine(input[0]);
                    int[] arr = Array.ConvertAll(input.Split(","), int.Parse);
                    int[] result = TwoSum(arr, goal);
                    Console.WriteLine("\n\n\n\t\"By adding {0} and {1} elements in the given numbers You will get {2}\"\n\n\n", result[0] + 1, result[1] + 1,goal);
                }
            } while (input != "x" && input != "X");
            Console.WriteLine("\n\n\n\t\t\t\t \"Hope you enjoyed!!!,  Have a nice day\"...\n\n\n\n\n\n");
        }
        static int[] TwoSum(int[] given,int target)
        {
            int i, j;
           int[] output = new int[2];
           for(i=0; i<given.Length;i++)
            {
                for(j=0;j<given.Length;j++)
                {
                    if(i!=j)
                    {
                        if(given[i]+given[j]==target)
                        {
                            output[0] = i;
                            output[1] = j;
                            break;
                        }
                    }
                }
                if (j != given.Length)
                {
                    if (given[i] + given[j] == target)
                    {
                        break;
                    }
                }
            }
            return output;
        }

    }
}

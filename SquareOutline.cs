using System;

namespace SquareOutline
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            do
            { 
                Console.WriteLine("Enter a Word\t\t\t\t\t\t\t Enter \"X\" instead of INPUT, to quite the loop ");
                input = Console.ReadLine();
                if (input != "x" && input != "X")
                {
                    Console.WriteLine("\n Here your  \"  |>  <|  |-  |-  (>  |~  |/|  \"   goes.. \n\n");
                    Pattern(input);
                }
            } while (input !="x"&& input !="X");
            Console.WriteLine("\n\n\n\n\t\t\t\t \"Hope you enjoyed!!!,  Have a nice day\"...\n\n\n\n\n\n");
        }
        static void Pattern(String given)
        {
            int len = given.Length;
            for (int row = 1; row <=len; row++)
            {

                for(int col=0;col<len;col++)
                {
                    if (row == 1)
                        Console.Write(given[col] + "   ");
                    else if (row == len)
                    {
                        String reversed = "";
                        reversed = reverse(given, len);
                        Console.Write(reversed[col]+"   ");
                    }
                    else if(row!=1&&row!=len)
                    {
                        if (col != 0 && col != len-1)
                        {
                            Console.Write("    ");
                        }
                        else if (col == 0)
                            Console.Write(given[row-1] + "   ");
                        else
                            Console.Write(given[col - row+1] + "   ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static String reverse(String normal, int size)
        {
            String result = "";
            for (int i = 0; i < size; i++)
            {
                result = result + normal[size - i - 1];
            }
            return result;
        }
    }
}

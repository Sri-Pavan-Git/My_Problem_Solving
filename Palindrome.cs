using System;

namespace PalindromeLeetCode
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("\nEnter any number to find Palindrome or NOT \t\tOR\t\t Enter \"0\" to quit the Game\n");
                input = (int)Convert.ToInt64(Console.ReadLine());
                if (input != 0)
                {
                    Console.WriteLine(IsPalindrome(input)+"\n\n");
                }
            } while (input != 0);
            Console.WriteLine("\n\n\n\n\t\t\t\t \"Hope you enjoyed!!!,  Have a nice day\"...\n\n\n\n\n\n");

        }
        static bool IsPalindrome(int x)
        {
            int res, rem, temp;
            res = 0; temp = x;
            while (temp > 0)
            {
                if (temp >= 10)
                {
                    rem = temp % 10;
                    res = res * 10 + rem;
                }
                else
                {
                    res = res * 10 + temp;
                }
                temp = temp / 10;
            }
            if (x == res)
                return true;
            else
                return false;
        }
    }
}

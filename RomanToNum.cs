using System;
public class RomanToNum
{
    int sum = 0;
    public int RomanToInt(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1)
            {
                if ((s[i] == 'I' && s[i + 1] == 'V') || (s[i] == 'I' && s[i + 1] == 'X'))
                    sum -= 2;
                else if ((s[i] == 'X' && s[i + 1] == 'L') || (s[i] == 'X' && s[i + 1] == 'C'))
                    sum -= 20;
                else if ((s[i] == 'C' && s[i + 1] == 'D') || (s[i] == 'C' && s[i + 1] == 'M'))
                    sum -= 200;
                else
                    sum=sum + 0;
            }
        }
        for (int i = 0; i < s.Length; i++) 
        {
            switch (s[i])
            {
                case 'I':
                    sum += 1;
                    break;
                case 'V':
                    sum += 5;
                    break;
                case 'X':
                    sum += 10;
                    break;
                case 'L':
                    sum += 50;
                    break;
                case 'C':
                    sum += 100;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'M':
                    sum += 1000;
                    break;
            }
            
        }
        return sum;
    }
    static void Main()
    {
        int res = 0;
        RomanToNum r = new RomanToNum();
        Console.WriteLine("---Besed on below roman symbol give an Input in roman numeral---\n\n");
        Console.WriteLine("Symbol\t     \t\tValue\n");
        Console.WriteLine("I\t ==> \t\t1");
        Console.WriteLine("V\t ==> \t\t5");
        Console.WriteLine("X\t ==> \t\t10");
        Console.WriteLine("L\t ==> \t\t50");
        Console.WriteLine("C\t ==> \t\t100");
        Console.WriteLine("D\t ==> \t\t500");
        Console.WriteLine("M\t ==> \t\t1000");
        Console.WriteLine("");
        Console.WriteLine("I can be placed before V (5) and X (10) to make 4 and 9. ");
        Console.WriteLine("X can be placed before L (50) and C (100) to make 40 and 90. ");
        Console.WriteLine("C can be placed before D (500) and M (1000) to make 400 and 900.");
        Console.WriteLine("\n");

        string input="";
        do
        {
            Console.WriteLine("\n\nEnter a Numeral\t\t\t\t\t\t\t Enter \"X\" instead of INPUT, to quite the loop ");
            input = Console.ReadLine();
            if (input != "x" && input != "X")
            {
                Console.Write("==> ");
                res= r.RomanToInt(input);
                Console.Write(res);
                r.sum = 0;
            }
        } while (input != "x" && input != "X");
        Console.WriteLine("\n\n\n\n\t\t\t\t \"Hope you enjoyed!!!,  Have a nice day\"...\n\n\n\n\n\n");
    }
}

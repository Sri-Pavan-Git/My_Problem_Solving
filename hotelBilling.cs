using System;
using System.Security.Cryptography.X509Certificates;

namespace HotelBilling
{
    class hotelBilling
    {
        char input; double discount;
        string item; string PlateCount; double total; string ItemName; int ItemCount;
        int[] item2; int[] PlateCount2;
        const double IGST = 2.5; const double PGST = 8.5;
        const double UGST = 5; const double DGST = 3;
        const double VGST = 3.5; const double BGST = 3.5;
        const int IPRICE = 20; const int PPRICE = 40; const int UPRICE = 30; 
        const int DPRICE = 20; const int VPRICE = 25; const int BPRICE = 25;
        public void welcome()
        {
            
            Console.WriteLine("\n\n\n\t\t\t\tMENU\n \n1.IDLY(4) - 20Rs \t 2.PURI(2) - 40RS \t 3.UPMA - 30RS\n4.DOSA(2) - 20RS \t 5.VADA(2) - 25RS \t 6.BONDA(3) - 25RS");
            Console.Write("\n\nEnter What Items(no.) you want(\"Ex- 1,5,6,7\"):");
            item = Console.ReadLine();
            item2 = Array.ConvertAll(item.Split(','), Convert.ToInt32);

        }
        public void calculate(int[] item, int[] PlateCount)
        {
            for (int i = 0; i < item.Length; i++)
            {
                switch (item[i])
                {
                    case 1: total += (IGST + IPRICE) * PlateCount[i]; break;
                    case 2: total += (PGST + PPRICE) * PlateCount[i]; break;
                    case 3: total += (UGST + UPRICE) * PlateCount[i]; break;
                    case 4: total += (DGST + DPRICE) * PlateCount[i]; break;
                    case 5: total += (VGST + VPRICE) * PlateCount[i]; break;
                    case 6: total += (BGST + BPRICE) * PlateCount[i]; break;
                    default: Console.WriteLine("Choose Correct Item number.."); break;

                }
            }
        }
        public void billing()
        {
            Console.WriteLine("\n\n\n\n\n\n**********************************************************************************************************************************");
            Console.WriteLine("Item Name \t Item Price \t Item GST \t No.of Plates \t Total");
            for (int i = 0; i < item2.Length; i++)
            {
                switch (item2[i])
                {
                    case 1:
                        Console.WriteLine($"IDLY \t\t {IPRICE} \t\t {IGST} \t\t {PlateCount2[i]} \t\t {((IPRICE + IGST) * PlateCount2[i])}");
                        break;
                    case 2:
                        Console.WriteLine($"PURI \t\t {PPRICE} \t\t {PGST} \t\t {PlateCount2[i]} \t\t {((PPRICE + PGST) * PlateCount2[i])}");
                        break;
                    case 3:
                        Console.WriteLine($"UPMA \t\t {UPRICE} \t\t {UGST} \t\t {PlateCount2[i]} \t\t {((UPRICE + UGST) * PlateCount2[i])}");
                        break;
                    case 4:
                        Console.WriteLine($"DOSA \t\t {DPRICE} \t\t {DGST} \t\t {PlateCount2[i]} \t\t {((DPRICE + DGST) * PlateCount2[i])}");
                        break;
                    case 5:
                        Console.WriteLine($"VADA \t\t {VPRICE} \t\t {VGST} \t\t {PlateCount2[i]} \t\t {((VPRICE + VGST) * PlateCount2[i])}");
                        break;
                    case 6:
                        Console.WriteLine($"BONDA \t\t {BPRICE} \t\t {BGST} \t\t {PlateCount2[i]} \t\t {((BPRICE + BGST) * PlateCount2[i])}");
                        break;
                    default: Console.WriteLine("Invalid Entry Try again..."); break;
                }
            }
            if(total> 200)
            {
                Console.WriteLine($"\nDISCOUNT:\t{discount} RS");
                total -= discount;
            }
            Console.WriteLine($"\n\nGRAND TOTAL \t {total} ONLY");
        }
        public static void Main()
        {
            hotelBilling p = new hotelBilling();
            Console.WriteLine("\t\t\tWelcome to \"<== Blissful ==>\"  ");
            do
            {
                p.welcome();
                Console.Write("Enter How many plates you want: ");
                p.PlateCount = Console.ReadLine();
                p.PlateCount2 = Array.ConvertAll(p.PlateCount.Split(','), int.Parse);

                p.calculate(p.item2, p.PlateCount2);

                if (p.total > 200)
                {
                    p.discount = p.total / 10;
                }
                p.billing();
                Console.WriteLine("\n\n\n\n\t\t\t\tDont you want some more!!! \"Y for yes, X for exit the Hotel!!!\" ");
                p.input = char.Parse(Console.ReadLine());
            } while (p.input != 'X' && p.input != 'x');
            Console.WriteLine("\n\n\t\tThanks for coming.. \n\t\t\t\t ..Visit again\n\n\n\n\n\n");
            Console.WriteLine("**********************************************************************************************************************************");
        }
    }
}

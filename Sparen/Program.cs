namespace Sparen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Sparen");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Zakgeld (per week): ");
            decimal.TryParse(Console.ReadLine(), out decimal pocketMoney);

            Console.Write("Wekelijkse verhoging: ");
            decimal.TryParse(Console.ReadLine(), out decimal increase);

            Console.Write("Gewenst bedrag (doel): ");
            decimal.TryParse(Console.ReadLine(), out decimal purpose);

            Console.WriteLine();


            int week = 0;
            decimal total = pocketMoney;

            do
            {
                Console.Write($"Week {week}\t");
                Console.Write($"Zakgeld {pocketMoney}\t");

                if (!(week == 0))
                {
                    total += pocketMoney;
                }
                               


                Console.Write($"Totaal: {total}");
                Console.WriteLine();

                week += 1;
                pocketMoney += increase;

            } while (total < purpose);



            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je hebt {week - 1} weken nodig om je doel van {purpose} euro bij elkaar te sparen.");
            Console.ResetColor();


            //int week = 1;
            //decimal newIncrease = increase;



            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
            //    Console.Write($"Week {week}: {pocketMoney * week} + {newIncrease} = {pocketMoney * week + newIncrease}");
            //    Console.WriteLine();


            //    week += 1;
            //    newIncrease += increase;


            //} while ((pocketMoney * week + newIncrease) <= purpose);

            //Console.Write($"Week {week}: {pocketMoney * week} + {newIncrease} = {pocketMoney * week + newIncrease}");

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Je hebt {week} weken nodig om je doel van {purpose} euro bij elkaar te sparen.");
            //Console.ResetColor();
        }
    }
}

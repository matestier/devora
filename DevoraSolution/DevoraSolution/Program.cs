using DevoraSolution.FightDetails.FightModels;
using DevoraSolution.Models;

namespace DevoraSolution
{
    internal class Program
    {
        static void Main()
        {
            #region get number of fighters

            Console.WriteLine(" Aréni szimiláció kezdéséhez nyomj meg egy gombot!");
            Console.ReadKey();

            int numberOfFighters = -1;
            string input = string.Empty;
            bool isValidInput = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" A dicsőséges győzelemért küzdő harcosok száma: (egy és plusz végtelen közötti egész szám)");
                input = Console.ReadLine();

                isValidInput = !String.IsNullOrEmpty(input) && int.TryParse(input, out numberOfFighters) && numberOfFighters > 1;
            }
            while (!isValidInput);

            #endregion

            #region FIGHT!

            new Arena().beginFight
            (
                new Round(),
                new RandomModul.Random(),
                numberOfFighters,
                new FightLogger.FightLogger()
            );

            #endregion

            Console.WriteLine("\r\n Kilépéshez nyomj meg egy gombot!");
            Console.ReadLine();
        }
    }
}
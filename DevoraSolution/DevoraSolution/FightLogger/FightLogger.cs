using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightLogger
{
    internal class FightLogger : IFightLogger
    {
        public void logFight(IFighter attacker, IFighter target)
        {
            Console.WriteLine();
            Console.WriteLine($" Egy {attacker.ID} - {attacker.TypeName()} (HP: {attacker.HP}) megtámadta ->");
            Console.WriteLine($" {target.ID} - {target.TypeName()}-t (HP: {target.HP})!");
        }

        public void logArena(IList<IFighter> figters)
        {
            Console.WriteLine("\r\n A harcosok: (ID - Típus)");
            foreach (IFighter fighter in figters)
            {
                Console.WriteLine($" {fighter.ID} - {fighter.TypeName()}");
            }

            Console.WriteLine();
        }

        public void logRoundEnd(IList<IFighter> fighters)
        {
            if (fighters.Count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\r\n A Győztes: {fighters[0].ID} - {fighters[0].TypeName()}!!");
                Console.ForegroundColor = ConsoleColor.White;

                return;
            }

            if (fighters.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\r\n Nincs győztes!! Utolsó harcan életüket vesztették mindketten...");
                Console.ForegroundColor = ConsoleColor.White;

                return;
            }

            Console.WriteLine("\r\n A következő körbe lépnek:");
            foreach (IFighter fighter in fighters)
            {
                Console.WriteLine($" {fighter.ID} - {fighter.TypeName()} - {fighter.HP}");
            }
        }
    }
}

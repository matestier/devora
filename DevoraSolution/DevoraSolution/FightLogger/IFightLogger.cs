using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightLogger
{
    internal interface IFightLogger
    {
        void logFight(IFighter attacker, IFighter target);

        void logArena(IList<IFighter> figters);

        void logRoundEnd(IList<IFighter> fighters);
    }
}
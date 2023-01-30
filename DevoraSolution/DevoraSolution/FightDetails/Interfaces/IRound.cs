using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.Interfaces
{
    internal interface IRound
    {
        void fight(IFight fight);
        bool hasNext(IList<IFighter> _fighters);
        void removeDeathFighters(IList<IFighter> _fighters);
        void rest(IList<IFighter> _fighters, IFightPair pair);
    }
}
using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.RandomModul
{
    internal interface IRandomModule
    {
        IList<IFighter> getFighters(int numberOfFighters);
        IFightPair getRandomFightPair(IList<IFighter> fighters);
    }
}
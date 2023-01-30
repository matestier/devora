using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.Interfaces
{
    internal interface IFightPair
    {
        IFighter Attacker { get; init; }
        IFighter Defender { get; init; }
    }
}
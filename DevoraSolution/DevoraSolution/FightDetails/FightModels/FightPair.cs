using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.FightModels
{
    internal sealed record FightPair : IFightPair
    {
        public IFighter Attacker { get; init; }
        public IFighter Defender { get; init; }
    }
}

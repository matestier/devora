using DevoraSolution.Extensions;
using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.FightModels
{
    internal class Round : IRound
    {
        public void rest(IList<IFighter> _fighters, IFightPair pair)
        {
            var restFighters = _fighters
            .Where
            (
                x =>
                    x.ID != pair.Attacker.ID &&
                    x.ID != pair.Defender.ID
            ).ToList();

            foreach (var fighter in restFighters)
            {
                if (fighter.BaseHP >= fighter.HP + 10)
                    fighter.HP += 10;
            }
        }

        public void removeDeathFighters(IList<IFighter> _fighters)
        {
            var deaths = _fighters.Where(x => x.BaseHP * 0.25 > x.HP).ToList();
            _fighters.RemoveRange(deaths);
        }

        public void fight(IFight fight)
        {
            fight.doFight();
        }

        public bool hasNext(IList<IFighter> _fighters) => _fighters.Count > 1;

    }
}

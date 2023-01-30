using DevoraSolution.FightDetails.FightModels;
using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.Models;
using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.RandomModul
{
    internal class Random : IRandomModule
    {
        private readonly System.Random _random;

        public Random()
        {
            _random = new System.Random();
        }

        public Random(System.Random random)
        {
            _random = random;
        }

        public IFightPair getRandomFightPair(IList<IFighter> fighters)
        {
            Func<IList<IFighter>, int> getRandomIndex = collection => _random.Next(fighters.Count);

            var attacker = fighters[getRandomIndex(fighters)];
            IFighter defender;
            do
            {
                defender = fighters[getRandomIndex(fighters)];

            } while (defender.ID == attacker.ID);


            List<Fighter> _fighter = new();

            return new FightPair() { Attacker = attacker, Defender = defender };
        }

        public IList<IFighter> getFighters(int numberOfFighters)
        {
            var fighters = new List<IFighter>(numberOfFighters);

            for (int i = 0; i < numberOfFighters; ++i)
            {
                switch (_random.Next(1, 4))
                {
                    case 1:
                        fighters.Add(new Archer() { ID = i });
                        break;
                    case 2:
                        fighters.Add(new Knight() { ID = i });
                        break;
                    case 3:
                        fighters.Add(new Swordman() { ID = i });
                        break;
                }
            }

            return fighters;
        }
    }
}

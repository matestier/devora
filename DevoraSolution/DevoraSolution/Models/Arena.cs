using DevoraSolution.FightDetails.FightModels;
using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.FightLogger;
using DevoraSolution.Models.Interfaces;
using DevoraSolution.RandomModul;

namespace DevoraSolution.Models
{
    internal class Arena : IArena
    {
        public void beginFight(IRound _round, IRandomModule _random, int numberOfFighters, FightLogger.IFightLogger _logger)
        {
            var _fighters = _random.getFighters(numberOfFighters);

            Console.Clear();
            _logger.logArena(_fighters);

            do
            {
                // chose attacker and defender ->
                var pair = _random.getRandomFightPair(_fighters);

                // fight ->
                _logger.logFight(pair.Attacker, pair.Defender);
                Fight fight = new Fight(pair.Attacker, pair.Defender);
                fight.doFight();

                // rest ->
                _round.rest(_fighters, pair);

                // remove deaht fighters ->
                _round.removeDeathFighters(_fighters);

                // log rund end
                _logger.logRoundEnd(_fighters);

            } while (_round.hasNext(_fighters));
        }
    }
}

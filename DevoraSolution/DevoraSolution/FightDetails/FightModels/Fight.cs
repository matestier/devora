using DevoraSolution.FightDetails.Interfaces;
using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.FightModels
{
    internal class Fight : IFight
    {
        private readonly IFighter _attacker;
        private readonly IFighter _defender;

        public Fight(IFighter attacker, IFighter defender)
        {
            _attacker = attacker;
            _defender = defender;

            // Common ->
            attacker.HP = attacker.HP / 2;
            defender.HP = defender.HP / 2;
        }

        // Swordman ->

        public void fight(ISwordman attacker, ISwordman target)
        {
            target.HP = 0;
        }

        public void fight(ISwordman attacker, IKnight target) { }

        public void fight(ISwordman attacker, IArcher target)
        {
            target.HP = 0;
        }

        // Archer ->

        public void fight(IArcher attacker, ISwordman target)
        {
            target.HP = 0;
        }

        public void fight(IArcher attacker, IKnight target)
        {
            var isSuccededAttack = new Random().Next(1, 101) <= 40;

            if(isSuccededAttack)
                target.HP = 0;
        }

        public void fight(IArcher attacker, IArcher target)
        {
            target.HP = 0;
        }

        // Knight ->

        public void fight(IKnight attacker, IKnight target)
        {
            target.HP = 0;
        }

        public void fight(IKnight attacker, IArcher target)
        {
            attacker.HP = 0;
        }

        public void fight(IKnight attacker, ISwordman target)
        {
            attacker.HP = 0;
        }

        public void doFight()
        {
            // -> Swordman

            // Swordman -> Swordman
            if (_attacker is ISwordman && _defender is ISwordman)
            {
                fight(_attacker as ISwordman, _defender as ISwordman);
                return;
            }

            // Knight -> Swordman
            if (_attacker is IKnight && _defender is ISwordman)
            {
                fight(_attacker as IKnight, _defender as ISwordman);
                return;
            }

            // Archer -> Swordman
            if (_attacker is IArcher && _defender is ISwordman)
            {
                fight(_attacker as IArcher, _defender as ISwordman);
                return;
            }

            // -> Knight

            // Swordman -> Knight
            if (_attacker is ISwordman && _defender is IKnight)
            {
                fight(_attacker as ISwordman, _defender as IKnight);
                return;
            }

            // IKnight -> Knight
            if (_attacker is IKnight && _defender is IKnight)
            {
                fight(_attacker as IKnight, _defender as IKnight);
                return;
            }

            // Archer -> Knight
            if (_attacker is IArcher && _defender is IKnight)
            {
                fight(_attacker as IArcher, _defender as IKnight);
                return;
            }

            // -> Archer

            // Swordman -> IArcher
            if (_attacker is ISwordman && _defender is IArcher)
            {
                fight(_attacker as ISwordman, _defender as IArcher);
                return;
            }

            // IKnight -> IArcher
            if (_attacker is IKnight && _defender is IArcher)
            {
                fight(_attacker as IKnight, _defender as IArcher);
                return;
            }

            // Archer -> IArcher
            if (_attacker is IArcher && _defender is IArcher)
            {
                fight(_attacker as IArcher, _defender as IArcher);
                return;
            }
        }
    }
}

using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.FightDetails.Interfaces
{
    internal interface IFight
    {
        void doFight();

        void fight(ISwordman attacker, ISwordman target);
        void fight(IKnight attacker, ISwordman target);
        void fight(IArcher attacker, ISwordman target);

        void fight(ISwordman attacker, IKnight target);
        void fight(IKnight attacker, IKnight target);
        void fight(IArcher attacker, IKnight target);

        void fight(ISwordman attacker, IArcher target);
        void fight(IKnight attacker, IArcher target);
        void fight(IArcher attacker, IArcher target);

    }
}

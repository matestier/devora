using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.Models
{
    internal sealed class Swordman : Fighter, ISwordman
    {
        public Swordman()
        {
            HP = 120;
            BaseHP = 120;
        }

        public override string TypeName() => "Kardos";
    }
}

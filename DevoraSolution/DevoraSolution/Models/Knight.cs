using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.Models
{
    internal sealed class Knight : Fighter, IKnight
    {
        public Knight()
        {
            HP = 150;
            BaseHP = 150;
        }

        public override string TypeName() => "Lovag";
    }
}

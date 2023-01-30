using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.Models
{
    internal sealed class Archer : Fighter, IArcher
    {
        public Archer()
        {
            HP = 100;
            BaseHP = 100;
        }

        public override string TypeName() => "Íjjász";
    }
}

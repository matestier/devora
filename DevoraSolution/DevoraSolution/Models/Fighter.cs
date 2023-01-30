using DevoraSolution.Models.Interfaces;

namespace DevoraSolution.Models
{
    internal abstract class Fighter : IFighter
    {
        public int ID { get; set; }
        public int HP { get; set; }
        public int BaseHP { get; init; }

        public virtual string TypeName()
        {
            throw new NotImplementedException();
        }
    }
}

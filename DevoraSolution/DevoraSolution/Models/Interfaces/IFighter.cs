namespace DevoraSolution.Models.Interfaces
{
    internal interface IFighter
    {
        int ID { get; set; }
        int HP { get; set; }
        int BaseHP { get; init; }

        string TypeName();
    }
}

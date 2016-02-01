
namespace Credit
{
    public class MasterCard : ICreditCard
    {
        public int ChargeCount { get; set; }

        public string Charge()
        {
            ChargeCount++;
            return "this is MasterCard";
        }
    }
}

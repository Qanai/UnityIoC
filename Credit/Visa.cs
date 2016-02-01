
namespace Credit
{
    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Visa ... Visa";
        }


        public int ChargeCount
        {
            get { return 0; }
        }
    }
}

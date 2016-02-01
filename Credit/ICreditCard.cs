
namespace Credit
{
    public interface ICreditCard
    {
        int ChargeCount { get; }
        string Charge();
    }
}
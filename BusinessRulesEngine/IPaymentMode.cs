
namespace BusinessRulesEngine
{
    /// <summary>
    /// Payment Mode Interface declares the operation that all the concrete Product Types must implement 
    /// </summary>
    public interface IPaymentMode
    {
        void InvoiceGenerator();
    }
}

using System;

namespace BusinessRulesEngine
{
    /// <summary>
    /// Concrete Creator Class
    /// </summary>
    public class ProductInitializer : ProductFactory
    {
        /// <summary>
        /// Overriden Method of the GetInvoiceDetails
        /// </summary>
        /// <param name="productNumber">int productNumber</param>
        /// <returns>PaymentMode Types</returns>
        public override IPaymentMode GetInvoiceDetails(int productNumber)
        {
            switch (productNumber)
            {
                case 1: return new PurchasePhysicalProduct();
                case 2: return new PurchaseBook();
                case 3: return new MembershipActivation();
                case 4: return new MembershipUpgrade();
                case 5: return new LearningVideo();
                default: throw new ApplicationException("This product type does not exisit");
            }
        }
        }
}

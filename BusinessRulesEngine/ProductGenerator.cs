using System;

namespace BusinessRulesEngine
{
    /// <summary>
    /// Concrete Class for PurchasePhysicalProduct
    /// </summary>
    public class PurchasePhysicalProduct : IPaymentMode
    {
        /// <summary>
        /// Implementation for the method defied in IPaymentMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Packing Slip generated for your Physical product");
            Console.WriteLine("And comission payment to the agent initiated.");
        }
    }

    /// <summary>
    /// Concrete Class for PurchaseBook
    /// </summary>
    public class PurchaseBook : IPaymentMode
    {
        /// <summary>
        /// Implementation for the method defied in IPaymentMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Created a duplicate packing slip for the royalty department for the purchase of Book");
            Console.WriteLine("And comission payment to the agent initiated.");
        }
    }

    /// <summary>
    /// Concrete Class for MembershipActivation
    /// </summary>
    public class MembershipActivation : IPaymentMode
    {
        /// <summary>
        /// Implementation for the method defied in IPaymentMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Membership activated!");
            Console.WriteLine("Activation Email sent successfully.");
        }
    }

    /// <summary>
    /// Concrete Class for MembershipUpgrade
    /// </summary>
    public class MembershipUpgrade : IPaymentMode
    {
        /// <summary>
        /// Implementation for the method defied in IPaymentMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Upgradation on the membership done!");
            Console.WriteLine("Upgradation Email sent successfully.");
        }
    }

    /// <summary>
    /// Concrete Class for LearningVideo
    /// </summary>
    public class LearningVideo : IPaymentMode
    {
        /// <summary>
        /// Implementation for the method defied in IPaymentMode
        /// </summary>
        public void InvoiceGenerator()
        {
            Console.WriteLine("Added Skining videos and also a First Aid video as a complimentory to your account.");
        }
    }
}

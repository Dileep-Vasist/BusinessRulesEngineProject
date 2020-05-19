using System;

namespace BusinessRulesEngine
{
    class Program
    {
        /// <summary>
        /// Client method working with instances of concrete creator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Physical Product : 1\nBook : 2\nMembership : 3\nUpgrade Membership : 4\nLearning Ski Video : 5");
            Console.WriteLine("**************************************************************");
            ProductFactory productFactory = new ProductInitializer();

            IPaymentMode physicalProduct = productFactory.GetInvoiceDetails(1);
            physicalProduct.InvoiceGenerator();
            Console.WriteLine("*************************");

            IPaymentMode purchaseBook = productFactory.GetInvoiceDetails(2);
            purchaseBook.InvoiceGenerator();
            Console.WriteLine("*************************");

            IPaymentMode membershipActivation = productFactory.GetInvoiceDetails(3);
            membershipActivation.InvoiceGenerator();
            Console.WriteLine("*************************");

            IPaymentMode membershipUpgrade = productFactory.GetInvoiceDetails(4);
            membershipUpgrade.InvoiceGenerator();
            Console.WriteLine("*************************");

            IPaymentMode learningVideo = productFactory.GetInvoiceDetails(5);
            learningVideo.InvoiceGenerator();

            Console.ReadKey();
        }
    }
}

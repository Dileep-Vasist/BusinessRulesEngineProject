using System;
using BusinessRulesEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectForBusinessRuleEngine
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductGenerator_Should_Create_PhysicalProductObject()
        {
            //Arrange
            var physicalProduct = new ProductInitializer();

            //Act
            var actual = physicalProduct.GetInvoiceDetails(1);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(PurchasePhysicalProduct));
        }

        [TestMethod]
        public void ProductGenerator_Should_Create_PurchaseBookObject()
        {
            //Arrange
            var purchaseBook = new ProductInitializer();

            //Act
            var actual = purchaseBook.GetInvoiceDetails(2);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(PurchaseBook));
        }

        [TestMethod]
        public void ProductGenerator_Should_Create_MembershipActivationObject()
        {
            //Arrange
            var membershipActivation = new ProductInitializer();

            //Act
            var actual = membershipActivation.GetInvoiceDetails(3);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(MembershipActivation));
        }

        [TestMethod]
        public void ProductGenerator_Should_Create_MembershipUpgradeObject()
        {
            //Arrange
            var membershipUpgrade = new ProductInitializer();

            //Act
            var actual = membershipUpgrade.GetInvoiceDetails(4);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(MembershipUpgrade));
        }

        [TestMethod]
        public void ProductGenerator_Should_Create_LearningVideoObject()
        {
            //Arrange
            var learningVideo = new ProductInitializer();

            //Act
            var actual = learningVideo.GetInvoiceDetails(5);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(LearningVideo));
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "This product type does not exisit")]
        public void ProductGenerator_Should_Not_Create_Object_If_Type_NotDefined()
        {
            //Arrange
            var productNotPresent = new ProductInitializer();

            //Act
            var actual = productNotPresent.GetInvoiceDetails(100);

            //Assert
            Assert.ThrowsException<Exception>(actual.InvoiceGenerator).Message.Equals("This product type does not exisit");
        }
    }
}

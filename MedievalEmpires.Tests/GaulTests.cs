using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedievalEmpires;

namespace MedievalEmpires.Tests
{
    [TestClass]
    public class GaulTests
    {
        [TestMethod]
        public void BuySoldier_WithTooFewCoins_ThrowsExceptionAndCoinsUnchanged()
        {
            // Arrange
            var gaul = new Gaul("TestGaul", 0, 10);
            var soldier = new Knight("Weak", 0, 0, 20, gaul);
            var initialCoins = gaul.pCoins;

            // Act & Assert
            Assert.ThrowsException<Exception>(() => gaul.buySoldier(soldier));
            Assert.AreEqual(initialCoins, gaul.pCoins, "Coins should remain unchanged when purchase fails");
        }
    }
}

using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void PobierzProdukt()
        {
            var produktRepository = new ProductRepository();
            var oczekiwana = new Product(2)
            {
                productName = "Piłka",
                specification = "Piłka rozmiar 5, Mundial 2018 Rosja",
                actualPrice = 349.99M
            };

            var aktualna = produktRepository.Pobierz(2);

            Assert.AreEqual(oczekiwana.productId, aktualna.productId);
            Assert.AreEqual(oczekiwana.productName, aktualna.productName);
            Assert.AreEqual(oczekiwana.specification, aktualna.specification);
            Assert.AreEqual(oczekiwana.actualPrice, aktualna.actualPrice);
        }
    }
}

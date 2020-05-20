using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            var klientRepository = new ClientRepository();
            var oczekiwana = new Client(1)
            {
                Email = "patryk@wp.pl",
                Name = "Patryk",
                Surname = "Nowak"
            };

            var aktualna = klientRepository.Pobierz(1);

            Assert.AreEqual(oczekiwana.clientId, aktualna.clientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Name, aktualna.Name);
            Assert.AreEqual(oczekiwana.Surname, aktualna.Surname);
        }
    }
}

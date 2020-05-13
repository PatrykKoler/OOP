using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void imienazwiskotest()
        {
            //Ararnge(zaaranżuj test)
            Client client = new Client();
            client.Name = "Patryk";
            client.Surname = "Koler";
            string check = "Patryk, Koler";

            //ACT (działaj)
            string actual = client.nameSurname;

            //Assect(potwierdzenie testu)
            Assert.AreEqual(check, actual);
        }
        [TestMethod]
        public void imiepuste()
        {
            //Ararnge(zaaranżuj test)
            Client client = new Client();
            client.Surname = "Koler";
            string check = "Koler";

            //ACT (działaj)
            string actual = client.nameSurname;

            //Assect(potwierdzenie testu)
            Assert.AreEqual(check, actual);
        }
        [TestMethod]
        public void nazwiskopuste()
        {
            //Ararnge(zaaranżuj test)
            Client client = new Client();
            client.Name = "Patryk";            
            string check = "Patryk";

            //ACT (działaj)
            string actual = client.nameSurname;

            //Assect(potwierdzenie testu)
            Assert.AreEqual(check, actual);
        }
        [TestMethod]
        public void statictest()
        {
            Client client1 = new Client();
            client1.Name = "Patryk";
            Client.Licznik += 1;

            Client client2 = new Client();
            client2.Name = "Magda";
            Client.Licznik += 1;

            Client client3 = new Client();
            client3.Name = "Marek";
            Client.Licznik += 1;

            Assert.AreEqual(3, Client.Licznik);
        }
        [TestMethod]
        public void zwaliduj()
        {
            var klient = new Client();
            klient.Surname = "Koler";
            klient.Email = "koler@wp.pl";
            var check = true;

            var actual = klient.zwaliduj();

            Assert.AreEqual(check, actual);
        }
        [TestMethod]
        public void zwalidujBrakNazwiska()
        {
            var klient = new Client();
            klient.Email = "koler@wp.pl";
            var check = false;

            var klient1 = new Client(100);
            var klient2 = new Client();
            var actual = klient.zwaliduj();

            Assert.AreEqual(check, actual);
        }
        [TestMethod]
        public void zwalidujBrakEmail()
        {
            var klient = new Client();
            klient.Surname = "Koler";
            var check = false;

            var actual = klient.zwaliduj();

            Assert.AreEqual(check, actual);
        }
    }
}

using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Jacek";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Marek";
            Klient.Licznik += 1;

            // Assert
            Assert.AreEqual(3, Klient.Licznik);
        }

        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (zaaranżuj test)
            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            klient.Email = "tomek@dev-hobby.pl";
            var oczekiwana = true;

            // Act (działaj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakNazwiska()
        {
            // Arrange (zaaranżuj test)
            var klient = new Klient();
            klient.Email = "tomek@dev-hobby.pl";
            var oczekiwana = false;

            var klient1 = new Klient(100);
            var klient2 = new Klient();

            // Act (działaj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}

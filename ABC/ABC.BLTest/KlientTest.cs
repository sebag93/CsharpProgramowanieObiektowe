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
    }
}

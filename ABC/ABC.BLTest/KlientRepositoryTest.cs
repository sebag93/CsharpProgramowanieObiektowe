﻿using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            // Arrange
            var klientReposiory = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Nowak"
            };

            // Act
            var aktualna = klientReposiory.Pobierz(1);

            // Assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }
    }
}

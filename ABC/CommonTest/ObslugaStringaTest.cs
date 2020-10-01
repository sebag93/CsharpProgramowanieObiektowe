﻿using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            // Arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";
            var obslugaStringa = new ObslugaStringa();

            // Act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            // Arrange
            var zrodlo = "Klocki Lego";
            var oczekiwana = "Klocki Lego";
            var obslugaStringa = new ObslugaStringa();

            // Act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}

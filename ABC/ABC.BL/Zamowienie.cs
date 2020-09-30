using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }

        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> PozycjaZamowienia { get; set; }

        public int KlientId { get; set; }

        public int AdresDostawyId { get; set; }

        /// <summary>
        /// Pobieramy jedno zamówienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Kod, który pobiera zdefiniowane zamówienie
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisujemy bieżące zamówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowane zamówienie
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
        }
    }
}

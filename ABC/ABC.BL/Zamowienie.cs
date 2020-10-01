using Common;
using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
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
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " {" + ZamowienieId + "}";
        }

        public string Log()
        {
            var logTekst = ZamowienieId + ": " +
                           "Data: " + DataZamowienia.Value.Date + " " +
                           "Status: " + StanObiektu.ToString();

            return logTekst;
        }
    }
}

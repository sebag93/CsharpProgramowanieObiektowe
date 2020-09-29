namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }

        public int Ilosc { get; set; }

        public int ProduktId { get; set; }

        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobieramy jedną pozycję zamówienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int pozycjaZamowieniaId)
        {
            // Kod, który pobiera zdefiniowany element zamówienia
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisujemy bieżący element zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowany element zamówienia
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane pozycji zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == null)
                poprawne = false;

            return poprawne;
        }

    }
}

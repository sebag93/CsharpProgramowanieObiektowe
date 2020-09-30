using System.Collections.Generic;

namespace ABC.BL
{
    public class KlientRepository
    {
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientId);

            // kod który pobiera określonego klienta

            //Tymczasowo zakodowane wartości aby zwrócić klienta
            if (klientId == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Nowak";
            }


            return klient;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        public List<Klient> Pobierz()
        {
            // kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}

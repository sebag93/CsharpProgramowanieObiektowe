using System.Collections.Generic;
using System.Linq;

namespace ABC.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientId);

            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

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
        public bool Zapisz(Klient klient)
        {
            // Kod, który zapisuje zdefiniowany produkt
            var sukces = true;
            if (klient.MaZmiany && klient.DaneSaPrawidlowe)
            {
                if (klient.JestNowy)
                {
                    // wywołujemy procedurę składowaną insert
                }
                else
                {
                    // wywołujemy procedurę składowaną update
                }
            }

            return sukces;
        }
    }
}

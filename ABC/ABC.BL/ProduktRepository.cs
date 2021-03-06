﻿using System;
using System.Runtime.InteropServices;

namespace ABC.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // Tworzymy instancje klasy produkt i przekazujemy identyfikator
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new Object();
            Console.WriteLine("Obiekt: " + mojObiekt.ToString());
            Console.WriteLine("Produkt: " + produkt.ToString());

            // Kod, który pobiera zdefiniowany produkt

            // Tymczasowe zakodowane wartości, aby zwrócić produkt
            if (produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki do zabawy dla dzieci powyżej 3 lat";
                produkt.AktualnaCena = 119.99M;
            }

            return produkt;
        }

        /// <summary>
        /// Zapisujemy bieżący produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            // Kod, który zapisuje zdefiniowany produkt
            var sukces = true;
            if (produkt.MaZmiany && produkt.DaneSaPrawidlowe)
            {
                if (produkt.JestNowy)
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

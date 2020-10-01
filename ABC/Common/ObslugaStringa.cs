namespace Common
{
    public static class ObslugaStringa
    {
        public static string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        // przycinamy wszelkie spacje, które tam są, a potem dodamy naszą spację
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }

            return wynik;
        }
    }
}

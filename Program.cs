using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal eur = 4.60m, usd = 3.99m, amount;
        start:
            Console.WriteLine("Jaka walute chcesz zmienic EUR/USD");
            string input = Console.ReadLine();
            if (input != "EUR" && input != "USD") //Jesli input jest różny od EUR i input jest różny od USD wyskoczy blad nieprawidlowa waluta i powroci do startu
            {
                Console.WriteLine("Błąd ! Nieprawidłowa waluta");
                goto start;
            }
            if (input == "EUR")
            {
            eur:
                Console.WriteLine("Aktualny kurs EUR to : {0} PLN. Podaj kwotę" + "Jaką chcesz wymienić", eur);
                input = Console.ReadLine();
                if (decimal.TryParse(input, out amount))
                {
                    Console.WriteLine("Otrzymasz {0} PLN.", (eur * amount));
                }
                else
                {
                    Console.WriteLine("Błąd! Niepoprawna kwota!.");
                    goto eur;
                }
            }
            if (input == "USD")
            {
            usd:
                Console.WriteLine("Akutalny kurs USD to : {0} PLN. Podaj kwotę" + "Jaką chcesz wymienić", usd);
                input = Console.ReadLine();
                if (decimal.TryParse(input, out amount))
                {
                    Console.WriteLine("Otrzymasz {0} PLN", (usd * amount));
                }
                else
                {
                    Console.WriteLine("Błąd! Niepoprawna kwota!");
                    goto usd;
                }
            }
        }
    }
}
            
        
    



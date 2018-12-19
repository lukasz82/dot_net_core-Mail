using System;

namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - - - - - - - ");
            Console.WriteLine();

            // TODO: Dla wersji dla nieabstrakcyjnej klasy - odkomentować
            // Mail gmail = new Mail();
            // gmail.send("");
            // gmail.showConfiguration();

            Mail gmail = new Gmail();
            gmail.send("");
            gmail.showConfiguration();

            IMail [] mailsArray = new IMail[3];
            mailsArray[0] = new Gmail();
            mailsArray[1] = new Wp();
            mailsArray[2] = new Gmail();
    
            string message = "Wysylam do wszystkich jedna wiadomosc, niezaleznie od konfiguracji poczty";

            mailsArray[0].send(message);
            mailsArray[1].send(message);
            mailsArray[2].send(message);

            Console.WriteLine();
            Console.WriteLine(" - - - - - - - ");
        }
    }
}

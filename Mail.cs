namespace Mail
{
    public abstract class Mail : IMail
    {
        protected string configuration;
        protected string name;

        // TODO: Gdyby klasa nie miala byc abstraktyjną to odkomentować
        // public Mail()
        // {
        //     configuration = " Domyslna - niezdefiniowana";
        //     name = "Domyslna niezdefiniowana";
        // }

        public void send(string message)
        {
            System.Console.WriteLine();
            if (message == "")
            {
                message = "Wiadomosc domyslna";
            } 
            System.Console.WriteLine("Wyslalem maila z konfiguracją dla " + name);
            System.Console.WriteLine("Tresc wiadomosci to: ");
            System.Console.WriteLine(message);
            System.Console.WriteLine();
        }

        public void showConfiguration()
        {
            System.Console.WriteLine("Obecnie ustawiona konfiguracja serwera do wysylania maili to " + configuration);
        }
    }
}
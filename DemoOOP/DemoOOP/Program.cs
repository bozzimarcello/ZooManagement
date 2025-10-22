namespace DemoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione personaggi");

            Personaggio giocatore1 = new Personaggio();
            giocatore1.Nome = "Aragorn";
            giocatore1.Razza = "umano";

            Personaggio giocatore2 = new Personaggio();
            giocatore2.Nome = "Ghimli";
            giocatore2.Razza = "nano";

            Mago giocatore3 = new Mago();
            giocatore3.Nome = "Gandalf";
            giocatore3.Razza = "mago";
            giocatore3.PuntiMagia = 100;

            giocatore1.Stampa();
            giocatore2.Stampa();
            giocatore3.Stampa();

            // questa è una modifica
        }
    }
}

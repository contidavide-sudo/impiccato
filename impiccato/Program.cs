namespace impiccato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sceltaDifficolta;
            Console.WriteLine("Seleziona il livello di difficoltà:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| 1 - Facile (10tentativi)         |");
            Console.WriteLine("| 2 - Medio (7 tentativi)          |");
            Console.WriteLine("| 3 - Difficile (3 tentativi)      |");
            Console.WriteLine("------------------------------------");

            sceltaDifficolta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (sceltaDifficolta == 1)
            {
                Console.WriteLine("Hai scelto la modalità facile");
            }
            else if (sceltaDifficolta == 2)
            {
                Console.WriteLine("Hai scelto la modalità media");
            }
            else if (sceltaDifficolta == 3)
            {
                Console.WriteLine("Hai scelto la modalità difficile");
            }
        }
    }
}

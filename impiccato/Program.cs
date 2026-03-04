namespace impiccato
{
    internal class Program
    {

        static string SceltaParola(string[] paro, int difficolta)
        {
            Random rnd = new Random();
            int indiceParola=0;
            string parolaScelta;

            if (difficolta == 1)
            {
                indiceParola = rnd.Next(0, 10);
            }
            else if(difficolta == 2)
            {
                indiceParola = rnd.Next(10, 19);
            }
            else if(difficolta == 3)
            {
                indiceParola = rnd.Next(20, 29);
            }

            return parolaScelta = paro[indiceParola];
           
        }

        static void Main(string[] args)
        {
                                               
            string[] parole = { "Cane", "Gatto", "Leone", "Libro", "Palla", "Tavolo", "Roma", "Milano", "Parigi",// Parole facili
                                "Giraffa", "Pinguino", "Scimpanze", "Chitarra", "Computer", "Orologio", "Berlino", "Venezia", "Firenze",//Parole medie
                                "Ornitorinco", "Armadillo", "Camaleonte", "Clessidra", "Pianoforte", "Caleidoscopio", "Dakar", "Stoccolma", "Tirana"}; //Parole difficili

            string[] generi = { "Animali", "Oggetti", "Città" };



            int sceltaDifficolta;
            Console.WriteLine("Seleziona il livello di difficoltà:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| 1 - Facile (10 tentativi)         |");
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

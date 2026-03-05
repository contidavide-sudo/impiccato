using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace impiccato
{
    internal class Program
    {
        static Random rnd = new Random();//Random
        static string SceltaParola(int difficolta, string[] tema)//Funzione per la scelta della parola in maniera randomica in base alla difficoltà scelta e al tema scelto
        {
            int indiceParola = 0;
            string parolaScelta;

            if (difficolta == 1)
            {
                indiceParola = rnd.Next(0, 4);
            }
            else if(difficolta == 2)
            {
                indiceParola = rnd.Next(4, 7);
            }
            else if(difficolta == 3)
            {
                indiceParola = rnd.Next(7, 10);
            }

            return parolaScelta = tema[indiceParola];
           
        }

        static string GeneraTrattini(string parola)//Funzione che genera la stringa di '_' della stessa lunghezza della parola
        {
            string trattini = "";

            for (int i = 0; i < parola.Length; i++)
            {
                trattini = trattini + "_";
            }

            return trattini;
        }

        static void ProvaLettera(ref string parola, ref string trattini, string[] alfa, ref int punti)//Funzione per provare ad inserire una sola lettera 
        {
            string lettera;

            Console.Write("Inserisci una lettera: ");
            lettera = Console.ReadLine();

            lettera = lettera.ToLower();

            parola = parola.ToLower();


            if(parola.Contains(lettera) == true)
            {
                Console.WriteLine("La lettera c'è!!!");

                char[] arrayTrattini = trattini.ToCharArray();

                for (int i = 0;i < trattini.Length; i++)
                {
                    if (parola[i] == Convert.ToChar(lettera))
                    {
                        arrayTrattini[i] = Convert.ToChar(lettera);
                    }
                }

                trattini = new string(arrayTrattini);

                for(int i = 0; i < alfa.Length; i++)
                {
                    if (alfa[i] != lettera)
                    {
                        Console.Write($"[{alfa[i]}]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        alfa[i] = "-";
                        Console.Write($"[{alfa[i]}]");
                        Console.ResetColor();
                    }
                }

            }
            else
            {
                Console.WriteLine("La parola non c'è!!!");

                punti = punti - 10; //Decrementazione del punteggiom se si sbaglia

                for (int i = 0; i < alfa.Length; i++)
                {
                    if (alfa[i] != lettera)
                    {
                        Console.Write($"[{alfa[i]}]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        alfa[i] = "-";
                        Console.Write($"[{alfa[i]}]");
                        Console.ResetColor();
                    }
                }
            }

        }

        static bool ParolaIntera(string parola)//Funzione per provare ad inserire la parola completa, se sbagliata il punteggio si azzera, se si indovina si vince
        {
            Console.Write("Scrivi la parola:");
            string provaParola = Console.ReadLine();

            if (parola == provaParola)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        static void Jolly(string parola, ref string trattini)//Funzione per l'indizio jolly che aggiunge una lettera casuale, che non è stata ancoramindovinata, alla parola da indovinare
        {
            int  indiceLetteraCas = rnd.Next(0, parola.Length); 
            char letteraScelta;

            while (parola[indiceLetteraCas] == trattini[indiceLetteraCas])
            {
                indiceLetteraCas = rnd.Next(0, parola.Length);
            }

            letteraScelta = parola[indiceLetteraCas];

            char[] arrayTrattini = trattini.ToCharArray();

            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] == letteraScelta)
                {
                    arrayTrattini[i] = letteraScelta;
                }
            }

            trattini = new string(arrayTrattini);

        }

        static void Main(string[] args)
        {
             //Tre array, ognuno di un propio tema le prime tre parole degli array sono facili, le ultime tre difficili e le tre a metà sono medie
            string[] animali = { "Cane", "Gatto", "Leone", "Giraffa", "Pinguino", "Scimpanze",  "Ornitorinco", "Armadillo", "Camaleonte", };

            string[] oggetti = { "Libro", "Palla", "Tavolo", "Chitarra", "Computer", "Orologio", "Clessidra", "Pianoforte", "Caleidoscopio" };

            string[] citta = { "Roma", "Milano", "Parigi", "Berlino", "Venezia", "Firenze", "Dakar", "Stoccolma", "Tirana" };

            string[] alfabeto = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

            int sceltaDifficolta, tentativi = 0, sceltaTema, sceltaAzione, punteggio = 100, contaJolly = 0, giocare;
            string parolaSegreta = "", trattini;

            Console.WriteLine("Seleziona il livello di difficoltà:");   //Selezione del livello di difficolta, più è difficile meno tentativi si hanno e più le parole sono complicate
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| 1 - Facile (10 tentativi)        |");
            Console.WriteLine("| 2 - Medio (8 tentativi)          |");
            Console.WriteLine("| 3 - Difficile (5 tentativi)      |");
            Console.WriteLine("------------------------------------");

            sceltaDifficolta = Convert.ToInt32(Console.ReadLine());

            if (sceltaDifficolta == 1)
            {
                tentativi = 10;
            }
            else if (sceltaDifficolta == 2)
            {
                tentativi = 8;
            }
            else if (sceltaDifficolta == 3)
            {
                tentativi = 5;
            }

            Console.WriteLine("Seleziona il tema della parola:");
            Console.WriteLine("------------------------------------");  //Scelta del tema delle parole 
            Console.WriteLine("| 1 - Animali                      |");
            Console.WriteLine("| 2 - Oggetti                      |");
            Console.WriteLine("| 3 - Città                        |");
            Console.WriteLine("------------------------------------");

            sceltaTema = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (sceltaTema == 1)
            {
                parolaSegreta = SceltaParola(sceltaDifficolta, animali);
            }
            else if (sceltaTema == 2)
            {               
                parolaSegreta = SceltaParola(sceltaDifficolta, oggetti);
            }
            else if (sceltaTema == 3)
            {                
                parolaSegreta = SceltaParola(sceltaDifficolta, citta);
            }

            trattini = GeneraTrattini(parolaSegreta);

            while (tentativi > 0 && trattini != parolaSegreta && punteggio > 0) //While per lo svolgimento partita
            {
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("------------------------------------");   //Scelta dell'azione che si vuole fare
                Console.WriteLine("| 1 - Provare una lettera          |");
                Console.WriteLine("| 2 - Scrivere la parola intera    |");
                Console.WriteLine("| 3 - Ricevere un indizio          |");
                Console.WriteLine("------------------------------------");

                sceltaAzione = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if(sceltaAzione == 1)
                {
                    ProvaLettera(ref parolaSegreta, ref trattini, alfabeto, ref punteggio);
                }
                else if(sceltaAzione == 2)
                {
                    if(ParolaIntera(parolaSegreta) == false)
                    {
                        punteggio = 0;
                    }
                }
                else if(sceltaAzione == 3)
                {
                    if (contaJolly == 0)
                    {
                        Jolly(parolaSegreta, ref trattini);
                        contaJolly = 1;
                    }
                    else
                    {
                        Console.WriteLine("Hai gia usato il jolly, non puoi più utilizzarlo");
                    }
                }

                Console.WriteLine();

                Console.WriteLine(trattini);       //Parola con i trattini che segna le lettere indovinate

                Console.WriteLine();

                Console.WriteLine($"Tentativi rimasti: {tentativi}");  //Tentativi rimasti

                tentativi--;
            }

            Console.WriteLine();

            if (trattini == parolaSegreta)  //Condizioni per la vittoria o la sconfitta
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("HAI VINTO!!!!");
                Console.ResetColor();

                Console.WriteLine($"Punteggio: {punteggio}");
                Console.WriteLine($"Tentativi rimasti: {tentativi}");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("HAI PERSO!!!!");
                Console.ResetColor();
            }


        }
    }
}

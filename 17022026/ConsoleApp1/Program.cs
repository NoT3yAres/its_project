using System;
using System.Data;
using System.Reflection.Metadata;

class Program
{

    static void Main()
    {
        string nomeFile = "studente.csv";
        if (!File.Exists(nomeFile))
            File.Create(nomeFile).Close();
        while (true)
        {
            Console.Clear();
            string[] Users = File.ReadAllLines(nomeFile);
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("(1) Aggiungi studente");
            Console.WriteLine("(2) Visualizza studenti");
            Console.WriteLine("(3) Media voti");
            Console.WriteLine("(4) Cerca studente");
            int scelta = int.Parse(Console.ReadLine() ?? "");
            switch (scelta)
            {
                case 1:
                    AggiungiUser(nomeFile);
                    break;
                case 2:
                    VisualizzaStud(Users);
                    break;
                case 3:
                    MediaVoti(Users);
                    break;
                case 4:
                    CercaStudente(Users);
                    break;
                default: Console.Write("scegli bene"); break;
            }
        }
    }
    static void AggiungiUser(string nomeFile)
    {
        Console.Clear();
        Console.WriteLine("Inserisci nome studente");
        string? nome = Console.ReadLine();
        Console.WriteLine("Inserisci voto");
        int voto = int.Parse(Console.ReadLine() ?? "");
        File.AppendAllText(nomeFile, $"{nome},{voto} \n");
    }


    static void VisualizzaStud(string[] Users)
    {
        Console.Clear();
        foreach (var i in Users)
        {
            string userName = i.Split(',')[0];
            string userVote = i.Split(',')[1];
            Console.WriteLine($"{userName} ---> \t\t{userVote}");
        }
        Console.WriteLine("Press any key");
        Console.ReadKey();
    }

    static void MediaVoti(string[] Users)
    {
        float media = 0;
        foreach (var i in Users)
        {
            float userVote = float.Parse(i.Split(',')[1]);
            media += userVote;
        }
        media = media / Users.Length;
        Console.WriteLine($"Media: {media:F2}");
        Console.WriteLine("Press any key");
        Console.ReadKey();
    }

    static void CercaStudente(string[] Users)
    {
        Console.Clear();
        Console.WriteLine("Inserisci il nome da cercare");
        string nomeDaCercare = Console.ReadLine() ?? "";
        foreach (var i in Users)
        {
            string userName = i.Split(',')[0];
            string userVote = i.Split(',')[1];
            if (userName == nomeDaCercare)
            {
                Console.WriteLine($"Studente trovato\n{userName} ---> \t\t{userVote}");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                return;

            }
        }
        Console.WriteLine("Nessuna corrispondenza trovata");
        Console.WriteLine("Press any key");
        Console.ReadKey();
    }
}

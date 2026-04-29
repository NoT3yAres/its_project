using System.Net.WebSockets;
using FileSystem;

class Program
{
    public static void Main(string[] args)
    {
        NodoFileSystem root = new NodoFileSystem();

        NodoFileSystem User = root.AggiungiNodo(root).AggiungiFolder("Users/");
        NodoFileSystem System = root.AggiungiNodo(root).AggiungiFolder("System/");
        NodoFileSystem Desktop = User.AggiungiNodo(User).AggiungiFolder("Desktop/");
        NodoFileSystem brawlstars = Desktop.AggiungiNodo(Desktop).AggiungiFile("Brawlstars.exe", 5000);
        NodoFileSystem kernel = System.AggiungiNodo(System).AggiungiFile("kernel.sys", 50);
        NodoFileSystem config = System.AggiungiNodo(System).AggiungiFile("config.ini", 50);
        NodoFileSystem Documents = User.AggiungiNodo(User).AggiungiFolder("Documents/");
        root.SelfStampa();
        root.StampaChildren();
        Console.WriteLine($"{TrovaFile(root, "Brawlstars.exe")}");
        

    }

    public static bool TrovaFile(NodoFileSystem nodo, string nome)
    {
        foreach (var figlio in nodo.Figli)
        {

            if (nodo.Nome == nome)
                return true;
            TrovaFile(figlio, nome);
        }
        return false;
    }
}
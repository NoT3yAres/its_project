using System.Runtime.Versioning;

class Progrm
{
    public static void Main(string[] args)
    {
        Grafo mappa = new Grafo();

        mappa.AggiungiNodo("Roma");
        mappa.AggiungiNodo("Milano");
        mappa.AggiungiNodo("Napoli");
        mappa.AggiungiNodo("Firenze");

        mappa.ConnectNodi("Roma", "Milano");
        mappa.ConnectNodi("Roma", "Firenze");
        mappa.ConnectNodi("Roma", "Napoli");
        mappa.ConnectNodi("Firenze", "Milano");
        mappa.ConnectNodi("Firenze", "Napoli");

        mappa.Visualizza();

        Console.WriteLine($"BFS");
        NodoGrafo roma = mappa.TrovaNodo("Roma");
        Grafo.BFS(roma, new HashSet<string>());
    }
}
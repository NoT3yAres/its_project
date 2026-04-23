using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class NodoAlbert
{
    public int Valore { get; set; }

    public NodoAlbert Sinistro { get; set; }

    public NodoAlbert Destro { get; set; }

    public NodoAlbert(int valore)
    {
        Valore = valore;
        Sinistro = null;
        Destro = null;
    }

    public static void StampaInOrdine(NodoAlbert nodo)
    {
        if (nodo == null) return;
        StampaInOrdine(nodo.Sinistro);
        Console.WriteLine($"{nodo.Valore}");
        StampaInOrdine(nodo.Destro);
        Console.WriteLine($"{nodo.Valore}");
    }

    public static void StampaPreOrdine(NodoAlbert nodo)
    {
        if (nodo == null) return;
        Console.WriteLine($"{nodo.Valore}");
        StampaPreOrdine(nodo.Sinistro);
        StampaPreOrdine(nodo.Destro);
    }

    public static bool Cerca(NodoAlbert nodo, int valore)
    {
        if (nodo == null) return false;
        if (nodo.Valore == valore) return true;
        return Cerca(nodo.Sinistro, valore) || Cerca(nodo.Destro, valore);
    }

    public static int ContaNodi(NodoAlbert nodo)
    {
        if (nodo == null) return 0;
        return 1 + ContaNodi(nodo.Sinistro) + ContaNodi(nodo.Destro);
    }

    public static int Altezza(NodoAlbert nodo)
    {
        if (nodo == null) return -1;

        int altezzaSinistra = Altezza(nodo.Sinistro);
        int altezzaDestra = Altezza(nodo.Destro);

        return Math.Max(altezzaDestra, altezzaSinistra) + 1;

    }

    public static int TrovaMax(NodoAlbert nodo)
    {
        if (nodo == null) return int.MinValue;
        int max = nodo.Valore;
        int maxSinistro = TrovaMax(nodo.Sinistro);
        int maxDestro = TrovaMax(nodo.Destro);
        if (maxSinistro > max)
            max = maxSinistro;
        if (maxDestro > max)
            max = maxDestro;
        return max;
    }

    public static int TrovaMin(NodoAlbert nodo)
    {
        if (nodo == null) return int.MaxValue;
        int min = nodo.Valore;
        int minSinistro = TrovaMin(nodo.Sinistro);
        int minDestro = TrovaMin(nodo.Destro);
        if (minSinistro > min)
            min = minSinistro;
        if (minDestro > min)
            min = minDestro;
        return min;
    }

    public static int ContaFoglie(NodoAlbert nodo)
    {
        if (nodo == null) return 0;
        if ((nodo.Sinistro == null) && (nodo.Destro == null)) return 1;
        return 1 + ContaFoglie(nodo.Sinistro) + ContaFoglie(nodo.Destro);
    }

    public static int Somma(NodoAlbert nodo)
    {
        if (nodo == null) return 0;

        return nodo.Valore + Somma(nodo.Sinistro) + Somma(nodo.Destro);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        NodoAlbert radice = new NodoAlbert(10);
        radice.Sinistro = new NodoAlbert(5);
        radice.Destro = new NodoAlbert(15);
        radice.Sinistro.Sinistro = new NodoAlbert(3);
        radice.Sinistro.Destro = new NodoAlbert(7);
        radice.Destro.Destro = new NodoAlbert(20);

        Console.Write($"IN ORDINE");
        NodoAlbert.StampaInOrdine(radice);

        Console.Write($"\n\nPRE ORDINE");
        NodoAlbert.StampaPreOrdine(radice);

        //Console.Write($"\n\nPOST ORDINE");
        //NodoAlbert.StampaPostOrdine(radice);

        bool nodo_sette = NodoAlbert.Cerca(radice, 7);
        Console.WriteLine($"ricerca 7: {(nodo_sette ? "trovato" : "non trovato")}");
        Console.WriteLine($"ricerca 6: {(NodoAlbert.Cerca(radice, 6) ? "trovato" : "non trovato")}");

        int nodi = NodoAlbert.ContaNodi(radice);
        int altezza = NodoAlbert.Altezza(radice);
        int foglie = NodoAlbert.ContaFoglie(radice);
        int massimo = NodoAlbert.TrovaMax(radice);
        int minimo = NodoAlbert.TrovaMin(radice);
        int somma = NodoAlbert.Somma(radice);

        Console.WriteLine($"numero nodi: {nodi}");
        Console.WriteLine($"Altezza albero: {altezza}");
        Console.WriteLine($"numero foglie: {foglie}");
        Console.WriteLine($"valore massimo: {massimo}");
        Console.WriteLine($"valore minimo: {minimo}");
        Console.WriteLine($"valore somma: {somma}");
    }
}


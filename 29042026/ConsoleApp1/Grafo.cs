using System.Runtime.InteropServices;

public class NodoGrafo
{
    public string Nome { get; set; }
    public List<NodoGrafo> Vicini { get; set; }

    public NodoGrafo(string nome)
    {
        Nome = nome;
        Vicini = new List<NodoGrafo>();
    }
}

public class Grafo
{
    public List<NodoGrafo> Nodi { get; set; }

    public Grafo()
    {
        Nodi = new List<NodoGrafo>();
    }

    public void AggiungiNodo(string nome)
    {
        if (!Nodi.Any(n => n.Nome == nome))
        {
            Nodi.Add(new NodoGrafo(nome));
        }
    }

    public NodoGrafo TrovaNodo(string nome)
    {
        return Nodi.FirstOrDefault(n => n.Nome == nome);
    }

    public void ConnectNodi(string nome_a, string nome_b)
    {
        NodoGrafo nodoA = TrovaNodo(nome_a);
        NodoGrafo nodoB = TrovaNodo(nome_b);

        if (nodoA != null && nodoB != null)
        {
            if (nodoA.Vicini.Contains(nodoB))
                nodoA.Vicini.Add(nodoB);
            if (nodoB.Vicini.Contains(nodoA))
                nodoB.Vicini.Add(nodoA);
        }
    }

    public void ConnectNodi_Diretto(string da, string a)
    {
        NodoGrafo NodoDa = TrovaNodo(da);
        NodoGrafo NodoA = TrovaNodo(a);

        if (NodoDa != null && NodoA != null)
        {
            if (NodoDa.Vicini.Contains(NodoA))
                NodoDa.Vicini.Add(NodoA);

        }
    }


    public static void BFS(NodoGrafo inizio, HashSet<string> visitati)
    {
        Queue<NodoGrafo> coda = new Queue<NodoGrafo>();
        coda.Enqueue(inizio);
        visitati.Add(inizio.Nome);

        while (coda.Count > 0)
        {
            NodoGrafo attuale = coda.Dequeue();
            Console.WriteLine($"{attuale.Nome}");

            foreach (var vicino in attuale.Vicini)
            {
                visitati.Add(vicino.Nome);
                coda.Enqueue(vicino);
            }
        }
    }

    public static void DFS(NodoGrafo nodo, HashSet<string> visitati)
    {
        visitati.Add(nodo.Nome);
        Console.WriteLine($"{nodo.Nome}");

        foreach (var vicino in nodo.Vicini)
        {
            if (!visitati.Contains(vicino.Nome))
                DFS(vicino, visitati);
        }
    }

    public int ContaNodi()
    {
        return Nodi.Count;
    }

    public int ContaGrado(string nome)
    {
        NodoGrafo nodo = TrovaNodo(nome);
        return nodo?.Vicini.Count ?? 0;
    }

    public void Visualizza()
    {
        foreach (var nodo in Nodi)
        {
            string vicini = nodo.Vicini.Count > 0 ? string.Join(", ", nodo.Vicini.Select(v => v.Nome)) : "[Isolato]";

            Console.WriteLine($" {nodo.Nome}  -> {vicini}");
        }
    }
}
// =============================================
// ESERCIZI AVANZATO — Delegati e strutture dati
// =============================================
// Argomenti: Func<decimal,decimal>, Predicate<Prodotto>,
//            Dictionary<string, List<Prodotto>>,
//            progettazione autonoma della classe CarrelloSpesa
//
// REGOLA: usa foreach + if per le iterazioni manuali.
//         Per l'esercizio 4 implementa la classe CarrelloSpesa
//         in fondo a questo file (dopo il commento indicato).
// =============================================

// Dataset già pronto — non modificare
List<Prodotto> prodotti = new List<Prodotto>
{
    new Prodotto { Nome = "Laptop",    Categoria = "Elettronica",   Prezzo = 899.99m, Quantita = 5   },
    new Prodotto { Nome = "Mouse",     Categoria = "Elettronica",   Prezzo = 25.99m,  Quantita = 20  },
    new Prodotto { Nome = "Tastiera",  Categoria = "Elettronica",   Prezzo = 59.99m,  Quantita = 15  },
    new Prodotto { Nome = "Monitor",   Categoria = "Elettronica",   Prezzo = 349.99m, Quantita = 0   },
    new Prodotto { Nome = "Felpa",     Categoria = "Abbigliamento", Prezzo = 39.99m,  Quantita = 30  },
    new Prodotto { Nome = "Scarpe",    Categoria = "Abbigliamento", Prezzo = 129.99m, Quantita = 10  },
    new Prodotto { Nome = "Giacca",    Categoria = "Abbigliamento", Prezzo = 199.99m, Quantita = 8   },
    new Prodotto { Nome = "Pallone",   Categoria = "Sport",         Prezzo = 29.99m,  Quantita = 25  },
    new Prodotto { Nome = "Racchetta", Categoria = "Sport",         Prezzo = 89.99m,  Quantita = 12  },
    new Prodotto { Nome = "Pasta",     Categoria = "Alimentari",    Prezzo = 1.29m,   Quantita = 100 },
    new Prodotto { Nome = "Olio",      Categoria = "Alimentari",    Prezzo = 8.99m,   Quantita = 50  },
    new Prodotto { Nome = "Caffe",     Categoria = "Alimentari",    Prezzo = 4.99m,   Quantita = 75  },
};

// ────────────────────────────────────────────
// ESERCIZIO 1 — Func<decimal, decimal>
// ────────────────────────────────────────────
// Func<decimal, decimal> è un delegato che riceve un decimal
// e restituisce un decimal. Perfetto per trasformazioni di prezzo.
//
// ► ESEMPIO: Func che aggiunge l'IVA al 22%
Func<decimal, decimal> aggiungiIva = (prezzo) => prezzo * 1.22m;

Console.WriteLine("=== ESEMPIO — Func<decimal,decimal> aggiungiIva ===");
Console.WriteLine($"  Laptop 899,99€ + IVA = {aggiungiIva(899.99m):F2}€");
Console.WriteLine();

// ► TODO 1a: dichiara  Func<decimal, decimal> applicaSconto10
//            che restituisce il prezzo ridotto del 10%  (prezzo * 0.90m)

// ► TODO 1b: con foreach, per ogni prodotto stampa:
//            $"  {p.Nome}: {p.Prezzo:F2}€ → {applicaSconto10(p.Prezzo):F2}€ (sconto 10%)"

Console.WriteLine("=== ESERCIZIO 1 — Prezzi con sconto 10% ===");
// scrivi qui
Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 2 — Predicate<Prodotto>
// ────────────────────────────────────────────
// Dichiara un Predicate che identifica i prodotti costosi (Prezzo > 100).
// Costruisci MANUALMENTE una lista filtrata con foreach + if.

Console.WriteLine("=== ESERCIZIO 2 — Prodotti costosi (Prezzo > 100) ===");

// ► TODO 2a: dichiara  Predicate<Prodotto> eCostoso = (p) => p.Prezzo > 100;

// ► TODO 2b: crea  List<Prodotto> costosi = new List<Prodotto>();
//            con foreach + if: if (eCostoso(p)) costosi.Add(p);

// ► TODO 2c: con foreach stampa nome e prezzo dei prodotti costosi:
//            $"  {p.Nome} — {p.Prezzo:F2}€"

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 3 — Dictionary<string, List<Prodotto>>
// ────────────────────────────────────────────
// Raggruppa i prodotti per categoria in un Dictionary.
// Chiave: nome categoria | Valore: lista di prodotti in quella categoria
// Non usare LINQ — costruiscilo con foreach + ContainsKey.

Console.WriteLine("=== ESERCIZIO 3 — Prodotti raggruppati per categoria ===");

// ► TODO 3a: crea  Dictionary<string, List<Prodotto>> perCategoria = new();

// ► TODO 3b: con foreach su prodotti:
//            - se la categoria non esiste nel dictionary, aggiungila con lista vuota
//            - poi aggiungi il prodotto alla lista della sua categoria
//
//            Suggerimento:
//            if (!perCategoria.ContainsKey(p.Categoria))
//                perCategoria[p.Categoria] = new List<Prodotto>();
//            perCategoria[p.Categoria].Add(p);

// ► TODO 3c: con foreach sul dizionario stampa ogni categoria e il numero di prodotti:
//            foreach (var coppia in perCategoria)
//                Console.WriteLine($"  {coppia.Key}: {coppia.Value.Count} prodotti");

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 4 — Progetta e usa CarrelloSpesa
// ────────────────────────────────────────────
// La classe CarrelloSpesa è definita in fondo a questo file.
// Implementa i metodi segnati con TODO nella classe, poi testali qui.

Console.WriteLine("=== ESERCIZIO 4 — CarrelloSpesa ===");

// ► TODO 4 (test): crea un CarrelloSpesa
//   CarrelloSpesa carrello = new CarrelloSpesa();

// ► aggiungi 3 prodotti dalla lista (usa i costruttori new Prodotto { ... })

// ► stampa il totale con CalcolaTotale()

// ► dichiara Func<decimal, decimal> sconto15 = (t) => t * 0.85m;
//   e stampa il totale scontato con CalcolaTotaleConSconto(sconto15)

Console.WriteLine();
Console.WriteLine("=== Fine esercizi — premi INVIO per uscire ===");
Console.ReadLine();


// ============================================================
// CLASSE CarrelloSpesa — DA IMPLEMENTARE QUI SOTTO
// ============================================================
// Implementa il corpo di ogni metodo.
// Non modificare le firme (nome, parametri, tipo di ritorno).
// ============================================================

class CarrelloSpesa
{
    // Campo privato — lista interna dei prodotti nel carrello
    private List<Prodotto> _prodotti = new List<Prodotto>();

    // Aggiunge un prodotto al carrello
    public void Aggiungi(Prodotto p)
    {
        // TODO 4a: aggiungi p alla lista _prodotti
        throw new NotImplementedException("TODO 4a: implementa Aggiungi");
    }

    // Rimuove dal carrello il prodotto con il nome indicato
    public void Rimuovi(string nome)
    {
        // TODO 4b: con foreach, trova il prodotto con Nome == nome
        //          salvalo in una variabile locale (Prodotto? trovato = null)
        //          quando lo trovi, assegna e fai break
        //          poi: if (trovato != null) _prodotti.Remove(trovato);
        throw new NotImplementedException("TODO 4b: implementa Rimuovi");
    }

    // Calcola e restituisce il totale (somma di Prezzo di ogni prodotto)
    public decimal CalcolaTotale()
    {
        // TODO 4c: dichiara decimal totale = 0;
        //          con foreach somma p.Prezzo per ogni prodotto
        //          restituisci totale
        throw new NotImplementedException("TODO 4c: implementa CalcolaTotale");
    }

    // Applica la Func al totale e restituisce il risultato
    public decimal CalcolaTotaleConSconto(Func<decimal, decimal> sconto)
    {
        // TODO 4d: chiama CalcolaTotale() per ottenere il totale
        //          passa il totale alla Func e restituisci il risultato
        //          Suggerimento: return sconto(CalcolaTotale());
        throw new NotImplementedException("TODO 4d: implementa CalcolaTotaleConSconto");
    }
}

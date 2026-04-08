# Esercizi Avanzato — Delegati, Dictionary e progettazione

## Obiettivo
Applicare `Func<T,TResult>` e `Predicate<T>` su dati reali, costruire manualmente un `Dictionary<string, List<Prodotto>>`, e progettare autonomamente la classe `CarrelloSpesa`.

## Come procedere
Apri `EserciziAvanzato.sln` con Visual Studio.
La classe `Prodotto` è già in `Prodotto.cs` — non modificarla.
Completa i TODO in `Program.cs`. La classe `CarrelloSpesa` va implementata in fondo allo stesso file.

---

## Esercizio 1 — Func\<decimal, decimal\>

`Func<decimal, decimal>` è un delegato che riceve un `decimal` e ne restituisce un altro.
Serve per incapsulare una trasformazione di prezzo.

**Da fare:**
1. Dichiara `Func<decimal, decimal> applicaSconto10` che calcola prezzo × 0.90
2. Con `foreach`, stampa per ogni prodotto il prezzo originale e quello scontato

**Output atteso (esempio):**
```
  Laptop: 899,99€ → 809,99€ (sconto 10%)
  Mouse: 25,99€ → 23,39€ (sconto 10%)
  ...
```

---

## Esercizio 2 — Predicate\<Prodotto\>

**Da fare:**
1. Dichiara `Predicate<Prodotto> eCostoso` che verifica `Prezzo > 100`
2. Crea una `List<Prodotto> costosi` vuota
3. Con `foreach` + `if (eCostoso(p))`, popola la lista
4. Stampa nome e prezzo dei prodotti costosi

**Output atteso (esempio):**
```
  Laptop — 899,99€
  Monitor — 349,99€
  Scarpe — 129,99€
  Giacca — 199,99€
```

---

## Esercizio 3 — Dictionary\<string, List\<Prodotto\>\>

Raggruppa tutti i prodotti per categoria senza usare LINQ.

**Tecnica:**
```csharp
Dictionary<string, List<Prodotto>> perCategoria = new();

foreach (Prodotto p in prodotti)
{
    if (!perCategoria.ContainsKey(p.Categoria))
        perCategoria[p.Categoria] = new List<Prodotto>();

    perCategoria[p.Categoria].Add(p);
}
```

Poi stampa ogni categoria con il numero di prodotti.

**Output atteso:**
```
  Elettronica: 4 prodotti
  Abbigliamento: 3 prodotti
  Sport: 2 prodotti
  Alimentari: 3 prodotti
```

---

## Esercizio 4 — Progetta CarrelloSpesa

Implementa la classe `CarrelloSpesa` già definita in fondo a `Program.cs`.

### Schema da rispettare

| Membro | Tipo | Descrizione |
|--------|------|-------------|
| `_prodotti` | `List<Prodotto>` (privata) | Lista interna dei prodotti |
| `Aggiungi(Prodotto p)` | `void` | Aggiunge p alla lista |
| `Rimuovi(string nome)` | `void` | Rimuove il prodotto con quel nome |
| `CalcolaTotale()` | `decimal` | Somma i prezzi di tutti i prodotti |
| `CalcolaTotaleConSconto(Func<decimal,decimal>)` | `decimal` | Applica la Func al totale |

### Come implementare Rimuovi (suggerimento)
```csharp
Prodotto? trovato = null;
foreach (Prodotto p in _prodotti)
{
    if (p.Nome == nome) { trovato = p; break; }
}
if (trovato != null) _prodotti.Remove(trovato);
```

### Test nel Main
```csharp
CarrelloSpesa carrello = new CarrelloSpesa();
carrello.Aggiungi(new Prodotto { Nome = "Laptop", Prezzo = 899.99m, Categoria = "Elettronica", Quantita = 1 });
carrello.Aggiungi(new Prodotto { Nome = "Mouse",  Prezzo = 25.99m,  Categoria = "Elettronica", Quantita = 1 });
carrello.Aggiungi(new Prodotto { Nome = "Felpa",  Prezzo = 39.99m,  Categoria = "Abbigliamento", Quantita = 1 });

Console.WriteLine($"Totale: {carrello.CalcolaTotale():F2}€");

Func<decimal, decimal> sconto15 = (t) => t * 0.85m;
Console.WriteLine($"Totale con sconto 15%: {carrello.CalcolaTotaleConSconto(sconto15):F2}€");
```

---

## Verifica finale

- Esercizi 1, 2, 3: il programma gira e stampa i risultati
- Esercizio 4: `CalcolaTotale()` e `CalcolaTotaleConSconto()` restituiscono valori corretti

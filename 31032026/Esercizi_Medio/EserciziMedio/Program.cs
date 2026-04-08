// =============================================
// ESERCIZI MEDIO — List<T> e Delegati con oggetti
// =============================================
// Argomenti: List<Studente>, foreach + if manuale,
//            Action<T>, Predicate<T>
//
// REGOLA IMPORTANTE:
//   NON usare List.Find, List.FindAll, List.Sort, List.RemoveAll.
//   Usa SEMPRE foreach + if per scorrere e filtrare.
// =============================================

// Dataset già pronto — non modificare
List<Studente> studenti = new List<Studente>
{
    new Studente { Nome = "Alice",   Eta = 20, Media = 8.5m  },
    new Studente { Nome = "Marco",   Eta = 17, Media = 5.5m  },
    new Studente { Nome = "Giorgia", Eta = 22, Media = 7.0m  },
    new Studente { Nome = "Luca",    Eta = 19, Media = 9.2m  },
    new Studente { Nome = "Sofia",   Eta = 16, Media = 4.8m  },
    new Studente { Nome = "Davide",  Eta = 21, Media = 6.1m  },
    new Studente { Nome = "Elena",   Eta = 18, Media = 8.0m  },
};

// ────────────────────────────────────────────
// ESERCIZIO 1 — Stampare tutti gli studenti
// ────────────────────────────────────────────
// Scorri la lista con foreach e stampa ogni studente.
// Formato atteso:
//   Nome: Alice   | Età: 20 | Media: 8,50

Console.WriteLine("=== ESERCIZIO 1 — Stampa tutti gli studenti ===");

// TODO 1: scrivi un foreach su "studenti"
//         per ogni studente s stampa:
//         $"  Nome: {s.Nome,-8} | Età: {s.Eta} | Media: {s.Media:F2}"
//         (il -8 dopo il nome allinea il testo — puoi anche ignorarlo)

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 2 — Ricerca manuale con break
// ────────────────────────────────────────────
// Trova il PRIMO studente con Media >= 8.
// Usa foreach + if. Quando lo trovi, salva il riferimento e usa break.

Console.WriteLine("=== ESERCIZIO 2 — Primo studente con media >= 8 ===");

// TODO 2: dichiara  Studente? primoOttimo = null;
//         con foreach + if: se s.Media >= 8, assegna s a primoOttimo e fai break
//         Poi: se primoOttimo non è null stampa il nome, altrimenti "Nessuno trovato"

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 3 — Conteggio manuale
// ────────────────────────────────────────────
// Conta quanti studenti hanno Eta > 18.
// Usa un contatore locale, foreach e if.

Console.WriteLine("=== ESERCIZIO 3 — Studenti maggiorenni (Eta > 18) ===");

// TODO 3: dichiara  int contatoreAdulti = 0;
//         con foreach + if: se s.Eta > 18, incrementa contatoreAdulti  (contatoreAdulti++)
//         Poi stampa: $"  Studenti con età > 18: {contatoreAdulti}"

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 4 — Action<Studente>
// ────────────────────────────────────────────
// Dichiara un Action<Studente> e applicala a ogni studente con foreach.
// L'Action deve stampare le informazioni dello studente — non farlo nel foreach direttamente.

Console.WriteLine("=== ESERCIZIO 4 — Action<Studente> ===");

// TODO 4a: dichiara un'Action<Studente> chiamata "stampaStudente" che stampa:
//          $"  [{s.Media:F2}] {s.Nome} ({s.Eta} anni)"

// TODO 4b: con foreach, invoca stampaStudente per ogni studente:
//          foreach (Studente s in studenti) { stampaStudente(s); }

Console.WriteLine();

// ────────────────────────────────────────────
// ESERCIZIO 5 — Predicate<Studente>
// ────────────────────────────────────────────
// Dichiara un Predicate<Studente> che identifica gli insufficienti (Media < 6).
// Costruisci MANUALMENTE una nuova lista contenente solo i bocciati.

Console.WriteLine("=== ESERCIZIO 5 — Studenti insufficienti (Media < 6) ===");

// TODO 5a: dichiara  Predicate<Studente> eInsufficiente = (s) => s.Media < 6;

// TODO 5b: crea  List<Studente> bocciati = new List<Studente>();
//          con foreach + if, usa il predicate per decidere:
//          foreach (Studente s in studenti)
//          {
//              if (eInsufficiente(s))
//                  bocciati.Add(s);
//          }

// TODO 5c: stampa tutti i bocciati con un secondo foreach
//          formato: $"  {s.Nome} — Media: {s.Media:F2}"

Console.WriteLine();
Console.WriteLine("=== Fine esercizi — premi INVIO per uscire ===");
Console.ReadLine();

// =============================================
// ESERCIZIO FINALE — Sistema Biblioteca
// =============================================
// Questo file NON COMPILA finché non avrai implementato
// tutte le classi richieste. È normale: il tuo obiettivo
// è progettare e scrivere tutto da zero seguendo la
// traccia in CONSEGNA.md.
//
// Una volta implementate le classi, rimuovi i commenti
// dai passi qui sotto uno alla volta e verifica che
// il programma funzioni correttamente.
// =============================================


// ── PASSO 1: crea una BibliotecaService ──────────────────
// BibliotecaService biblioteca = new BibliotecaService();


// ── PASSO 2: aggiungi libri alla biblioteca ───────────────
// Aggiungi almeno 3 LibroFisico e 2 EBook con dati diversi.
// Esempio:
// biblioteca.Aggiungi(new LibroFisico
// {
//     Titolo = "Il Signore degli Anelli",
//     Autore = "J.R.R. Tolkien",
//     AnnoPublicazione = 1954,
//     NumeroPagine = 1178
// });
// biblioteca.Aggiungi(new EBook
// {
//     Titolo = "Clean Code",
//     Autore = "Robert C. Martin",
//     AnnoPublicazione = 2008,
//     Formato = "PDF"
// });
// ... altri libri ...


// ── PASSO 3: stampa tutti i libri ────────────────────────
// Usa GetTutti() per ottenere la lista e foreach + GetDescrizione() per stamparli.
// Console.WriteLine("=== Tutti i libri in biblioteca ===");
// foreach (ILibro libro in biblioteca.GetTutti())
// {
//     Console.WriteLine($"  {libro.GetDescrizione()}");
// }
// Console.WriteLine();


// ── PASSO 4: usa Cerca() con un Predicate ────────────────
// Trova tutti i libri pubblicati dopo il 2010.
// Predicate<ILibro> recenti = (l) => l.AnnoPublicazione > 2010;
// List<ILibro> libriRecenti = biblioteca.Cerca(recenti);
// Console.WriteLine("=== Libri pubblicati dopo il 2010 ===");
// foreach (ILibro libro in libriRecenti)
// {
//     Console.WriteLine($"  {libro.Titolo} ({libro.AnnoPublicazione})");
// }
// Console.WriteLine();


// ── PASSO 5: usa RimuoviDove() con un Predicate ──────────
// Rimuovi i libri con anno di pubblicazione antecedente al 2000.
// Predicate<ILibro> vecchi = (l) => l.AnnoPublicazione < 2000;
// biblioteca.RimuoviDove(vecchi);
// Console.WriteLine("Libri ante 2000 rimossi dalla biblioteca.");
// Console.WriteLine();


// ── PASSO 6: raggruppa con LINQ GroupBy ──────────────────
// Raggruppa i libri rimanenti per tipo concreto (LibroFisico / EBook).
// var perTipo = biblioteca.GetTutti().GroupBy(l => l.GetType().Name);
// Console.WriteLine("=== Libri per tipo ===");
// foreach (var gruppo in perTipo)
// {
//     Console.WriteLine($"  {gruppo.Key}: {gruppo.Count()} libri");
//     foreach (ILibro libro in gruppo)
//         Console.WriteLine($"    - {libro.Titolo}");
// }


Console.WriteLine("Implementa le classi descritte in CONSEGNA.md e rimuovi i commenti.");
Console.ReadLine();

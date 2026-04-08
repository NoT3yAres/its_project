// =============================================
// ESERCIZI BASE — Strutture Dati e Delegati
// =============================================
// Argomenti: Array, List<T>, Dictionary<K,V>,
//            Stack<T>, Queue<T>,
//            Action<T>, Func<T,TResult>, Predicate<T>
//
// Per ogni sezione trovi:
//   ► ESEMPIO — codice già scritto, leggilo con attenzione
//   ► TODO    — completa tu il codice
//
// CONVENZIONI RICORDATE:
//   camelCase   → variabili locali:  nomeStudente, listaCitta
//   PascalCase  → classi e metodi:   List<string>, Console.WriteLine
//   _camelCase  → campi privati di classe: _contatore
// =============================================


// ────────────────────────────────────────────
// SEZIONE A — Array
// ────────────────────────────────────────────
// Un array ha dimensione FISSA: devi sapere quanti elementi
// vuoi PRIMA di crearlo. Si accede con l'indice: arr[0], arr[1]...
// ────────────────────────────────────────────

// ► ESEMPIO: array di 3 colori, stampati con ciclo for
using System.Runtime.CompilerServices;

string[] colori = new string[3];
colori[0] = "Rosso";
colori[1] = "Verde";
colori[2] = "Blu";

Console.WriteLine("=== ESEMPIO — Array di colori ===");
for (int i = 0; i < colori.Length; i++)
{
    Console.WriteLine($"  colori[{i}] = {colori[i]}");
}
Console.WriteLine();

// ► TODO A1: dichiara un array di 5 elementi chiamato "nomi" (string[])
//            e assegna 5 nomi a tua scelta (almeno uno che inizia con 'M')
// string[] nomi = new string[5];
// nomi[0] = "...";
// ...

string[] nomi = new string[5];
nomi = { "simone", "mario", "giuppeppeepee", "re_caio", "cacasbura"};

// ► TODO A2: con un ciclo for, stampa ogni nome con il suo indice
//            formato: "  nomi[0] = Mario"
for(int j = 0; j < nomi.Length; j++)
{
    Console.WriteLine($"nome[{j}] = {nomi[j]}");
}

// ► TODO A3: con un ciclo for e un if, trova e stampa il PRIMO nome
//            che inizia con la lettera 'M'
//            Suggerimento: usa nomi[i].StartsWith("M")

for (int j = 0; j < nomi.Length; j++)
{
    if (nomi[i].StartsWith("m"))
    {
        Console.WriteLine($"nome[{j}] = {nomi[j]}");
    }
}

Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE B — List<string>
// ────────────────────────────────────────────
// Una List<T> ha dimensione DINAMICA: cresce e si riduce
// automaticamente. Principali metodi: Add, Remove, Contains, Count.
// ────────────────────────────────────────────

// ► ESEMPIO: lista di animali
List<string> animali = new List<string>();
animali.Add("Cane");
animali.Add("Gatto");
animali.Add("Pappagallo");

Console.WriteLine("=== ESEMPIO — List<string> animali ===");
Console.WriteLine($"  Elementi: {animali.Count}");
Console.WriteLine($"  Contiene 'Gatto': {animali.Contains("Gatto")}");
animali.Remove("Pappagallo");
Console.WriteLine($"  Dopo Remove('Pappagallo'): {animali.Count} elementi");
Console.WriteLine();

// ► TODO B1: crea una List<string> chiamata "citta" e aggiungi 3 città italiane
List<string> citta = new List<string>();
citta.Add("Teramo");
citta.Add("Tettazze");
citta.Add("Roma");



// ► TODO B2: stampa il numero di città con la proprietà Count

Console.WriteLine("=== ESEMPIO — List<string> citta ===");
Console.WriteLine($"  Elementi: {citta.Count}");


// ► TODO B3: rimuovi una città dalla lista con Remove

citta.Remove("Teramo");

// ► TODO B4: verifica con Contains se "Roma" è ancora nella lista e stampa il risultato
if (citta.Contains("Roma"))
    return true;
else
    return false;
Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE C — Dictionary<string, int>
// ────────────────────────────────────────────
// Un Dictionary mappa una CHIAVE a un VALORE: chiave → valore
// Come una rubrica: nome → numero di telefono
// Metodi utili: Add, ContainsKey, TryGetValue, [chiave]
// ────────────────────────────────────────────

// ► ESEMPIO: dizionario prodotto → prezzo
Dictionary<string, int> prezzi = new Dictionary<string, int>();
prezzi.Add("Pane", 2);
prezzi.Add("Latte", 1);
prezzi.Add("Pasta", 1);

Console.WriteLine("=== ESEMPIO — Dictionary<string,int> prezzi ===");
Console.WriteLine($"  Prezzo del pane: {prezzi["Pane"]}€");
Console.WriteLine($"  Contiene 'Burro': {prezzi.ContainsKey("Burro")}");

if (prezzi.TryGetValue("Latte", out int prezzoLatte))
    Console.WriteLine($"  Prezzo latte (TryGetValue): {prezzoLatte}€");
Console.WriteLine();

// ► TODO C1: crea un Dictionary<string, int> chiamato "eta"
//            mappa nome → età. Inserisci almeno 3 persone.

// ► TODO C2: stampa l'età di una persona usando la chiave diretta:  eta["Mario"]

// ► TODO C3: usa ContainsKey per verificare se "Luigi" è nel dizionario

// ► TODO C4: usa TryGetValue per leggere l'età di una persona in modo sicuro
//            (non lancia eccezione se la chiave non esiste)
//            Suggerimento: if (eta.TryGetValue("nome", out int etaTrovata)) { ... }

Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE D — Stack<string>
// ────────────────────────────────────────────
// Stack = pila LIFO (Last In, First Out)
// L'ULTIMO elemento inserito è il PRIMO ad uscire.
// Metodi: Push (inserisci), Pop (rimuovi e restituisci), Peek (leggi senza rimuovere)
// Esempio reale: cronologia del browser — il tasto "Indietro" torna all'ultima pagina
// ────────────────────────────────────────────

// ► ESEMPIO: stack di numeri
Stack<int> numeriStack = new Stack<int>();
numeriStack.Push(10);
numeriStack.Push(20);
numeriStack.Push(30);

Console.WriteLine("=== ESEMPIO — Stack<int> ===");
Console.WriteLine($"  In cima (Peek): {numeriStack.Peek()}");       // legge 30 senza rimuoverlo
Console.WriteLine($"  Pop: {numeriStack.Pop()}");                    // rimuove e restituisce 30
Console.WriteLine($"  Elementi rimasti: {numeriStack.Count}");
Console.WriteLine();

// ► TODO D1: crea uno Stack<string> chiamato "cronologia"
//            fai Push di 3 pagine web (es: "google.com", "github.com", "youtube.com")

// ► TODO D2: stampa la pagina in cima con Peek (senza rimuoverla)

// ► TODO D3: simula il tasto "Indietro": fai Pop e stampa quale pagina hai lasciato

// ► TODO D4: stampa quante pagine restano nella cronologia

Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE E — Queue<string>
// ────────────────────────────────────────────
// Queue = coda FIFO (First In, First Out)
// Il PRIMO elemento inserito è il PRIMO ad uscire.
// Metodi: Enqueue (aggiungi in fondo), Dequeue (rimuovi dal fronte), Peek (leggi il fronte)
// Esempio reale: coda di clienti allo sportello
// ────────────────────────────────────────────

// ► ESEMPIO: coda di stampa
Queue<string> codaStampa = new Queue<string>();
codaStampa.Enqueue("documento1.pdf");
codaStampa.Enqueue("foto.jpg");
codaStampa.Enqueue("report.docx");

Console.WriteLine("=== ESEMPIO — Queue<string> coda stampa ===");
Console.WriteLine($"  Prossimo in stampa (Peek): {codaStampa.Peek()}");
Console.WriteLine($"  Stampo: {codaStampa.Dequeue()}");
Console.WriteLine($"  Elementi in coda: {codaStampa.Count}");
Console.WriteLine();

// ► TODO E1: crea una Queue<string> chiamata "clienti"
//            aggiungi con Enqueue 3 nomi di clienti

// ► TODO E2: stampa il primo cliente in attesa con Peek

// ► TODO E3: serve il primo cliente: usa Dequeue e stampa chi è stato servito

// ► TODO E4: stampa quanti clienti restano in coda

Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE F — Action<T>
// ────────────────────────────────────────────
// Action<T> è un delegato che rappresenta un metodo che:
//   - riceve un parametro di tipo T
//   - NON restituisce nulla (void)
//
// Dichiarazione:
//   Action<string> saluta = (nome) => Console.WriteLine("Ciao, " + nome);
//
// Invocazione — come un metodo normale:
//   saluta("Mario");
// ────────────────────────────────────────────

// ► ESEMPIO: Action che stampa un numero al quadrato
Action<int> stampaQuadrato = (numero) => Console.WriteLine($"  {numero}² = {numero * numero}");

Console.WriteLine("=== ESEMPIO — Action<int> stampaQuadrato ===");
stampaQuadrato(4);
stampaQuadrato(7);
Console.WriteLine();

// ► TODO F1: dichiara un'Action<string> chiamata "saluta"
//            che stampa "Benvenuto, {nome}!" usando l'interpolazione di stringhe

// ► TODO F2: invoca "saluta" due volte con nomi diversi

Console.WriteLine();

// ────────────────────────────────────────────
// SEZIONE G — Predicate<T> e Func<T, TResult>
// ────────────────────────────────────────────
// Predicate<T>: delegato che riceve T e restituisce bool
//   Serve per porre una domanda vero/falso su un valore.
//   Predicate<int> ePari = (n) => n % 2 == 0;
//
// Func<T, TResult>: delegato che riceve T e restituisce TResult
//   Serve per trasformare un valore in un altro.
//   Func<int, int> raddoppia = (n) => n * 2;
// ────────────────────────────────────────────

// ► ESEMPIO: Predicate che verifica se una stringa è lunga più di 5 caratteri
Predicate<string> eLunga = (testo) => testo.Length > 5;

Console.WriteLine("=== ESEMPIO — Predicate<string> eLunga ===");
Console.WriteLine($"  'Ciao' è lunga: {eLunga("Ciao")}");
Console.WriteLine($"  'Benvenuto' è lunga: {eLunga("Benvenuto")}");

// ► ESEMPIO: Func che converte in maiuscolo
Func<string, string> maiuscolo = (testo) => testo.ToUpper();
Console.WriteLine($"  'hello' in maiuscolo: {maiuscolo("hello")}");
Console.WriteLine();

// ► TODO G1: dichiara un Predicate<int> chiamato "ePari"
//            che restituisce true se il numero è divisibile per 2
//            Suggerimento: usa l'operatore modulo  n % 2 == 0

// ► TODO G2: testa "ePari" con i numeri 4, 7 e 10 — stampa il risultato per ciascuno

// ► TODO G3: dichiara un Func<int, int> chiamato "raddoppia"
//            che restituisce il doppio del numero ricevuto

// ► TODO G4: testa "raddoppia" con 3 numeri e stampa i risultati

Console.WriteLine();
Console.WriteLine("=== Fine esercizi — premi INVIO per uscire ===");
Console.ReadLine();

# Esercizi Base — Strutture Dati e Delegati

## Obiettivo
Familiarizzarsi con le principali strutture dati di C# e con i delegati base (Action, Func, Predicate) attraverso esercizi guidati a difficoltà crescente.

## Come procedere
Apri la solution `EserciziBase.sln` con Visual Studio.
Ogni sezione nel file `Program.cs` contiene:
- un **ESEMPIO** già scritto e funzionante — leggilo con attenzione
- uno o più **TODO** da completare tu

Completa i TODO dall'alto verso il basso. Avvia il programma con **F5** per verificare il risultato.

---

## Sezione A — Array

Un array ha **dimensione fissa**: decidi quanti elementi vuoi prima di crearlo.

```csharp
string[] nomi = new string[5];   // array di 5 stringhe
nomi[0] = "Mario";               // accesso tramite indice
```

**Da fare:**
- A1: Dichiara un array di 5 nomi e assegnali (almeno uno inizia con 'M')
- A2: Stampali tutti con un ciclo `for` e il loro indice
- A3: Con `for` + `if`, trova e stampa il **primo** nome che inizia con 'M'
  _(Suggerimento: `nomi[i].StartsWith("M")`)_

---

## Sezione B — List\<string\>

Una List ha **dimensione dinamica**: cresce e si riduce con `Add` e `Remove`.

```csharp
List<string> lista = new List<string>();
lista.Add("Roma");
lista.Remove("Roma");
bool c = lista.Contains("Roma");  // false
int n = lista.Count;              // numero di elementi
```

**Da fare:**
- B1: Crea una `List<string>` con 3 città italiane
- B2: Stampa il numero di città (`Count`)
- B3: Rimuovi una città con `Remove`
- B4: Verifica con `Contains` se "Roma" è ancora nella lista

---

## Sezione C — Dictionary\<string, int\>

Un Dictionary mappa ogni **chiave** a un **valore**.

```csharp
Dictionary<string, int> eta = new Dictionary<string, int>();
eta.Add("Mario", 25);
int anni = eta["Mario"];                       // accesso diretto
bool esiste = eta.ContainsKey("Luigi");        // sicuro prima di accedere
if (eta.TryGetValue("Luigi", out int v)) { }  // ancora più sicuro
```

**Da fare:**
- C1: Crea un dizionario `nome → età` con 3 persone
- C2: Stampa l'età di una persona con accesso diretto (`[]`)
- C3: Verifica con `ContainsKey` se "Luigi" esiste
- C4: Usa `TryGetValue` per leggere un'età in modo sicuro

---

## Sezione D — Stack\<string\>

Stack = **LIFO** — l'ultimo inserito è il primo a uscire.
Pensa alla cronologia del browser: il tasto "Indietro" torna all'ultima pagina visitata.

```csharp
Stack<string> stack = new Stack<string>();
stack.Push("pagina1");    // inserisci
string top = stack.Peek(); // leggi senza rimuovere
string rimossa = stack.Pop(); // rimuovi e restituisci
```

**Da fare:**
- D1: Crea uno `Stack<string>` "cronologia" e fai Push di 3 pagine web
- D2: Stampa la pagina in cima con `Peek`
- D3: Simula il tasto "Indietro": fai `Pop` e stampa la pagina lasciata
- D4: Stampa quante pagine restano

---

## Sezione E — Queue\<string\>

Queue = **FIFO** — il primo inserito è il primo a uscire.
Pensa a una coda di clienti allo sportello.

```csharp
Queue<string> queue = new Queue<string>();
queue.Enqueue("Cliente1");   // aggiungi in fondo
string primo = queue.Peek(); // leggi il fronte
string servito = queue.Dequeue(); // rimuovi il fronte
```

**Da fare:**
- E1: Crea una `Queue<string>` "clienti" e aggiungi 3 nomi
- E2: Stampa il primo in attesa con `Peek`
- E3: Servi il primo cliente con `Dequeue` e stampa chi è stato servito
- E4: Stampa quanti clienti restano

---

## Sezione F — Action\<T\>

`Action<T>` è un metodo "in linea" che **non restituisce nulla**.

```csharp
Action<string> stampa = (testo) => Console.WriteLine(testo);
stampa("Ciao!");   // invocazione
```

**Da fare:**
- F1: Dichiara un `Action<string>` chiamato "saluta" che stampa `"Benvenuto, {nome}!"`
- F2: Invocalo due volte con nomi diversi

---

## Sezione G — Predicate\<T\> e Func\<T, TResult\>

`Predicate<T>` è un metodo "in linea" che **restituisce bool** (domanda vero/falso).
`Func<T, TResult>` è un metodo "in linea" che **trasforma T in TResult**.

```csharp
Predicate<int> positivo = (n) => n > 0;
bool ok = positivo(5);   // true

Func<int, int> doppio = (n) => n * 2;
int d = doppio(4);       // 8
```

**Da fare:**
- G1: Dichiara `Predicate<int> ePari` che restituisce `true` se il numero è pari (`n % 2 == 0`)
- G2: Testalo con 4, 7, 10
- G3: Dichiara `Func<int, int> raddoppia` che restituisce il doppio
- G4: Testalo con 3 numeri

---

## Verifica finale

Il programma deve avviarsi senza errori e mostrare l'output corretto per ogni sezione.
Confronta il tuo output con quello delle sezioni ESEMPIO per capire il formato atteso.

# Esercizi Medio — List e Delegati con oggetti

## Obiettivo
Usare `List<T>` con oggetti reali (classe `Studente`), scorrere le liste con `foreach` + `if`, e applicare i delegati `Action<T>` e `Predicate<T>` in contesti pratici.

## Regola fondamentale
> **NON usare** `List.Find`, `List.FindAll`, `List.Sort`, `List.RemoveAll`.
> Usa **sempre** `foreach` + `if` per scorrere e filtrare le liste.
> Lo scopo è capire come funzionano queste operazioni "a mano" prima di usare le scorciatoie.

## Come procedere
Apri `EserciziMedio.sln` con Visual Studio.
La classe `Studente` è già implementata in `Studente.cs` — non modificarla.
Completa i TODO in `Program.cs` dall'alto verso il basso. Premi **F5** per verificare.

---

## Esercizio 1 — Stampare tutti gli studenti

Scorri la lista `studenti` con `foreach` e stampa ogni studente.

**Output atteso (esempio):**
```
Nome: Alice    | Età: 20 | Media: 8,50
Nome: Marco    | Età: 17 | Media: 5,50
...
```

**Suggerimento:**
```csharp
foreach (Studente s in studenti)
{
    Console.WriteLine($"  Nome: {s.Nome} | Età: {s.Eta} | Media: {s.Media:F2}");
}
```

---

## Esercizio 2 — Ricerca manuale con break

Trova il **primo** studente con `Media >= 8`.

**Tecnica:**
1. Dichiara `Studente? primoOttimo = null;` (null = non trovato)
2. Con `foreach` + `if`, quando trovi uno studente con media >= 8:
   - assegnalo a `primoOttimo`
   - esci subito dal ciclo con `break`
3. Stampa il nome se trovato, "Nessuno trovato" altrimenti

**Output atteso:** `Primo studente con media >= 8: Alice`

---

## Esercizio 3 — Conteggio manuale

Conta quanti studenti hanno `Eta > 18`.

**Tecnica:** dichiara un contatore intero a 0, incrementalo con `++` quando la condizione è vera.

**Output atteso:** `Studenti con età > 18: 4`

---

## Esercizio 4 — Action\<Studente\>

`Action<Studente>` è un metodo inline che riceve uno `Studente` e non restituisce nulla.

```csharp
Action<Studente> stampaStudente = (s) => Console.WriteLine($"  [{s.Media:F2}] {s.Nome}");
stampaStudente(studenti[0]);  // invocazione
```

**Da fare:**
1. Dichiara `Action<Studente> stampaStudente` che stampa `[media] nome (età anni)`
2. Con `foreach`, invocala per ogni studente della lista

**Output atteso (esempio):**
```
  [8,50] Alice (20 anni)
  [5,50] Marco (17 anni)
  ...
```

---

## Esercizio 5 — Predicate\<Studente\>

`Predicate<Studente>` è un metodo inline che riceve uno `Studente` e restituisce `bool`.

```csharp
Predicate<Studente> eInsufficiente = (s) => s.Media < 6;
bool risultato = eInsufficiente(studenti[0]);  // true o false
```

**Da fare:**
1. Dichiara `Predicate<Studente> eInsufficiente` che verifica `Media < 6`
2. Crea una `List<Studente> bocciati` vuota
3. Con `foreach` + `if (eInsufficiente(s))`, aggiungi i bocciati alla lista
4. Stampa tutti i bocciati

**Output atteso (esempio):**
```
  Marco — Media: 5,50
  Sofia — Media: 4,80
```

---

## Verifica finale

Il programma deve girare senza eccezioni e produrre output per tutti e 5 gli esercizi.

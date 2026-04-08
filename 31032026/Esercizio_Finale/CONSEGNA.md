# Esercizio Finale — Sistema Biblioteca

## Obiettivo
Progettare e implementare da zero un sistema di gestione biblioteca applicando tutto quello che hai imparato:
**interface**, **classi astratte**, **List**, **Predicate**, **LINQ**.

Non viene fornito codice di partenza (tranne il `Main` in `Program.cs`): devi progettare tu lo schema e implementare ogni classe.

---

## Schema delle classi da progettare

Completa lo schema qui sotto **prima di scrivere codice** (su carta o in un documento).

### Interface
```
ILibro
  ├── Proprietà: Titolo (get)        tipo: ???
  ├── Proprietà: Autore (get)        tipo: ???
  ├── Proprietà: AnnoPublicazione (get) tipo: ???
  └── Metodo: GetDescrizione()       ritorna: ???
```

### Classe astratta
```
LibroBase : ILibro  (is-a ILibro)
  ├── implementa: Titolo, Autore, AnnoPublicazione  con  { get; set; }
  └── GetDescrizione() → abstract  (delegato alle classi figlie)
```

### Classi concrete
```
LibroFisico : LibroBase  (is-a LibroBase → is-a ILibro)
  ├── Proprietà aggiuntiva: NumeroPagine (int)
  └── GetDescrizione() → "Libro fisico: {Titolo} di {Autore} ({NumeroPagine} pag.)"

EBook : LibroBase  (is-a LibroBase → is-a ILibro)
  ├── Proprietà aggiuntiva: Formato (string)  es. "PDF", "EPUB"
  └── GetDescrizione() → "EBook [{Formato}]: {Titolo} di {Autore}"
```

### Classe di servizio
```
BibliotecaService
  ├── Campo privato: _libri  tipo: List<ILibro>  (inizializzato vuoto)
  │
  ├── void Aggiungi(ILibro libro)
  │     → aggiunge libro a _libri
  │
  ├── List<ILibro> GetTutti()
  │     → restituisce _libri (o una sua copia)
  │
  ├── List<ILibro> Cerca(Predicate<ILibro> condizione)
  │     → crea una lista vuota
  │     → scorre _libri con foreach
  │     → se condizione(libro) è true, aggiunge alla lista
  │     → restituisce la lista
  │
  └── void RimuoviDove(Predicate<ILibro> condizione)
        → crea una lista dei libri DA RIMUOVERE (foreach + if)
        → poi rimuovili da _libri con foreach + Remove
        → (non modificare _libri mentre lo stai scorrendo)
```

---

## Regole is-a / can-do

| Domanda | Risposta | Struttura |
|---------|----------|-----------|
| LibroFisico **è un** libro? | Sì | `LibroFisico : LibroBase` |
| EBook **è un** libro? | Sì | `EBook : LibroBase` |
| Tutti i libri **sanno** descriversi? | Sì (contratto) | `ILibro` con `GetDescrizione()` |
| Titolo/Autore/Anno sono uguali per tutti? | Sì | Implementati in `LibroBase` |
| La descrizione è diversa per tipo? | Sì | `GetDescrizione()` è `abstract` in `LibroBase` |

---

## Passi del Main (da sbloccare uno alla volta)

1. Crea una `BibliotecaService`
2. Aggiungi almeno **3 LibroFisico** e **2 EBook** con dati reali
3. Stampa tutti i libri con `foreach` + `GetDescrizione()`
4. Usa `Cerca()` con un `Predicate<ILibro>` per trovare i libri dopo il 2010
5. Usa `RimuoviDove()` con un `Predicate<ILibro>` per rimuovere i libri ante 2000
6. Con **LINQ GroupBy** raggruppa i libri rimanenti per tipo e stampa i gruppi

---

## Suggerimento per il Passo 6

```csharp
var perTipo = biblioteca.GetTutti().GroupBy(l => l.GetType().Name);
foreach (var gruppo in perTipo)
{
    Console.WriteLine($"  {gruppo.Key}: {gruppo.Count()} libri");
    foreach (ILibro libro in gruppo)
        Console.WriteLine($"    - {libro.Titolo}");
}
```

---

## Domanda finale (ci pensi su)

Nel `Main`, per creare un `LibroFisico` o un `EBook` usi un `if`/`else` basato sul tipo.
Come potresti **eliminare questo if/else** rendendo il codice più flessibile?
_(Indizio: c'è un pattern che crea oggetti in base a un parametro... ne parleremo prossimamente.)_

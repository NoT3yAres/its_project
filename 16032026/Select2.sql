SELECT Corsi.CorsoID, Corsi.NomeCorso
FROM Corsi, Studenti, Iscrizioni
WHERE 
    Studenti.StudenteID = Iscrizioni.StudenteID AND
    Corsi.CorsoID = Iscrizioni.CorsoID AND
    Studenti.Cognome = "Rossi";
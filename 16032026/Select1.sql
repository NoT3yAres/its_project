SELECT Studenti.Nome, Studenti.Cognome 
FROM Studenti, Corsi, Iscrizioni
WHERE 
    Corsi.CorsoID = Iscrizioni.CorsoID AND
    Iscrizioni.StudenteID = Studenti.StudenteID AND
    Corsi.DocenteID = "1";
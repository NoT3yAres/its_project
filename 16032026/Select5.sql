SELECT Studenti.Nome, Studenti.Cognome
FROM  Studenti, Corsi, Iscrizioni, Docenti
WHERE 
    Studenti.StudenteID = Iscrizioni.StudenteID AND
    Corsi.CorsoID = Iscrizioni.CorsoID AND
    Corsi.DocenteID = Docenti.DocenteID AND
    

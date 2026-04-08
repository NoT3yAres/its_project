SELECT Studenti.Nome, Studenti.Cognome
FROM  Studenti, Corsi, Iscrizioni
WHERE 
    Studenti.StudenteID = Iscrizioni.StudenteID AND
    Corsi.CorsoID = Iscrizioni.CorsoID AND
    Corsi.NomeCorso IS NULL;

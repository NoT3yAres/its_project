using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseBiglietto
{
    internal class Biglietto
    {
        public DateOnly DataEvento { get; }

        public string Luogo { get; }

        public double Prezzo { get; private set; }
        public string Posto { get; }

        public bool Annullato { get; private set; }

        public Biglietto(DateOnly date, string luogo, double prezzo, string posto)
        {
            DataEvento = date;
            Luogo = luogo;
            Prezzo = prezzo;
            Posto = posto;
            Annullato = false;
        }

        public void annullaBiglietto()
        {
            Annullato = true;
        }
        public string stampaDettagli()
        {
            if (!Annullato)
                return $"il biglietto per il giorno {DataEvento} per {Luogo} con posto a sedere {Posto} costa {Prezzo} risulta valido";
            else
                return $"il biglietto risulta NON valido";
        }

        public void cambiaPrezzo(double nuovoPrezzo)
        {
            Prezzo = nuovoPrezzo;
        }
    }
}
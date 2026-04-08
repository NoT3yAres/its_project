using System.Reflection;

namespace ClasseVeicolo
{
    public class Auto : Veicolo
    {
        public int NumeroPorte;
        public Auto(string marca, string modello, int anno, int numeroPorte) : base(marca, modello, anno)
        {
            NumeroPorte = numeroPorte;
        }

        public override void Avvia()
        {
            Console.WriteLine($"Auto: accesa");
        }

        public override void Ferma()
        {
            Console.WriteLine($"");
        }
    }
}
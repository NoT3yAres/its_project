using System.Reflection;

namespace ClasseVeicolo
{
    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public Veicolo(string marca, string modello, int anno)
        {
            Anno = anno;
            Modello = modello;
            Anno = anno;
        }

        public void MostraInfo()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello} ({Anno})");
        }

        public abstract void Avvia();
        public abstract void Ferma();
    }
}
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animale cane1 = new Cane("sesamo");
            Console.Write($"{cane1.Nome} dice: ");
            cane1.Verso();
            ((Cane)cane1).Gioca();
            Animale gatto1 = new Gatto("pistacchio");
            Console.Write($"{gatto1.Nome} dice: ");
            gatto1.Verso();
            ((Gatto)gatto1).Dormi();
            Animale canePoli1 = new CaneDaLavoro("rex", "poliziotto");
            Console.WriteLine($"{canePoli1.Nome} dice: ");
            canePoli1.Verso();
            Console.WriteLine($"Mansione: {((CaneDaLavoro)canePoli1).mansione}");
            canePoli1.DaiDaMangiare(32);

        }
    }


    abstract class Animale
    {
        protected int energia;
        public string Nome { get; set; }

        public Animale(string p_nome)
        {
            Nome = p_nome;
            energia = 50;
        }

        public Animale(string p_nome, int cibo)
        {
            Nome = p_nome;
            energia = 50 + cibo;
        }
        public abstract void Verso();

        protected void Mangia(int cibo)
        {
            energia += cibo;
            Console.WriteLine($"Energia aumentata a {energia}");
        }

        public void DaiDaMangiare(int cibo)
        {
            Mangia(cibo);
        }
    }

    class Cane : Animale
    {

        public Cane(string p_nome) : base(p_nome)
        {

        }
        public override void Verso()
        {
            Console.WriteLine($"Bau");
        }

        public void Gioca()
        {
            if (energia >= 10)
            {
                energia -= 10;
                Console.WriteLine($"{Nome} sta giocando!");
                Console.WriteLine($"energia rimasta: {energia}");
            }
            else
            {
                Console.WriteLine($"{Nome} e' troppo stanco per giocare");
            }

        }
    }

    class Gatto : Animale
    {
        public Gatto(string p_nome) : base(p_nome) { }
        public override void Verso()
        {
            Console.WriteLine($"Miao");
        }
        public void Dormi()
        {
            Console.WriteLine($"{Nome} sta dormendo!");
        }
    }

    class CaneDaLavoro : Cane
    {
        public string mansione;
        public CaneDaLavoro(string p_nome, string p_mansione) : base(p_nome)
        {
            mansione = p_mansione;
        }

        public override void Verso()
        {
            Console.WriteLine($"BAUUUUU!");
        }

        public void Addestra()
        {
            Console.WriteLine($"{Nome} sta facendo addestramento!");
        }



    }
}

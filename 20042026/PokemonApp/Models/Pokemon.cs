using System.Reflection.Metadata.Ecma335;

namespace PokemonApp.Models
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public int Attacco { get; private set; }
        public int Difesa { get; private set; }
        public int Salute { get; set; }
        public TipoPokemon Tipo { get; set; }

        public Pokemon(string p_Nome, TipoPokemon p_Tipo)
        {
            Nome = p_Nome;
            Attacco = new Random().Next(5, 10) * 10 + 5;
            Difesa = new Random().Next(3, 7) * 7 + 5;
            Salute = new Random().Next(5, 10) * 25 + 15;
            Tipo = p_Tipo;
        }

        public bool isVivo()
        {
            if (Salute > 0)
                return true;
            else
                return false;
        }

        private bool hasVantaggio(Pokemon p_Avversario)
        {
            switch (this.Tipo, p_Avversario.Tipo)
            {
                case (TipoPokemon.Fuoco, TipoPokemon.Erba): return true;
                case (TipoPokemon.Acqua, TipoPokemon.Fuoco): return true;
                case (TipoPokemon.Erba, TipoPokemon.Acqua): return true;
                default: return false;
            }
        }
        public void Attacca(Pokemon p_Avversario)
        {
            p_Avversario.Salute = this.Attacco - (p_Avversario.Difesa / 2);
        }
    }
}
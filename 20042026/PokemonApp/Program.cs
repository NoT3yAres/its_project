using PokemonApp.Models;
using PokemonApp.Services;

namespace PokemonApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pokemon p1 = new Pokemon("Albert", TipoPokemon.Erba);
            Pokemon p2 = new Pokemon("Leonards", TipoPokemon.Fuoco);

            BattleManager battaglia1 = new BattleManager(p1, p2);
            battaglia1.Lotta();
        }
    }
}
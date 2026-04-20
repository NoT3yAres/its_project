using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using PokemonApp.Models;

namespace PokemonApp.Services
{
    public class BattleManager
    {
        private Pokemon p1;
        private Pokemon p2;
        int turno;

        public BattleManager(Pokemon p_p1, Pokemon p_p2)
        {
            p1 = p_p1;
            p2 = p_p2;
            turno = 0;
        }

        public void Lotta()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                p1.Attacca(p2);
                p2.Attacca(p1);
                turno++;
                if (!p1.isVivo())
                {
                    Console.WriteLine($"{p2.Nome} vince!");
                    isFinished = true;
                }

                if (!p2.isVivo())
                {
                    Console.WriteLine($"{p1.Nome} vince!");
                    isFinished = true;
                }

            }
        }

    }
}
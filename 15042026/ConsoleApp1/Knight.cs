namespace Videogiochino
{
    public class Knight : Character
    {
        public string Nome;
        public int Hp;

        public Knight(string p_nome, int p_hp) : base(p_nome, p_hp)
        {
            Nome = p_nome;
            Hp = p_hp;
        }
    }
}
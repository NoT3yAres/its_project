namespace Videogiochino
{
    public abstract class Character
    {
        public string Nome { get; set; }
        public int Hp { get; set; }
        private int Level;
        private int Xp;
        private int maxHp;

        public Character(string p_nome, int p_hp)
        {
            Nome = p_nome;
            Hp = p_hp;
            Level = 0;
            maxHp = 100;
            ControlloLifePoint();
        }

        public void ControlloLifePoint()
        {
            if (Hp < 0)
                Hp = 0;
            if (Hp > maxHp)
                Hp = maxHp;

        }
        public void LevelUp(int xpGained)
        {
            Xp += xpGained;
            //Controlla se supera i 5000 xp cosi da fare +1 al livello
            if (Xp > 5000)
            {
                Xp -= 5000;
                Level += 1;
                ControlloLifePoint();
                LevelUp(Xp);
            }
        }

        public void Cura(int hpRestored)
        {
            Hp += hpRestored;
        }
    }
}
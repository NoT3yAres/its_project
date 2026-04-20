namespace Videogiochino
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character Marco = new Wizard(p_nome: "Marco", p_hp: 10000);
            Console.WriteLine($"{Marco.Hp}");
            Marco.LevelUp(5001);
            Console.WriteLine($"{Marco.Hp}");
            Marco.LevelUp(50000);
            Console.WriteLine($"{Marco.Hp}");


        }
    }
}
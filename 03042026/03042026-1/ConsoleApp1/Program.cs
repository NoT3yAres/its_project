namespace ClasseVeicolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo macchina = new Veicolo("BA434AA", "FIAT", "PANDA", 145);

            macchina.Accelera(67);
            Console.WriteLine($"La macchina sta andando a {macchina.Velocita} Km/h");
            macchina.Frena(68);
            Console.WriteLine($"La macchina sta andando a {macchina.Velocita} Km/h");
            macchina.Accelera(12000);
            Console.WriteLine($"La macchina sta andando a {macchina.Velocita} Km/h");


            Console.WriteLine(macchina.GetInfo());
        }
    }
}
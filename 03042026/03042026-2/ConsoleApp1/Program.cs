namespace ClasseBiglietto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Biglietto PAPAPOUI = new Biglietto(new DateOnly(2026, 3, 3), "Padova", 32, "1C");
            Console.WriteLine(PAPAPOUI.stampaDettagli());
            PAPAPOUI.annullaBiglietto();
            Console.WriteLine(PAPAPOUI.stampaDettagli());
        }
    }
}
using System.Formats.Asn1;

class mediaVoti
{
    static void Main(string[] args)
    {
        double rag;
        Console.WriteLine("Inserisci raggio");
        rag = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci altezza");
        alt = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Area = {funcArea(rag, alt)}\nPerimestro = {funcPerimetro(rag,alt)}");
    }
    static double funcArea(double rag, double alt)
    {
        return (rag * rag * 3.14 * alt);
    }

    static double funcPerimetro(double rag, double alt)
    {
        return (3.14 * rag * 2 * alt);
    }


}
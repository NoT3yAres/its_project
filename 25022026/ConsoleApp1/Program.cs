using Microsoft.VisualBasic;

class Program
{
    public static void Main(String[] args)
    {
        int[] arrayCosto = new int[10] { 10, 10, 10, 10, 1, 2, 3, 3, 3, 3 };
        int numMax = arrayCosto[0];
        int numMin = arrayCosto[0];
        int oraMinima = 0;
        int oraMassima = 0;
        for (int i = 0; i < 10; i++)
        {
            if (numMin >= arrayCosto[i])
            {
                numMin = arrayCosto[i];
                oraMinima = i;
            }
        }
        for (int j = oraMinima; j < 10; j++)
        {
            if (numMax <= arrayCosto[j])
            {
                numMax = arrayCosto[j];
                oraMassima = j;
            }
        }
        if (oraMassima < oraMinima)
            Console.WriteLine("NON COMPRARE OGGI");
        else
            Console.WriteLine($"Min: {numMin} da acquistare alle {oraMinima}:00\nMax: {numMax} da vendere alle {oraMassima}:00\n\nProfitto massimo della giornata: {numMax - numMin}");
    }
}
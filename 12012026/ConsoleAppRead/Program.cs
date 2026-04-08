using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ConsoleAppRead;
//leggere da console 9 interi e memorizzarli in un array mono-dimensionale
class Program
{
    static void Main(string[] args)
    {
        //dichiarare array di 9 elementi
        int[] arrayOfNumbers = new int[9];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.WriteLine("inserisci un numero: ");
            arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(CalculateAverage(arrayOfNumbers));
        return;
    }
    public static float CalculateAverage(int[] values)
    {
        if (values.Length < 0) return 0;

        float tmp = 0.0f;
        for (int i = 0; i < values.Length; i++)
        {
            tmp += values[i];
        }
        return (tmp / values.Length);
    }
}
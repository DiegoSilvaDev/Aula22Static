using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            
            Console.WriteLine(Conversor.ConverterDolarParaReal(200));
            Console.WriteLine(Conversor.ConverterRealParaDolar(200));

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(Conversor.ConverterEuroParaReal(250));
            Console.WriteLine(Conversor.ConverterRealParaEuro(250));

            Console.ResetColor();
        }
    }
}

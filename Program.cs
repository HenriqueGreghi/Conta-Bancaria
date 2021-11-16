using System;
using System.Globalization

namespace ContaBancaria01
{
    class Program
    {
        public static int Numero { get; private set; }
        public static string Titular { get; set; }
        public static double Saldo { get; private set; }
        string S, N;

        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta:");
            Numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta");
            Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)");
            if (S)
            {
            public double Saldo = Console.ReadLine(); }

        


        }
    }
}

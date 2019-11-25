using System;

namespace EjemploMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase Estática no necesita ser instanciada para usar sus mátodos");

            Console.WriteLine("Valor Absoluto");
            Console.WriteLine(Math.Abs(29));
            Console.WriteLine(Math.Abs(-15));
            Console.WriteLine(Math.Abs(0));

            Console.WriteLine();

            Console.WriteLine("valores Trigonométricos en Radianes : ");
            Console.WriteLine("sin (pi/3)    = {0}", Math.Sin(Math.PI / 3));
            Console.WriteLine("cos (pi/3)    = {0}", Math.Cos(Math.PI / 3));
            Console.WriteLine("tan (pi/3)    = {0}", Math.Tan(Math.PI / 3));
            Console.WriteLine("arcsin (1/2)  = {0}", Math.Asin(0.5));
            Console.WriteLine("arccos (1/2)  = {0}", Math.Acos(0.5));
            Console.WriteLine("arctan (1/2)  = {0}", Math.Atan(0.5));

            Console.WriteLine();

            Console.WriteLine("Logaritmo y Exponencial de e");
            Console.WriteLine("Log10(1000) = {0}", Math.Log10(1000));
            Console.WriteLine("Log(100) = {0}", Math.Log(100));
            Console.WriteLine("Exp(3) = {0}", Math.Exp(3));

            Console.WriteLine();

            Console.WriteLine("Min - Max");
            Console.WriteLine("El mínimo entre {0} y {1} es: {2}", 10, 33, Math.Min(10, 33));
            Console.WriteLine("El mínimo entre {0} y {1} es: {2}", -12, -2, Math.Min(-12, -2));
            Console.WriteLine("El minimo entre {0} y {1} es: {2}", -10, 45, Math.Min(-10, 45));
            Console.WriteLine("El máximo entre {0} y {1} es: {2}", 10, 33, Math.Max(10, 33));
            Console.WriteLine("El máximo entre {0} y {1} es: {2}", -12, -2, Math.Max(-12, -2));
            Console.WriteLine("El máximo entre {0} y {1} es: {2}", -10, 45, Math.Max(-10, 45));

            Console.WriteLine();

            Console.WriteLine("Potencia y Raiz");
            Console.WriteLine("Potencia de 2 a la 10, Pow(2, 10) es: {0}", Math.Pow(2, 10));
            Console.WriteLine("Raiz Cuadrada de 100, Sqrt(100) es: {0} ", Math.Sqrt(100));

            Console.WriteLine();

            Console.WriteLine("Round y Truncate");
            double num = 9.75;
            Console.WriteLine("Round({0}) es: {1}", num, Math.Round(num));
            Console.WriteLine("Truncate({0}) es: {1}", num, Math.Truncate(num));
        }
    }
}

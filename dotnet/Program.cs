using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

         var magica = new Magica();

        Console.WriteLine("Digite o primeiro valor: "); 
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: "); 
        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O resultado da soma é: " + (valor1+valor2));
        Console.ReadKey();


        }
    }
}

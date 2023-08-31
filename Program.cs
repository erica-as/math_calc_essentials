using System;
using Calculator.Menu;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a operação que deseja realizar: ");
            Console.WriteLine("1 para SOMAR\n2 para SUBTRAIR\n3 para MULTIPLICAR\n4 para DIVIDIR\n5 para SAIR");
            int resultado = int.Parse(Console.ReadLine());

            MenuAplicacao.MenuCalculadora(resultado);
        }
    }
}
using System;

namespace Calculator.OperacoesAritmeticas
{
    public class Soma
    {
        public static void CalcularSoma()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float resultadoSoma = primeiroNumero + segundoNumero;
            
            Console.WriteLine($"A soma de {primeiroNumero} e {segundoNumero} é {resultadoSoma}.");
            Console.ReadKey();
        }
    }
}
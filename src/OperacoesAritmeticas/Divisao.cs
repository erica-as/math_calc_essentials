using System;

namespace Calculator.OperacoesAritmeticas
{
    public class Divisao
    {
        public static void CalcularDivisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float resultadoDivisao = primeiroNumero / segundoNumero;
            
            Console.WriteLine($"A divisao de {primeiroNumero} e {segundoNumero} é {resultadoDivisao}.");
            Console.ReadKey();
        }
    }
}
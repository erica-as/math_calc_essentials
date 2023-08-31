using System;

namespace Calculator.OperacoesAritmeticas
{
    public class Multiplicacao
    {
        public static void CalcularMultiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float resultadoMultiplicacao = primeiroNumero * segundoNumero;
            
            Console.WriteLine($"A multiplicação de {primeiroNumero} e {segundoNumero} é {resultadoMultiplicacao}.");
            Console.ReadKey();
        } 
    }
}
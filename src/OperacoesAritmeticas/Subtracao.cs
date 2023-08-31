using System;

namespace Calculator.OperacoesAritmeticas
{
    public class Subtracao
    {
        public static void CalcularSubtracao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float resultadoSubtracao = primeiroNumero - segundoNumero;
            
            Console.WriteLine($"A subtração de {primeiroNumero} e {segundoNumero} é {resultadoSubtracao}.");
            Console.ReadKey();
        }
    }
}
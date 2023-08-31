using System;
using Calculator.OperacoesAritmeticas;

namespace Calculator.Menu
{
    public class MenuAplicacao
    {
        public static int MenuCalculadora(int resultado)
        {
            switch (resultado)
            {
                case 1:
                    Soma.CalcularSoma();
                    break;
                case 2:
                    Subtracao.CalcularSubtracao();
                    break;
                case 3:
                    Multiplicacao.CalcularMultiplicacao();
                    break;
                case 4:
                    Divisao.CalcularDivisao();
                    break;
                case 5: 
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção digitada inválida. Tente novamente!");
                    break;
            }

            return resultado;
        }
    }
}

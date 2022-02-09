// Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e 
//calcule a tabuada de N.
//• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.

using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variaveis
            int n, i;
            //inicio da estrutura de repetiçao entrada com numero e conversao da variavel N para int32
            do
            {
                Console.WriteLine("Digite um numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                //inicio do IF para que se o numero for 0 ele da erro e fechar
                if (n == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fatal ERROR!");
                    Console.WriteLine("O numero multiplicado {N} nao pode ser 0! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    return;
                }
                //fim da estrutura de repetiçao
            } while (n <= 0);
            //inicio do for responsavel por multiplicar a variavel 'I' 10x pelo numero que entrou em 'N'
            for (i = 0; i<= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(n + " x " + i + " = " + n * i, "\n");
                Console.ReadLine();

            }
        }
    }
}

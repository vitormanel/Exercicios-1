// Escreva um algoritmo que leia um valor inicial A e imprima a sequência de 
//valores do cálculo de A! e o seu resultado. 
//Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//a

using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao da variavel result e i e num para int.parse. tambem inseri o resultado da soma incial
            int i;
            int result = 0;
            Console.Write("Digite um valor: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Resultado: " + num + "x");
            //basicamente o mesmo if do programa anterior, que impossibilita o usuario de digitar 0 no programa;
            if (num == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fatal ERROR!");
                Console.WriteLine("O numero multiplicado {N} nao pode ser 0! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                return;
            }
            // inicio do for que e responsavel pela repetiçao das multiplicaçoes, ex: 15*15 = 225 e indo ate 1*15 = 15
            for (i = num; i > 0; i--)
            {
                result = result + i;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(num + " x " + i + " = " + num * i, "\n");
                Console.ReadLine();
            }
            Console.Write(result);
        }
    }
}

//Desenvolver um algoritmo que efetue a soma de todos os números 
//ímpares que são múltiplos de três e que se encontram no conjunto dos 
//números de 1 até 500.

using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraçao das variaveis
            int soma = 0;
            int i;
            //estrutura do for para numeros entre 1 e 500
            for (i = 1; i <= 500; i++)
            {
                //if para filtrar os impares multipos de 3
                if (i % 3 == 0)
                {
                   soma = i;
                    Console.WriteLine(" Impar multiplo de 3: "+soma);
                    Console.ReadLine();
                }
            }
        }
        
    }
}



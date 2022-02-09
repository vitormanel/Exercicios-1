//Escrever um algoritmo que gera e escreve os números ímpares entre 100 
//e 200.

using System;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraçao das variaveis
            int numero = 0;
            Console.WriteLine("Números ímpares entre 100 e 200.");
            Console.ForegroundColor = ConsoleColor.White;
            //for para identificar os numeros entre 100 e 201 
            for (int i = 100; i < 201; i++)
            {
                //if para mostrar apenas os numeros impares
                if ((i % 2) != 0)
                {
                    numero++;
                    Console.WriteLine(numero + " Numero Impar: " + i);
                    Console.ReadLine();
                }
                Console.ReadLine();

                if(numero == 50)
                {
                    break;
                }
            }
        }
    }
}

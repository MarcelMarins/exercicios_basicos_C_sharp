/*
 * Criado por SharpDevelop.
 * Usuário: Marcel
 * Data: 04/09/2018
 * Hora: 15:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicio04_lista_bonus_
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num;

            Console.Write("Vamos definir se um numero é positivo/negativo e par/impar\n\nDigite um numero: ");
            num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.Write(num + " é Negativo ");
            }

            if (num > 0)
            {
                Console.Write(num + " é Positivo ");
            }

            if (num % 2 != 0)
            {
                Console.Write("e Impar ");
            }

            if (num % 2 == 0)
            {
                Console.Write("e Par ");
            }
            Console.ReadKey();

        }
    }
}
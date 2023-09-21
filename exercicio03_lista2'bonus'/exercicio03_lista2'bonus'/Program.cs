/*
 * Criado por SharpDevelop.
 * Usuário: Marcel
 * Data: 04/09/2018
 * Hora: 15:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicio03_lista2_bonus_
{
    class Program
    {
        public static void Main(string[] args)
        {
            int idade;

            Console.Write("Vamos definir qual e a categoria do nadador\n\nDigite a idade do nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 7)
            {
                Console.WriteLine("Categoria Infantil A");
            }
            else if (idade <= 10)
            {
                Console.WriteLine("Categoria Infantil B");
            }
            else if (idade <= 13)
            {
                Console.WriteLine("Categoria Juvenil A");
            }
            else if (idade <= 17)
            {

                Console.WriteLine("Categoria Juvenil B");
            }
            else if (idade > 18)
            {
                Console.WriteLine("Categoria Adulto");
            }

            Console.ReadKey();

        }
    }
}
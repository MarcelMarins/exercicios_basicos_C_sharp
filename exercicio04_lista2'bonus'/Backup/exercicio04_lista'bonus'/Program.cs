/*
 * Criado por SharpDevelop.
 * Usuário: aluno
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
			
			Console.Write("Digite um numero: ");
			num = double.Parse(Console.ReadLine());
			
			if (num < 0){
			Console.WriteLine("NEGATIVO");
			}
			
			if (num > 0){
			Console.WriteLine("POSITIVO");
			}
			
			if (num % 2 != 0){
			Console.WriteLine("IMPAR");
			}
			
			if (num % 2 == 0){
			Console.WriteLine("PAR");
			}
			Console.ReadKey();
			
		}
	}
}
/*
 * Criado por SharpDevelop.
 * Usuário: Marcel
 * Data: 04/09/2018
 * Hora: 15:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicio02_lista2_bonus_
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a, b;
			
			Console.WriteLine("Vamos verificar se dois valores sao multiplos.\n\nDigite o primeiro numero");
			a = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o segundo numero");
			b = int.Parse(Console.ReadLine());
			
			
			if (a % b == 0 || b % a == 0){
				Console.WriteLine("São multiplos!");
			}else{
				Console.WriteLine("Não são multiplos");
			}
			
			
			Console.ReadKey();
			
			
		}
	}
}
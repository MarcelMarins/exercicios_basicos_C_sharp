/*
 * Criado por SharpDevelop.
 * Usuário: Marcel
 * Data: 04/09/2018
 * Hora: 14:44
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicio01_lista2_bonus_
{
	class Program
	{
		public static void Main(string[] args)
		{
			double a, b, c, media;
			
			Console.Write("Digite sua 1° nota: ");
			a = int.Parse(Console.ReadLine());
			
			Console.Write("Digite sua 2° nota: ");
			b = int.Parse(Console.ReadLine());
			
			Console.Write("Digite sua 3° nota: ");
			c = int.Parse(Console.ReadLine());
			
			media = (a+b+c) / 3;
			
			if (media < 6){
				Console.WriteLine("Nota insuficiente, você foi reprovado.\nMédia:" + media);
			}else{
			Console.WriteLine("Você foi aprovado!!\nMédia: " + media);
			}
			
			Console.ReadKey();
				
			
		}
	}
}
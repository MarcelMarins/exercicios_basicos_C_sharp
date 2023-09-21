/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/09/2018
 * Hora: 14:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicios06_lista_bonus_
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cod, qnt;
			
			
			Console.WriteLine("Código do Produto Preço unitário: ");
			Console.WriteLine("1001   |   5,32");
			Console.WriteLine("1324   |   6,45");
			Console.WriteLine("6548   |   2,37");
			Console.WriteLine("0987   |   5,32");
			Console.WriteLine("7623   |   6,45");
			Console.WriteLine("Escolha o código do produto: ");
			cod = int.Parse(Console.ReadLine());
			
			
			  if (cod == 1001){
				Console.WriteLine("Quantidade: ");
				qnt = int.Parse(Console.ReadLine());
				Console.WriteLine(qnt + " deste produto que custa 5,32: " + (5.32 * qnt));
			} if  (cod == 1324){
				Console.WriteLine("Quantidade: ");
				qnt = int.Parse(Console.ReadLine());
				Console.WriteLine(qnt + " deste produto que custa 6,45 : " + (6.45  * qnt));
			} if  (cod == 6548){
				Console.WriteLine("Quantidade: ");
				qnt = int.Parse(Console.ReadLine());
				Console.WriteLine(qnt + " deste produto que custa 2,37: " + (2.37  * qnt));
			} if  (cod == 0987){
				Console.WriteLine("Quantidade: ");
				qnt = int.Parse(Console.ReadLine());
				Console.WriteLine(qnt + " deste produto que custa 5,32: " + (5.32 * qnt));
			} if  (cod == 7623){
				Console.WriteLine("Quantidade: ");
				qnt = int.Parse(Console.ReadLine());
				Console.WriteLine(qnt + " deste produto que custa 6,45: " + (6.45 * qnt));
			} 
			
			
			
			
			
			
Console.ReadKey();
		}
	}
}
/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/09/2018
 * Hora: 13:59
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercicio05_lista2_bonus_
{
	class Program
	{
		public static void Main(string[] args)
		{
			double salmed;
			
			Console.WriteLine("Digite o saldo médio");
			salmed = double.Parse(Console.ReadLine());
			
		    if (salmed < 200){
			    	Console.WriteLine("Saldo: " + salmed);
			} else if (salmed < 400){
			        salmed = salmed * 0.2;
			        Console.WriteLine("Saldo: " + salmed);       	
			}  else if (salmed < 600){
					salmed = salmed * 0.3;
			        Console.WriteLine("Saldo: " + salmed);       	
			}  else {
			        salmed = salmed * 0.4;
			        Console.WriteLine("Saldo: " + salmed);       
			    }

			
			Console.ReadKey();
		}
	}
}
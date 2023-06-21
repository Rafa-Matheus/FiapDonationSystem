using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
			string nome, telefone, email, senha, apelido;

			Console.WriteLine(" -- FIAP Donation System -- ");

			Console.WriteLine("MENU:");
			Console.WriteLine("1 - Registrar um novo usuário\n2 - Logar\n3 - Sair");
			Console.Write("\nDigite a opção desejada: ");
			int opcao = Convert.ToInt32(Console.ReadLine());

			if (opcao == 1)
			{
				Console.Clear();
				Console.WriteLine("FIAP Donation System");
				Console.WriteLine("Digite seu nome: ");
				nome = Console.ReadLine();
				Console.WriteLine("Digite seu telefone: ");
				telefone = Console.ReadLine();
				Console.WriteLine("Digite seu email: ");
				email = Console.ReadLine();
				Console.WriteLine("Digite sua senha: ");
				senha = Console.ReadLine();
				Console.WriteLine("Digite seu apelido: ");
				apelido = Console.ReadLine();
			}
			else if(opcao == 2)
            {
				Console.WriteLine("Digite o seu email: ");
				string emailUsuario = Console.ReadLine();
				Console.WriteLine("Digite a sua senha: ");
				string senhaUsuario = Console.ReadLine();

				if (emailUsuario.Equals("admin123@email.com"))
				{
					if (senhaUsuario.Equals("admin123"))
						Console.WriteLine("Bem-vindo ao sistema " + emailUsuario);
					else
						Console.WriteLine("Usuário e/ou Senha inválidos");
				}
				else
					Console.WriteLine("Usuario e/ou senha inválidos");
            }
			else
                Console.WriteLine("Obrigado por usar o sistema");

			Console.ReadKey();
		}
    }
}

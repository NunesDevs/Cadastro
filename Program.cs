using Cadastro;
using System;

namespace Cadastro
{
    class Program
    {
        static cadastroRepo repositorio = new cadastroRepo();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarFuncionarios();
						break;
					case "2":
						InserirFuncionarios();
						break;
					case "3":
						AtualizarFuncionarios();
						break;
					case "4":
						ExcluirFuncionarios();
						break;
					case "5":
						VisualizarFuncionarios();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirFuncionarios()
		{
			Console.Write("Digite o id do Funcionário: ");
			int indiceFuncionarios = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceFuncionarios);
		}

        private static void VisualizarFuncionarios()
		{
			Console.Write("Digite o id do funcionário: ");
			int indiceFuncionarios = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornarPorId(indiceFuncionarios);

			Console.WriteLine(serie);
		}

        private static void AtualizarFuncionarios()
		{
			Console.Write("Digite o id do funcionário: ");
			int indiceFuncionarios = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o seu nome: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite a sua idade: ");
			int entradaIdade = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Cargo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Cargo), i));
			}
			Console.Write("Digite o seu cargo entre as opções acima: ");
			int entradaCargo = int.Parse(Console.ReadLine());

			CadastroProj atualizaFuncionarios = new CadastroProj(id: indiceFuncionarios,
										genero: (Genero)entradaGenero,
										nome: entradaNome,
										idade: entradaIdade,
										cargo: (Cargo)entradaCargo);

			repositorio.Atualiza(indiceFuncionarios, atualizaFuncionarios);
		}
        private static void ListarFuncionarios()
		{
			Console.WriteLine("Listar funcionários");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum funcionário cadastrado.");
				return;
			}

			foreach (var funcionario in lista)
			{
                var excluido = funcionario.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", funcionario.retornarId(), funcionario.retornoNome(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirFuncionarios()
		{
			Console.WriteLine("Inserir novo funcionário");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o seu nome: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite a sua idade: ");
			int entradaAno = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Cargo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Cargo), i));
			}
			Console.Write("Digite o seu cargo entre as opções acima: ");
			int entradaCargo = int.Parse(Console.ReadLine());
			CadastroProj novoFuncionario = new CadastroProj(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										nome: entradaTitulo,
										idade: entradaAno,
										cargo: (Cargo)entradaCargo);

			repositorio.Insere(novoFuncionario);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
            Console.WriteLine("################################");
			Console.WriteLine("# Painel de funcionários ativo! #");
            Console.WriteLine("################################");

			Console.WriteLine(" - Informe a opção desejada -");

			Console.WriteLine("1 - Listar funcionários");
			Console.WriteLine("2 - Inserir novo funcionário");
			Console.WriteLine("3 - Atualizar dados");
			Console.WriteLine("4 - Excluir funcionário");
			Console.WriteLine("5 - Visualizar funcionários");
			Console.WriteLine("C - Limpar Tela");
			Console.WriteLine("X - Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}

using System;

namespace DesafioDioSeries
{
    class Program
    {
        static serieRepositorio repositorio = new serieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida");
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série a ser visualizada");
            int indice = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaporId(indice);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série a ser excluída");
            int indice = int.Parse(Console.ReadLine());

            repositorio.Exclui(indice);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série que deseja atualizar");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Escolha uma das opções de genero acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título da Série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();

            Series atualizarSerie = new Series(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao,
                                            ano: entradaAno,
                                            excluido: false);
            repositorio.Atualiza(indiceSerie, atualizarSerie);
            
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Escolha uma das opções de genero acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título da Série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao,
                                            ano: entradaAno,
                                            excluido: false);
            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de Séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0} - {1}", serie.RetornaId(), serie.RetornaTitulo());
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Sistema de armazenamento de Series");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir Nova Série");
            Console.WriteLine("3- Atualizar Série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("C- Limpar a tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;
        }
    }
}

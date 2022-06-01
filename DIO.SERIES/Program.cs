using System;

namespace DIO.SERIES
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

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
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                        //VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("Dio Séries a seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static void ListarSeries()
        {
            Console.WriteLine($"Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine($"Nennhum série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine($"#ID {0}: - {1}", serie.RetornarId(), serie.RetornarTitulo());
            }

        }
        private static void InserirSeries()
        {

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));

            }

            Console.WriteLine($"Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o titulo da serie:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine($"Digite o Ano de Inicio da Serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a descrição da serie:");
            string entradaDescricao = Console.ReadLine();

            Serie novaserie = new Serie(repositorio.ProximoId(), (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno);
            repositorio.Insere(novaserie);
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine($"Digite o Id da serie para atualizar:");
            int idAtualizar = int.Parse(Console.ReadLine());


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));

            }

            Console.WriteLine($"Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o titulo da serie:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine($"Digite o Ano de Inicio da Serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a descrição da serie:");
            string entradaDescricao = Console.ReadLine();

            Serie novaserie = new Serie(idAtualizar, (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno);
            repositorio.Atualiza(idAtualizar, novaserie);
        }
    }
}
using System;

namespace ControleDeFilaHospitalar
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaHospitalar fila = new FilaHospitalar();

            while (true)
            {
                Console.WriteLine("=== Controle de Fila Hospitalar ===");
                Console.WriteLine("1. Cadastrar paciente");
                Console.WriteLine("2. Inserir paciente na fila");
                Console.WriteLine("3. Listar fila de pacientes");
                Console.WriteLine("4. Incluir paciente prioritário");
                Console.WriteLine("5. Atender paciente");
                Console.WriteLine("Pressione 'q' para sair");

                char opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.Write("Digite o nome do paciente: ");
                        string nome = Console.ReadLine();
                        fila.CadastrarPaciente(nome);
                        break;
                    case '2':
                        fila.InserirPacienteNaFila();
                        break;
                    case '3':
                        fila.ListarFilaDePacientes();
                        break;
                    case '4':
                        fila.IncluirPacientePrioritario();
                        break;
                    case '5':
                        fila.AtenderPaciente();
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}




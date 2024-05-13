using System;

class FilaHospitalar
{
    private string[] fila;
    private int quantidadeDePacientes;

    public FilaHospitalar()
    {
        fila = new string[10];
        quantidadeDePacientes = 0;
    }

    public void CadastrarPaciente(string nome)
    {
        if (quantidadeDePacientes < fila.Length)
        {
            fila[quantidadeDePacientes++] = nome;
            Console.WriteLine("Paciente cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("A fila está cheia. Não é possível cadastrar mais pacientes.");
        }
    }

    public void InserirPacienteNaFila()
    {
        Console.Write("Digite o nome do paciente: ");
        string nome = Console.ReadLine();
        CadastrarPaciente(nome);
    }

    public void ListarFilaDePacientes()
    {
        Console.WriteLine("Fila de pacientes:");
        for (int i = 0; i < quantidadeDePacientes; i++)
        {
            Console.WriteLine($"{i + 1}. {fila[i]}");
        }
    }

    public void IncluirPacientePrioritario()
    {
        if (quantidadeDePacientes < fila.Length)
        {
            for (int i = quantidadeDePacientes; i > 0; i--)
            {
                fila[i] = fila[i - 1];
            }
            Console.Write("Digite o nome do paciente prioritário: ");
            string nomePrioritario = Console.ReadLine();
            fila[0] = nomePrioritario;
            quantidadeDePacientes++;
            Console.WriteLine("Paciente prioritário incluído com sucesso!");
        }
        else
        {
            Console.WriteLine("A fila está cheia. Não é possível incluir mais pacientes prioritários.");
        }
    }

    public void AtenderPaciente()
    {
        if (quantidadeDePacientes > 0)
        {
            Console.WriteLine($"O paciente {fila[0]} está sendo atendido.");
            for (int i = 0; i < quantidadeDePacientes - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            fila[quantidadeDePacientes - 1] = null;
            quantidadeDePacientes--;
        }
        else
        {
            Console.WriteLine("Não há pacientes na fila para serem atendidos.");
        }
    }
}

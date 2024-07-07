class Program
{
    // Implemente a classe Program com o método Main.
    static void Main(string[] args)
    {
        // Dentro do método Main, crie uma instância da classe Empresa.
        Empresa empresa = new Empresa();
        bool continuar = true;

        // Implemente um menu interativo no console
        while (continuar)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar Funcionário de Tempo Integral");
            Console.WriteLine("2. Adicionar Funcionário de Meio Período");
            Console.WriteLine("3. Remover Funcionário");
            Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
            Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
                case 2:
                    AdicionarFuncionarioMeioPeriodo(empresa);
                    break;
                case 3:
                    RemoverFuncionario(empresa);
                    break;
                case 4:
                    empresa.ExibirFuncionarios();
                    break;
                case 5:
                    AdicionarProjetos(empresa);
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
            return;
        }

        Console.Write("Matrícula: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

        Console.Write("Salário Mensal: ");
        if (!double.TryParse(Console.ReadLine() ?? string.Empty, out double salarioMensal))
        {
            Console.WriteLine("Salário inválido. Tente novamente.");
            return;
        }

        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);
    }

    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
            return;
        }

        Console.Write("Matrícula: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

        Console.Write("Salário por Hora: ");
        if (!double.TryParse(Console.ReadLine() ?? string.Empty, out double salarioPorHora))
        {
            Console.WriteLine("Salário inválido. Tente novamente.");
            return;
        }

        Console.Write("Horas Trabalhadas: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int horasTrabalhadas))
        {
            Console.WriteLine("Número de horas trabalhadas inválido. Tente novamente.");
            return;
        }

        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);
    }

    static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário a Remover: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }
        empresa.RemoverFuncionario(matricula);
    }

    static void AdicionarProjetos(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

        var funcionario = empresa.Funcionarios.SingleOrDefault(f => f.matricula == matricula);
        if (funcionario != null)
        {
            Console.Write("Quantos projetos deseja adicionar? ");
            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int qtd))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                return;
            }
            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Nome do Projeto {i + 1}: ");
                string? projeto = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(projeto))
                {
                    funcionario.AdicionarProjeto(projeto);
                }
                else
                {
                    Console.WriteLine("Nome do projeto inválido. Tente novamente.");
                }
            }
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}
// Crie uma classe chamada Empresa.

public class Empresa
{
    // Adicione uma lista de funcionários (List<Funcionario>).
    public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

    // Implemente os métodos:
    // void AdicionarFuncionario(Funcionario funcionario): adiciona um funcionário à lista.
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    // void RemoverFuncionario(int matricula): remove um funcionário da lista com base na matrícula.
    public void RemoverFuncionario(int matricula)
    {
        var funcionario = Funcionarios.SingleOrDefault(f => f.matricula == matricula);
        if (funcionario != null)
        {
            Funcionarios.Remove(funcionario);
        }
    }

    // void ExibirFuncionarios(): exibe as informações de todos os funcionários na lista.
    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
}
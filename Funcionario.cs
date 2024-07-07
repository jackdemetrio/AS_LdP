//Crie uma classe abstrata chamada Funcionario.
public abstract class Funcionario
{
    //Declare variáveis publicas para armazenar o nome, matrícula do funcionário e uma lista de string para Projetos.
    public string nome;
    public int matricula;
    public List<string> projetos;

    //Crie um construtor para inicializar o nome e a matrícula.
    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
        projetos = new List<string>();
    }

    // Declare os seguintes métodos abstratos:
    // double CalcularSalario(): retorna o salário do funcionário.
    // void ExibirInformacoes(): exibe as informações do funcionário.
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    
    // Na classe Funcionario, adicione um método sobrecarregado AdicionarProjeto:
    // AdicionarProjeto(string projeto): armazena o nome do projeto em uma lista de strings.
    public void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }

    // AdicionarProjeto(List<string> projetos): armazena cada nome de projeto da lista em uma lista de strings.
    public void AdicionarProjeto(List<string> projetos)
    {
        projetos.AddRange(projetos);
    }

}
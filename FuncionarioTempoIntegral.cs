// Crie uma classe FuncionarioTempoIntegral que herda de Funcionario.
// Implemente a interface IBonus nas classes FuncionarioTempoIntegral e FuncionarioMeioPeriodo.
public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    // Adicione uma variável privada para armazenar o salário mensal.
    private double SalarioMensal;

    // Implemente o construtor para inicializar o nome, a matrícula e o salário mensal.
    public FuncionarioTempoIntegral(string nome, int matricula, double SalarioMensal) : base(nome, matricula)
    {
        this.SalarioMensal = SalarioMensal;
    }

    // Implemente os métodos CalcularSalario() e ExibirInformacoes().
    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário Mensal: {SalarioMensal}");
    }

    // FuncionarioTempoIntegral: O método CalcularBonus() deve retornar 10% do salário mensal.
    public double CalcularBonus()
    {
        return SalarioMensal * 0.1;
    }

}

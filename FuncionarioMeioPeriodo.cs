// Crie uma classe FuncionarioMeioPeriodo que herda de Funcionario.
// Implemente a interface IBonus nas classes FuncionarioTempoIntegral e FuncionarioMeioPeriodo.
public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    // Adicione variáveis privadas para armazenar o salário por hora e o número de horas trabalhadas.
    private double SalarioPorHora;
    private int HorasTrabalhadas;

    // Implemente o construtor para inicializar o nome, a matrícula, o salário por hora e o número de horas trabalhadas.
    public FuncionarioMeioPeriodo(string nome, int matricula, double SalarioPorHora, int HorasTrabalhadas) : base(nome, matricula)
    {
        this.SalarioPorHora = SalarioPorHora;
        this.HorasTrabalhadas = HorasTrabalhadas;
    }

    // Implemente os métodos CalcularSalario() e ExibirInformacoes().
    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário por Hora: {SalarioPorHora}, Horas Trabalhadas: {HorasTrabalhadas}");
    }

    // FuncionarioMeioPeriodo: O método CalcularBonus() deve retornar 5% do salário total calculado pelo método CalcularSalario().
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}
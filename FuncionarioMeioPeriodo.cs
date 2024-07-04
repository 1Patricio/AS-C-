public class FuncionarioMeioPeriodo : Funcionario{
    private double salarioPorHora;
    private double horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula){
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }   
    public override double CalcularSalario(){
        return salarioPorHora * horasTrabalhadas;
    } //classe abstrata
        public override void ExibirInformações(){
        double salarioMensal = CalcularSalario();
        Console.WriteLine($"Nome: {nome}, Matrícula: {matricula}, Salário Mensal: R${salarioMensal} e sou um Funcionário Meio Periodo");
    }
    public double CalcularBonus(){
        return CalcularSalario() * 0.05; //Retornando 5% do salário total chamando o método CalcularSalario()
    }
}
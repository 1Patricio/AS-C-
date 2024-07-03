public class FuncionarioMeioPeriodo : Funcionario{
    private double salarioPorHora;
    private double horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula){
    }   
    public override double CalcularSalario(){
        return salarioPorHora * horasTrabalhadas;
    } //classe abstrata
    public override void ExibirInformações(){
        
    }
    public double CalcularBonus(){
        return CalcularSalario() * 0.05; //Retornando 5% do salário total chamando o método CalcularSalario()
    }
}
public class FuncionarioTempoIntegral : Funcionario, IBonus{ //herdando a classe abstrata Funcionario
    private double salarioMensal;
    public double bonus;
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome , matricula)
    {
        this.salarioMensal = salarioMensal;
    }
    public override double CalcularSalario(){
        return salarioMensal; //como não se tem cálculo retornamos apenas o salario mensal 
    }
    public override void ExibirInformações(){

    }
    public double CalcularBonus(){
        return salarioMensal * 0.10; //retornando 10% do salário mensal
    }
}
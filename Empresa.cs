public class Empresa(){
    List<Funcionario> listaFuncionarios = new List<Funcionario>(); //criando uma lista do tipo Funcionario (classe) chamada listaFuncionarios

    public void AdicionarFuncionario(Funcionario funcionario){
        listaFuncionarios.Add(funcionario);
    }
    public void RemoverFuncionario(int numeroMatricula){
        for (int i = 0; i < listaFuncionarios.Count; i++)
        {
            if (listaFuncionarios[i].matricula == numeroMatricula) //verificando a posição do i a propriedade matrícula é igual ao numero de matricula passado
            {
                listaFuncionarios.RemoveAt(i); //como já temos a posição que está na lista podemos usar um RemoveAt(i) onde i siginifica a posiçao
            }
        }
    }
    public void ExibirFuncionario(){
        for (int i = 0; i < listaFuncionarios.Count; i++)
        {
            Console.WriteLine($"{listaFuncionarios}");
        }
    }

}
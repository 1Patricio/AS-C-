public class Empresa(){
    //criando uma lista do tipo Funcionario (classe) chamada listaFuncionarios
    public List<Funcionario> listaFuncionarios = new List<Funcionario>(); 

    // Adiciona um funcionário à lista
    public void AdicionarFuncionario(Funcionario funcionario){
        listaFuncionarios.Add(funcionario);
    }
    public void RemoverFuncionario(int numeroMatricula){
        for (int i = 0; i < listaFuncionarios.Count; i++)
        {
            //verificando a posição do i a propriedade matrícula é igual ao numero de matricula passado
            if (listaFuncionarios[i].matricula == numeroMatricula) 
            {
                //como já temos a posição que está na lista podemos usar um RemoveAt(i) onde i siginifica a posiçao
                listaFuncionarios.RemoveAt(i); 
            }
        }
    }
    public void ExibirFuncionario(){
        for (int i = 0; i < listaFuncionarios.Count; i++)
        {
            listaFuncionarios[i].ExibirInformações();
            if (listaFuncionarios[i].Projetos.Count > 0)
            {
                // Console.WriteLine($"Projeto: {listaFuncionarios[i].Projetos}");
                Console.WriteLine($"Projetos: {string.Join(", ", listaFuncionarios[i].Projetos)}");

            }
            else
            {
                Console.WriteLine("Projetos: Nenhum projeto");
            }
            Console.WriteLine();
        }
    }

}
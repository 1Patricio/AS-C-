public abstract class Funcionario{ //classe abstrata
    public string nome;
    public int matricula;
    public List<string> Projetos = new List<string>(); //criando o a propriedade lista

    public Funcionario(string nome, int matricula) //construtor
    {
        this.nome = nome;
        this.matricula = matricula;
    }
    public abstract double CalcularSalario(); //método abstrato
    public abstract void ExibirInformacoes();

    //adicionando um projeto
    public void AdicionarProjeto(string projeto){ //usando -projeto- e não -Projetos- pois estamos passando apenas 1 
        Projetos.Add(projeto); 
    }
    public void AdicionarProjeto (List<string>Lista){ //Lista de projetos
        for (int i = 0; i < Lista.Count; i++) //Lista.Count é o tamanho da lista
        {
            Projetos.Add(Lista[i]); 
        }
    }
}
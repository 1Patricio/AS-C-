﻿Empresa empresa = new Empresa();

while (true)
{
    Console.WriteLine("1. Adicionar um funcionário de tempo integral");
    Console.WriteLine("2. Adicionar um funcionário de meio período");
    Console.WriteLine("3. Remover um funcionário");
    Console.WriteLine("4. Exibir informações de todos os funcionários");
    Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
    Console.WriteLine("9. Sair do programa");
    int opcao = Convert.ToInt32(Console.ReadLine()); //recebendo a opção do menu

    switch (opcao)
    {
        case 1: //caso digitar 1 
            Console.WriteLine("Digite um nome de um funcionário de tempo integral");
            string nomeTI = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário:");
            int matriculaTI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário mensal do funcionário:");
            double salarioTI = Convert.ToDouble(Console.ReadLine());


            FuncionarioTempoIntegral funcionarioTI = new FuncionarioTempoIntegral(nomeTI, matriculaTI, salarioTI); //funcionarioTI vai receber todos os parâmetros
            empresa.AdicionarFuncionario(funcionarioTI); //vai adicionar 
            Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
            break;
        
        case 2:
            Console.WriteLine("Digite o nome do funcionáiro de meio período");
            string nomeMP = Console.ReadLine();
            Console.WriteLine("Digite o número de matrícula");
            int matriculaMP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora do funcionário");
            double salarioPorHoraMP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas do funcionário (Arredonde os minutos)");
            int horasTrabalhadasMP = Convert.ToInt32(Console.ReadLine()); // 

            FuncionarioMeioPeriodo funcionarioMP = new FuncionarioMeioPeriodo(nomeMP, matriculaMP, salarioPorHoraMP,horasTrabalhadasMP);
            empresa.AdicionarFuncionario(funcionarioMP);
            Console.WriteLine("Funcionário de meio periodo adicionado com sucesso!");
            break;
    }
}
using projeto_teste_csharp._11_Atributos_e_metodos_Estaticos;
using projeto_teste_csharp._12_Abstracao;
using projeto_teste_csharp.A10_Polimorfismo;
using projeto_teste_csharp.Calcula_Imc;
using projeto_teste_csharp.Construtores;
using projeto_teste_csharp.Encapsulamento;
using projeto_teste_csharp.Exercicio_Media_Aluno;
using projeto_teste_csharp.Get_e_Set;
using projeto_teste_csharp.Heranca;
using projeto_teste_csharp.Metodos;
using projeto_teste_csharp.ModificadoresDeAcesso;
using projeto_teste_csharp.This;
using System;


class Programa
{
    static void Main(string[] args)
    {
        // Construtor 
        Construtor construtor = new Construtor();
        Construtor construtor1 = new Construtor("Rafael");// Passando o nome Rafael para dentro do parâmetro do construtor


        // Sobrecarga de métodos
        Pessoa pessoa = new Pessoa(); //Criando o objeto pessoa
        pessoa.pessoa();
        pessoa.pessoa("Rafael",29);
        pessoa.pessoa("Rafael", "Cunha", 29, "Brasileiro");


        Console.WriteLine(); // pula 1 linha


        // Exercicio Média do Aluno
        Aluno aluno = new Aluno();
        aluno.nota1 = 7;
        aluno.nota2 = 4;
        aluno.mensagem();


        Calculo pessoaImc = new Calculo();
        pessoaImc.peso = 86;
        pessoaImc.altura = 1.71;
        pessoaImc.mensagem();


        // Modificadores de acesso
        Produto produto = new Produto();
        produto.nomeProd = "Rafael";


        // Encapsulamento
        Encapsulamento encapsu = new Encapsulamento();
        encapsu.mensagem();


        // Get e Set
        Get_Set getset = new Get_Set();
        Console.WriteLine("Executando o get: "+getset.Nome);
        getset.Nome = "...Valor enviado pelo set";

        // This - acessor de atributo de classe privada 
        ClassThis classeThis = new ClassThis("Teste");
        classeThis.tome();

        // Heranca
        Colaborador colab = new Colaborador("Rafael", 30, 200.00); // Instância da classe Colaborador, os valores são passados como parâmetro para dentro do Construtor


        // Polimorfismo
        Imposto estagiario = new Estagiario();
        estagiario.valeAlimentacao(1000);
        estagiario.valeTransporte(1000);
        

        Console.WriteLine("_____________________________");

        Imposto atendente = new Atendente();
        atendente.valeAlimentacao(2000);
        atendente.valeTransporte(2000);

        Console.WriteLine("_____________________________");

        Imposto gerente = new Gerente();
        gerente.valeAlimentacao(5000);
        gerente.valeTransporte(5000);

        // Exemplo de Métodos e Atributos Estaticos
        
        Exemplo.soma(8, 7); // Não é necessário criar um objeto para acessar o método da classe exemplo, porém, é necessário chamar a classe (Com letra maiúscula) e depois o método
        Exemplo.valor1 = 50;
        Exemplo.valor2 = 100;
        Console.WriteLine("Valor1: " + Exemplo.valor1);
        Console.WriteLine("Valor2: " + Exemplo.valor2);

        // Exemplo de Abstrãção - classe abstrata

        PessoaFisica pessoaFisica = new PessoaFisica();
        pessoaFisica.taxaEmprestimo(1000); // método obrigatório da classe abstrata Padrao
        pessoaFisica.calculaPoupanca(1000, 0.15); // método não obrigatório da classe abstrata Padrao

        PessoaJuridica pessoaJuridica = new PessoaJuridica();
        pessoaJuridica.taxaEmprestimo(1000); // método obrigatório da classe abstrata Padrao
        pessoaJuridica.calculaPoupanca(1000, 0.25); // método não obrigatório da classe abstrata Padrao

        
    }
}
























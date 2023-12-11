using System.Data;
using ExemploFundamentos;

public class Program
{
    public static void Main(string[] args)
    {

    Pessoa Joao = new Pessoa(nome: "João", sobrenome: "Silva", idade: 20);

    Pessoa Eduardo = new Pessoa(nome: "Eduardo", sobrenome: "Ferreira", idade: 30); 

    Pessoa Hugo = new Pessoa(nome: "Hugo", sobrenome: "Angelo", idade: 30);

    Curso csharp = new Curso();
    csharp.Nome = "C# Fundamentos";

    Curso dotnet = new Curso();
    dotnet.Nome = "Dotnet";

    csharp.AdicionarAluno(Joao);
    csharp.AdicionarAluno(Eduardo); 
    
    Console.WriteLine(csharp.QuantidadeAlunos());

    csharp.ListarAlunos();

    dotnet.AdicionarAluno(Hugo);
    dotnet.AdicionarAluno(Joao);

    Console.WriteLine(dotnet.QuantidadeAlunos());

    dotnet.ListarAlunos();

    dotnet.RemoverAluno(Joao);

    Console.WriteLine(dotnet.QuantidadeAlunos());

    dotnet.ListarAlunos();

    }
}
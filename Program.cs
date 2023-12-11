using System.Data;
using ExemploFundamentos;

public class Program
{
    public static void Main(string[] args)
    {

    Pessoa Joao = new Pessoa();
    Joao.Nome = "João";
    Joao.Sobrenome = "Silva";
    Joao.Idade = 20;

    Pessoa Eduardo = new Pessoa(); 
    Eduardo.Nome = "Eduardo";
    Eduardo.Sobrenome = "Ferreira";
    Eduardo.Idade = 30;

    Pessoa Hugo = new Pessoa();
    Hugo.Nome = "Hugo";
    Hugo.Sobrenome  = "Angelo";
    Hugo.Idade = 30;

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
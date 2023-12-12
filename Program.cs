using System.Data;
using ExemploFundamentos;

public class Program
{
    public static void Main(string[] args)
    {

    //Instanciando objetos    
    Pessoa Joao = new Pessoa(nome: "João", sobrenome: "Silva", idade: 20);

    Pessoa Eduardo = new Pessoa(nome: "Eduardo", sobrenome: "Ferreira", idade: 30); 

    Pessoa Hugo = new Pessoa(nome: "Hugo", sobrenome: "Angelo", idade: 30);

    Curso csharp = new Curso(nome: "C# Fundamentos", professor: "Paul McCartney");

    Curso dotnet = new Curso(nome: "Dotnet Fundamentos", professor: "John Lennon");


    //Métodos
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
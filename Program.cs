class Aluno
{
    public string Nome;
    public int Idade;
    public string Curso;
}
class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Brayan";
        aluno1.Idade = 19;
        aluno1.Curso = "Programação";
        Console.WriteLine(aluno1.Nome);
        Console.WriteLine(aluno1.Idade);
        Console.WriteLine(aluno1.Curso);
    }
}


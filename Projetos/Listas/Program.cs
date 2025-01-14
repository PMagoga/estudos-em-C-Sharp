
using Listas;

List<Aluno> alunos = FonteDados.GetAlunos();

// criação do método estático para exibir os alunos
ExibirAlunos(alunos);

// criação dos objetos alunos Bia e Mario
Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75};
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95};
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

// remover um aluno da lista, de acordo com o nome
var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

// para ordenar os alunos não podemos usar o método sort, pois alunos é um objeto
var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();
ExibirAlunos(listaOrdenada);

// exibir alunos com nota maior que 8
var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.Write("\nAlunos com nota maior que 8\n");
foreach (var aluno in alunosNotaOito)
{
    Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
}

Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de Alunos\n");
    Console.WriteLine("\nNome\tNota");

    double somaNotas = 0.0;

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    double mediaNota = somaNotas / alunos.Count;
    Console.WriteLine($"\nMédia das Notas: {Math.Round(mediaNota, 2)}");
    Console.WriteLine($"\nTotal de Alunos: {alunos.Count()}");
}
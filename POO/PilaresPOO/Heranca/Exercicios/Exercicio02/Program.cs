using Heranca;

//02
// Funcionario funComum = new Funcionario();
// Gerente gerente = new Gerente();

// funComum.SalarioBase = 1000;
// gerente.SalarioBase = 10000;

// float SalFinalComum = funComum.CalcularSalario();
// float SalFinalGer = gerente.CalcularSalario();

// Console.WriteLine($"Salario do funcionario: {SalFinalComum}");
// Console.WriteLine($"Salario do Gerente: {SalFinalGer}");

Aluno aluno = new Aluno();
        aluno.Nome = "Carlos";
        aluno.Idade = 20;
        aluno.Curso = "Engenharia de Software";

        // Criando um professor
        Professor prof = new Professor();
        prof.Nome = "Marcos";
        prof.Idade = 45;
        prof.Disciplina = "Programação Orientada a Objetos";

        Console.WriteLine("Informações da Escola:\n");

        Console.WriteLine($"Aluno: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");
        Console.WriteLine($"Professor: {prof.Nome}, Idade: {prof.Idade}, Disciplina: {prof.Disciplina}");
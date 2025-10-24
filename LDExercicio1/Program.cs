double salario;
double totalGasto;


Console.Write("Informe o salário recebido: ");
salario = double.Parse(Console.ReadLine());

//double aceita mais casas decimais

Console.Write("Informe o total gasto: ");
totalGasto = double.Parse(Console.ReadLine());

if (totalGasto <= salario)

Console.WriteLine("Gastos dentro do orçamento");

else

Console.WriteLine("Orçamento estourado");

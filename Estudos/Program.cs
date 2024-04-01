


using Estudos;
using System.Globalization;
using System.Net.Http.Headers;


Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();


Console.WriteLine("Dados do primeiro funcionário:");

Console.Write("Nome:");
p1.Nome = Console.ReadLine();

Console.Write("Salário:");
p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Dados do segundo funcionário:");

Console.Write("Nome:");
p2.Nome = Console.ReadLine();

Console.Write("Salário:");
p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double media = (p1.Salario + p2.Salario) / 2.00;

Console.WriteLine("Salário médio = " + media);


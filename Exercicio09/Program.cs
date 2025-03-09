// Faça  um  algoritmo  que  leia  a  idade  de  uma  pessoa  expressa  em  anos,
// meses  e  dias  e  escreva  a  idade  dessa pessoa expressa apenas em dias.
// Considerar ano com 365 dias e mês com 30 dias.

// declaração de variáveis
int anos, meses, dias, idadeDias;

// solicita ao usuário a idade em anos, meses e dias
Console.Write("Idade (anos): ");
anos = int.Parse(Console.ReadLine());
Console.Write("Idade (meses): ");
meses = int.Parse(Console.ReadLine());
Console.Write("Idade (dias): ");
dias = int.Parse(Console.ReadLine());

// calcula a idade em dias
idadeDias = (anos * 365) + (meses * 30) + dias;

// exibe a idade em dias
Console.WriteLine($"A idade em dias é: {idadeDias}");

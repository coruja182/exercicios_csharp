// Ler  quatro  valores  numéricos  inteiros  e  apresentar  o  resultado  dois  a  dois  da  adição  e  multiplicação  entre  os
// valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
// A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
// com  D  e  por  último  C  com  D.  Note  que  para  cada  operação  serão  utilizadas  seis  combinações.  Assim  sendo,
// devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
// multiplicações.

// variaveis
int A, B, C, D;
int soma1, soma2, soma3, soma4, soma5, soma6;
int mult1, mult2, mult3, mult4, mult5, mult6;

// entrada de dados
Console.WriteLine("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
C = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de D: ");
D = int.Parse(Console.ReadLine());

// processamento
soma1 = A + B;
soma2 = A + C;
soma3 = A + D;
soma4 = B + C;
soma5 = B + D;
soma6 = C + D;

mult1 = A * B;
mult2 = A * C;
mult3 = A * D;
mult4 = B * C;
mult5 = B * D;
mult6 = C * D;

// saida
Console.WriteLine($"A + B = {soma1}");
Console.WriteLine($"A + C = {soma2}");
Console.WriteLine($"A + D = {soma3}");
Console.WriteLine($"B + C = {soma4}");
Console.WriteLine($"B + D = {soma5}");
Console.WriteLine($"C + D = {soma6}");
Console.WriteLine($"A * B = {mult1}");
Console.WriteLine($"A * C = {mult2}");
Console.WriteLine($"A * D = {mult3}");
Console.WriteLine($"B * C = {mult4}");
Console.WriteLine($"B * D = {mult5}");
Console.WriteLine($"C * D = {mult6}");

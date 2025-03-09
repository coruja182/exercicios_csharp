// Escrever  um  programa  que  leia  dois  números  inteiros  e  mostre  todos  os  relacionamentos 
// de  ordem  existentes  entre eles.
// Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual

// declaração de variáveis
int num1, num2;

// solicita ao usuário os números
Console.Write("Número 1: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Número 2: ");
num2 = int.Parse(Console.ReadLine());

// verifica os relacionamentos
if (num1 == num2)
{
    Console.WriteLine($"{num1} é igual a {num2}");
}
else
{
    Console.WriteLine($"{num1} não é igual a {num2}");
}


if (num1 > num2)
{
    Console.WriteLine($"{num1} é maior que {num2}");
}

if(num1 < num2)
{
    Console.WriteLine($"{num1} é menor que {num2}");
}

if(num1 >= num2)
{
    Console.WriteLine($"{num1} é maior ou igual a {num2}");
} else {
    Console.WriteLine($"{num1} é menor ou igual a {num2}");
}

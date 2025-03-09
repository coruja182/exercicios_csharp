// Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:  
// V =  3.14159 * R * R * A 
// Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura

//declaração de constantes
const double PI = 3.14159;

//declaração de variáveis
double volume, raio, altura;

//pedir ao utilizador para inserir o raio da lata de óleo
Console.Write("Insira o raio da lata de óleo: ");

//ler o raio da lata de óleo
raio = double.Parse(Console.ReadLine());

//pedir ao utilizador para inserir a altura da lata de óleo
Console.Write("Insira a altura da lata de óleo: ");
altura = double.Parse(Console.ReadLine());

//calcular o volume da lata de óleo
volume = PI * raio * raio * altura;

//apresentar o resultado
Console.WriteLine($"O volume da lata de óleo é {volume}.");

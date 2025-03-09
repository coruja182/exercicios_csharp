// Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de 
// temperatura  a  ser  utilizada  é  F  =  (9  *  C  +  160)  /  5,  em  que  a  variável  F  representa  é  a  temperatura  em  graus 
// Fahrenheit e a variável C representa é a temperatura em graus Celsius

//declaração de variáveis
double celsius, fahrenheit;

//pedir ao utilizador para inserir a temperatura em graus Celsius
Console.Write("Insira a temperatura em graus Celsius: ");
celsius = double.Parse(Console.ReadLine());

//calcular a temperatura em graus Fahrenheit
fahrenheit = (9 * celsius + 160) / 5;

//apresentar o resultado
Console.WriteLine($"{celsius} graus Celsius são {fahrenheit} graus Fahrenheit.");

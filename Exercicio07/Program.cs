// Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de 
// temperatura  a  ser  utilizada  é  C  =  (F  -  32)  *  5  /  9,  em  que  a  variável  F  é  a  temperatura  em  graus  Fahrenheit  e  a 
// variável C é a temperatura em graus Celsius

//declaração de variáveis
double celsius, fahrenheit;

//pedir ao utilizador para inserir a temperatura em graus Fahrenheit
Console.Write("Insira a temperatura em graus Fahrenheit: ");
fahrenheit = double.Parse(Console.ReadLine());

//calcular a temperatura em graus Celsius
celsius = (fahrenheit - 32) * 5 / 9;

//apresentar o resultado
Console.WriteLine($"{fahrenheit} graus Fahrenheit são {celsius} graus Celsius.");

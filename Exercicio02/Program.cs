// Faça um programa que:
// - Leia a cotação do dólar
// - Leia um valor em dólares
// - Converta esse valor para Real
// - Mostre o resultado

// declarando as variáveis
double cotacaoDolar;
double valorEmDolar;
double resultadoConversao;

// exibe a mensagem
Console.WriteLine("Cotação do dólar: ");
// recebe o valor do teclado (String), converte para double e o armazena na variável cotacaoDolar
cotacaoDolar = double.Parse(Console.ReadLine());

// exibe a mensagem
Console.WriteLine("Valor em dólares: ");
// recebe o valor do teclado
valorEmDolar = double.Parse(Console.ReadLine());

// calcula a conversão e o armazena na variável resultadoConversao
resultadoConversao = cotacaoDolar * valorEmDolar;
Console.WriteLine($"Valor em reais: {resultadoConversao}");

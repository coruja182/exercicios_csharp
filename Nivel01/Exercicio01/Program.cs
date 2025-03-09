/*
Faça um programa para calcular o estoque médio de uma peça, sendo que:
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
*/
// variaveis
int QUANTIDADE_MINIMA;
int QUANTIDADE_MAXIMA;
int ESTOQUE_MEDIO;

// programa

// exibe a mensagem
Console.WriteLine("Quantidade mínima: ");
// recebe o valor do teclado (String), converte para inteiro e o armazena na variável QUANTIDADE_MINIMA
QUANTIDADE_MINIMA = int.Parse(Console.ReadLine());

// exibe a mensagem
Console.WriteLine("Quantidade máxima: ");
// recebe o valor do teclado
QUANTIDADE_MAXIMA = int.Parse(Console.ReadLine());

// calcula o estoque médio e o armazena na variável ESTOQUE_MEDIO
ESTOQUE_MEDIO = (QUANTIDADE_MINIMA + QUANTIDADE_MAXIMA) / 2;
Console.WriteLine("Estoque médio: " + ESTOQUE_MEDIO);

// fim do programa
// Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
// comissão será de 5% do total da venda e que você tem os seguintes dados:
// - Identificação do vendedor
// - Código da peça
// - Preço unitário da peça
// - Quantidade vendida

// variáveis
string nomeVendedor;
string codigoPeca;
double precoUnitario;
int quantidadeVendida;

// exibe a mensagem
Console.WriteLine("Nome do vendedor: ");
// recebe o valor do teclado e o armazena na variável nomeVendedor
nomeVendedor = Console.ReadLine();

// exibe a mensagem
Console.WriteLine("Código da peça: ");
// recebe o valor do teclado e o armazena na variável codigoPeca
codigoPeca = Console.ReadLine();

// exibe a mensagem
Console.WriteLine("Preço unitário da peça: ");
// recebe o valor do teclado (String), converte para double e o armazena na variável precoUnitario
precoUnitario = double.Parse(Console.ReadLine());

// exibe a mensagem
Console.WriteLine("Quantidade vendida: ");
// recebe o valor do teclado (String), converte para int e o armazena na variável quantidadeVendida
quantidadeVendida = int.Parse(Console.ReadLine());

// calcula a comissão e o armazena na variável comissao
double comissao = 0.05 * precoUnitario * quantidadeVendida;

// exibe o resultado
Console.WriteLine($"Comissão: {comissao}");

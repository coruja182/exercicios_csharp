// Efetuar o cálculo da quantidade  de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
// 12  Km  por  litro.  Para  obter  o  cálculo,  o  usuário  deve  fornecer  o  tempo  gasto  na  viagem  e  a  velocidade  média.
// Desta  forma,  será  possível  obter  a  distância  percorrida  com  a  fórmula  DISTANCIA  =  TEMPO  *  VELOCIDADE.
// Tendo  o  valor  da  distância,  basta  calcular  a  quantidade  de  litros  de  combustível  utilizada  na  viagem  com  a
// fórmula:  LITROS_USADOS  =  DISTANCIA  /  12.  O  programa  deve  apresentar  os  valores  da  velocidade  média,
// tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.

// declarando as variáveis
double tempoGasto;
double velocidadeMedia;
double distanciaPercorrida;
double litrosUsados;

// exibe a mensagem
Console.WriteLine("Tempo gasto na viagem: ");
// recebe o valor do teclado (String), converte para double e o armazena na variável tempoGasto
tempoGasto = double.Parse(Console.ReadLine());

// exibe a mensagem
Console.WriteLine("Velocidade média: ");
// recebe o valor do teclado
velocidadeMedia = double.Parse(Console.ReadLine());

// calcula a distância percorrida
distanciaPercorrida = tempoGasto * velocidadeMedia;
// calcula a quantidade de litros usados
litrosUsados = distanciaPercorrida / 12;

// exibe os resultados
Console.WriteLine($"Velocidade média: {velocidadeMedia}");
Console.WriteLine($"Tempo gasto: {tempoGasto}");
Console.WriteLine($"Distância percorrida: {distanciaPercorrida}");
Console.WriteLine($"Litros usados: {litrosUsados}");

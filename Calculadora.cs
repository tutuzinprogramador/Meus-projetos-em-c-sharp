//Calculadora

// Variáveis
string operacao;
string numeroUm;
string numeroDois;
int a_resposta;


//Definindo a operação
Console.WriteLine("Informe a operação (adição, subtração, divisão ou multiplicação)");
operacao = Console.ReadLine();


//Definindo o primeiro número
Console.WriteLine("Informe o primeiro número");
numeroUm = Console.ReadLine();


//Definindo o segundo número
Console.WriteLine("Informe o segundo número");
numeroDois = Console.ReadLine();


//Fazendo montando e fazendo a equação que o usuario montou
if (operacao == "multiplicação")
{
    a_resposta = int.Parse(numeroUm) *int.Parse(numeroDois);
    Console.WriteLine($"A resposta da sua equação é: {a_resposta}");
}

if (operacao == "divisão")
{
    a_resposta = int.Parse(numeroUm) / int.Parse(numeroDois);
    Console.WriteLine($"A resposta da sua equação é: {a_resposta}");
}

if (operacao == "adição")
{
    a_resposta = int.Parse(numeroUm) + int.Parse(numeroDois);
    Console.WriteLine($"A resposta da sua equação é: {a_resposta}");
}

if (operacao == "subtração")
{
    a_resposta = int.Parse(numeroUm) - int.Parse(numeroDois);
    Console.WriteLine($"A resposta da sua equação é: {a_resposta}");
}








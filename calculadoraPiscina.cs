using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando as variaveis
        string lado1;
        string lado2;
        string profundidade;

        //Obtem dados do usuário
        Console.WriteLine("Informe a largura da piscina");
        lado1 = Console.ReadLine();

        Console.WriteLine("Informe a comprimento da piscina");
        lado2 = Console.ReadLine();

        Console.WriteLine("Informe a profundidade da piscina");
        profundidade = Console.ReadLine();        

        Console.WriteLine($"A quantidade de água que você precisa para encher sua psicina é:{calculo(int.Parse(lado1), int.Parse(lado2), int.Parse(profundidade))} Litros!");
    }

    //Método que vai realziar o cálculo
    public static int calculo (int lado1, int lado2, int profundidade)
    {
        int volume;

        //Calcula
        volume = ((lado1*lado2*profundidade)* 1000);

        return volume;
    }    
}

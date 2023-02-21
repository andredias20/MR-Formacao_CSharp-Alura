using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

        double fatorRendimento = 1.005;
        double valorInvestimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {

            for (int mes = 1; mes <= 12; mes++)
            {
                valorInvestimento *= fatorRendimento;
            }

            fatorRendimento = fatorRendimento + 0.001;
        }

        Console.WriteLine($"Deposis de 5 anos você terá R$ {valorInvestimento}");

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
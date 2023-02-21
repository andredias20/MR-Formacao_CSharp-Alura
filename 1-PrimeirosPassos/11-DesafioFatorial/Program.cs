using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exibindo numeros fatoriais de 1 a 10");
        
        //From 1 to range
        var range = 10;

        for(int i = 1; i <= range; i++) {
            var resultado = fatorial(i); 
            Console.WriteLine($"!{i} = {resultado}");
        }
    }

    private static int fatorial(int numero)
    {
        int fat = numero;
        
        for (int i = numero; i > 1; i--)
        { 
            fat *= (i - 1);
        }

        return fat;
    }

}
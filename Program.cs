// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor");
        var valor = int.Parse(Console.ReadLine());
        var total = valor * valor;
        Console.WriteLine($" o valor {valor} multiplicado por ele mesmo é " + total);
    }
}
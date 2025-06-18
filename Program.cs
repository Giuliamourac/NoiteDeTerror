using System;

class NoiteDeTerror
{
    static void Main(string[] args)
    {
        int dia = 0;
        int mes = 0;

        Console.WriteLine(@"--Bem vindo a Noite de Terror--
pressione uma tecla para proseguir...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Para começarmos precisamos saber de alguns dados seus.");

        Thread.Sleep(1000);

        Console.WriteLine("Qual dia você nasceu?(1-31)");
        while (!int.TryParse(Console.ReadLine()!, out dia) || dia < 1 || dia > 31)
        {
            Console.WriteLine("Por favor digite um dia válido.");
        }

        Console.WriteLine("Qual mês você nasceu?(1-12)");
        while (!int.TryParse(Console.ReadLine()!, out mes) || mes < 1 || mes > 12)
        {
            Console.WriteLine("Por favor digite um mes válido.");
        }
    }
} 
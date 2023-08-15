// (Para converter graus Celsius em graus Fahrenheit, multiplique por 1,8 e adicione 32) celsius para Fahrenheit subtraia 32 e divida por 1,8

using System;
public class temperatura
{
    public static void Main(string[] args)
    {
        Menu();

    }

    static void Menu()
    {
        Console.WriteLine("Qual temperatura gostaria de converter ?");
        Console.WriteLine("Em graus Celsius 1");
        Console.WriteLine("Em graus Fahrenheit 2");
        Console.WriteLine("Sair 3");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Selecione uma opção");
        short resposta = short.Parse(Console.ReadLine());
        switch(resposta)
        {
            case 1: Celsius(); break;
            case 2: Fahrenheit(); break;
            case 3: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Celsius()
    {
        Console.WriteLine("Conversor de Fahrenheit para Celsius");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Digite a Temperatura em Fahrenheit");
        double temperatura = double.Parse(Console.ReadLine());
        double celsius = (temperatura - 32) / 1.8;   
        Console.WriteLine($"Sua Temperatura em Graus Celsius é {celsius} ");
        Console.ReadKey();
        Menu();
    }

    static void Fahrenheit()
    {
        Console.WriteLine("Conversor de Celsius para Fahrenheit ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Digite a Temperatura em Celsius");
        double temperatura = double.Parse(Console.ReadLine());
        double Fahrenheit = (temperatura * 1.8) + 32;
        Console.WriteLine($"Sua temperatura em Graus Fahrenheit é {Fahrenheit} ");
        Console.ReadKey();
        Menu();
    }

}



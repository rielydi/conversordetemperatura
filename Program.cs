using Internal;
// (Para converter graus Celsius em graus Fahrenheit, multiplique por 1,8 e adicione 32) celsius para Fahrenheit subtraia 32 e divida por 1,8

using System;
public class temperatura
{
    public static void Main(string[] args)
    {


    }

    static void Menu()
    {
        Console.WriteLine
    }
    static void Celsius()
    {
        Console.WriteLine("Conversor de Fahrenheit para Celsius");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Digite a Temperatura em Fahrenheit");
        double temperatura = double.Parse(Console.ReadLine());
        double celsius = (temperatura - 32) / 1.8;   
        Console.WriteLine($"Sua Temperatura em Graus Celsius é {celsius} "); 

    }

    static void Fahrenheit()
    {
        Console.WriteLine("Conversor de Celsius para Fahrenheit ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Digite a Temperatura em Celsius");
        double temperatura = double.Parse(Console.ReadLine());
        double Fahrenheit = (temperatura * 1.8) + 32;
        Console.WriteLine($"Sua temperatura em Graus Fahrenheit é {Fahrenheit} ");
    }

}



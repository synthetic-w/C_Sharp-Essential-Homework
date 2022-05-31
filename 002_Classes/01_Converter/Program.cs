using _01_Converter.Models;

// See https://aka.ms/new-console-template for more information

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub).

Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.
 */
Converter converter = new Converter(29.53, 31.83, 0.46);

Console.WriteLine("Нажмите:");
Console.WriteLine("1: Для перевода в гривны");
Console.WriteLine("2: Для перевода из гривен");

switch (int.Parse(Console.ReadLine()))
{
    case 1:
        ConvertTo(converter);
        break;

    case 2:
        ConvertFrom(converter);
        break;
}

Console.WriteLine("Выполнено");
Console.ReadKey();

// Метод конвертации в гривны из другой валюты
void ConvertTo(Converter currencyConverter)
{
    Console.WriteLine("Нвжмите:");
    Console.WriteLine("1: Для перевода из USD");
    Console.WriteLine("2: Для перевода из EUR");
    Console.WriteLine("3: Для перевода из RUB");

    var option = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите сумму");

    var input = double.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine(currencyConverter.ConvertFromUsd(input));
            break;

        case 2:
            Console.WriteLine(currencyConverter.ConvertFromEur(input));
            break;

        case 3:
            Console.WriteLine(currencyConverter.ConvertFromRub(input));
            break;
    }
}

// Метод конвертации из гривны в другую валюту
void ConvertFrom(Converter currencyConverter)
{
    Console.WriteLine("Нажмите:");
    Console.WriteLine("1: Для перевода в USD");
    Console.WriteLine("2: Для перевода в EUR");
    Console.WriteLine("3: Для перевода в RUB");

    var option = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите сумму");

    var input = double.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine(currencyConverter.ConvertToUsd(input));
            break;

        case 2:
            Console.WriteLine(currencyConverter.ConvertToEur(input));
            break;

        case 3:
            Console.WriteLine(currencyConverter.ConvertToRub(input));
            break;
    }
}

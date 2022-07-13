/*
Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Change(), void Save().
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата
должны быть методы открытия, создания, редактирования, сохранения определенного
формата документа.
 */

using _01_AbstractHandler.Models;

Console.WriteLine("Введите формат документа");

string documentFormat = Console.ReadLine();

AbstractHandler docHandler = new DOCHandler();
AbstractHandler txtHandler = new TXTHandler();
AbstractHandler xmlHandler = new XMLHandler();
switch (documentFormat.ToLower())
{
    case "doc":
        Console.WriteLine("Тип документа - DOC");
        docHandler.Open();
        docHandler.Create();
        docHandler.Change();
        docHandler.Save();
        break;

    case "txt":
        Console.WriteLine("Тип документа - TXT");
        txtHandler.Open();
        txtHandler.Create();
        txtHandler.Change();
        txtHandler.Save();
        break;

    case "xml":
        Console.WriteLine("Тип документа - XML");
        xmlHandler.Open();
        xmlHandler.Create();
        xmlHandler.Change();
        xmlHandler.Save();
        break;

    default:
        Console.WriteLine("Не выбран тип документа");
        break;
}

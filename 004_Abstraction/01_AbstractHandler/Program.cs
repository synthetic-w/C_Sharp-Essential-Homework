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

Console.WriteLine("Укажите расширение файла:");
string fileType = Console.ReadLine();

AbstractHandler handler = null;

switch (fileType.ToLower())
{
    case "":
        Console.WriteLine("Расширение файла не может быть пустым");
        break;

    case null:
        Console.WriteLine("Расширение файла не может быть null");
        break;

    case "doc":
        handler = new DOCHandler();
        handler.Create();
        handler.Open();
        handler.Change();
        handler.Save();
        break;

    case "txt":
        handler = new TXTHandler();
        handler.Create();
        handler.Open();
        handler.Change();
        handler.Save();
        break;

    case "xml":
        handler = new XMLHandler();
        handler.Create();
        handler.Open();
        handler.Change();
        handler.Save();
        break;
}

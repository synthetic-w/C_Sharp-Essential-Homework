/*
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение
аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
выводились разными цветами.
Обязательно используйте приведение типов
 */

using _04_Printer.Models;

Printer printerCyan = new PrinterCyan();
Printer printerMagenta = new PrinterMagenta();
Printer printerRed = new PrinterRed();
Printer printer = new Printer();

printerCyan.Print("Cyan");
printerMagenta.Print("Magenta");
printerRed.Print("Red");
printer.Print("Default");
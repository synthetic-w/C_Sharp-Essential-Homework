/*
Требуется:
Создать класс Employee.
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
инициализирует поля, соответствующие фамилии и имени сотрудника.
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
сбор.
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
оклад и налоговый сбор.
*/

using _02_Employee.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя сотрудника:");

string firstName = Console.ReadLine();

Console.WriteLine("Введите Фамилию сотрудника:");
string lastName = Console.ReadLine();

Employee employee = new Employee(firstName, lastName);

Console.WriteLine("Укажите должность сотрудника:\n" +
                  "1. JS frontend developer\n" +
                  "2. .NET fullstack developer\n" +
                  "3. PHP-макака\n" +
                  "4. Бизнес-аналитик\n" +
                  "5. Python QA");

int position = int.Parse(Console.ReadLine());
string displayPosition = "Здесь должна быть должность\n+" +
                         "Если её нет, значит кто-то уволен";

switch (position)
{
    case 1:
        displayPosition = "JS frontend developer";
        break;

    case 2:
        displayPosition = ".NET fullstack developer";
        break;

    case 3:
        displayPosition = "PHP-макака";
        break;

    case 4:
        displayPosition = "Бизнес-аналитик";
        break;

    case 5:
        displayPosition = "Python QA";
        break;
}

Console.WriteLine("Укажите стаж сотрудника:\n" +
                  "1. До 1 года\n" +
                  "2. От 1 до 2 лет\n" +
                  "3. От 2 до 4 лет\n" +
                  "4. От 4 до 6 лет");

int experience = int.Parse(Console.ReadLine());

Console.WriteLine($"Фио сотрудника        : {firstName} {lastName}\n" +
                  $"Должность сотрудника  : {displayPosition}");
employee.SalaryAndTaxes(position, experience);
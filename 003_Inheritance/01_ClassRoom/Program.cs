/*
Требуется:
Создать класс, представляющий учебный класс ClassRoom.
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
писать, отдыхать.
*/
// See https://aka.ms/new-console-template for more information

using _01_ClassRoom.Models;

Pupil p1 = new BadPupil();
Pupil p2 = new GoodPupil();
Pupil p3 = new ExcellentPupil();
Pupil p4 = new BadPupil();

ClassRoom classRoom1 = new ClassRoom(p1, p2, p3, p4);
Console.WriteLine(nameof(classRoom1));
classRoom1.ShowPupils();

ClassRoom classRoom2 = new ClassRoom(p4, p1, p3);
Console.WriteLine(nameof(classRoom2));
classRoom2.ShowPupils();
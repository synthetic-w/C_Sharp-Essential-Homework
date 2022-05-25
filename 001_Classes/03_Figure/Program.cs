/*
Требуется:
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.
 */

using _03_Figure.Models;

Point pointA = new(0, 0, "A");
Point pointB = new(1, 3, "B");
Point pointC = new(3, 7, "C");
Point pointD = new(6, 9, "D");

Figure rectangle = new Figure(pointA, pointB, pointC, pointD);

rectangle.PerimeterCalculator();
rectangle.GetFigureType();
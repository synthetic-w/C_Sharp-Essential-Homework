namespace _01_Rectangle.Models
{
    public class Rectangle
    {
        // Поля - значения сторон
        private double side1;
        private double side2;

        //Пользовательский конструктор, инициализирующийся значениями аргументов
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод вычисления площади прямоугольника
        private double AreaCalculator()
        {
            return side1 * side2;
        }

        //Метод вычисления периметра прямоугольника
        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}

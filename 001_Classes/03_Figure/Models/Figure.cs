namespace _03_Figure.Models
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new[] { p1, p2, p3, p4, p5 };
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i != points.Length - 1)
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
                else
                {
                    perimeter += LengthSide(points[i], points[0]);
                }
            }

            Console.WriteLine($"Периметр заданного многоугольника равен: {perimeter}");
        }

        public void GetFigureType()
        {
            switch (points.Length)
            {
                case 3:
                    Console.WriteLine("Многоугольник - треугольник");
                    break;

                case 4:
                    Console.WriteLine("Многоугольник - четырёхугольник");
                    break;

                case 5:
                    Console.WriteLine("Многоугольник - пятиугольник");
                    break;
            }

            // Второй вариант решения

            //public void PerimeterCalculator()
            //{
            //    double perimeter = 0;
            //    for (int i = 0; i < points.Length - 1; i++)
            //    {
            //        perimeter += LengthSide(points[i], points[i + 1]);
            //    }
            //    perimeter += LengthSide(points[points.Length - 1], points[0]);

            //    Console.WriteLine($"Периметр заданного многоугольника равен: {perimeter}");
            //}
        }
    }
}
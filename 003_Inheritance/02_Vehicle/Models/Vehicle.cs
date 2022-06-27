namespace _02_Vehicle.Models
{
    internal class Vehicle
    {
        public double x;
        public double y;
        public decimal value;
        public double speed;
        public int releaseYear;

        public Vehicle(double x, double y, decimal value, double speed, int releaseYear)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Координаты {x}, {y}\n" +
                              $"Стоимость {value} у.е.\n" +
                              $"Скорость {speed} км/ч\n" +
                              $"Год выпуска {releaseYear} г.");
        }
    }
}

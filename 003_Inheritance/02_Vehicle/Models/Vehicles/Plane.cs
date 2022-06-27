namespace _02_Vehicle.Models.Vehicles
{
    internal class Plane : Vehicle
    {
        public double altitude;
        public int passengersQuantity;

        public Plane(double x, double y, decimal value, double speed, int releaseYear, double altitude, int passengersQuantity)
             : base(x, y, value, speed, releaseYear)
        {
            this.altitude = altitude;
            this.passengersQuantity = passengersQuantity;
        }

        public override void Show()
        {
            Console.WriteLine($"Параметры {nameof(Plane)}");
            base.Show();
            Console.WriteLine($"Высота {altitude} м.\n" +
                              $"Количество пассажиров {passengersQuantity}");
            Console.WriteLine(new String('|', 10));
        }
    }
}

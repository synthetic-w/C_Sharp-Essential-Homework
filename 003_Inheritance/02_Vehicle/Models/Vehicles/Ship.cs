namespace _02_Vehicle.Models.Vehicles
{
    internal class Ship : Vehicle
    {
        public string portOfRegistry;
        public int passengersQuantity;

        public Ship(double x, double y, decimal value, double speed, int releaseYear, string portOfRegistry, int passengersQuantity)
             : base(x, y, value, speed, releaseYear)
        {
            this.portOfRegistry = portOfRegistry;
            this.passengersQuantity = passengersQuantity;
        }

        public override void Show()
        {
            Console.WriteLine($"Параметры {nameof(Ship)}");
            base.Show();
            Console.WriteLine($"Порт приписки {portOfRegistry}\n" +
                              $"Количество пассажиров {passengersQuantity}");
            Console.WriteLine(new String('|', 10));
        }
    }
}

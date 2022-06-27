namespace _02_Vehicle.Models.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(double x, double y, decimal value, double speed, int releaseYear) : base(x, y, value, speed, releaseYear)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Параметры {nameof(Car)}");
            base.Show();
            Console.WriteLine(new String('|', 10));
        }
    }
}

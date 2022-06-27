namespace _01_ClassRoom.Models
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учится отвратительно");
        }

        public override void Read()
        {
            Console.WriteLine("Читает по слогам");
        }

        public override void Write()
        {
            Console.WriteLine("Писать не умеет");
        }

        public override void Relax()
        {
            Console.WriteLine("Отдыхает много");
        }
    }
}

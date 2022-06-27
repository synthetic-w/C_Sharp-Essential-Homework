namespace _01_ClassRoom.Models
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Учится нормально");
        }

        public virtual void Read()
        {
            Console.WriteLine("Читает нормально");
        }

        public virtual void Write()
        {
            Console.WriteLine("Пишет нормально");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Отдыхает нормально");
        }
    }
}

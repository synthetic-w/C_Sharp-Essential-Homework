namespace _01_ClassRoom.Models
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учится в целом хорошо");
        }

        public override void Read()
        {
            Console.WriteLine("Читает неплохо");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет хорошо");
        }

        public override void Relax()
        {
            Console.WriteLine("Отжыхает достаточно");
        }
    }
}

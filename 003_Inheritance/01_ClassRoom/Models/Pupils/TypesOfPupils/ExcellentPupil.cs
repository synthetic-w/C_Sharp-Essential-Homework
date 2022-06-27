namespace _01_ClassRoom.Models
{
    internal class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учится как Эйнштейн");
        }

        public override void Read()
        {
            Console.WriteLine("Читает всё");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет 200 страниц в день");
        }

        public override void Relax()
        {
            Console.WriteLine("Не отдыхает");
        }
    }
}

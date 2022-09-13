namespace _02_IPlayIRecord.Models
{
    internal class Player : IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение");
        }

        public void Stop()
        {
            Console.WriteLine("Остановлено");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Record()
        {
            Console.WriteLine("Запись");
        }
    }
}

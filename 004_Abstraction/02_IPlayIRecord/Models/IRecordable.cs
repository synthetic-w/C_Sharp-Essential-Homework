namespace _02_IPlayIRecord.Models
{
    internal interface IRecordable
    {
        void Record();

        void Pause();

        void Stop();
    }
}

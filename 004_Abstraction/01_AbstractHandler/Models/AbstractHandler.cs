namespace _01_AbstractHandler.Models
{
    internal abstract class AbstractHandler
    {
        public abstract void Open();

        public abstract void Create();

        public abstract void Change();

        public abstract void Save();
    }
}

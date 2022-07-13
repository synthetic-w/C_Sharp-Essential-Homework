namespace _01_AbstractHandler.Models
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл .txt");
        }

        public override void Create()
        {
            Console.WriteLine("Создан файл .txt");
        }

        public override void Change()
        {
            Console.WriteLine("Изменён файл .txt");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён файл .txt");
        }
    }
}

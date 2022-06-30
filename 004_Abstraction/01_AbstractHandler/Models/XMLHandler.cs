namespace _01_AbstractHandler.Models
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл .xml");
        }

        public override void Create()
        {
            Console.WriteLine("Создан файл .xml");
        }

        public override void Change()
        {
            Console.WriteLine("Изменён файл .xml");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён файл .xml");
        }
    }
}

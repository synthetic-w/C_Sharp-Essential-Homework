namespace _01_AbstractHandler.Models
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл .doc");
        }

        public override void Create()
        {
            Console.WriteLine("Создан файл .doc");
        }

        public override void Change()
        {
            Console.WriteLine("Изменён файл .doc");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён файл .doc");
        }
    }
}

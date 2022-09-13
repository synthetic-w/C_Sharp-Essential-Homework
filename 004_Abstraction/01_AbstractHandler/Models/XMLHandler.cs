namespace _01_AbstractHandler.Models
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата .XML");
        }

        public override void Create()
        {
            Console.WriteLine("Создан документ формата .XML");
        }

        public override void Change()
        {
            Console.WriteLine("Изменен документ формата .XML");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён документ формата .XML");
        }
    }
}

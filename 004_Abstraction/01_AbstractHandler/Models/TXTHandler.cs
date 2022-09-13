namespace _01_AbstractHandler.Models
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата .TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Создан документ формата .TXT");
        }

        public override void Change()
        {
            Console.WriteLine("Изменен документ формата .TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён документ формата .TXT");
        }
    }
}

namespace _01_AbstractHandler.Models
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата .DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Создан документ формата .DOC");
        }

        public override void Change()
        {
            Console.WriteLine("Изменен документ формата .DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён документ формата .DOC");
        }
    }
}

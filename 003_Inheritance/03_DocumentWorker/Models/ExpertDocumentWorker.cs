namespace _03_DocumentWorker.Models
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}

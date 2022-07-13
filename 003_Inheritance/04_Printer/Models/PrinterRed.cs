namespace _04_Printer.Models
{
    internal class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

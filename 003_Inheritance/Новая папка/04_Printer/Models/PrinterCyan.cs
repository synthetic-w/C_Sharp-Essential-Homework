namespace _04_Printer.Models
{
    internal class PrinterCyan : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

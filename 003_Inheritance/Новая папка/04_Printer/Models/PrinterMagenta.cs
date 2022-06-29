namespace _04_Printer.Models
{
    internal class PrinterMagenta : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

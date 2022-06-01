namespace _03_Invoice.Models
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;

        public string Article
        {
            get => article;
            set => article = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public double GetaccountWithTax(double tax = 0.2)
        {
            return account + (account * tax);
        }

        public void Show()
        {
            Console.WriteLine($" {customer} заказал у {provider} {quantity} позиций {article} и выставил счет," +
                $"\n который будет составлять {account} без НДС, и {GetaccountWithTax()} с НДС");
        }
    }
}
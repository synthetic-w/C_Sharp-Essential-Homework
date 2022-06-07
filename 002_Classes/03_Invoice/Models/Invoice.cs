/*
Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider, которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity.
Создать метод расчета стоимости заказа с НДС и без НДС.
*/

namespace _03_Invoice.Models
{
    internal class Invoice
    {
        // Поля, инициализируемые один раз (при создании экземпляра данного класса)
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        // Закрытые поля
        private string article;
        private int quantity;

        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
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
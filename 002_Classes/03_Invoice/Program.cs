using _03_Invoice.Models;

/*
Требуется:
Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider, которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
 */

// See https://aka.ms/new-console-template for more information
Invoice invoice = new Invoice(420000000, "ООО МОЯ ОБОРОНА", "Uncle Sam.Ltd")
{
    Quantity = 99999,
    Article = "FGM-148 Javelin"
};
invoice.GetaccountWithTax();
invoice.Show();
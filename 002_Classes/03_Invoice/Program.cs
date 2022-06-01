using _03_Invoice.Models;

// See https://aka.ms/new-console-template for more information
Invoice invoice = new Invoice(420000000, "ООО МОЯ ОБОРОНА", "Uncle Sam.Ltd")
{
    Quantity = 99999,
    Article = "FGM-148 Javelin"
};
invoice.GetaccountWithTax();
invoice.Show();
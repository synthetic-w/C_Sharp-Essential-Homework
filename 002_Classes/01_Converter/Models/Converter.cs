namespace _01_Converter.Models
{
    internal class Converter
    {
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / usd;
        }

        public double ConvertToEur(double value)
        {
            return value / eur;
        }

        public double ConvertToRub(double value)
        {
            return value / rub;
        }

        public double ConvertFromUsd(double value)
        {
            return usd * value;
        }

        public double ConvertFromEur(double value)
        {
            return eur * value;
        }

        public double ConvertFromRub(double value)
        {
            return rub * value;
        }
    }
}

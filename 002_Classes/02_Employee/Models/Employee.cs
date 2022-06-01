namespace _02_Employee.Models
{
    internal class Employee
    {
        private readonly string firstName;
        private readonly string lastName;
        private double positionSalary;
        private double experienceSalaryMultiplier;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SalaryAndTaxes(int position, int experience)
        {
            switch (position)
            {
                case 1:
                    positionSalary = 100000;
                    break;

                case 2:
                    positionSalary = 120000;
                    break;

                case 3:
                    positionSalary = 169696;
                    break;

                case 4:
                    positionSalary = 80000;
                    break;

                case 5:
                    positionSalary = 700000;
                    break;
            }

            switch (experience)
            {
                case <= 1:
                    experienceSalaryMultiplier = 1;
                    break;

                case <= 2:
                    experienceSalaryMultiplier = 1.2;
                    break;

                case <= 5:
                    experienceSalaryMultiplier = 1.4;
                    break;

                case > 10:
                    this.experienceSalaryMultiplier = 1.6;
                    break;
            }
            double totalSalary = positionSalary * experienceSalaryMultiplier;
            double taxes = 0.4 * totalSalary;

            Console.WriteLine($"Текущая зарплата составляет      : {Math.Round(totalSalary, 2)} руб.\n" +
                              $"Текущий налоговый сбор составляет: {Math.Round(taxes, 2)} руб.");
        }
    }
}

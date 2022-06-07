/*
Требуется:
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.
 */

namespace _04_User.Models
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;

        private readonly DateOnly dateOfCompletion;

        public User(string login, string firstName, string lastName, int age, DateOnly dateOfCompletion)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.dateOfCompletion = dateOfCompletion;
        }

        public void PreShow()
        {
            Console.WriteLine("Для вывода информации о пользователе нажмите любую клавишу");
            Console.ReadKey();
        }

        public void Show()
        {
            Console.WriteLine($"        User login: {login}\n" +
                              $"        First name: {firstName}\n" +
                              $"         Last name: {lastName}\n" +
                              $"               Age: {age}\n" +
                              $"Date of completion: {dateOfCompletion}");
        }
    }
}

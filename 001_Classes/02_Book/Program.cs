/* Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание.
*/

using _02_Book.Models;

Console.WriteLine("Введите автора, название и краткое содержание книги");

//string authorName = Console.ReadLine();
//string titleName = Console.ReadLine();           Раскомментить, если захочется сделать через доп. переменные
//string contentContent = Console.ReadLine();

Author author = new Author(Console.ReadLine());
Title title = new Title(Console.ReadLine());
Content content = new Content(Console.ReadLine());

Book book = new Book(title, author, content);

book.Show();
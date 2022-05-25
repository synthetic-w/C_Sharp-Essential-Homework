namespace _02_Book.Models
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}

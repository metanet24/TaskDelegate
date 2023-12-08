using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class BookDelegate
    {
        public delegate bool CheckAuthor(List<Book> books);

        public void ShowCountOfBook(List<Book> books, Predicate<Book> predicate)
        {
            int count = 0;
            foreach (Book book in books)
            {
                if (predicate(book))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public void Result()
        {
            List<Book> books = new List<Book>()
            {
              new Book() {Author="Corc Oruel", Name="1984"},
              new Book() {Author="Rovshen Abdullaoghlu", Name="Bu sheherde kimse yoxdur"},
              new Book() {Author="Victor Huqo", Name="Sefiller"},
              new Book() {Author="Aqata Kristi", Name="Mavi qatarin sirri"},
            };
            ShowCountOfBook(books, books => books.Author == "Corc Oruel");
        }
    }
}
